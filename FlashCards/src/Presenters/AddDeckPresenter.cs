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
        private readonly IEventAggregator _eventAggregator;
        public AddDeckPresenter(IAddDeckView addDeckView,
                                IDeckService deckService,
                                IEventAggregator eventAggregator)
        {
            _addDeckView = addDeckView;
            _deckService = deckService;
            _eventAggregator = eventAggregator;
        }

        private void _addDeckView_DeckAddedClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
