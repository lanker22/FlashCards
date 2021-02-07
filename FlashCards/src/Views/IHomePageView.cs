using src.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace src.Views
{
    public interface IHomePageView
    {
        IEnumerable<IDeckView> Decks { get; set; } 
        
        event EventHandler AddDeckClicked;
        
        void Show();
    }
}
