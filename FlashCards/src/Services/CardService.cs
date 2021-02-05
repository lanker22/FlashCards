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
        private readonly ICardRepo _cardrepo;
        public CardService(ICardRepo cardRepo)
        {
            _cardrepo = cardRepo;
        }

        /// <summary>
        ///     Add the List of Cards to database.
        /// </summary>
        /// <param name="cards">List of cards to add</param>
        /// <param name="deckId">Deck to put the cards into</param>
        public void AddNewCards(List<Card> cards, int deckId)
        {
            try
            {
                _cardrepo.AddCardsToDatabase(cards, deckId);
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
