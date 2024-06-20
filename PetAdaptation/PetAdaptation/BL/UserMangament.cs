using PetAdaptation.Data;
using PetAdaptation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using DTO;
namespace PetAdaptation.BL
{
    public class UserMangament
    {
        private static string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private static string GenerateToken()
        {
            return Guid.NewGuid().ToString();
        }

        public static Response Register(Request<UserDTO> request)
        {
            try
            {
                UserDTO userDto = request.Object;
                userDto.Password = HashPassword(userDto.Password);

                using (ApplicationDbContext db = new ApplicationDbContext())
                {
                    User user = new User
                    {
                        Name = userDto.Name,
                        LastName = userDto.LastName,
                        Email = userDto.Email,
                        PasswordHash = userDto.Password,
                        RoleId = userDto.RoleId
                    };

                    db.Users.Add(user);
                    db.SaveChanges();
                }

                return new Response { Success = true, Message = "User registered successfully" };
            }
            catch (Exception ex)
            {
                return new Response { Success = false, Message = "Error registering user", Errors = new Dictionary<string, string> { { "Exception", ex.Message } } };
            }
        }

        public static Response Login(Request<UserDTO> request)
        {
            try
            {
                UserDTO userDto = request.Object;
                string hashedPassword = HashPassword(userDto.Password);

                using (ApplicationDbContext db = new ApplicationDbContext())
                {
                    User user = db.Users.FirstOrDefault(u => u.Email == userDto.Email && u.PasswordHash == hashedPassword);
                    if (user == null)
                    {
                        return new Response { Success = false, Message = "Invalid email or password" };
                    }

                    // Generate simple token
                    string token = GenerateToken();
                    user.AuthToken = token;
                    user.TokenExpiry = DateTime.UtcNow.AddHours(1); // Token valid for 1 hour
                    db.SaveChanges();

                    return new Response { Success = true, Message = "Login successful", Token = token, UserId = user.Id };
                }
            }
            catch (Exception ex)
            {
                return new Response { Success = false, Message = "Error logging in", Errors = new Dictionary<string, string> { { "Exception", ex.Message } } };
            }
        }
    }
}