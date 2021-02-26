using Prism.Events;
using src.Events;
using src.Models;
using src.Services;
using src.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace src.Presenters
{
    /// <summary>
    ///     Provides values to and executes commands from the EditDeck view.
    /// </summary>
    public class EditDeckPresenter<TView> : IPresenter<TView> where TView : IEditDeckView
    {
        private readonly ICardService _cardService;
        private readonly IDeckService _deckService;
        private IEventAggregator _eventAggregator;

        public TView View { get; set; }

        public EditDeckPresenter(ICardService cardService, IEventAggregator eventAggregator, IDeckService deckService)
        {
            _cardService = cardService;
            _eventAggregator = eventAggregator;
            _deckService = deckService;
        }

        private void View_NewCardAdded(object sender, EventArgs e)
        {
            if (QuestionOrAnswerFieldBlank())
            {
                ShowBlankFieldMessageToUser();
            }
            else
            {
                AddCardToDeck();
                ResetViewValues();
                ShowCardAddedMessageToUser();
            }
        }

        private static void ShowCardAddedMessageToUser()
        {
            MessageBox.Show("Card added to deck");
        }

        private bool QuestionOrAnswerFieldBlank()
        {
            return View.NewAnswer == "" || View.NewQuestion == "";
        }

        private static void ShowBlankFieldMessageToUser()
        {
            MessageBox.Show("Question and answer field must both be populated");
        }

        private void ResetViewValues()
        {
            View.NewQuestion = "";
            View.NewAnswer = "";
        }

        private void AddCardToDeck()
        {
            var cardToAdd = new Card
            {
                Answer = View.NewAnswer,
                Question = View.NewQuestion
            };
            _cardService.AddSingleCardToDeck(cardToAdd, View.DeckId);
        }

        public void InitialSetup()
        {
            View.CardAddedButtonClicked += View_NewCardAdded;
            View.EditDeckViewClosedEvent += View_EditDeckViewClosedEvent;
            View.UpdateDeckNameButtonClicked += View_UpdateDeckNameButtonClicked;
            View.DeckName = _deckService.GetDeckName(View.DeckId);
            View.NewAnswer = "";
            View.NewQuestion = "";
        }

        private void View_UpdateDeckNameButtonClicked(object sender, EventArgs e)
        {
            if(View.DeckName == "")
            {
                MessageBox.Show("Deck name cannot be blank.");
            }
            else
            {
                _deckService.UpdateDeckName(View.DeckId, View.DeckName);
                ShowDeckUpdatedMessageToUser();
            }
        }

        private static void ShowDeckUpdatedMessageToUser()
        {
            MessageBox.Show("Deck name updated");
        }

        private void View_EditDeckViewClosedEvent(object sender, EventArgs e)
        {
            _eventAggregator.GetEvent<EditDeckFormClosedEvent>().Publish("Edit deck view closed.");
        }
    }
}
