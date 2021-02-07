using src.Models;
using src.Services;
using src.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace src.Presenters
{
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
        }

        public void WireUpview()
        {
            
        }

        public List<Deck> FetchDecks()
        {
            try
            {
                return _deckService.GetAllDecks();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
            }
        }
    }
}
