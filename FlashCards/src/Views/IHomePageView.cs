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
        
        event EventHandler AddDeckClicked;

        event EventHandler HomePageViewLoaded;

        event EventHandler DeckDeleted;

        void WireUpDecks();
    }
}
