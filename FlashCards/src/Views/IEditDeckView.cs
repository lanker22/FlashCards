using System;
using System.Collections.Generic;
using System.Text;

namespace src.Views
{
    public interface IEditDeckView
    {
        public int DeckId { get; set; }
        
        public string Name { get; set; }

        public string NewQuestion { get; set; }

        public string NewAnswer { get; set; }

        event EventHandler NewCardAdded;
    }
}
