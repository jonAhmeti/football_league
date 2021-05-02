using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace FootballLeague.Models
{
    public class Match
    {
        public int Id { get; set; }
        public int Timestamp { get; set; }
        public string DateGMT { get; set; }
        public string Status { get; set; }
        public string Attendance { get; set; }
        public string HomeTeamName { get; set; }
        public string AwayTeamName { get; set; }
        public int HomeTeamGoalCount { get; set; }
        public int AwayTeamGoalCount { get; set; }
        public int TotalGoalCount { get; set; }
        public int TotalGoalsAtHalfTime { get; set; }
        public int HomeTeamGoalCountHalfTime { get; set; }
        public int AwayTeamGoalCountHalfTime { get; set; }
        public string HomeTeamGoalTimings { get; set; }
        public string AwayTeamGoalTimings { get; set; }
        public int HomeTeamCornerCount { get; set; }
        public int AwayTeamCornerCount { get; set; }
        public int HomeTeamYellowCards { get; set; }
        public int HomeTeamRedCards { get; set; }
        public int AwayTeamYellowCards { get; set; }
        public int AwayTeamRedCards { get; set; }
        public int HomeTeamShots { get; set; }
        public int AwayTeamShots { get; set; }
        public int HomeTeamShotsOnTarget { get; set; }
        public int AwayTeamShotsOnTarget { get; set; }
        public int HomeTeamShotsOffTarget { get; set; }
        public int AwayTeamShotsOffTarget { get; set; }
        public int HomeTeamFouls { get; set; }
        public int AwayTeamFouls { get; set; }
        public int HomeTeamPossession { get; set; }
        public int AwayTeamPossession { get; set; }
        public float AverageGoalsPerMatchPreMatch { get; set; }
        public string StadiumName { get; set; }

        public static readonly string _connectionString = ConfigurationManager.ConnectionStrings["FootballLeague"].ConnectionString;

        public static int Add(Match model)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {

                connection.Open();

                SqlCommand sqlCommand = new SqlCommand("AddMatch", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                sqlCommand.Parameters.AddWithValue("@timestamp", model.Timestamp);
                sqlCommand.Parameters.AddWithValue("@date_GMT", model.DateGMT);
                sqlCommand.Parameters.AddWithValue("@status", model.Status);
                sqlCommand.Parameters.AddWithValue("@attendance", model.Attendance);
                sqlCommand.Parameters.AddWithValue("@home_team_name", model.HomeTeamName);
                sqlCommand.Parameters.AddWithValue("@away_team_name ", model.AwayTeamName);
                sqlCommand.Parameters.AddWithValue("@home_team_goal_count ", model.HomeTeamGoalCount);
                sqlCommand.Parameters.AddWithValue("@away_team_goal_count ", model.AwayTeamGoalCount);
                sqlCommand.Parameters.AddWithValue("@total_goal_count ", model.TotalGoalCount);
                sqlCommand.Parameters.AddWithValue("@total_goals_at_half_time ", model.TotalGoalsAtHalfTime);
                sqlCommand.Parameters.AddWithValue("@home_team_goal_count_half_time ", model.HomeTeamGoalCountHalfTime);
                sqlCommand.Parameters.AddWithValue("@away_team_goal_count_half_time", model.AwayTeamGoalCountHalfTime);
                sqlCommand.Parameters.AddWithValue("@home_team_goal_timings ", model.HomeTeamGoalTimings);
                sqlCommand.Parameters.AddWithValue("@away_team_goal_timings", model.AwayTeamGoalTimings);
                sqlCommand.Parameters.AddWithValue("@home_team_corner_count ", model.HomeTeamCornerCount);
                sqlCommand.Parameters.AddWithValue("@away_team_corner_count", model.AwayTeamCornerCount);
                sqlCommand.Parameters.AddWithValue("@home_team_yellow_cards ", model.HomeTeamYellowCards);
                sqlCommand.Parameters.AddWithValue("@away_team_yellow_cards ", model.AwayTeamYellowCards);
                sqlCommand.Parameters.AddWithValue("@home_team_red_cards", model.HomeTeamRedCards);
                sqlCommand.Parameters.AddWithValue("@away_team_red_cards ", model.AwayTeamRedCards);
                sqlCommand.Parameters.AddWithValue("@home_team_shots ", model.HomeTeamShots);
                sqlCommand.Parameters.AddWithValue("@away_team_shots ", model.AwayTeamShots);
                sqlCommand.Parameters.AddWithValue("@home_team_shots_on_target", model.HomeTeamShotsOnTarget);
                sqlCommand.Parameters.AddWithValue("@away_team_shots_on_target ", model.AwayTeamShotsOnTarget);
                sqlCommand.Parameters.AddWithValue("@home_team_shots_off_target ", model.HomeTeamShotsOffTarget);
                sqlCommand.Parameters.AddWithValue("@away_team_shots_off_target ", model.AwayTeamShotsOffTarget);
                sqlCommand.Parameters.AddWithValue("@home_team_fouls ", model.HomeTeamFouls);
                sqlCommand.Parameters.AddWithValue("@away_team_fouls ", model.AwayTeamFouls);
                sqlCommand.Parameters.AddWithValue("@home_team_possession ", model.HomeTeamPossession);
                sqlCommand.Parameters.AddWithValue("@away_team_possession ", model.AwayTeamPossession);
                sqlCommand.Parameters.AddWithValue("@average_goals_per_match_pre_match ", model.AverageGoalsPerMatchPreMatch);
                sqlCommand.Parameters.AddWithValue("@stadium_name ", model.StadiumName);
                int rowsAffected = sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
                return rowsAffected;
            }
        }

        public static int Edit(Match model)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {

                connection.Open();

                SqlCommand sqlCommand = new SqlCommand("EditMatch", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                sqlCommand.Parameters.AddWithValue("@timestamp", model.Timestamp);
                sqlCommand.Parameters.AddWithValue("@date_GMT", model.DateGMT);
                sqlCommand.Parameters.AddWithValue("@status", model.Status);
                sqlCommand.Parameters.AddWithValue("@attendance", model.Attendance);
                sqlCommand.Parameters.AddWithValue("@home_team_name", model.HomeTeamName);
                sqlCommand.Parameters.AddWithValue("@away_team_name ", model.AwayTeamName);
                sqlCommand.Parameters.AddWithValue("@home_team_goal_count ", model.HomeTeamGoalCount);
                sqlCommand.Parameters.AddWithValue("@away_team_goal_count ", model.AwayTeamGoalCount);
                sqlCommand.Parameters.AddWithValue("@total_goal_count ", model.TotalGoalCount);
                sqlCommand.Parameters.AddWithValue("@total_goals_at_half_time ", model.TotalGoalsAtHalfTime);
                sqlCommand.Parameters.AddWithValue("@home_team_goal_count_half_time ", model.HomeTeamGoalCountHalfTime);
                sqlCommand.Parameters.AddWithValue("@away_team_goal_count_half_time", model.AwayTeamGoalCountHalfTime);
                sqlCommand.Parameters.AddWithValue("@home_team_goal_timings ", model.HomeTeamGoalTimings);
                sqlCommand.Parameters.AddWithValue("@away_team_goal_timings", model.AwayTeamGoalTimings);
                sqlCommand.Parameters.AddWithValue("@home_team_corner_count ", model.HomeTeamCornerCount);
                sqlCommand.Parameters.AddWithValue("@away_team_corner_count", model.AwayTeamCornerCount);
                sqlCommand.Parameters.AddWithValue("@home_team_yellow_cards ", model.HomeTeamYellowCards);
                sqlCommand.Parameters.AddWithValue("@away_team_yellow_cards ", model.AwayTeamYellowCards);
                sqlCommand.Parameters.AddWithValue("@home_team_red_cards", model.HomeTeamRedCards);
                sqlCommand.Parameters.AddWithValue("@away_team_red_cards ", model.AwayTeamRedCards);
                sqlCommand.Parameters.AddWithValue("@home_team_shots ", model.HomeTeamShots);
                sqlCommand.Parameters.AddWithValue("@away_team_shots ", model.AwayTeamShots);
                sqlCommand.Parameters.AddWithValue("@home_team_shots_on_target", model.HomeTeamShotsOnTarget);
                sqlCommand.Parameters.AddWithValue("@away_team_shots_on_target ", model.AwayTeamShotsOnTarget);
                sqlCommand.Parameters.AddWithValue("@home_team_shots_off_target ", model.HomeTeamShotsOffTarget);
                sqlCommand.Parameters.AddWithValue("@away_team_shots_off_target ", model.AwayTeamShotsOffTarget);
                sqlCommand.Parameters.AddWithValue("@home_team_fouls ", model.HomeTeamFouls);
                sqlCommand.Parameters.AddWithValue("@away_team_fouls ", model.AwayTeamFouls);
                sqlCommand.Parameters.AddWithValue("@home_team_possession ", model.HomeTeamPossession);
                sqlCommand.Parameters.AddWithValue("@away_team_possession ", model.AwayTeamPossession);
                sqlCommand.Parameters.AddWithValue("@average_goals_per_match_pre_match ", model.AverageGoalsPerMatchPreMatch);
                sqlCommand.Parameters.AddWithValue("@stadium_name ", model.StadiumName);
                sqlCommand.Parameters.AddWithValue("@Id", model.Id);
                int rowsAffected = sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
                return rowsAffected;
            }
        }

        public static int Delete(Match model)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {

                connection.Open();

                SqlCommand sqlCommand = new SqlCommand("DeleteMatch", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                sqlCommand.Parameters.AddWithValue("@Id", model.Id);
                int rowsAffected = sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
                return rowsAffected;
            }
        }

        public static Match GetMatch(Match model)
        {
            Match obj = new Match();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand sqlCommand = new SqlCommand("GetMatch", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                sqlCommand.Parameters.AddWithValue("@Id", model.Id);
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        obj.Timestamp = int.Parse(reader["timestamp"].ToString());
                        obj.DateGMT = reader["date_GMT"].ToString();
                        obj.Status = reader["status"].ToString();
                        obj.Attendance = reader["attendance"].ToString();
                        obj.HomeTeamName = reader["home_team_name"].ToString();
                        obj.AwayTeamName = reader["away_team_name"].ToString();
                        obj.HomeTeamGoalCount = int.Parse(reader["home_team_goal_count"].ToString());
                        obj.AwayTeamGoalCount = int.Parse(reader["away_team_goal_count"].ToString());
                        obj.TotalGoalCount = int.Parse(reader["total_goal_count"].ToString());
                        obj.TotalGoalsAtHalfTime = int.Parse(reader["total_goals_at_half_time"].ToString());
                        obj.HomeTeamGoalCountHalfTime = int.Parse(reader["home_team_goal_count_half_time"].ToString());
                        obj.AwayTeamGoalCountHalfTime = int.Parse(reader["away_team_goal_count_half_time"].ToString());
                        obj.HomeTeamGoalTimings = reader["home_team_goal_timings"].ToString();
                        obj.AwayTeamGoalTimings = reader["away_team_goal_timings"].ToString();
                        obj.HomeTeamCornerCount = int.Parse(reader["home_team_corner_count"].ToString());
                        obj.AwayTeamCornerCount = int.Parse(reader["away_team_corner_count"].ToString());
                        obj.HomeTeamYellowCards = int.Parse(reader["home_team_yellow_cards"].ToString());
                        obj.AwayTeamYellowCards = int.Parse(reader["away_team_yellow_cards"].ToString());
                        obj.HomeTeamRedCards = int.Parse(reader["home_team_red_cards"].ToString());
                        obj.AwayTeamRedCards = int.Parse(reader["away_team_red_cards"].ToString());
                        obj.HomeTeamShots = int.Parse(reader["home_team_shots"].ToString());
                        obj.AwayTeamShots = int.Parse(reader["away_team_shots"].ToString());
                        obj.HomeTeamShotsOnTarget = int.Parse(reader["home_team_shots_on_target"].ToString());
                        obj.AwayTeamShotsOnTarget = int.Parse(reader["away_team_shots_on_target"].ToString());
                        obj.HomeTeamShotsOffTarget = int.Parse(reader["home_team_shots_off_target"].ToString());
                        obj.AwayTeamShotsOffTarget = int.Parse(reader["away_team_shots_off_target"].ToString());
                        obj.HomeTeamFouls = int.Parse(reader["home_team_fouls"].ToString());
                        obj.AwayTeamFouls = int.Parse(reader["away_team_fouls"].ToString());
                        obj.HomeTeamPossession = int.Parse(reader["home_team_possession"].ToString());
                        obj.AwayTeamPossession = int.Parse(reader["away_team_possession"].ToString());
                        obj.AverageGoalsPerMatchPreMatch = float.Parse(reader["average_goals_per_match_pre_match"].ToString());
                        obj.StadiumName = reader["stadium_name"].ToString();
                        obj.Id = int.Parse(reader["Id"].ToString());
                    }
                }
                sqlCommand.Dispose();
            }
            return obj;
        }

        public static List<Match> GetAll()
        {
            List<Match> matches = new List<Match>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand sqlCommand =
                    new SqlCommand("GetAllMatches", connection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Match match = new Match();

                        match.Id = int.Parse(reader["Id"].ToString());
                        match.Timestamp = int.Parse(reader["timestamp"].ToString());
                        match.DateGMT = reader["date_GMT"].ToString();
                        match.Status = reader["status"].ToString();
                        match.HomeTeamName = reader["home_team_name"].ToString();
                        match.AwayTeamName = reader["away_team_name"].ToString();
                        matches.Add(match);
                    }
                }
                sqlCommand.Dispose();
            }
            return matches;
        }
        public static List<Match> GetAllByAway()
        {
            List<Match> matches = new List<Match>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand sqlCommand =
                    new SqlCommand("GetAllMatchesByAway", connection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Match match = new Match();

                        match.Id = int.Parse(reader["Id"].ToString());
                        match.Timestamp = int.Parse(reader["timestamp"].ToString());
                        match.DateGMT = reader["date_GMT"].ToString();
                        match.Status = reader["status"].ToString();
                        match.HomeTeamName = reader["home_team_name"].ToString();
                        match.AwayTeamName = reader["away_team_name"].ToString();
                        matches.Add(match);
                    }
                }
                sqlCommand.Dispose();
            }
            return matches;
        }

        public static List<Match> GetAllByHome()
        {
            List<Match> matches = new List<Match>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand sqlCommand =
                    new SqlCommand("GetAllMatchesByHome", connection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Match match = new Match();

                        match.Id = int.Parse(reader["Id"].ToString());
                        match.Timestamp = int.Parse(reader["timestamp"].ToString());
                        match.DateGMT = reader["date_GMT"].ToString();
                        match.Status = reader["status"].ToString();
                        match.HomeTeamName = reader["home_team_name"].ToString();
                        match.AwayTeamName = reader["away_team_name"].ToString();
                        matches.Add(match);
                    }
                }
                sqlCommand.Dispose();
            }
            return matches;
        }

        public static List<Match> GetAllByGoal()
        {
            List<Match> matches = new List<Match>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand sqlCommand =
                    new SqlCommand("GetAllMatchesByGoals", connection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Match match = new Match();

                        match.Id = int.Parse(reader["Id"].ToString());
                        match.Timestamp = int.Parse(reader["timestamp"].ToString());
                        match.DateGMT = reader["date_GMT"].ToString();
                        match.Status = reader["status"].ToString();
                        match.HomeTeamName = reader["home_team_name"].ToString();
                        match.AwayTeamName = reader["away_team_name"].ToString();
                        matches.Add(match);
                    }
                }
                sqlCommand.Dispose();
            }
            return matches;
        }
        public static List<Match> GetAllByStadium()
        {
            List<Match> matches = new List<Match>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand sqlCommand =
                    new SqlCommand("GetAllMatchesByStadium", connection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Match match = new Match();

                        match.Id = int.Parse(reader["Id"].ToString());
                        match.Timestamp = int.Parse(reader["timestamp"].ToString());
                        match.DateGMT = reader["date_GMT"].ToString();
                        match.Status = reader["status"].ToString();
                        match.HomeTeamName = reader["home_team_name"].ToString();
                        match.AwayTeamName = reader["away_team_name"].ToString();
                        matches.Add(match);
                    }
                }
                sqlCommand.Dispose();
            }
            return matches;
        }

    }
}