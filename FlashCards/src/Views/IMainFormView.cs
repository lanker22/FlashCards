using src.Controls;
using src.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace src.Views
{
    public interface IMainFormView
    {
        List<Deck> Decks { get; set; } 

        void WireUpView();
        void RemoveDeckControl(DeckControl deckControl);
        void ClearDecksPanel();

        event EventHandler Load;
        event EventHandler DeleteDeckClicked;
    }
}
