using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace FootballLeague.Models
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public static readonly string _connectionString = ConfigurationManager.ConnectionStrings["FootballLeague"].ConnectionString;
        public static List<Role> GetAllRoles()
        {
            List<Role> roles = new List<Role>();
            Role role = new Role();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Roles", connection);
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        role.Id = int.Parse(reader["Id"].ToString());
                        role.Name = reader["Name"].ToString();
                        role.Description = reader["Description"].ToString();

                        roles.Add(role);
                    }
                }
                sqlCommand.Dispose();
            }
            return roles;
        }
    }
}