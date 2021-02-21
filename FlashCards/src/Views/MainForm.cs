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
    public partial class MainForm : Form, IMainFormView
    {
        public List<Deck> Decks { get; set; }

        private readonly IFormOpener _formOpener;
        public MainForm(IFormOpener formOpener)
        {
            _formOpener = formOpener;
            InitializeComponent();
            var presenter = PresenterFactory.CreateForView(this);
            presenter.InitialSetup();
        }

        public event EventHandler DeleteDeckClicked;

        public void WireUpView()
        {
            while (!IsAnotherRowNeeded())
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
            for (int row = 0; row < tlpListOfDecks.RowCount && deckIndex < Decks.Count; row++)
            {
                for (int col = 0; col < tlpListOfDecks.ColumnCount && deckIndex < Decks.Count; col++)
                {
                    var deckId = Decks[deckIndex].Id;
                    var numOfCards = Decks[deckIndex].Cards.Count;
                    var deckName = Decks[deckIndex].Name;
                    var deckControlToAdd = new DeckControl(deckId, numOfCards, deckName);
                    AddDeckToCell(row, col, deckControlToAdd);
                    SubscribeToDeckControlEvents(deckControlToAdd);
                    deckIndex += 1;
                }
            }
        }

        public void SubscribeToDeckControlEvents(DeckControl deckControl)
        {
            //deckControl.EditButtonClicked += (s, e) => EditDeckClicked?.Invoke(s as DeckControl, EventArgs.Empty);

            deckControl.DeleteButtonClicked += (s, e) => DeleteDeckClicked?.Invoke(s as DeckControl, EventArgs.Empty);

            deckControl.PlayGameButtonClicked += (s, e) =>
            {
                var snd = s as DeckControl;
                var form = (FlashCardGameView)_formOpener.ShowModelessForm<FlashCardGameView>();
                form.DeckId = snd.DeckId;
            };
        }
    }
}
