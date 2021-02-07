using src.Services;
using src.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace src.Presenters
{
    public class FlashCardGamePresenter
    {
        private IFlashCardGameView _flashCardGameView;
        private readonly IDeckService _deckService;
        private readonly ICardService _cardService;
        private IEventAggregator _eventAggregator;

        public FlashCardGamePresenter(IFlashCardGameView flashCardGameView,
                                      IDeckService deckService,
                                      ICardService cardService,
                                      IEventAggregator eventAggregator)
        {
            _flashCardGameView = flashCardGameView;
            _deckService = deckService;
            _cardService = cardService;
            _eventAggregator = eventAggregator;
        }
    }
}
