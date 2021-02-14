using src.Models;
using src.Services;
using src.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace src.Presenters
{
    /// <summary>
    ///     Provides values to and executes commands from the EditDeck view.
    /// </summary>
    class EditDeckPresenter
    {
        private readonly ICardService _cardService;
        private IEditDeckView _editDeckView;

        public EditDeckPresenter(ICardService cardService,
                                 IEditDeckView editDeckView)
        {
            _cardService = cardService;
            _editDeckView = editDeckView;
            _editDeckView.NewCardAdded += _editDeckView_NewCardAdded;
        }

        private void _editDeckView_NewCardAdded(object sender, EventArgs e)
        {
            var snd = sender as IEditDeckView;
            AddCardToDeck(snd);
            ResetViewValues();
        }

        private void ResetViewValues()
        {
            _editDeckView.NewQuestion = "";
            _editDeckView.NewAnswer = "";
        }

        private void AddCardToDeck(IEditDeckView deckView)
        {
            var cardToAdd = new Card
            {
                Answer = deckView.NewAnswer,
                Question = deckView.NewQuestion
            };
            _cardService.AddSingleCardToDeck(cardToAdd, deckView.DeckId);
        }
    }
}
