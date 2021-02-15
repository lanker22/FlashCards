using src.Controls;
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
        public List<Deck> Decks { get; set; } = new List<Deck>();
        public HomePageView()
        {
            InitializeComponent();
            WireUpDecks();
        }

        public void WireUpDecks()
        {
            foreach(var deck in Decks)
            {
                tlpListOfDecks.Controls.Add(new DeckControl(deck.Id));
            }
        }
    }
}
