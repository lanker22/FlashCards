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
        void RefreshDecksPanel();

        event EventHandler Load;
        event EventHandler DeleteDeckClicked;
    }
}
