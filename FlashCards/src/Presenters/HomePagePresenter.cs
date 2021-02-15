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
    public class HomePagePresenter
    {
        private IHomePageView _homePageView;
        private readonly IDeckService _deckService;
        public HomePagePresenter(IHomePageView homePageView,
                                 IDeckService deckService)
        {
            _homePageView = homePageView;
            _deckService = deckService;
            _homePageView.Load += _homePageView_Load;
            WireUpView();
        }

        private void _homePageView_Load(object sender, EventArgs e)
        {
            WireUpView();   
        }

        private void _homePageView_DeckDeleted(object sender, EventArgs e)
        {
            var snd = sender as Deck;
            _deckService.RemoveDeck(snd.Id);
            WireUpView();
        }

        private void WireUpView()
        {
             var decks = _deckService.GetAllDecks();
            _homePageView.Decks = decks;
        }
    }
}
