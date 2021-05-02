using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.Mvc;

namespace FootballLeague.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public int Birthday { get; set; }
        public string League { get; set; }
        public string Season { get; set; }
        public string Position { get; set; }
        public string CurrentClub { get; set; }
        public int MinutesPlayedOverall { get; set; }
        public int MinutesPlayedHome { get; set; }
        public int MinutesPlayedAway { get; set; }
        public string Nationality { get; set; }
        public int AppearancesOverall { get; set; }
        public int AppearancesHome { get; set; }
        public int AppearancesAway { get; set; }
        public int GoalsOverall { get; set; }
        public int GoalsHome { get; set; }
        public int GoalsAway { get; set; }
        public int AssistsOverall { get; set; }
        public int AssistsHome { get; set; }
        public int AssistsAway { get; set; }
        public int PenaltyGoals { get; set; }
        public int PenaltyMisses { get; set; }
        public int YellowCardsOverall { get; set; }
        public int RedCardsOverall { get; set; }
        public int MinPerMatch { get; set; }
        public int MinPerCardOverall { get; set; }
        public int MinPerAssistOverall { get; set; }
        public int RankInLeagueTopAttackers { get; set; }
        public int RankInLeagueTopMidfielders { get; set; }
        public int RankInLeagueTopDefenders { get; set; }
        public int RankInClubTopScorer { get; set; }

        public static readonly string _connectionString = ConfigurationManager.ConnectionStrings["FootballLeague"].ConnectionString;

        public static int Add(Player model)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {

                connection.Open();

                SqlCommand sqlCommand = new SqlCommand("AddPlayer", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                sqlCommand.Parameters.AddWithValue("@full_name", model.FullName);
                sqlCommand.Parameters.AddWithValue("@age", model.Age);
                sqlCommand.Parameters.AddWithValue("@birthday", model.Birthday);
                sqlCommand.Parameters.AddWithValue("@league", model.League);
                sqlCommand.Parameters.AddWithValue("@season ", model.Season);
                sqlCommand.Parameters.AddWithValue("@position ", model.Position);
                sqlCommand.Parameters.AddWithValue("@Current_Club ", model.CurrentClub);
                sqlCommand.Parameters.AddWithValue("@minutes_played_away ", model.MinutesPlayedAway);
                sqlCommand.Parameters.AddWithValue("@minutes_played_home ", model.MinutesPlayedHome);
                sqlCommand.Parameters.AddWithValue("@minutes_played_overall ", model.MinutesPlayedOverall);
                sqlCommand.Parameters.AddWithValue("@nationality", model.Nationality);
                sqlCommand.Parameters.AddWithValue("@appearances_away ", model.AppearancesAway);
                sqlCommand.Parameters.AddWithValue("@appearances_home", model.AppearancesHome);
                sqlCommand.Parameters.AddWithValue("@appearances_overall ", model.AppearancesOverall);
                sqlCommand.Parameters.AddWithValue("@goals_away", model.GoalsAway);
                sqlCommand.Parameters.AddWithValue("@goals_home ", model.GoalsHome);
                sqlCommand.Parameters.AddWithValue("@goals_overall ", model.GoalsOverall);
                sqlCommand.Parameters.AddWithValue("@assists_away", model.AssistsAway);
                sqlCommand.Parameters.AddWithValue("@assists_home ", model.AssistsHome);
                sqlCommand.Parameters.AddWithValue("@assists_overall ", model.AssistsOverall);
                sqlCommand.Parameters.AddWithValue("@penalty_goals ", model.PenaltyGoals);
                sqlCommand.Parameters.AddWithValue("@penalty_misses", model.PenaltyMisses);
                sqlCommand.Parameters.AddWithValue("@red_cards_overall ", model.RedCardsOverall);
                sqlCommand.Parameters.AddWithValue("@yellow_cards_overall ", model.YellowCardsOverall);
                sqlCommand.Parameters.AddWithValue("@min_per_match ", model.MinPerMatch);
                sqlCommand.Parameters.AddWithValue("@min_per_card_overall ", model.MinPerCardOverall);
                sqlCommand.Parameters.AddWithValue("@min_per_assist_overall ", model.MinPerAssistOverall);
                sqlCommand.Parameters.AddWithValue("@rank_in_club_top_scorer ", model.RankInClubTopScorer);
                sqlCommand.Parameters.AddWithValue("@rank_in_league_top_attackers ", model.RankInLeagueTopAttackers);
                sqlCommand.Parameters.AddWithValue("@rank_in_league_top_defenders ", model.RankInLeagueTopDefenders);
                sqlCommand.Parameters.AddWithValue("@rank_in_league_top_midfielders ", model.RankInLeagueTopMidfielders);
                int rowsAffected = sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
                return rowsAffected;
            }
        }

        public static int Edit(Player model)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {

                connection.Open();

                SqlCommand sqlCommand = new SqlCommand("EditPlayer", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                sqlCommand.Parameters.AddWithValue("@Id", model.Id);
                sqlCommand.Parameters.AddWithValue("@full_name", model.FullName);
                sqlCommand.Parameters.AddWithValue("@age", model.Age);
                sqlCommand.Parameters.AddWithValue("@birthday", model.Birthday);
                sqlCommand.Parameters.AddWithValue("@league", model.League);
                sqlCommand.Parameters.AddWithValue("@season ", model.Season);
                sqlCommand.Parameters.AddWithValue("@position ", model.Position);
                sqlCommand.Parameters.AddWithValue("@Current_Club ", model.CurrentClub);
                sqlCommand.Parameters.AddWithValue("@minutes_played_away ", model.MinutesPlayedAway);
                sqlCommand.Parameters.AddWithValue("@minutes_played_home ", model.MinutesPlayedHome);
                sqlCommand.Parameters.AddWithValue("@minutes_played_overall ", model.MinutesPlayedOverall);
                sqlCommand.Parameters.AddWithValue("@nationality", model.Nationality);
                sqlCommand.Parameters.AddWithValue("@appearances_away ", model.AppearancesAway);
                sqlCommand.Parameters.AddWithValue("@appearances_home", model.AppearancesHome);
                sqlCommand.Parameters.AddWithValue("@appearances_overall ", model.AppearancesOverall);
                sqlCommand.Parameters.AddWithValue("@goals_away", model.GoalsAway);
                sqlCommand.Parameters.AddWithValue("@goals_home ", model.GoalsHome);
                sqlCommand.Parameters.AddWithValue("@goals_overall ", model.GoalsOverall);
                sqlCommand.Parameters.AddWithValue("@assists_away", model.AssistsAway);
                sqlCommand.Parameters.AddWithValue("@assists_home ", model.AssistsHome);
                sqlCommand.Parameters.AddWithValue("@assists_overall ", model.AssistsOverall);
                sqlCommand.Parameters.AddWithValue("@penalty_goals ", model.PenaltyGoals);
                sqlCommand.Parameters.AddWithValue("@penalty_misses", model.PenaltyMisses);
                sqlCommand.Parameters.AddWithValue("@red_cards_overall ", model.RedCardsOverall);
                sqlCommand.Parameters.AddWithValue("@yellow_cards_overall ", model.YellowCardsOverall);
                sqlCommand.Parameters.AddWithValue("@min_per_match ", model.MinPerMatch);
                sqlCommand.Parameters.AddWithValue("@min_per_card_overall ", model.MinPerCardOverall);
                sqlCommand.Parameters.AddWithValue("@min_per_assist_overall ", model.MinPerAssistOverall);
                sqlCommand.Parameters.AddWithValue("@rank_in_club_top_scorer ", model.RankInClubTopScorer);
                sqlCommand.Parameters.AddWithValue("@rank_in_league_top_attackers ", model.RankInLeagueTopAttackers);
                sqlCommand.Parameters.AddWithValue("@rank_in_league_top_defenders ", model.RankInLeagueTopDefenders);
                sqlCommand.Parameters.AddWithValue("@rank_in_league_top_midfielders ", model.RankInLeagueTopMidfielders);
                int rowsAffected = sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
                return rowsAffected;
            }
        }

        public static int Delete(Player model)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {

                connection.Open();

                SqlCommand sqlCommand = new SqlCommand("DeletePlayer", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                sqlCommand.Parameters.AddWithValue("@Id", model.Id);
                int rowsAffected = sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
                return rowsAffected;
            }
        }

        public static Player GetPlayer(Player model)
        {
            Player obj = new Player();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand sqlCommand = new SqlCommand("GetPlayer", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                sqlCommand.Parameters.AddWithValue("@Id", model.Id);
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        obj.Id = int.Parse(reader["Id"].ToString());
                        obj.FullName = reader["full_name"].ToString();
                        obj.Age = int.Parse(reader["age"].ToString());
                        obj.Birthday = int.Parse(reader["birthday"].ToString());
                        obj.League = reader["league"].ToString();
                        obj.Season = reader["season"].ToString();
                        obj.Position = reader["position"].ToString();
                        obj.CurrentClub = reader["Current_Club"].ToString();
                        obj.MinutesPlayedAway = int.Parse(reader["minutes_played_away"].ToString());
                        obj.MinutesPlayedHome = int.Parse(reader["minutes_played_home"].ToString());
                        obj.MinutesPlayedOverall = int.Parse(reader["minutes_played_overall"].ToString());
                        obj.Nationality = reader["nationality"].ToString();
                        obj.AppearancesAway = int.Parse(reader["appearances_away"].ToString());
                        obj.AppearancesHome = int.Parse(reader["appearances_home"].ToString());
                        obj.AppearancesOverall = int.Parse(reader["appearances_overall"].ToString());
                        obj.GoalsAway = int.Parse(reader["goals_away"].ToString());
                        obj.GoalsHome = int.Parse(reader["goals_home"].ToString());
                        obj.GoalsOverall = int.Parse(reader["goals_overall"].ToString());
                        obj.AssistsAway = int.Parse(reader["assists_away"].ToString());
                        obj.AssistsHome = int.Parse(reader["assists_home"].ToString());
                        obj.AssistsOverall = int.Parse(reader["assists_overall"].ToString());
                        obj.PenaltyGoals = int.Parse(reader["penalty_goals"].ToString());
                        obj.PenaltyMisses = int.Parse(reader["penalty_misses"].ToString());
                        obj.RedCardsOverall = int.Parse(reader["red_cards_overall"].ToString());
                        obj.YellowCardsOverall = int.Parse(reader["yellow_cards_overall"].ToString());
                        obj.MinPerMatch = int.Parse(reader["min_per_match"].ToString());
                        obj.MinPerCardOverall = int.Parse(reader["min_per_card_overall"].ToString());
                        obj.MinPerAssistOverall = int.Parse(reader["min_per_assist_overall"].ToString());
                        obj.RankInClubTopScorer = int.Parse(reader["rank_in_club_top_scorer"].ToString());
                        obj.RankInLeagueTopAttackers = int.Parse(reader["rank_in_league_top_attackers"].ToString());
                        obj.RankInLeagueTopDefenders = int.Parse(reader["rank_in_league_top_defenders"].ToString());
                        obj.RankInLeagueTopMidfielders = int.Parse(reader["rank_in_league_top_midfielders"].ToString());
                    }
                }
                sqlCommand.Dispose();
            }
            return obj;
        }

        public static List<Player> GetAll()
        {
            List<Player> players = new List<Player>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand sqlCommand =
                    new SqlCommand("GetAllPlayers", connection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Player player = new Player();

                        player.Id = int.Parse(reader["Id"].ToString());
                        player.FullName = (reader["full_name"].ToString());
                        player.Age = int.Parse(reader["age"].ToString());
                        player.Birthday = int.Parse(reader["birthday"].ToString());
                        player.League = reader["league"].ToString();
                        player.Season = reader["season"].ToString();
                        player.Position = reader["position"].ToString();
                        player.CurrentClub = (reader["current_club"].ToString());
                        player.MinutesPlayedAway = int.Parse(reader["minutes_played_away"].ToString());
                        player.MinutesPlayedHome = int.Parse(reader["minutes_played_home"].ToString());
                        player.MinutesPlayedOverall = int.Parse(reader["minutes_played_overall"].ToString());
                        player.Nationality = reader["nationality"].ToString();
                        player.AppearancesAway = int.Parse(reader["appearances_away"].ToString());
                        player.AppearancesHome = int.Parse(reader["appearances_home"].ToString());
                        player.AppearancesOverall = int.Parse(reader["appearances_overall"].ToString());
                        player.GoalsAway = int.Parse(reader["goals_away"].ToString());
                        player.GoalsHome = int.Parse(reader["goals_home"].ToString());
                        player.GoalsOverall = int.Parse(reader["goals_overall"].ToString());
                        player.AssistsAway = int.Parse(reader["assists_away"].ToString());
                        player.AssistsHome = int.Parse(reader["assists_home"].ToString());
                        player.AssistsOverall = int.Parse(reader["assists_overall"].ToString());
                        player.PenaltyGoals = int.Parse(reader["penalty_goals"].ToString());
                        player.PenaltyMisses = int.Parse(reader["penalty_misses"].ToString());
                        player.RedCardsOverall = int.Parse(reader["red_cards_overall"].ToString());
                        player.YellowCardsOverall = int.Parse(reader["yellow_cards_overall"].ToString());
                        player.MinPerMatch = int.Parse(reader["min_per_match"].ToString());
                        player.MinPerCardOverall = int.Parse(reader["min_per_card_overall"].ToString());
                        player.MinPerAssistOverall = int.Parse(reader["min_per_assist_overall"].ToString());
                        player.RankInClubTopScorer = int.Parse(reader["rank_in_club_top_scorer"].ToString());
                        player.RankInLeagueTopAttackers = int.Parse(reader["rank_in_league_top_attackers"].ToString());
                        player.RankInLeagueTopDefenders = int.Parse(reader["rank_in_league_top_defenders"].ToString());
                        player.RankInLeagueTopMidfielders = int.Parse(reader["rank_in_league_top_midfielders"].ToString());

                        players.Add(player);
                    }
                }
                sqlCommand.Dispose();
            }
            return players;
        }

        public static List<Player> GetAllByAge()
        {
            List<Player> players = new List<Player>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand sqlCommand =
                    new SqlCommand("GetAllPlayersByAge", connection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Player player = new Player();

                        player.Id = int.Parse(reader["Id"].ToString());
                        player.FullName = (reader["full_name"].ToString());
                        player.Age = int.Parse(reader["age"].ToString());
                        player.Birthday = int.Parse(reader["birthday"].ToString());
                        player.League = reader["league"].ToString();
                        player.Season = reader["season"].ToString();
                        player.Position = reader["position"].ToString();
                        player.CurrentClub = (reader["current_club"].ToString());
                        player.MinutesPlayedAway = int.Parse(reader["minutes_played_away"].ToString());
                        player.MinutesPlayedHome = int.Parse(reader["minutes_played_home"].ToString());
                        player.MinutesPlayedOverall = int.Parse(reader["minutes_played_overall"].ToString());
                        player.Nationality = reader["nationality"].ToString();
                        player.AppearancesAway = int.Parse(reader["appearances_away"].ToString());
                        player.AppearancesHome = int.Parse(reader["appearances_home"].ToString());
                        player.AppearancesOverall = int.Parse(reader["appearances_overall"].ToString());
                        player.GoalsAway = int.Parse(reader["goals_away"].ToString());
                        player.GoalsHome = int.Parse(reader["goals_home"].ToString());
                        player.GoalsOverall = int.Parse(reader["goals_overall"].ToString());
                        player.AssistsAway = int.Parse(reader["assists_away"].ToString());
                        player.AssistsHome = int.Parse(reader["assists_home"].ToString());
                        player.AssistsOverall = int.Parse(reader["assists_overall"].ToString());
                        player.PenaltyGoals = int.Parse(reader["penalty_goals"].ToString());
                        player.PenaltyMisses = int.Parse(reader["penalty_misses"].ToString());
                        player.RedCardsOverall = int.Parse(reader["red_cards_overall"].ToString());
                        player.YellowCardsOverall = int.Parse(reader["yellow_cards_overall"].ToString());
                        player.MinPerMatch = int.Parse(reader["min_per_match"].ToString());
                        player.MinPerCardOverall = int.Parse(reader["min_per_card_overall"].ToString());
                        player.MinPerAssistOverall = int.Parse(reader["min_per_assist_overall"].ToString());
                        player.RankInClubTopScorer = int.Parse(reader["rank_in_club_top_scorer"].ToString());
                        player.RankInLeagueTopAttackers = int.Parse(reader["rank_in_league_top_attackers"].ToString());
                        player.RankInLeagueTopDefenders = int.Parse(reader["rank_in_league_top_defenders"].ToString());
                        player.RankInLeagueTopMidfielders = int.Parse(reader["rank_in_league_top_midfielders"].ToString());

                        players.Add(player);
                    }
                }
                sqlCommand.Dispose();
            }
            return players;
        }

        public static List<Player> GetAllByClub()
        {
            List<Player> players = new List<Player>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand sqlCommand =
                    new SqlCommand("GetAllPlayersByClub", connection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Player player = new Player();

                        player.Id = int.Parse(reader["Id"].ToString());
                        player.FullName = (reader["full_name"].ToString());
                        player.Age = int.Parse(reader["age"].ToString());
                        player.Birthday = int.Parse(reader["birthday"].ToString());
                        player.League = reader["league"].ToString();
                        player.Season = reader["season"].ToString();
                        player.Position = reader["position"].ToString();
                        player.CurrentClub = (reader["current_club"].ToString());
                        player.MinutesPlayedAway = int.Parse(reader["minutes_played_away"].ToString());
                        player.MinutesPlayedHome = int.Parse(reader["minutes_played_home"].ToString());
                        player.MinutesPlayedOverall = int.Parse(reader["minutes_played_overall"].ToString());
                        player.Nationality = reader["nationality"].ToString();
                        player.AppearancesAway = int.Parse(reader["appearances_away"].ToString());
                        player.AppearancesHome = int.Parse(reader["appearances_home"].ToString());
                        player.AppearancesOverall = int.Parse(reader["appearances_overall"].ToString());
                        player.GoalsAway = int.Parse(reader["goals_away"].ToString());
                        player.GoalsHome = int.Parse(reader["goals_home"].ToString());
                        player.GoalsOverall = int.Parse(reader["goals_overall"].ToString());
                        player.AssistsAway = int.Parse(reader["assists_away"].ToString());
                        player.AssistsHome = int.Parse(reader["assists_home"].ToString());
                        player.AssistsOverall = int.Parse(reader["assists_overall"].ToString());
                        player.PenaltyGoals = int.Parse(reader["penalty_goals"].ToString());
                        player.PenaltyMisses = int.Parse(reader["penalty_misses"].ToString());
                        player.RedCardsOverall = int.Parse(reader["red_cards_overall"].ToString());
                        player.YellowCardsOverall = int.Parse(reader["yellow_cards_overall"].ToString());
                        player.MinPerMatch = int.Parse(reader["min_per_match"].ToString());
                        player.MinPerCardOverall = int.Parse(reader["min_per_card_overall"].ToString());
                        player.MinPerAssistOverall = int.Parse(reader["min_per_assist_overall"].ToString());
                        player.RankInClubTopScorer = int.Parse(reader["rank_in_club_top_scorer"].ToString());
                        player.RankInLeagueTopAttackers = int.Parse(reader["rank_in_league_top_attackers"].ToString());
                        player.RankInLeagueTopDefenders = int.Parse(reader["rank_in_league_top_defenders"].ToString());
                        player.RankInLeagueTopMidfielders = int.Parse(reader["rank_in_league_top_midfielders"].ToString());

                        players.Add(player);
                    }
                }
                sqlCommand.Dispose();
            }
            return players;
        }
        public static List<Player> GetAllByNationality()
        {
            List<Player> players = new List<Player>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand sqlCommand =
                    new SqlCommand("GetAllPlayersByNationality", connection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Player player = new Player();

                        player.Id = int.Parse(reader["Id"].ToString());
                        player.FullName = (reader["full_name"].ToString());
                        player.Age = int.Parse(reader["age"].ToString());
                        player.Birthday = int.Parse(reader["birthday"].ToString());
                        player.League = reader["league"].ToString();
                        player.Season = reader["season"].ToString();
                        player.Position = reader["position"].ToString();
                        player.CurrentClub = (reader["current_club"].ToString());
                        player.MinutesPlayedAway = int.Parse(reader["minutes_played_away"].ToString());
                        player.MinutesPlayedHome = int.Parse(reader["minutes_played_home"].ToString());
                        player.MinutesPlayedOverall = int.Parse(reader["minutes_played_overall"].ToString());
                        player.Nationality = reader["nationality"].ToString();
                        player.AppearancesAway = int.Parse(reader["appearances_away"].ToString());
                        player.AppearancesHome = int.Parse(reader["appearances_home"].ToString());
                        player.AppearancesOverall = int.Parse(reader["appearances_overall"].ToString());
                        player.GoalsAway = int.Parse(reader["goals_away"].ToString());
                        player.GoalsHome = int.Parse(reader["goals_home"].ToString());
                        player.GoalsOverall = int.Parse(reader["goals_overall"].ToString());
                        player.AssistsAway = int.Parse(reader["assists_away"].ToString());
                        player.AssistsHome = int.Parse(reader["assists_home"].ToString());
                        player.AssistsOverall = int.Parse(reader["assists_overall"].ToString());
                        player.PenaltyGoals = int.Parse(reader["penalty_goals"].ToString());
                        player.PenaltyMisses = int.Parse(reader["penalty_misses"].ToString());
                        player.RedCardsOverall = int.Parse(reader["red_cards_overall"].ToString());
                        player.YellowCardsOverall = int.Parse(reader["yellow_cards_overall"].ToString());
                        player.MinPerMatch = int.Parse(reader["min_per_match"].ToString());
                        player.MinPerCardOverall = int.Parse(reader["min_per_card_overall"].ToString());
                        player.MinPerAssistOverall = int.Parse(reader["min_per_assist_overall"].ToString());
                        player.RankInClubTopScorer = int.Parse(reader["rank_in_club_top_scorer"].ToString());
                        player.RankInLeagueTopAttackers = int.Parse(reader["rank_in_league_top_attackers"].ToString());
                        player.RankInLeagueTopDefenders = int.Parse(reader["rank_in_league_top_defenders"].ToString());
                        player.RankInLeagueTopMidfielders = int.Parse(reader["rank_in_league_top_midfielders"].ToString());

                        players.Add(player);
                    }
                }
                sqlCommand.Dispose();
            }
            return players;
        }
        public static List<Player> GetAllByGoals()
        {
            List<Player> players = new List<Player>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand sqlCommand =
                    new SqlCommand("GetAllPlayersByGoals", connection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Player player = new Player();

                        player.Id = int.Parse(reader["Id"].ToString());
                        player.FullName = (reader["full_name"].ToString());
                        player.Age = int.Parse(reader["age"].ToString());
                        player.Birthday = int.Parse(reader["birthday"].ToString());
                        player.League = reader["league"].ToString();
                        player.Season = reader["season"].ToString();
                        player.Position = reader["position"].ToString();
                        player.CurrentClub = (reader["current_club"].ToString());
                        player.MinutesPlayedAway = int.Parse(reader["minutes_played_away"].ToString());
                        player.MinutesPlayedHome = int.Parse(reader["minutes_played_home"].ToString());
                        player.MinutesPlayedOverall = int.Parse(reader["minutes_played_overall"].ToString());
                        player.Nationality = reader["nationality"].ToString();
                        player.AppearancesAway = int.Parse(reader["appearances_away"].ToString());
                        player.AppearancesHome = int.Parse(reader["appearances_home"].ToString());
                        player.AppearancesOverall = int.Parse(reader["appearances_overall"].ToString());
                        player.GoalsAway = int.Parse(reader["goals_away"].ToString());
                        player.GoalsHome = int.Parse(reader["goals_home"].ToString());
                        player.GoalsOverall = int.Parse(reader["goals_overall"].ToString());
                        player.AssistsAway = int.Parse(reader["assists_away"].ToString());
                        player.AssistsHome = int.Parse(reader["assists_home"].ToString());
                        player.AssistsOverall = int.Parse(reader["assists_overall"].ToString());
                        player.PenaltyGoals = int.Parse(reader["penalty_goals"].ToString());
                        player.PenaltyMisses = int.Parse(reader["penalty_misses"].ToString());
                        player.RedCardsOverall = int.Parse(reader["red_cards_overall"].ToString());
                        player.YellowCardsOverall = int.Parse(reader["yellow_cards_overall"].ToString());
                        player.MinPerMatch = int.Parse(reader["min_per_match"].ToString());
                        player.MinPerCardOverall = int.Parse(reader["min_per_card_overall"].ToString());
                        player.MinPerAssistOverall = int.Parse(reader["min_per_assist_overall"].ToString());
                        player.RankInClubTopScorer = int.Parse(reader["rank_in_club_top_scorer"].ToString());
                        player.RankInLeagueTopAttackers = int.Parse(reader["rank_in_league_top_attackers"].ToString());
                        player.RankInLeagueTopDefenders = int.Parse(reader["rank_in_league_top_defenders"].ToString());
                        player.RankInLeagueTopMidfielders = int.Parse(reader["rank_in_league_top_midfielders"].ToString());

                        players.Add(player);
                    }
                }
                sqlCommand.Dispose();
            }
            return players;
        }

        public static List<Player> SearchBy(string category,string text)
        {
            List<Player> players = new List<Player>();

            if (category == null)
            {
                category = "name";
            }

            if (text == null)
            {
                text = "";
            }
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand sqlCommand =
                    new SqlCommand("SearchPlayerBy", connection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                sqlCommand.Parameters.AddWithValue("@category", category);
                sqlCommand.Parameters.AddWithValue("@text", text);

                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Player player = new Player();

                        player.Id = int.Parse(reader["Id"].ToString());
                        player.FullName = (reader["full_name"].ToString());
                        player.Age = int.Parse(reader["age"].ToString());
                        player.Birthday = int.Parse(reader["birthday"].ToString());
                        player.League = reader["league"].ToString();
                        player.Season = reader["season"].ToString();
                        player.Position = reader["position"].ToString();
                        player.CurrentClub = (reader["current_club"].ToString());
                        player.MinutesPlayedAway = int.Parse(reader["minutes_played_away"].ToString());
                        player.MinutesPlayedHome = int.Parse(reader["minutes_played_home"].ToString());
                        player.MinutesPlayedOverall = int.Parse(reader["minutes_played_overall"].ToString());
                        player.Nationality = reader["nationality"].ToString();
                        player.AppearancesAway = int.Parse(reader["appearances_away"].ToString());
                        player.AppearancesHome = int.Parse(reader["appearances_home"].ToString());
                        player.AppearancesOverall = int.Parse(reader["appearances_overall"].ToString());
                        player.GoalsAway = int.Parse(reader["goals_away"].ToString());
                        player.GoalsHome = int.Parse(reader["goals_home"].ToString());
                        player.GoalsOverall = int.Parse(reader["goals_overall"].ToString());
                        player.AssistsAway = int.Parse(reader["assists_away"].ToString());
                        player.AssistsHome = int.Parse(reader["assists_home"].ToString());
                        player.AssistsOverall = int.Parse(reader["assists_overall"].ToString());
                        player.PenaltyGoals = int.Parse(reader["penalty_goals"].ToString());
                        player.PenaltyMisses = int.Parse(reader["penalty_misses"].ToString());
                        player.RedCardsOverall = int.Parse(reader["red_cards_overall"].ToString());
                        player.YellowCardsOverall = int.Parse(reader["yellow_cards_overall"].ToString());
                        player.MinPerMatch = int.Parse(reader["min_per_match"].ToString());
                        player.MinPerCardOverall = int.Parse(reader["min_per_card_overall"].ToString());
                        player.MinPerAssistOverall = int.Parse(reader["min_per_assist_overall"].ToString());
                        player.RankInClubTopScorer = int.Parse(reader["rank_in_club_top_scorer"].ToString());
                        player.RankInLeagueTopAttackers = int.Parse(reader["rank_in_league_top_attackers"].ToString());
                        player.RankInLeagueTopDefenders = int.Parse(reader["rank_in_league_top_defenders"].ToString());
                        player.RankInLeagueTopMidfielders = int.Parse(reader["rank_in_league_top_midfielders"].ToString());

                        players.Add(player);
                    }
                }
                sqlCommand.Dispose();
            }
            return players;
        }
    }
}