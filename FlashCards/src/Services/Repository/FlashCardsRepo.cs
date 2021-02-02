using src.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlServerCe;
using System.Text;

namespace src.Services.Repository
{
    /// <summary>
    ///     Provides database connection and queries to service layer.
    /// </summary>
    public class FlashCardsRepo
    {
        private readonly string _connectionString = ConfigurationManager.AppSettings["connectionString"];
        
        /// <returns>A List of all the current decks of cards</returns>
        public List<Deck> GetAllDecks()
        {
            var decks = new List<Deck>();
            var queryString = "SELECT * FROM decks";
            using (var connection = new SqlCeConnection(_connectionString))
            {
                var command = new SqlCeCommand(queryString, connection);
                command.Connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {

                        // create the first card to populate IF the query returned data
                        var currentDeck = new Deck
                        {
                            Cards = new List<Card>(),
                            Id = reader.GetOrdinal("DeckId"),
                            Name = reader.GetString(reader.GetOrdinal("Name"))
                        };
                        
                        // TODO : INSERT COMMENTS TO CLARIFY METHOD
                        while (reader.Read())
                        {
                            if (currentDeck.Name == reader.GetString(reader.GetOrdinal("Name")))
                            {
                                currentDeck.Cards.Add(new Card
                                {
                                    Question = reader.GetString(reader.GetOrdinal("Question")),
                                    Answer = reader.GetString(reader.GetOrdinal("Answer"))
                                });
                            }
                            else
                            {
                                decks.Add(currentDeck);
                                currentDeck = new Deck
                                {
                                    Cards = new List<Card>(),
                                    Id = reader.GetOrdinal("DeckId"),
                                    Name = reader.GetString(reader.GetOrdinal("Name"))
                                };
                            }
                        }
                    }
                }
            }
            return decks;
        }
    
        public List<Card> GetCardsInDeck(int deckId)
        {
            var cards = new List<Card>();
            var queryString = "SELECT * FROM cards" +
                              "WHERE DeckId = @deckId";
            using (var connection = new SqlCeConnection(_connectionString))
            {
                var command = new SqlCeCommand(queryString, connection);

                // add deckId to query parameters
                var param = new SqlCeParameter
                {
                    ParameterName = "@deckId",
                    Value = deckId
                };
                command.Parameters.Add(param);
                
                command.Connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // create new card with "Question" and "Answer" from query row
                        // add card to "cards" return List
                        cards.Add(new Card
                        {
                            Question = reader.GetString(reader.GetOrdinal("Question")),
                            Answer = reader.GetString(reader.GetOrdinal("Answer"))
                        });
                    }
                }
            }
            return cards;
        }









    }
}
