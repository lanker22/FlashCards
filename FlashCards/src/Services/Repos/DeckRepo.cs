using src.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using System.Text;

namespace src.Services.Repos
{
    /// <summary>
    ///     Provides database connection and returns data to Deck Service layer.
    /// </summary>
    public class DeckRepo
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["FlashCardsDatabase"].ConnectionString;

        // TODO: CONFIGURE DI FOR THIS
        private readonly RepoHelper _helper;

        public DeckRepo()
        {
            _helper = new RepoHelper();
        }

        /// <returns>A List of all the current decks of cards in the database</returns>
        public List<Deck> GetAllDecksFromDatabase()
        {
            var queryString = "SELECT * " +
                              "FROM decks " +
                              "INNER JOIN cards " +
                              "ON decks.DeckID = cards.DeckID";

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand(queryString, connection))
                {
                    var reader = command.ExecuteReader();
                    var decks = _helper.GenerateListOfAllDecksFromReader(reader);
                    reader.Close();
                    return decks;
                }
            }
        }
    
        /// <param name="deckId">Primary key of the deck to search for in database</param>
        /// <returns>Returns a single deck</returns>
        public Deck GetDeck(int deckId)
        {
            var queryString = "SELECT * FROM decks " +
                              "INNER JOIN cards " +
                              "ON decks.DeckID = cards.DeckID " +
                              "WHERE decks.DeckID = @deckId";

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand(queryString, connection))
                {
                    command.Parameters.AddWithValue("@deckId", deckId);
                    var reader = command.ExecuteReader();
                    var deck = _helper.GeneratePopulatedDeckFromReader(reader);
                    reader.Close();
                    return deck;
                }
            }
        }

        /// <summary>
        ///     INSERT a new deck with the specified name into the database
        /// </summary>
        /// <param name="name">Name of the new deck to be added</param>
        public void AddNewDeckToDatabase(string name)
        {
            var queryString = "INSERT INTO decks (Name)" +
                              "VALUES (@deckName)";

            using(var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand(queryString, connection))
                {
                    command.Parameters.AddWithValue("@deckName", name);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
