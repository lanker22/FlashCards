using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace src.Views
{
    public interface IAddDeckView
    {
        string NewDeckName { get; set; }

        event EventHandler DeckAddedClicked;

        event EventHandler Load;
        void Show();

        event EventHandler AddDeckViewClosedEvent;
    }
}
