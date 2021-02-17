using Prism.Events;
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
    public class HomePagePresenter<TView> : IPresenter<TView> where TView : HomePageView
    {
        private readonly IDeckService _deckService;
        public TView View { get; set; }
        public HomePagePresenter(IDeckService deckService)
        {
            _deckService = deckService;
            View.Load += _homePageView_Load;
            PopulateDecks();
            View.WireUpView();
        }

        public void _homePageView_Load(object sender, EventArgs e)
        {
            PopulateDecks();
            View.WireUpView();
        }

        public void _homePageView_DeckDeleted(object sender, EventArgs e)
        {
            var snd = sender as Deck;
            _deckService.RemoveDeck(snd.Id);
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
