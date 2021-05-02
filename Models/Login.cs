using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace FootballLeague.Models
{
    public class Login
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }


        public static readonly string _connectionString = ConfigurationManager.ConnectionStrings["FootballLeague"].ConnectionString;
        public static Login CheckForUser(Login model)
        {
            Login user = new Login();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand sqlCommand = new SqlCommand("CheckUser", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                sqlCommand.Parameters.AddWithValue("@Username", model.Username);
                sqlCommand.Parameters.AddWithValue("@Password", model.Password);
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        user.Id = int.Parse(reader["Id"].ToString());
                        user.RoleId = int.Parse(reader["RoleID"].ToString());
                        user.Username = reader["Username"].ToString();
                        user.Password = reader["Password"].ToString();
                    }
                }
                sqlCommand.Dispose();
            }
            return user;
        }


        public static int AddUser(Login model)
        {
            int res;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand sqlCommand = new SqlCommand("AddUser", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                sqlCommand.Parameters.AddWithValue("@Username", model.Username);
                sqlCommand.Parameters.AddWithValue("@Password", model.Password);
                res = sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
            }
            return res;
        }

    }
}