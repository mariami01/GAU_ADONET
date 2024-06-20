using Org.BouncyCastle.Crypto.Generators;
using PetAdaptation.Data;
using PetAdaptation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Helpers;
using System.Web.Http;
using System.Web.Mvc;
using HttpPostAttribute = System.Web.Http.HttpPostAttribute;
using RouteAttribute = System.Web.Http.RouteAttribute;
using DTO;
using PetAdaptation.BL;

namespace PetAdaptation.Controllers
{
    public class AuthController : ApiController
    {
        [HttpPost]
        [Route("api/auth/register")]
        public async Task<IHttpActionResult> Register([FromBody] Request<UserDTO> request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var response = UserMangament.Register(request);
            if (response.Success)
            {
                return Ok(new { Message = response.Message });
            }
            else
            {
                return BadRequest(response.Message);
            }
        }

        [HttpPost]
        [Route("api/auth/login")]
        public async Task<IHttpActionResult> Login([FromBody] Request<UserDTO> request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var response = UserMangament.Login(request);
            if (response.Success)
            {
                return Ok(new { Token = response.Token });
            }
            else
            {
                return Unauthorized();
            }
        }
    }
}