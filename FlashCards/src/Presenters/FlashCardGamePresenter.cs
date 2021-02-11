using src.Events;
using src.Models;
using src.Services;
using src.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace src.Presenters
{
    /// <summary>
    ///     Provides values to and executes commands from the FlashCardGame View.
    /// </summary>
    public class FlashCardGamePresenter
    {
        private IFlashCardGameView _flashCardGameView;
        private readonly IDeckService _deckService;
        private readonly ICardService _cardService;
        private IEventAggregator _eventAggregator;
        private IGameCompletedView _gameCompletedView;
        private Card _currentCard;
        private Deck _deck;

        public FlashCardGamePresenter(IFlashCardGameView flashCardGameView,
                                      IDeckService deckService,
                                      ICardService cardService,
                                      IEventAggregator eventAggregator,
                                      IGameCompletedView gameCompletedView)
        {
            _flashCardGameView = flashCardGameView;
            _deckService = deckService;
            _cardService = cardService;
            _eventAggregator = eventAggregator;
            _gameCompletedView = gameCompletedView;
            _flashCardGameView.NextCardClicked += _flashCardGameView_NextCardClicked;
            _eventAggregator.Publish(new NotPlayingAgain());
            _gameCompletedView.PlayingAgain += _gameCompletedView_PlayingAgain;
            WireUpView();
        }

        private void _gameCompletedView_PlayingAgain(object sender, EventArgs e)
        {
            WireUpView();
        }

        private void IfNotPlayingAgain()
        {
            _flashCardGameView.Hide();
        }

        private void WireUpView()
        {
            _flashCardGameView.CurrentCardIndex = 0;
            _deck = _deckService.ShuffleDeck(_deckService.GetDeck(_flashCardGameView.DeckId));
            SetCurrentCard();
            SetQuestion(_currentCard.Question);
        }

        private void _flashCardGameView_NextCardClicked(object sender, EventArgs e)
        {
            var snd = sender as IFlashCardGameView;
            if (snd.IsAnswerShowing)
            {
                GetNextCard();
                SetCurrentCard();
                SetQuestion(_currentCard.Question);
            }
            else
            {
                SetAnswer(_currentCard.Answer);
            }
        }

        public void SetAnswer(string answer)
        {
            _flashCardGameView.Answer = answer;
            _flashCardGameView.Question = "";
            _flashCardGameView.IsAnswerShowing = true;
        }

        public void SetQuestion(string question)
        {
            _flashCardGameView.Question = question;
            _flashCardGameView.Answer = "";
            _flashCardGameView.IsAnswerShowing = false;
        }

        public void GetNextCard()
        {
            if (!IsGameComplete())
            {
                _flashCardGameView.CurrentCardIndex += 1;
            }
            else
            {

            }
        }

        public void SetCurrentCard()
        {
            _currentCard = _deck.Cards.ElementAt(_flashCardGameView.CurrentCardIndex);
        }

        public bool IsGameComplete()
        {
            if(_flashCardGameView.CurrentCardIndex == _deck.Cards.Count)
            {
                return true;
            }
            return false;
        }
    }
}
