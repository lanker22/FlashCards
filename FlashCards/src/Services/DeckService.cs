using src.Models;
using src.Services.Repos;
using System;
using System.Collections.Generic;
using System.Text;

namespace src.Services
{
    /// <summary>
    ///     Fulfills requests from Presenter layer for Deck data.
    /// </summary>
    public class DeckService : IDeckService
    {
        private readonly IDeckRepo _deckRepo;

        public DeckService(IDeckRepo deckRepo)
        {
            _deckRepo = deckRepo;
        }

        /// <summary>
        ///     Retrieve all the current decks.
        /// </summary>
        /// <returns>A List<Deck></returns>
        public List<Deck> GetAllDecks()
        {
            try
            {
                return _deckRepo.GetAllDecksFromDatabase();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                throw ex;
            }
        }

        /// <summary>
        ///     Retrieve a single deck.
        /// </summary>
        /// <param name="deckId">Primary key of the deck to retrieve</param>
        /// <returns>A single deck</returns>
        public Deck GetDeck(int deckId)
        {
            try
            {
                return _deckRepo.GetDeck(deckId);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                throw ex;
            }
        }

        /// <summary>
        ///     Add a new deck to the database.
        /// </summary>
        /// <param name="name">The name of the new deck to add.</param>
        public void AddNewDeck(string name)
        {
            try
            {
                _deckRepo.AddNewDeckToDatabase(name);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                throw ex;
            }
        }

    }
}
