using src.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace src.Views
{
    public interface IHomePageView
    {
        void SetDecks(IEnumerable<Deck> decks);
        
        event EventHandler AddDeckClicked;
        
        void Show();
    }
}
