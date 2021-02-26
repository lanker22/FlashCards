using src.Services;
using src.Views;
using System;
using System.Collections.Generic;
using System.Text;
using src.Models;
using Prism.Events;
using System.Windows.Forms;
using src.Events;

namespace src.Presenters
{
    /// <summary>
    ///     Provides values to and executes commands from the AddDeck view.
    /// </summary>
    public class AddDeckPresenter<TView> : IPresenter<TView> where TView : IAddDeckView
    {
        private readonly IDeckService _deckService;

        private IEventAggregator _eventAggregator;

        public TView View { get; set; }

        public AddDeckPresenter(IDeckService deckService,
                                IEventAggregator eventAggregator)
        {
            _deckService = deckService;
            _eventAggregator = eventAggregator;
        }

        private void View_DeckAddedClicked(object sender, EventArgs e)
        {
            if(View.NewDeckName == "")
            {
                DisplayEmptyDeckNameErrorMessage();
            }
            else
            {
                _deckService.AddNewDeck(View.NewDeckName);
                DisplayDeckAddedMessage();
                ResetViewValues();
            }
        }

        private void ResetViewValues()
        {
            View.NewDeckName = "";
        }

        public void InitialSetup()
        {
            View.DeckAddedClicked += View_DeckAddedClicked;
            View.AddDeckViewClosedEvent += View_OnClosing;
            View.NewDeckName = "";
        }

        private void View_OnClosing(object sender, EventArgs e)
        {
            _eventAggregator.GetEvent<AddDeckFormClosedEvent>().Publish("AddDeck form closed");
        }

        private void DisplayEmptyDeckNameErrorMessage()
        {
            MessageBox.Show("Deck name field cannot be blank. Please try again.");
        }

        private void DisplayDeckAddedMessage()
        {
            MessageBox.Show("Deck Added!");
        }
    }
}
