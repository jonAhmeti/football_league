using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace FootballLeague.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string TeamName { get; set; }
        public string CommonName { get; set; }
        public string Season { get; set; }
        public string Country { get; set; }
        public int MatchesPlayed { get; set; }
        public int MatchesPlayedHome { get; set; }
        public int MatchesPlayedAway { get; set; }
        public int SuspendedMatches { get; set; }
        public int Wins { get; set; }
        public int WinsHome { get; set; }
        public int WinsAway { get; set; }
        public int Draws { get; set; }
        public int DrawsHome { get; set; }
        public int DrawsAway { get; set; }
        public int Losses { get; set; }
        public int LossesHome { get; set; }
        public int LossesAway { get; set; }
        public float PointsPerGame { get; set; }
        public float PointsPerGameHome { get; set; }
        public float PointsPerGameAway { get; set; }
        public int LeaguePosition { get; set; }
        public int LeaguePositionHome { get; set; }
        public int LeaguePositionAway { get; set; }
        public int PerformanceRank { get; set; }
        public int GoalsScored { get; set; }
        public int GoalDifference { get; set; }
        public int TotalGoalCount { get; set; }
        public int TotalGoalCountHome { get; set; }
        public int TotalGoalCountAway { get; set; }
        public int GoalsScoredHome { get; set; }
        public int GoalsScoredAway { get; set; }
        public int GoalDifferenceHome { get; set; }
        public int GoalDifferenceAway { get; set; }
        public int MinutesPerGoalScored { get; set; }
        public int MinutesPerGoalScoredHome { get; set; }
        public int MinutesPerGoalScoredAway { get; set; }
        public int FirstTeamToScoreCount { get; set; }
        public int FirstTeamToScoreCountHome { get; set; }
        public int FirstTeamToScoreCountAway { get; set; }
        public int CornersTotal { get; set; }
        public int CornersTotalHome { get; set; }
        public int CornersTotalAway { get; set; }
        public int CardsTotal { get; set; }
        public int CardsTotalHome { get; set; }
        public int CardsTotalAway { get; set; }
        public int AveragePossession { get; set; }
        public int AveragePossessionHome { get; set; }
        public int AveragePossessionAway { get; set; }
        public int Shots { get; set; }
        public int ShotsHome { get; set; }
        public int ShotsAway { get; set; }
        public int ShotsOnTarget { get; set; }
        public int ShotsOnTargetHome { get; set; }
        public int ShotsOnTargetAway { get; set; }
        public int ShotsOffTarget { get; set; }
        public int ShotsOffTargetHome { get; set; }
        public int ShotsOffTargetAway { get; set; }
        public int Fouls { get; set; }
        public int FoulsHome { get; set; }
        public int FoulsAway { get; set; }
        public int GoalsScoredHalfTime { get; set; }
        public int GoalsScoredHalfTimeHome { get; set; }
        public int GoalsScoredHalfTimeAway { get; set; }
        public int GoalsConcededHalfTime { get; set; }
        public int GoalsConcededHalfTimeHome { get; set; }
        public int GoalsConcededHalfTimeAway { get; set; }
        public int GoalDifferenceHalfTime { get; set; }
        public int GoalDifferenceHalfTimeHome { get; set; }
        public int GoalDifferenceHalfTimeAway { get; set; }
        public int LeadingAtHalfTime { get; set; }
        public int LeadingAtHalfTimeHome { get; set; }
        public int LeadingAtHalfTimeAway { get; set; }
        public int DrawAtHalfTime { get; set; }
        public float CornersPerMatch { get; set; }
        public float CornersPerMatchHome { get; set; }
        public float CornersPerMatchAway { get; set; }
        public float CardsPerMatch { get; set; }
        public float CardsPerMatchHome { get; set; }
        public float CardsPerMatchAway { get; set; }

        public static readonly string _connectionString =
            ConfigurationManager.ConnectionStrings["FootballLeague"].ConnectionString;

        public static int Add(Team model)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {

                connection.Open();

                SqlCommand sqlCommand = new SqlCommand("AddTeam", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                sqlCommand.Parameters.AddWithValue("@TeamName", model.TeamName);
                sqlCommand.Parameters.AddWithValue("@CommonName", model.CommonName);
                sqlCommand.Parameters.AddWithValue("@Season", model.Season);
                sqlCommand.Parameters.AddWithValue("@Country", model.Country);
                sqlCommand.Parameters.AddWithValue("@MatchesPlayed", model.MatchesPlayed);
                sqlCommand.Parameters.AddWithValue("@MatchesPlayedHome", model.MatchesPlayedHome);
                sqlCommand.Parameters.AddWithValue("@MatchesPlayedAway", model.MatchesPlayedAway);
                sqlCommand.Parameters.AddWithValue("@SuspendedMatches", model.SuspendedMatches);
                sqlCommand.Parameters.AddWithValue("@Wins", model.Wins);
                sqlCommand.Parameters.AddWithValue("@WinsHome", model.WinsHome);
                sqlCommand.Parameters.AddWithValue("@WinsAway", model.WinsAway);
                sqlCommand.Parameters.AddWithValue("@Draws", model.Draws);
                sqlCommand.Parameters.AddWithValue("@DrawsHome", model.DrawsHome);
                sqlCommand.Parameters.AddWithValue("@DrawsAway", model.DrawsAway);
                sqlCommand.Parameters.AddWithValue("@Losses", model.Losses);
                sqlCommand.Parameters.AddWithValue("@LossesHome", model.LossesHome);
                sqlCommand.Parameters.AddWithValue("@LossesAway", model.LossesAway);
                sqlCommand.Parameters.AddWithValue("@PointsPerGame", model.PointsPerGame);
                sqlCommand.Parameters.AddWithValue("@PointsPerGameHome", model.PointsPerGameHome);
                sqlCommand.Parameters.AddWithValue("@PointsPerGameAway", model.PointsPerGameAway);
                sqlCommand.Parameters.AddWithValue("@LeaguePosition", model.LeaguePosition);
                sqlCommand.Parameters.AddWithValue("@LeaguePositionHome", model.LeaguePositionHome);
                sqlCommand.Parameters.AddWithValue("@LeaguePositionAway", model.LeaguePositionAway);
                sqlCommand.Parameters.AddWithValue("@PerformanceRank", model.PerformanceRank);
                sqlCommand.Parameters.AddWithValue("@GoalsScored", model.GoalsScored);
                sqlCommand.Parameters.AddWithValue("@GoalDifference", model.GoalDifference);
                sqlCommand.Parameters.AddWithValue("@TotalGoalCount", model.TotalGoalCount);
                sqlCommand.Parameters.AddWithValue("@TotalGoalCountHome", model.TotalGoalCountHome);
                sqlCommand.Parameters.AddWithValue("@TotalGoalCountAway", model.TotalGoalCountAway);
                sqlCommand.Parameters.AddWithValue("@GoalsScoredHome", model.GoalsScoredHome);
                sqlCommand.Parameters.AddWithValue("@GoalsScoredAway", model.GoalsScoredAway);
                sqlCommand.Parameters.AddWithValue("@GoalDifferenceHome", model.GoalDifferenceHome);
                sqlCommand.Parameters.AddWithValue("@GoalDifferenceAway", model.GoalDifferenceAway);
                sqlCommand.Parameters.AddWithValue("@MinutesPerGoalScored", model.MinutesPerGoalScored);
                sqlCommand.Parameters.AddWithValue("@MinutesPerGoalScoredHome", model.MinutesPerGoalScoredHome);
                sqlCommand.Parameters.AddWithValue("@MinutesPerGoalScoredAway", model.MinutesPerGoalScoredAway);
                sqlCommand.Parameters.AddWithValue("@FirstTeamToScoreCount", model.FirstTeamToScoreCount);
                sqlCommand.Parameters.AddWithValue("@FirstTeamToScoreCountHome", model.FirstTeamToScoreCountHome);
                sqlCommand.Parameters.AddWithValue("@FirstTeamToScoreCountAway", model.FirstTeamToScoreCountAway);
                sqlCommand.Parameters.AddWithValue("@CornersTotal", model.CornersTotal);
                sqlCommand.Parameters.AddWithValue("@CornersTotalHome", model.CornersTotalHome);
                sqlCommand.Parameters.AddWithValue("@CornersTotalAway", model.CornersTotalAway);
                sqlCommand.Parameters.AddWithValue("@CardsTotal", model.CardsTotal);
                sqlCommand.Parameters.AddWithValue("@CardsTotalHome", model.CardsTotalHome);
                sqlCommand.Parameters.AddWithValue("@CardsTotalAway", model.CardsTotalAway);
                sqlCommand.Parameters.AddWithValue("@AveragePossession", model.AveragePossession);
                sqlCommand.Parameters.AddWithValue("@AveragePossessionHome", model.AveragePossessionHome);
                sqlCommand.Parameters.AddWithValue("@AveragePossessionAway", model.AveragePossessionAway);
                sqlCommand.Parameters.AddWithValue("@Shots", model.Shots);
                sqlCommand.Parameters.AddWithValue("@ShotsHome", model.ShotsHome);
                sqlCommand.Parameters.AddWithValue("@ShotsAway", model.ShotsAway);
                sqlCommand.Parameters.AddWithValue("@ShotsOnTarget", model.ShotsOnTarget);
                sqlCommand.Parameters.AddWithValue("@ShotsOnTargetHome", model.ShotsOnTargetHome);
                sqlCommand.Parameters.AddWithValue("@ShotsOnTargetAway", model.ShotsOnTargetAway);
                sqlCommand.Parameters.AddWithValue("@ShotsOffTarget", model.ShotsOffTarget);
                sqlCommand.Parameters.AddWithValue("@ShotsOffTargetHome", model.ShotsOffTargetHome);
                sqlCommand.Parameters.AddWithValue("@ShotsOffTargetAway", model.ShotsOffTargetAway);
                sqlCommand.Parameters.AddWithValue("@Fouls", model.Fouls);
                sqlCommand.Parameters.AddWithValue("@FoulsHome", model.FoulsHome);
                sqlCommand.Parameters.AddWithValue("@FoulsAway", model.FoulsAway);
                sqlCommand.Parameters.AddWithValue("@GoalsScoredHalfTime", model.GoalsScoredHalfTime);
                sqlCommand.Parameters.AddWithValue("@GoalsScoredHalfTimeHome", model.GoalsScoredHalfTimeHome);
                sqlCommand.Parameters.AddWithValue("@GoalsScoredHalfTimeAway", model.GoalsScoredHalfTimeAway);
                sqlCommand.Parameters.AddWithValue("@GoalsConcededHalfTime", model.GoalsConcededHalfTime);
                sqlCommand.Parameters.AddWithValue("@GoalsConcededHalfTimeHome", model.GoalsConcededHalfTimeHome);
                sqlCommand.Parameters.AddWithValue("@GoalsConcededHalfTimeAway", model.GoalsConcededHalfTimeAway);
                sqlCommand.Parameters.AddWithValue("@GoalDifferenceHalfTime", model.GoalDifferenceHalfTime);
                sqlCommand.Parameters.AddWithValue("@GoalDifferenceHalfTimeHome", model.GoalDifferenceHalfTimeHome);
                sqlCommand.Parameters.AddWithValue("@GoalDifferenceHalfTimeAway", model.GoalDifferenceHalfTimeAway);
                sqlCommand.Parameters.AddWithValue("@LeadingAtHalfTime", model.LeadingAtHalfTime);
                sqlCommand.Parameters.AddWithValue("@LeadingAtHalfTimeHome", model.LeadingAtHalfTimeHome);
                sqlCommand.Parameters.AddWithValue("@LeadingAtHalfTimeAway", model.LeadingAtHalfTimeAway);
                sqlCommand.Parameters.AddWithValue("@DrawAtHalfTime", model.DrawAtHalfTime);
                sqlCommand.Parameters.AddWithValue("@CornersPerMatch", model.CornersPerMatch);
                sqlCommand.Parameters.AddWithValue("@CornersPerMatchHome", model.CornersPerMatchHome);
                sqlCommand.Parameters.AddWithValue("@CornersPerMatchAway", model.CornersPerMatchAway);
                sqlCommand.Parameters.AddWithValue("@CardsPerMatch", model.CardsPerMatch);
                sqlCommand.Parameters.AddWithValue("@CardsPerMatchHome", model.CardsPerMatchHome);
                sqlCommand.Parameters.AddWithValue("@CardsPerMatchAway", model.CardsPerMatchAway);
                int rowsAffected = sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
                return rowsAffected;
            }
        }

        public static int Edit(Team model)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {

                connection.Open();

                SqlCommand sqlCommand = new SqlCommand("EditTeam", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                sqlCommand.Parameters.AddWithValue("@Id", model.Id);
                sqlCommand.Parameters.AddWithValue("@TeamName", model.TeamName);
                sqlCommand.Parameters.AddWithValue("@Season", model.Season);
                sqlCommand.Parameters.AddWithValue("@Country", model.Country);
                sqlCommand.Parameters.AddWithValue("@CommonName", model.CommonName);
                sqlCommand.Parameters.AddWithValue("@MatchesPlayed", model.MatchesPlayed);
                sqlCommand.Parameters.AddWithValue("@MatchesPlayedHome", model.MatchesPlayedHome);
                sqlCommand.Parameters.AddWithValue("@MatchesPlayedAway", model.MatchesPlayedAway);
                sqlCommand.Parameters.AddWithValue("@SuspendedMatches", model.SuspendedMatches);
                sqlCommand.Parameters.AddWithValue("@Wins", model.Wins);
                sqlCommand.Parameters.AddWithValue("@WinsHome", model.WinsHome);
                sqlCommand.Parameters.AddWithValue("@WinsAway", model.WinsAway);
                sqlCommand.Parameters.AddWithValue("@Draws", model.Draws);
                sqlCommand.Parameters.AddWithValue("@DrawsHome", model.DrawsHome);
                sqlCommand.Parameters.AddWithValue("@DrawsAway", model.DrawsAway);
                sqlCommand.Parameters.AddWithValue("@Losses", model.Losses);
                sqlCommand.Parameters.AddWithValue("@LossesHome", model.LossesHome);
                sqlCommand.Parameters.AddWithValue("@LossesAway", model.LossesAway);
                sqlCommand.Parameters.AddWithValue("@PointsPerGame", model.PointsPerGame);
                sqlCommand.Parameters.AddWithValue("@PointsPerGameHome", model.PointsPerGameHome);
                sqlCommand.Parameters.AddWithValue("@PointsPerGameAway", model.PointsPerGameAway);
                sqlCommand.Parameters.AddWithValue("@LeaguePosition", model.LeaguePosition);
                sqlCommand.Parameters.AddWithValue("@LeaguePositionHome", model.LeaguePositionHome);
                sqlCommand.Parameters.AddWithValue("@LeaguePositionAway", model.LeaguePositionAway);
                sqlCommand.Parameters.AddWithValue("@PerformanceRank", model.PerformanceRank);
                sqlCommand.Parameters.AddWithValue("@GoalsScored", model.GoalsScored);
                sqlCommand.Parameters.AddWithValue("@GoalDifference", model.GoalDifference);
                sqlCommand.Parameters.AddWithValue("@TotalGoalCount", model.TotalGoalCount);
                sqlCommand.Parameters.AddWithValue("@TotalGoalCountHome", model.TotalGoalCountHome);
                sqlCommand.Parameters.AddWithValue("@TotalGoalCountAway", model.TotalGoalCountAway);
                sqlCommand.Parameters.AddWithValue("@GoalsScoredHome", model.GoalsScoredHome);
                sqlCommand.Parameters.AddWithValue("@GoalsScoredAway", model.GoalsScoredAway);
                sqlCommand.Parameters.AddWithValue("@GoalDifferenceHome", model.GoalDifferenceHome);
                sqlCommand.Parameters.AddWithValue("@GoalDifferenceAway", model.GoalDifferenceAway);
                sqlCommand.Parameters.AddWithValue("@MinutesPerGoalScored", model.MinutesPerGoalScored);
                sqlCommand.Parameters.AddWithValue("@MinutesPerGoalScoredHome", model.MinutesPerGoalScoredHome);
                sqlCommand.Parameters.AddWithValue("@MinutesPerGoalScoredAway", model.MinutesPerGoalScoredAway);
                sqlCommand.Parameters.AddWithValue("@FirstTeamToScoreCount", model.FirstTeamToScoreCount);
                sqlCommand.Parameters.AddWithValue("@FirstTeamToScoreCountHome", model.FirstTeamToScoreCountHome);
                sqlCommand.Parameters.AddWithValue("@FirstTeamToScoreCountAway", model.FirstTeamToScoreCountAway);
                sqlCommand.Parameters.AddWithValue("@CornersTotal", model.CornersTotal);
                sqlCommand.Parameters.AddWithValue("@CornersTotalHome", model.CornersTotalHome);
                sqlCommand.Parameters.AddWithValue("@CornersTotalAway", model.CornersTotalAway);
                sqlCommand.Parameters.AddWithValue("@CardsTotal", model.CardsTotal);
                sqlCommand.Parameters.AddWithValue("@CardsTotalHome", model.CardsTotalHome);
                sqlCommand.Parameters.AddWithValue("@CardsTotalAway", model.CardsTotalAway);
                sqlCommand.Parameters.AddWithValue("@AveragePossession", model.AveragePossession);
                sqlCommand.Parameters.AddWithValue("@AveragePossessionHome", model.AveragePossessionHome);
                sqlCommand.Parameters.AddWithValue("@AveragePossessionAway", model.AveragePossessionAway);
                sqlCommand.Parameters.AddWithValue("@Shots", model.Shots);
                sqlCommand.Parameters.AddWithValue("@ShotsHome", model.ShotsHome);
                sqlCommand.Parameters.AddWithValue("@ShotsAway", model.ShotsAway);
                sqlCommand.Parameters.AddWithValue("@ShotsOnTarget", model.ShotsOnTarget);
                sqlCommand.Parameters.AddWithValue("@ShotsOnTargetHome", model.ShotsOnTargetHome);
                sqlCommand.Parameters.AddWithValue("@ShotsOnTargetAway", model.ShotsOnTargetAway);
                sqlCommand.Parameters.AddWithValue("@ShotsOffTarget", model.ShotsOffTarget);
                sqlCommand.Parameters.AddWithValue("@ShotsOffTargetHome", model.ShotsOffTargetHome);
                sqlCommand.Parameters.AddWithValue("@ShotsOffTargetAway", model.ShotsOffTargetAway);
                sqlCommand.Parameters.AddWithValue("@Fouls", model.Fouls);
                sqlCommand.Parameters.AddWithValue("@FoulsHome", model.FoulsHome);
                sqlCommand.Parameters.AddWithValue("@FoulsAway", model.FoulsAway);
                sqlCommand.Parameters.AddWithValue("@GoalsScoredHalfTime", model.GoalsScoredHalfTime);
                sqlCommand.Parameters.AddWithValue("@GoalsScoredHalfTimeHome", model.GoalsScoredHalfTimeHome);
                sqlCommand.Parameters.AddWithValue("@GoalsScoredHalfTimeAway", model.GoalsScoredHalfTimeAway);
                sqlCommand.Parameters.AddWithValue("@GoalsConcededHalfTime", model.GoalsConcededHalfTime);
                sqlCommand.Parameters.AddWithValue("@GoalsConcededHalfTimeHome", model.GoalsConcededHalfTimeHome);
                sqlCommand.Parameters.AddWithValue("@GoalsConcededHalfTimeAway", model.GoalsConcededHalfTimeAway);
                sqlCommand.Parameters.AddWithValue("@GoalDifferenceHalfTime", model.GoalDifferenceHalfTime);
                sqlCommand.Parameters.AddWithValue("@GoalDifferenceHalfTimeHome", model.GoalDifferenceHalfTimeHome);
                sqlCommand.Parameters.AddWithValue("@GoalDifferenceHalfTimeAway", model.GoalDifferenceHalfTimeAway);
                sqlCommand.Parameters.AddWithValue("@LeadingAtHalfTime", model.LeadingAtHalfTime);
                sqlCommand.Parameters.AddWithValue("@LeadingAtHalfTimeHome", model.LeadingAtHalfTimeHome);
                sqlCommand.Parameters.AddWithValue("@LeadingAtHalfTimeAway", model.LeadingAtHalfTimeAway);
                sqlCommand.Parameters.AddWithValue("@DrawAtHalfTime", model.DrawAtHalfTime);
                sqlCommand.Parameters.AddWithValue("@CornersPerMatch", model.CornersPerMatch);
                sqlCommand.Parameters.AddWithValue("@CornersPerMatchHome", model.CornersPerMatchHome);
                sqlCommand.Parameters.AddWithValue("@CornersPerMatchAway", model.CornersPerMatchAway);
                sqlCommand.Parameters.AddWithValue("@CardsPerMatch", model.CardsPerMatch);
                sqlCommand.Parameters.AddWithValue("@CardsPerMatchHome", model.CardsPerMatchHome);
                sqlCommand.Parameters.AddWithValue("@CardsPerMatchAway", model.CardsPerMatchAway);

                int rowsAffected = sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
                return rowsAffected;
            }
        }

        public static int Delete(Team model)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {

                connection.Open();

                SqlCommand sqlCommand = new SqlCommand("DeleteTeam", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                sqlCommand.Parameters.AddWithValue("@Id", model.Id);
                int rowsAffected = sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
                return rowsAffected;
            }
        }

        public static Team GetTeam(Team model)
        {
            Team team = new Team();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand sqlCommand = new SqlCommand("GetTeam", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                sqlCommand.Parameters.AddWithValue("@Id", model.Id);
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        team.Id = int.Parse(reader["Id"].ToString());
                        team.CommonName = reader["common_name"].ToString();
                        team.TeamName = reader["team_name"].ToString();
                        team.Country = reader["country"].ToString();
                        team.Season = reader["season"].ToString();
                        team.MatchesPlayed = int.Parse(reader["matches_played"].ToString());
                        team.MatchesPlayedHome = int.Parse(reader["matches_played_home"].ToString());
                        team.MatchesPlayedAway = int.Parse(reader["matches_played_away"].ToString());
                        team.SuspendedMatches = int.Parse(reader["suspended_matches"].ToString());
                        team.Wins = int.Parse(reader["wins"].ToString());
                        team.WinsHome = int.Parse(reader["wins_home"].ToString());
                        team.WinsAway = int.Parse(reader["wins_away"].ToString());
                        team.Draws = int.Parse(reader["draws"].ToString());
                        team.DrawsHome = int.Parse(reader["draws_home"].ToString());
                        team.DrawsAway = int.Parse(reader["draws_away"].ToString());
                        team.Losses = int.Parse(reader["losses"].ToString());
                        team.LossesHome = int.Parse(reader["losses_home"].ToString());
                        team.LossesAway = int.Parse(reader["losses_away"].ToString());
                        team.PointsPerGame = float.Parse(reader["points_per_game"].ToString());
                        team.PointsPerGameHome = float.Parse(reader["points_per_game_home"].ToString());
                        team.PointsPerGameAway = float.Parse(reader["points_per_game_away"].ToString());
                        team.LeaguePosition = int.Parse(reader["league_position"].ToString());
                        team.LeaguePositionHome = int.Parse(reader["league_position_home"].ToString());
                        team.LeaguePositionAway = int.Parse(reader["league_position_away"].ToString());
                        team.PerformanceRank = int.Parse(reader["performance_rank"].ToString());
                        team.GoalsScored = int.Parse(reader["goals_scored"].ToString());
                        team.GoalDifference = int.Parse(reader["goal_difference"].ToString());
                        team.TotalGoalCount = int.Parse(reader["total_goal_count"].ToString());
                        team.TotalGoalCountHome = int.Parse(reader["total_goal_count_home"].ToString());
                        team.TotalGoalCountAway = int.Parse(reader["total_goal_count_away"].ToString());
                        team.GoalsScoredHome = int.Parse(reader["goals_scored_home"].ToString());
                        team.GoalsScoredAway = int.Parse(reader["goals_scored_away"].ToString());
                        team.GoalDifferenceHome = int.Parse(reader["goal_difference_home"].ToString());
                        team.GoalDifferenceAway = int.Parse(reader["goal_difference_away"].ToString());
                        team.MinutesPerGoalScored = int.Parse(reader["minutes_per_goal_scored"].ToString());
                        team.MinutesPerGoalScoredHome = int.Parse(reader["minutes_per_goal_scored_home"].ToString());
                        team.MinutesPerGoalScoredAway = int.Parse(reader["minutes_per_goal_scored_away"].ToString());
                        team.FirstTeamToScoreCount = int.Parse(reader["first_team_to_score_count"].ToString());
                        team.FirstTeamToScoreCountHome = int.Parse(reader["first_team_to_score_count_home"].ToString());
                        team.FirstTeamToScoreCountAway = int.Parse(reader["first_team_to_score_count_away"].ToString());
                        team.CornersTotal = int.Parse(reader["corners_total"].ToString());
                        team.CornersTotalHome = int.Parse(reader["corners_total_home"].ToString());
                        team.CornersTotalAway = int.Parse(reader["corners_total_away"].ToString());
                        team.CardsTotal = int.Parse(reader["cards_total"].ToString());
                        team.CardsTotalHome = int.Parse(reader["cards_total_home"].ToString());
                        team.CardsTotalAway = int.Parse(reader["cards_total_away"].ToString());
                        team.AveragePossession = int.Parse(reader["average_possession"].ToString());
                        team.AveragePossessionHome = int.Parse(reader["average_possession_home"].ToString());
                        team.AveragePossessionAway = int.Parse(reader["average_possession_away"].ToString());
                        team.Shots = int.Parse(reader["shots"].ToString());
                        team.ShotsHome = int.Parse(reader["shots_home"].ToString());
                        team.ShotsAway = int.Parse(reader["shots_away"].ToString());
                        team.ShotsOnTarget = int.Parse(reader["shots_on_target"].ToString());
                        team.ShotsOnTargetHome = int.Parse(reader["shots_on_target_home"].ToString());
                        team.ShotsOnTargetAway = int.Parse(reader["shots_on_target_away"].ToString());
                        team.ShotsOffTarget = int.Parse(reader["shots_off_target"].ToString());
                        team.ShotsOffTargetHome = int.Parse(reader["shots_off_target_home"].ToString());
                        team.ShotsOffTargetAway = int.Parse(reader["shots_off_target_away"].ToString());
                        team.Fouls = int.Parse(reader["fouls"].ToString());
                        team.FoulsHome = int.Parse(reader["fouls_home"].ToString());
                        team.FoulsAway = int.Parse(reader["fouls_away"].ToString());
                        team.GoalsScoredHalfTime = int.Parse(reader["goals_scored_half_time"].ToString());
                        team.GoalsScoredHalfTimeHome = int.Parse(reader["goals_scored_half_time_home"].ToString());
                        team.GoalsScoredHalfTimeAway = int.Parse(reader["goals_scored_half_time_away"].ToString());
                        team.GoalsConcededHalfTime = int.Parse(reader["goals_conceded_half_time"].ToString());
                        team.GoalsConcededHalfTimeHome = int.Parse(reader["goals_conceded_half_time_home"].ToString());
                        team.GoalsConcededHalfTimeAway = int.Parse(reader["goals_conceded_half_time_away"].ToString());
                        team.GoalDifferenceHalfTime = int.Parse(reader["goal_difference_half_time"].ToString());
                        team.GoalDifferenceHalfTimeHome =
                            int.Parse(reader["goal_difference_half_time_home"].ToString());
                        team.GoalDifferenceHalfTimeAway =
                            int.Parse(reader["goal_difference_half_time_away"].ToString());
                        team.LeadingAtHalfTime = int.Parse(reader["leading_at_half_time"].ToString());
                        team.LeadingAtHalfTimeHome = int.Parse(reader["leading_at_half_time_home"].ToString());
                        team.LeadingAtHalfTimeAway = int.Parse(reader["leading_at_half_time_away"].ToString());
                        team.DrawAtHalfTime = int.Parse(reader["draw_at_half_time"].ToString());
                        team.CornersPerMatch = float.Parse(reader["corners_per_match"].ToString());
                        team.CornersPerMatchHome = float.Parse(reader["corners_per_match_home"].ToString());
                        team.CornersPerMatchAway = float.Parse(reader["corners_per_match_away"].ToString());
                        team.CardsPerMatch = float.Parse(reader["cards_per_match"].ToString());
                        team.CardsPerMatchHome = float.Parse(reader["cards_per_match_home"].ToString());
                        team.CardsPerMatchAway = float.Parse(reader["cards_per_match_away"].ToString());
                    }
                }

                sqlCommand.Dispose();
            }

            return team;
        }

        public static List<Team> GetAll()
        {
            List<Team> teams = new List<Team>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand sqlCommand =
                    new SqlCommand("GetAllTeams", connection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Team team = new Team();

                        team.Id = int.Parse(reader["Id"].ToString());
                        team.CommonName = (reader["common_name"].ToString());
                        team.TeamName = reader["team_name"].ToString();
                        team.Country = reader["country"].ToString();
                        team.Season = reader["season"].ToString();

                        teams.Add(team);
                    }
                }

                sqlCommand.Dispose();
            }

            return teams;
        }

        public static List<Team> GetAllByCards()
        {
            List<Team> teams = new List<Team>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand sqlCommand =
                    new SqlCommand("GetAllTeamsByCards", connection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Team team = new Team();

                        team.Id = int.Parse(reader["Id"].ToString());
                        team.CommonName = (reader["common_name"].ToString());
                        team.TeamName = reader["team_name"].ToString();
                        team.Country = reader["country"].ToString();
                        team.Season = reader["season"].ToString();

                        teams.Add(team);
                    }
                }

                sqlCommand.Dispose();
            }

            return teams;
        }

        public static List<Team> GetAllByCountry()
        {
            List<Team> teams = new List<Team>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand sqlCommand =
                    new SqlCommand("GetAllTeamsByCountry", connection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Team team = new Team();

                        team.Id = int.Parse(reader["Id"].ToString());
                        team.CommonName = (reader["common_name"].ToString());
                        team.TeamName = reader["team_name"].ToString();
                        team.Country = reader["country"].ToString();
                        team.Season = reader["season"].ToString();

                        teams.Add(team);
                    }
                }

                sqlCommand.Dispose();
            }

            return teams;
        }

        public static List<Team> GetAllByFouls()
        {
            List<Team> teams = new List<Team>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand sqlCommand =
                    new SqlCommand("GetAllTeamsByFouls", connection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Team team = new Team();

                        team.Id = int.Parse(reader["Id"].ToString());
                        team.CommonName = (reader["common_name"].ToString());
                        team.TeamName = reader["team_name"].ToString();
                        team.Country = reader["country"].ToString();
                        team.Season = reader["season"].ToString();

                        teams.Add(team);
                    }
                }

                sqlCommand.Dispose();
            }

            return teams;
        }

        public static List<Team> GetAllByGoals()
        {
            List<Team> teams = new List<Team>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand sqlCommand =
                    new SqlCommand("GetAllTeamsByGoals", connection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Team team = new Team();

                        team.Id = int.Parse(reader["Id"].ToString());
                        team.CommonName = (reader["common_name"].ToString());
                        team.TeamName = reader["team_name"].ToString();
                        team.Country = reader["country"].ToString();
                        team.Season = reader["season"].ToString();

                        teams.Add(team);
                    }
                }

                sqlCommand.Dispose();
            }

            return teams;
        }

        public static List<Team> GetAllByLeaguePos()
        {
            List<Team> teams = new List<Team>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand sqlCommand =
                    new SqlCommand("GetAllTeamsByLeaguePos", connection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Team team = new Team();

                        team.Id = int.Parse(reader["Id"].ToString());
                        team.CommonName = (reader["common_name"].ToString());
                        team.TeamName = reader["team_name"].ToString();
                        team.Country = reader["country"].ToString();
                        team.Season = reader["season"].ToString();

                        teams.Add(team);
                    }
                }

                sqlCommand.Dispose();
            }

            return teams;
        }

        public static List<Team> GetAllByLosses()
        {
            List<Team> teams = new List<Team>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand sqlCommand =
                    new SqlCommand("GetAllTeamsByLosses", connection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Team team = new Team();

                        team.Id = int.Parse(reader["Id"].ToString());
                        team.CommonName = (reader["common_name"].ToString());
                        team.TeamName = reader["team_name"].ToString();
                        team.Country = reader["country"].ToString();
                        team.Season = reader["season"].ToString();

                        teams.Add(team);
                    }
                }

                sqlCommand.Dispose();
            }

            return teams;
        }

        public static List<Team> GetAllByWins()
        {
            List<Team> teams = new List<Team>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand sqlCommand =
                    new SqlCommand("GetAllTeamsByWins", connection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Team team = new Team();

                        team.Id = int.Parse(reader["Id"].ToString());
                        team.CommonName = (reader["common_name"].ToString());
                        team.TeamName = reader["team_name"].ToString();
                        team.Country = reader["country"].ToString();
                        team.Season = reader["season"].ToString();

                        teams.Add(team);
                    }
                }

                sqlCommand.Dispose();
            }

            return teams;
        }

        /*public static int GetAvgWins(string commonTeamName)
        {
            int result = 0;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand sqlCommand =
                    new SqlCommand("GetAllTeamsByWins", connection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                sqlCommand.Parameters.AddWithValue("@TeamName", commonTeamName);

                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result = int.Parse(reader["Average"].ToString());
                    }
                    sqlCommand.Dispose();
                }
            }
            return result;
        }*/
    }
}