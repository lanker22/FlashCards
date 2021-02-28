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
            btnExportDecks.Click += BtnExportDecks_Click;
            btnAddDeck.Click += BtnAddDeck_Click;
            var presenter = PresenterFactory.CreateForView(this);
            presenter.InitialSetup();
        }

        public event EventHandler DeleteDeckClicked;

        public void WireUpView()
        {
            while (AnotherRowNeeded())
            {
                AddNewRowToListOfDecks();
            }
            AddAllDecksToPanel();
        }

        private void BtnExportDecks_Click(object sender, EventArgs e)
        {
            InstantiateExportDecksView();
        }

        private void BtnAddDeck_Click(object sender, EventArgs e)
        {
            var form = (AddDeckView)_formOpener.ShowModelessForm<AddDeckView>();
            form.Show();
        }

        private bool AnotherRowNeeded()
        {
            var rows = tlpListOfDecks.RowCount;
            var cols = tlpListOfDecks.ColumnCount;
            var availableCells = rows * cols;
            return Decks.Count > availableCells;
        }

        private void AddNewRowToListOfDecks()
        {
            tlpListOfDecks.RowStyles.Add(new RowStyle(SizeType.Absolute, 275F));
            tlpListOfDecks.RowCount++;
        }

        private void AddDeckToCell(int row, int col, DeckControl deck)
        {
            tlpListOfDecks.Controls.Add(deck, col, row);
        }

        public void ClearDecksPanel()
        {
            tlpListOfDecks.Controls.Clear();
        }

        public void RemoveDeckControl(DeckControl deckControl)
        {
            tlpListOfDecks.Controls.Remove(deckControl);
            deckControl.Dispose();
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
            var deckControlToAdd = new DeckControl();
            SetDeckControlProperties(deckControlToAdd, deckId, deckName, numOfCards);
            AddDeckToCell(row, col, deckControlToAdd);
            SubscribeToDeckControlEvents(deckControlToAdd);
        }

        private void SetDeckControlProperties(DeckControl deckControlToAdd, int deckId, string deckName, int numOfCardsInDeck)
        {
            deckControlToAdd.DeckId = deckId;
            deckControlToAdd.DeckName = deckName;
            deckControlToAdd.NumOfCards = numOfCardsInDeck;
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

        private void InstantiateExportDecksView()
        {
            _formOpener.ShowModelessForm<ExportDecksView>();
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
