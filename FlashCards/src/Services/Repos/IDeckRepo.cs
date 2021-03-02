using src.Models;
using System.Collections.Generic;

namespace src.Services.Repos
{
    public interface IDeckRepo
    {
        void AddNewDeckToDatabase(string name);
        void DeleteDeckFromDatabase(int deckId);
        List<Deck> GetAllDecksFromDatabase();
        Deck GetDeck(int deckId);
        void ChangeDeckName(int deckId, string newDeckName);
        string GetDeckNameFromDatabase(int deckId);
    }
}