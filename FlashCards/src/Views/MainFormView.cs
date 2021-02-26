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
    public partial class MainFormView : Form, IMainFormView
    {
        public List<Deck> Decks { get; set; }

        private readonly IFormOpener _formOpener;
        public MainFormView(IFormOpener formOpener)
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
            AddAllDecksToPanel();
        }

        private bool IsAnotherRowNeeded()
        {
            var rows = tlpListOfDecks.RowCount;
            var cols = tlpListOfDecks.ColumnCount;
            var availableCells = rows * cols;
            return Decks.Count < availableCells;
        }

        private void AddNewRowToListOfDecks()
        {
            tlpListOfDecks.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tlpListOfDecks.RowCount++;
        }

        private void AddDeckToCell(int row, int col, DeckControl deck)
        {
            tlpListOfDecks.Controls.Add(deck, col, row);
        }

        public void RefreshDecksPanel()
        {
            tlpListOfDecks.Controls.Clear();
        }

        private void AddAllDecksToPanel()
        {
            var deckIndex = 0;
            for (int row = 0; row < tlpListOfDecks.RowCount && deckIndex < Decks.Count; row++)
            {
                for (int col = 0; col < tlpListOfDecks.ColumnCount && deckIndex < Decks.Count; col++)
                {
                    AddSingleDeckToPanel(deckIndex, row, col);
                    deckIndex += 1;
                }
            }
        }

        private void AddSingleDeckToPanel(int deckIndex, int row, int col)
        {
            var deckId = Decks[deckIndex].Id;
            var numOfCards = Decks[deckIndex].Cards.Count;
            var deckName = Decks[deckIndex].Name;
            var deckControlToAdd = new DeckControl(deckId, numOfCards, deckName);
            AddDeckToCell(row, col, deckControlToAdd);
            SubscribeToDeckControlEvents(deckControlToAdd);
        }

        private void HandlePlayGameButtonClickedEvent(object s, EventArgs e)
        {
            var snd = s as DeckControl;
            if(snd.NumOfCards == 0)
            {
                MessageBox.Show("Add card(s) to this Deck in order to play.");
            }
            else
            {
                InstantiateFlashCardView(snd);
            }
        }

        private void InstantiateFlashCardView(DeckControl deckControl)
        {
            var form = (FlashCardGameView)_formOpener.ShowModelessForm<FlashCardGameView>();
            form.DeckId = deckControl.DeckId;
            form.WireUpView();
        }

        private void SubscribeToDeckControlEvents(DeckControl deckControl)
        {
            deckControl.EditButtonClicked += (s, e) => HandleEditDeckButtonClickedEvent(s, e);

            deckControl.DeleteButtonClicked += (s, e) => DeleteDeckClicked?.Invoke(s as DeckControl, EventArgs.Empty);

            deckControl.PlayGameButtonClicked += (s, e) => HandlePlayGameButtonClickedEvent(s, e);
        }

        private void HandleEditDeckButtonClickedEvent(object s, EventArgs e)
        {
            var snd = s as DeckControl;
            var form = (EditDeckView)_formOpener.ShowModelessForm<EditDeckView>();
            form.DeckId = snd.DeckId;
            form.InitiatePresenter();
        }
    }
}
