using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace StudentManagmentSystem
{
    internal class DatabaseManager
    {
        private string connectionString = "Server=LAB316PC06\\SQLEXPRESS01;Database=StudentManagementSystem;Trusted_Connection=True";

        public List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();

            // Query to retrieve student data from the database
            string query = "SELECT * FROM Student";

            using (SqlConnection connection = new SqlConnection(connectionString))

            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Create Student objects and populate them with data from the database
                            Student student = new Student
                            {
                                StudentID = Convert.ToInt32(reader["StudentID"]),
                                FirstName = Convert.ToString(reader["FirstName"]),
                                LastName = Convert.ToString(reader["LastName"]),
                                DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]),
                                DepartmentID = Convert.ToInt32(reader["DepartmentID"])
                            };

                            students.Add(student);
                        }
                    }
                }
            }

            return students;
        }
    }
}
