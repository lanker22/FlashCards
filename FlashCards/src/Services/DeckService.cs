using src.Models;
using src.Services.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
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
            return _deckRepo.GetAllDecksFromDatabase();
        }

        /// <summary>
        ///     Retrieve a single deck.
        /// </summary>
        /// <param name="deckId">Primary key of the deck to retrieve</param>
        /// <returns>A single deck</returns>
        public Deck GetDeck(int deckId)
        {
            return _deckRepo.GetDeck(deckId);
        }

        /// <summary>
        ///     Add a new deck to the database.
        /// </summary>
        /// <param name="name">The name of the new deck to add.</param>
        public void AddNewDeck(string name)
        {
            _deckRepo.AddNewDeckToDatabase(name);
        }

        /// <summary>
        ///     Remove a single deck from the database.
        /// </summary>
        /// <param name="deckId">Primary key of the deck to remove</param>
        public void RemoveDeck(int deckId)
        {
            _deckRepo.DeleteDeckFromDatabase(deckId);
        }

        /// <summary>
        ///     Randomize the order of the cards in a given Deck.
        /// </summary>
        /// <param name="deck">The Deck to shuffle</param>
        /// <returns>A shuffled Deck</returns>
        public Deck ShuffleDeck(Deck deck)
        {
            var rnd = new Random();
            deck.Cards = deck.Cards.OrderBy(x => rnd.Next()).ToList();
            return deck;
        }

        public void UpdateDeckName(int deckId, string newDeckName)
        {
            _deckRepo.ChangeDeckName(deckId, newDeckName);
        }

        public string GetDeckName(int deckId)
        {
            return _deckRepo.GetDeckNameFromDatabase(deckId);
        }
    }
}
