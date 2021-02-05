using System;
using System.Collections.Generic;
using System.Text;

namespace src.Views
{
    public interface IDeckView
    {
        string Name { get; set; }
        
        int NumberOfCards { get; set; }

        event EventHandler DeckClicked;

        event EventHandler DeleteDeckClicked;

        void Show();
    }
}
