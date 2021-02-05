using src.Models;
using System.Collections.Generic;

namespace src.Services
{
    public interface ICardService
    {
        void AddNewCards(List<Card> cards, int deckId);
    }
}