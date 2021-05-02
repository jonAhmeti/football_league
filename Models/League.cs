using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace FootballLeague.Models
{
    public class League
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Season { get; set; }
        public string Status { get; set; }
        public string Format { get; set; }
        public int NumberOfClubs { get; set; }
        public int TotalMatches { get; set; }
        public int MatchesCompleted { get; set; }
        public int GameWeek { get; set; }
        public int TotalGameWeek { get; set; }
        public int Progress { get; set; }
        public float AverageGoalsPerMatch { get; set; }

        public static readonly string _connectionString = ConfigurationManager.ConnectionStrings["FootballLeague"].ConnectionString;

        public static int Add(League model)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {

                connection.Open();

                SqlCommand sqlCommand = new SqlCommand("AddLeague", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                sqlCommand.Parameters.AddWithValue("@name", model.Name);
                sqlCommand.Parameters.AddWithValue("@season", model.Season);
                sqlCommand.Parameters.AddWithValue("@status", model.Status);
                sqlCommand.Parameters.AddWithValue("@format", model.Format);
                sqlCommand.Parameters.AddWithValue("@number_of_clubs", model.NumberOfClubs);
                sqlCommand.Parameters.AddWithValue("@total_matches", model.TotalMatches);
                sqlCommand.Parameters.AddWithValue("@matches_completed", model.MatchesCompleted);
                sqlCommand.Parameters.AddWithValue("@game_week", model.GameWeek);
                sqlCommand.Parameters.AddWithValue("@total_game_week", model.TotalGameWeek);
                sqlCommand.Parameters.AddWithValue("@average_goals_per_match", model.AverageGoalsPerMatch);
                sqlCommand.Parameters.AddWithValue("@progress", model.Progress);
                int rowsAffected = sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
                return rowsAffected;
            }
        }

        public static int Edit(League model)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {

                connection.Open();

                SqlCommand sqlCommand = new SqlCommand("EditLeague", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                sqlCommand.Parameters.AddWithValue("@Id", model.Id);
                sqlCommand.Parameters.AddWithValue("@name", model.Name);
                sqlCommand.Parameters.AddWithValue("@season", model.Season);
                sqlCommand.Parameters.AddWithValue("@status", model.Status);
                sqlCommand.Parameters.AddWithValue("@format", model.Format);
                sqlCommand.Parameters.AddWithValue("@number_of_clubs", model.NumberOfClubs);
                sqlCommand.Parameters.AddWithValue("@total_matches", model.TotalMatches);
                sqlCommand.Parameters.AddWithValue("@matches_completed", model.MatchesCompleted);
                sqlCommand.Parameters.AddWithValue("@game_week", model.GameWeek);
                sqlCommand.Parameters.AddWithValue("@total_game_week", model.TotalGameWeek);
                sqlCommand.Parameters.AddWithValue("@average_goals_per_match", model.AverageGoalsPerMatch);
                sqlCommand.Parameters.AddWithValue("@progress", model.Progress);

                int rowsAffected = sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
                return rowsAffected;
            }
        }

        public static int Delete(League model)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {

                connection.Open();

                SqlCommand sqlCommand = new SqlCommand("DeleteLeague", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                sqlCommand.Parameters.AddWithValue("@Id", model.Id);
                int rowsAffected = sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
                return rowsAffected;
            }
        }

        public static League GetLeague(League model)
        {
            League obj = new League();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand sqlCommand = new SqlCommand("GetLeague", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                sqlCommand.Parameters.AddWithValue("@Id", model.Id);
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        obj.Id = int.Parse(reader["Id"].ToString());
                        obj.Name = reader["name"].ToString();
                        obj.Status = reader["status"].ToString();
                        obj.Season = reader["season"].ToString();
                        obj.Format = reader["format"].ToString();
                        obj.NumberOfClubs = int.Parse(reader["number_of_clubs"].ToString());
                        obj.TotalMatches = int.Parse(reader["total_matches"].ToString());
                        obj.MatchesCompleted = int.Parse(reader["matches_completed"].ToString());
                        obj.GameWeek = int.Parse(reader["game_week"].ToString());
                        obj.TotalGameWeek = int.Parse(reader["total_game_week"].ToString());
                        obj.Progress = int.Parse(reader["progress"].ToString());
                        obj.AverageGoalsPerMatch = float.Parse(reader["average_goals_per_match"].ToString());

                    }
                }
                sqlCommand.Dispose();
            }
            return obj;
        }

        public static List<League> GetAll()
        {
            List<League> leagues = new List<League>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand sqlCommand =
                    new SqlCommand("GetAllLeagues", connection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        League league = new League();
                        league.Id = int.Parse(reader["Id"].ToString());
                        league.Name = reader["name"].ToString();
                        league.Season = reader["season"].ToString();
                        league.Progress = int.Parse(reader["progress"].ToString());
                        leagues.Add(league);
                    }
                }
                sqlCommand.Dispose();
            }
            return leagues;
        }
    }
}