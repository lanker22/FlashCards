using src.Models;
using System.Collections.Generic;

namespace src.Services.Repos
{
    public interface ICardRepo
    {
        void AddCardsToDatabase(List<Card> cards, int deckId);

        void AddSingleCardToDatabase(Card card, int deckId);
    }
}