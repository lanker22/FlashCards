using src.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Text;

#nullable enable    

namespace src.Services.Repos
{
    /// <summary>
    ///     Provides some helper functions to assist the repository.
    /// </summary>
    public class RepoHelper : IRepoHelper
    {
        /// <param name="reader">A SqlCeDataReader instance</param>
        /// <returns>A list of all the current Decks within the reader</returns>
        public List<Deck> GenerateListOfAllDecksFromReader(SqlDataReader reader)
        {
            using (reader)
            {
                var decks = new List<Deck>();

                if (reader.Read())
                {

                    // create the first card to populate IF the query returned data
                    var currentDeck = GenerateEmptyDeckFromReader(reader);
                    TryAddCardToDeck(currentDeck, reader);

                    // Iterate through rows in reader
                    while (reader.Read())
                    {

                        // IF deck.Name of row is equal to currentDeck.Name, add Card to deck
                        if (currentDeck.Name == reader.GetString(reader.GetOrdinal("Name")))
                        {
                            TryAddCardToDeck(currentDeck, reader);
                        }

                        // ELSE add currentDeck to decks and create a new currentDeck with a new Name
                        else
                        {
                            decks.Add(currentDeck);
                            currentDeck = GenerateEmptyDeckFromReader(reader);
                            TryAddCardToDeck(currentDeck, reader);
                        }
                    }
                    decks.Add(currentDeck);
                }
                return decks;
            }
        }

        /// <summary>
        ///     Creates a new Deck from the current database reader row.
        /// </summary>
        /// <param name="reader">A SqlCeDataReader instance</param>
        /// <returns>A Deck object generated with data from reader</returns>
        public Deck GeneratePopulatedDeckFromReader(SqlDataReader reader)
        {
            using (reader)
            {
                var deck = new Deck
                {
                    Cards = new List<Card>(),
                };

                if (reader.Read())
                {
                    deck.Name = reader.GetString(reader.GetOrdinal("Name"));
                    deck.Id = reader.GetInt32(reader.GetOrdinal("DeckID"));
                    deck.Cards.Add(GenerateCardFromReader(reader));
                    while (reader.Read())
                    {
                        deck.Cards.Add(GenerateCardFromReader(reader));
                    }
                }
                reader.Close();
                return deck;
            }
        }

        private void TryAddCardToDeck(Deck deck, SqlDataReader reader)
        {
            if (DeckContainsCards(reader))
            {
                deck.Cards.Add(GenerateCardFromReader(reader));
            }
        }

        private string? GetCardQuestionFromReader(SqlDataReader reader)
        {
            try
            {
                return reader.GetString(reader.GetOrdinal("Question"));
            }
            catch (SqlNullValueException)
            {
                return null;
            }
        }

        private string? GetCardAnswerFromReader(SqlDataReader reader)
        {
            try
            {
                return reader.GetString(reader.GetOrdinal("Answer"));
            }
            catch(SqlNullValueException)
            {
                return null;
            }
        }

        /// <summary>
        ///     Creates a new Card object from the current database reader row.
        /// </summary>
        /// <param name="reader">The current database reader row</param>
        /// <returns>A single Card object</returns>
        private Card? GenerateCardFromReader(SqlDataReader reader)
        {
            return new Card
            {
                Question = GetCardQuestionFromReader(reader),
                Answer = GetCardAnswerFromReader(reader)
            };
        }

        public string GetDeckNameFromReader(SqlDataReader reader)
        {
            var name = "";
            while (reader.Read())
            {
                name = reader.GetString(reader.GetOrdinal("Name"));
            }
            return name;
        }

        private bool DeckContainsCards(SqlDataReader reader)
        {
            if(GetCardAnswerFromReader(reader) == null || GetCardQuestionFromReader(reader) == null)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        ///     Create a new Deck from the current database reader row.
        /// </summary>
        /// <param name="reader">The current database reader to populatea the new Deck with.</param>
        /// <returns>A single Card object</returns>
        private Deck GenerateEmptyDeckFromReader(SqlDataReader reader)
        {
            return new Deck
            {
                Cards = new List<Card>(),
                Id = reader.GetInt32(reader.GetOrdinal("DeckId")),
                Name = reader.GetString(reader.GetOrdinal("Name"))
            };
        }
    }
}
