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

        public FlashCardGamePresenter(IFlashCardGameView flashCardGameView,
                                      IDeckService deckService,
                                      ICardService cardService)
        {
            _flashCardGameView = flashCardGameView;
            _deckService = deckService;
            _cardService = cardService;
        }
    }
}
