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
        
        public HomePagePresenter(IHomePageView homePageView,
                                 IDeckService deckService)
        {
            _homePageView = homePageView;
            _deckService = deckService;
        }
    }
}
