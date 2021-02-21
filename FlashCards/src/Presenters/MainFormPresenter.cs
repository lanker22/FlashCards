using Prism.Events;
using src.Controls;
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
        public TView View { get; set; }
        public int DeckId { get; set; }

        public MainFormPresenter(IDeckService deckService)
        {
            _deckService = deckService;
        }

        public void InitialSetup()
        {
            View.Load += _homePageView_Load;
            View.DeleteDeckClicked += _homePageView_DeckDeleted;
        }

        public void _homePageView_Load(object sender, EventArgs e)
        {
            PopulateDecks();
            View.WireUpView();
        }

        public void _homePageView_DeckDeleted(object sender, EventArgs e)
        {
            var snd = sender as DeckControl;
            _deckService.RemoveDeck(snd.DeckId);
            PopulateDecks();
            View.WireUpView();
        }

        public void PopulateDecks()
        {
            var decks = _deckService.GetAllDecks();
            View.Decks = decks;
        }
    }
}
