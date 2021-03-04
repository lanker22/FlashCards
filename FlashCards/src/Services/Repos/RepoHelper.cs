using src.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Text;

#nullable enable    

namespace src.Services.Repos
{
    /// <summary>
    ///     Provides some helper functions to assist the repository.
    /// </summary>
    public class RepoHelper : IRepoHelper
    {
        /// <summary>
        ///     Generate a List of all current Decks within the database.
        /// </summary>
        /// <param name="reader">IDataReader containing all database data.</param>
        /// <returns>A List of all current Decks in the database. If no Decks are in the database, List will be empty.</returns>
        public List<Deck> GenerateListOfAllDecksFromReader(IDataReader reader)
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
        public Deck GeneratePopulatedDeckFromReader(IDataReader reader)
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
        /// <summary>
        ///     Add a single Parameter to a given IDbCommand.
        /// </summary>
        /// <typeparam name="T">Type of the data to be added.</typeparam>
        /// <param name="paramName">Name to be given to our Parameter.</param>
        /// <param name="value">Value to be given to our Parameter (of type T).</param>
        /// <param name="command">IDbCommand to add our newly created Parameter to.</param>
        public void AddParameterToCommand<T>(string paramName, T value, IDbCommand command)
        {
            var parameter = command.CreateParameter();
            parameter.ParameterName = paramName;
            parameter.Value = value;
            command.Parameters.Add(parameter);
        }

        /// <summary>
        ///     Add a single Card to the current Deck being looked at IF the Deck contains any Cards.
        /// </summary>
        /// <param name="deck">Deck to add the particular Card to</param>
        /// <param name="reader">SqlDataReader containing information about the current Deck.</param>
        private void TryAddCardToDeck(Deck deck, IDataReader reader)
        {
            if (DeckContainsCards(reader))
            {
                deck.Cards.Add(GenerateCardFromReader(reader));
            }
        }

        /// <summary>
        ///     Get "Question" string of Card in the current deck.
        /// </summary>
        /// <param name="reader">SqlDataReader containing relevant information.</param>
        /// <returns>The value in "Question" column, or null if no data was found.</returns>
        private string? GetCardQuestionFromReader(IDataReader reader)
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

        /// <summary>
        ///     Get "Answer" string of Card in the current deck.
        /// </summary>
        /// <param name="reader">SqlDataReader containing relevant information.</param>
        /// <returns>The value in "Answer" column, or null if no data was found.</returns>
        private string? GetCardAnswerFromReader(IDataReader reader)
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
        private Card? GenerateCardFromReader(IDataReader reader)
        {
            return new Card
            {
                Question = GetCardQuestionFromReader(reader),
                Answer = GetCardAnswerFromReader(reader)
            };
        }

        /// <summary>
        ///     Get value in "Name" column, given a single row of data. 
        /// </summary>
        /// <param name="reader">SqlDataReader object representing one row of data in the database.</param>
        /// <returns>The value in "Name" column, or an empty string if no value is found.</returns>
        public string GetDeckNameFromReader(IDataReader reader)
        {
            var name = "";
            while (reader.Read())
            {
                name = reader.GetString(reader.GetOrdinal("Name"));
            }
            return name;
        }

        /// <summary>
        ///     Calls <see cref="GetCardAnswerFromReader(IDataReader)"/> and <see cref="GetCardQuestionFromReader(IDataReader)"/> 
        ///     to determine whether the given Deck has any cards in it.
        /// </summary>
        /// <param name="reader">SqlDataReader containing the database information.</param>
        /// <returns>True if the Deck has cards in it, False if not.</returns>
        private bool DeckContainsCards(IDataReader reader)
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
        private Deck GenerateEmptyDeckFromReader(IDataReader reader)
        {
            Debug.WriteLine(reader.FieldCount);
            return new Deck
            {
                Cards = new List<Card>(),
                Name = reader.GetString(reader.GetOrdinal("Name")),
                Id = reader.GetInt32(reader.GetOrdinal("DeckId"))
            };
        }
    }
}
