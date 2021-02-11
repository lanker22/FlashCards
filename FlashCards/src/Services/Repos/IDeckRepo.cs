using src.Models;
using System.Collections.Generic;

namespace src.Services.Repos
{
    public interface IDeckRepo
    {
        void AddNewDeckToDatabase(string name);
        void DeleteDeckFromDatabase(int deckId);
        List<Models.Deck> GetAllDecksFromDatabase();
        Models.Deck GetDeck(int deckId);
    }
}