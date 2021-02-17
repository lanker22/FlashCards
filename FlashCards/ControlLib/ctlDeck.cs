using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlLib
{
    public partial class ctlDeck: UserControl
    {
        private readonly int _deckId;
        public ctlDeck(int deckId)
        {
            InitializeComponent();
            _deckId = deckId;
        }
    }
}
