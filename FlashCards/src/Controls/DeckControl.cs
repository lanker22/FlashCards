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
        private readonly int _deckId;
        private readonly int _numOfCards;
        public DeckControl(int deckId, int numOfCards)
        {
            _deckId = deckId;
            _numOfCards = numOfCards;
            InitializeComponent();
        }
    }
}
