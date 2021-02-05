using src.Services;
using src.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace src.Presenters
{
    public class DeckPresenter
    {
        private IDeckView _deckView;
        private readonly IDeckService _deckService;
        
        public DeckPresenter(IDeckView deckView, 
                             IDeckService deckService)
        {
            _deckView = deckView;
            _deckService = deckService;
            _deckView.DeckClicked += _deckView_DeckClicked;
            _deckView.DeleteDeckClicked += _deckView_DeleteDeckClicked;
        }

        private void _deckView_DeleteDeckClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void _deckView_DeckClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
