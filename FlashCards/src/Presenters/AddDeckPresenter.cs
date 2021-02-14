using src.Services;
using src.Views;
using System;
using System.Collections.Generic;
using System.Text;
using src.Models;
using Prism.Events;

namespace src.Presenters
{
    /// <summary>
    ///     Provides values to and executes commands from the AddDeck view.
    /// </summary>
    class AddDeckPresenter
    {
        private IAddDeckView _addDeckView;
        private readonly IDeckService _deckService;
        public AddDeckPresenter(IAddDeckView addDeckView,
                                IDeckService deckService)
        {
            _addDeckView = addDeckView;
            _deckService = deckService;
        }

        private void _addDeckView_DeckAddedClicked(object sender, EventArgs e)
        {
            var snd = sender as IAddDeckView;
            _deckService.AddNewDeck(snd.Name);
            // TODO : Add "deckadded" message event to event aggregator.
            ResetViewValues();
        }

        private void ResetViewValues()
        {
            _addDeckView.Name = "";
        }
    }
}
