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

        /// <summary>
        ///     Subscribes to the "deck added" event. Adds a new deck to
        ///     the database with the given name, and resets the View values so
        ///     that another Deck may be added afterwards. If no Deck Name is provided, 
        ///     display a message to the User prompting them to include a Name. 
        /// </summary>
        /// <param name="sender">The AddDeckView instnace which published the event.</param>
        /// <param name="e"></param>
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

        /// <summary>
        ///     Resets the "Name" field of the View an empty string.
        /// </summary>
        private void ResetViewValues()
        {
            View.NewDeckName = "";
        }

        /// <summary>
        ///     Register View events and ensure the Name field is empty, ready for User input. 
        /// </summary>
        public void InitialSetup()
        {
            View.DeckAddedClicked += View_DeckAddedClicked;
            View.AddDeckViewClosedEvent += View_OnClosing;
            ResetViewValues();
        }

        /// <summary>
        ///     Publishes an Event when the AddDeckView is closed.
        /// </summary>
        /// <param name="sender">AddDeckView which was closed to trigger the event.</param>
        /// <param name="e"></param>
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
