using src.Models;
using System.Collections.Generic;

namespace src.Services
{
    public interface IDeckService
    {
        void AddNewDeck(string name);
        List<Deck> GetAllDecks();
        Deck GetDeck(int deckId);
        void RemoveDeck(int deckId);
        Deck ShuffleDeck(Deck deck);
    }
}