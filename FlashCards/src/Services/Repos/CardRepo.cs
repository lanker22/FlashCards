using src.Factories;
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
        private readonly IDbFactory _dbFactory;
        private readonly IRepoHelper _helper;

        public CardRepo(IRepoHelper helper, IDbFactory dbFactory)
        {
            _helper = helper;
            _dbFactory = dbFactory;
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

            using (var connection = _dbFactory.CreateConnection())
            {
                connection.Open();
                foreach (var card in cards)
                {
                    using (var command = _dbFactory.CreateCommand(queryString, connection))
                    {
                        {
                            _helper.AddParameterToCommand("@question", card.Question, command);
                            _helper.AddParameterToCommand("@answer", card.Answer, command);
                            _helper.AddParameterToCommand("@deckId", deckId, command);

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

            using(var connection = _dbFactory.CreateConnection())
            {
                connection.Open();
                using (var command = _dbFactory.CreateCommand(queryString, connection))
                {
                    _helper.AddParameterToCommand("@question", card.Question, command);
                    _helper.AddParameterToCommand("@answer", card.Answer, command);
                    _helper.AddParameterToCommand("@deckId", deckId, command);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
