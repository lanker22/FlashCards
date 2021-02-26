using src.Models;
using src.Services.Repos;
using System;
using System.Collections.Generic;
using System.Text;

namespace src.Services
{
    /// <summary>
    ///     Fulfills requests from Presenter layer for Card data.
    /// </summary>
    public class CardService : ICardService
    {
        private readonly ICardRepo _cardRepo;
        public CardService(ICardRepo cardRepo)
        {
            _cardRepo = cardRepo;
        }

        /// <summary>
        ///     Add the List of Cards to database.
        /// </summary>
        /// <param name="cards">List of cards to add</param>
        /// <param name="deckId">Deck to put the cards into</param>
        public void AddNewCards(List<Card> cards, int deckId)
        {
            _cardRepo.AddCardsToDatabase(cards, deckId);
        }

        /// <summary>
        ///     Add a single Card to the specified Deck.
        /// </summary>
        /// <param name="card">The Card to add to the Deck.</param>
        /// <param name="deckId">The Deck to add the Card to.</param>
        public void AddSingleCardToDeck(Card card, int deckId)
        {
            _cardRepo.AddSingleCardToDatabase(card, deckId);
        }
    }
}
