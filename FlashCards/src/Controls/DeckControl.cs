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
        public DeckControl(int deckId)
        {
            InitializeComponent();
            _deckId = deckId;
        }
    }
}
