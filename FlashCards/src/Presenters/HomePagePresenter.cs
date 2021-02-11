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
    class HomePagePresenter
    {
        private IHomePageView _homePageView;
        private readonly IDeckService _deckService;
        private IEventAggregator _eventAggregator;
        
        public HomePagePresenter(IHomePageView homePageView,
                                 IDeckService deckService,
                                 IEventAggregator eventAggregator)
        {
            _homePageView = homePageView;
            _deckService = deckService;
            _eventAggregator = eventAggregator;
            _homePageView.HomePageViewLoaded += _homePageView_HomePageViewLoaded;
            _homePageView.DeckDeleted += _homePageView_DeckDeleted;
            WireUpView();
        }

        private void _homePageView_DeckDeleted(object sender, EventArgs e)
        {
            try
            {
                _deckService.RemoveDeck()
            }
        }

        private void Decks_ListChanged(object sender, System.ComponentModel.ListChangedEventArgs e)
        {
            _homePageView.WireUpDecks
        }

        private void _homePageView_HomePageViewLoaded(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public void WireUpView()
        {
            try
            {
                var decks = _deckService.GetAllDecks();
                _homePageView.Decks = decks;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }
    }
}
