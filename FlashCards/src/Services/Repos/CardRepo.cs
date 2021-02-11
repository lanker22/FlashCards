using src.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;

namespace src.Services.Repos
{
    /// <summary>
    ///     Provides database connection and returns data to Card Service layer.
    /// </summary>
    public class CardRepo : ICardRepo
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["FlashCardsDatabase"].ConnectionString;

        private readonly IRepoHelper _helper;

        public CardRepo(IRepoHelper helper)
        {
            _helper = helper;
        }

        /// <summary>
        ///     Insert a list of Cards into the database.
        /// </summary>
        /// <param name="cards">A list of Cards to iterate over and add to the database</param>
        /// <param name="deckId">The deckId to give each new Card</param>
        public void AddCardsToDatabase(List<Card> cards, int deckId)
        {
            var queryString = "INSERT INTO cards (Question, Answer, DeckId)" +
                              "VALUES (@question, @answer, @deckId)";

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                foreach (var card in cards)
                {
                    using (var command = new SqlCommand(queryString, connection))
                    {
                        {
                            command.Parameters.AddWithValue("@question", card.Question);
                            command.Parameters.AddWithValue("@answer", card.Answer);
                            command.Parameters.AddWithValue("@deckId", deckId);

                            command.ExecuteNonQuery();
                        }
                    }
                }
            }
        }

        /// <summary>
        ///     Add a single Card to the database.
        /// </summary>
        /// <param name="card">The Card object to add to the database.</param>
        /// <param name="deckId">The Deck primary key.</param>
        public void AddSingleCardToDatabase(Card card, int deckId)
        {
            var queryString = "INSERT INTO cards " +
                              "VALUES (@question, @answer, @deckId)";

            using(var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using(var command = new SqlCommand(queryString, connection))
                {
                    command.Parameters.AddWithValue("@question", card.Question);
                    command.Parameters.AddWithValue("@answer", card.Answer);
                    command.Parameters.AddWithValue("@deckId", deckId);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
