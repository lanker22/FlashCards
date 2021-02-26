using Prism.Events;
using src.Controls;
using src.Events;
using src.Models;
using src.Services;
using src.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace src.Presenters
{
    /// <summary>
    ///     Provies values to and executes commands from the HomePage view.
    /// </summary>
    public class MainFormPresenter<TView> : IPresenter<TView> where TView : IMainFormView
    {
        private readonly IDeckService _deckService;

        private IEventAggregator _eventAggregator;
        public TView View { get; set; }

        public MainFormPresenter(IDeckService deckService,
                                 IEventAggregator eventAggregator)
        {
            _deckService = deckService;
            _eventAggregator = eventAggregator;
        }

        public void InitialSetup()
        {
            View.Load += OnViewLoaded;
            View.DeleteDeckClicked += OnDeckDeleteButtonClicked;
            _eventAggregator.GetEvent<AddDeckFormClosedEvent>().Subscribe(OnAddDeckFormClosed);
            _eventAggregator.GetEvent<EditDeckFormClosedEvent>().Subscribe(OnEditDeckFormClosed);
        }

        private void OnEditDeckFormClosed(string message)
        {
            RefreshView();
        }

        private void OnViewLoaded(object sender, EventArgs e)
        {
            RefreshView();
        }

        private void OnDeckDeleteButtonClicked(object sender, EventArgs e)
        {
            var snd = sender as DeckControl;
            _deckService.RemoveDeck(snd.DeckId);
            RefreshView();
        }

        private void PopulateDecks()
        {
            var decks = _deckService.GetAllDecks();
            View.Decks = decks;
        }

        private void OnAddDeckFormClosed(string message)
        {
            RefreshView();
        }

        private void RefreshView()
        {
            PopulateDecks();
            View.RefreshDecksPanel();
            View.WireUpView();
        }
    }
}
