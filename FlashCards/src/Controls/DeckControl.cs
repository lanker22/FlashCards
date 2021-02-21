using Prism.Events;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace src.Controls
{
    public partial class DeckControl : UserControl
    {
        public int DeckId { get; set; }
        public int NumOfCards { get; set; }
        public string DeckName { get; set; }

        public event EventHandler DeleteButtonClicked;
        public event EventHandler EditButtonClicked;
        public event EventHandler PlayGameButtonClicked;

        public DeckControl(int deckId, int numOfCards, string deckName)
        {
            DeckId = deckId;
            NumOfCards = numOfCards;
            DeckName = deckName;
            InitializeComponent();
        }
    }
}
