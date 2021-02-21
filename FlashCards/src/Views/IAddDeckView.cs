using System;
using System.Collections.Generic;
using System.Text;

namespace src.Views
{
    public interface IAddDeckView
    {
        string Name { get; set; }

        event EventHandler DeckAddedClicked;

        event EventHandler Load;
        void Show();
    }
}
