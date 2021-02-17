using src.Controls;
using src.Models;
using src.Presenters;
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
        public List<Deck> Decks { get; set; }

        public HomePageView()
        {
            PresenterFactory.CreateForView(this);
            InitializeComponent();
        }

        public void WireUpView()
        {
            while(IsAnotherRowNeeded())
            {
                AddNewRowToListOfDecks();
            }
            AddDecksToPanel();
        }
        
        public bool IsAnotherRowNeeded()
        {
            var rows = tlpListOfDecks.RowCount;
            var cols = tlpListOfDecks.ColumnCount;
            var availableCells = rows * cols;
            return Decks.Count < availableCells;
        }

        public void AddNewRowToListOfDecks()
        {
            tlpListOfDecks.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tlpListOfDecks.RowCount++;
        }

        public void AddDeckToCell(int row, int col, DeckControl deck)
        {
            tlpListOfDecks.Controls.Add(deck, col, row);
        }

        public void AddDecksToPanel()
        {
            var deckIndex = 0;
            for(int row = 0; row < tlpListOfDecks.RowCount && deckIndex < Decks.Count; row++)
            {
                for(int col = 0; col < tlpListOfDecks.ColumnCount && deckIndex < Decks.Count; col++)
                {
                    var deckId = Decks[deckIndex].Id;
                    var numOfCards = Decks[deckIndex].Cards.Count;
                    var deckControlToAdd = new DeckControl(deckId, numOfCards);
                    AddDeckToCell(row, col, deckControlToAdd);
                }
            }
        }
    }
}
