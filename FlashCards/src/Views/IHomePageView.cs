using src.Controls;
using src.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace src.Views
{
    public interface IHomePageView
    {
        List<Deck> Decks { get; set; } 

        void AddDecksToPanel();
        bool IsAnotherRowNeeded();
        void WireUpView();
        void AddDeckToCell(int row, int col, DeckControl deck);
        void AddNewRowToListOfDecks();

        event EventHandler Load;
    }
}
