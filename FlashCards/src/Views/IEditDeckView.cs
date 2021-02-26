using System;
using System.Collections.Generic;
using System.Text;

namespace src.Views
{
    public interface IEditDeckView
    {
        public int DeckId { get; set; }
        
        public string DeckName { get; set; }

        public string NewQuestion { get; set; }

        public string NewAnswer { get; set; }

        event EventHandler CardAddedButtonClicked;

        event EventHandler UpdateDeckNameButtonClicked;

        event EventHandler Load;
        event EventHandler EditDeckViewClosedEvent;

        void Show();
    }
}
