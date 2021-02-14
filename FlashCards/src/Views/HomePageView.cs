using src.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace src.Views
{
    public partial class HomePageView : Form, IHomePageView
    {
        public event EventHandler AddDeckClicked;
        public event EventHandler HomePageViewLoaded;
        public event EventHandler DeckDeleted;

        public List<Deck> Decks { get; set; } = new List<Deck>();
        public HomePageView()
        {
            InitializeComponent();
            HomePageViewLoaded(this, EventArgs.Empty);
        }

        public void WireUpDecks()
        {
            // TODO: setup all decks on homepage
        }

        private void tlpAllDecks_Paint(object sender, PaintEventArgs e)
        {

        }

        private void deckControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
