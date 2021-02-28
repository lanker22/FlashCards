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
        public int NumOfCards
        {
            get { return Convert.ToInt32(labelNumOfCardsInDeck.Text); }
            set { labelNumOfCardsInDeck.Text = value.ToString(); }
        }
        public string DeckName
        {
            get { return labelDeckName.Text; }
            set { labelDeckName.Text = value; }
        }

        public event EventHandler DeleteButtonClicked;
        public event EventHandler EditButtonClicked;
        public event EventHandler PlayGameButtonClicked;

        public DeckControl()
        {
            InitializeComponent();
            btnDeleteDeck.Click += BtnDeleteDeck_Click;
            btnPlayGame.Click += BtnPlayGame_Click;
            btnEditDeck.Click += BtnEditDeck_Click;
        }

        private void BtnDeleteDeck_Click(object sender, EventArgs e)
        {
            DeleteButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void BtnPlayGame_Click(object sender, EventArgs e)
        {
            PlayGameButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void BtnEditDeck_Click(object sender, EventArgs e)
        {
            EditButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void panelMainLayout_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
