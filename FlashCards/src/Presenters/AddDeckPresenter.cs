using src.Services;
using src.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace src.Presenters
{
    class AddDeckPresenter
    {
        private IAddDeckView _addDeckView;
        private readonly IDeckService _deckService;
        public AddDeckPresenter(IAddDeckView addDeckView,
                                IDeckService deckService)
        {
            _addDeckView = addDeckView;
            _deckService = deckService;
            _addDeckView.DeckAddedClicked += _addDeckView_DeckAddedClicked;
        }

        private void _addDeckView_DeckAddedClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
