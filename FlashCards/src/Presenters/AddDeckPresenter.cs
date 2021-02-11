using src.Services;
using src.Views;
using System;
using System.Collections.Generic;
using System.Text;
using src.Models;

namespace src.Presenters
{
    /// <summary>
    ///     Provides values to and executes commands from the AddDeck view.
    /// </summary>
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
            var snd = sender as IAddDeckView;
            try
            {
                _deckService.AddNewDeck(snd.Name);
                // TODO : Add "deckadded" message event to event aggregator.
                _addDeckView.Name = "";
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                throw ex;
            }
        }
    }
}
