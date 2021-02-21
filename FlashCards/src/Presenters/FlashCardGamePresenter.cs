using Prism.Events;
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
    public class FlashCardGamePresenter<TView> : IPresenter<TView> where TView : IFlashCardGameView
    {
        private readonly IDeckService _deckService;
        private Card _currentCard;
        private Deck _deck;

        public TView View { get; set; }

        public FlashCardGamePresenter(IDeckService deckService)
        {
            _deckService = deckService;
        }
        public void InitialSetup()
        {
            View.NextCardClicked += View_NextCardClicked;
            View.PlayAgainButtonClicked += View_PlayAgainButtonClicked;
            BeginGame();
        }

        public void View_PlayAgainButtonClicked(object sender, EventArgs e)
        {
            BeginGame();
        }

        public void View_NextCardClicked(object sender, EventArgs e)
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

        public void BeginGame()
        {
            View.BtnPlayAgainIsVisible = false;
            View.LabelGameFinishedIsVisible = false;
            View.CurrentCardIndex = 0;
            _deck = _deckService.ShuffleDeck(_deckService.GetDeck(View.DeckId));
            SetCurrentCard();
            SetQuestion(_currentCard.Question);
        }

        public void SetAnswer(string answer)
        {
            View.Answer = answer;
            View.Question = "";
            View.IsAnswerShowing = true;
        }

        public void SetQuestion(string question)
        {
            View.Question = question;
            View.Answer = "";
            View.IsAnswerShowing = false;
        }

        public void GetNextCard()
        {
            if (!IsGameComplete())
            {
                View.CurrentCardIndex += 1;
            }
            else
            {
                GameCompleted();
            }
        }

        public void SetCurrentCard()
        {
            _currentCard = _deck.Cards.ElementAt(View.CurrentCardIndex);
        }

        public bool IsGameComplete()
        {
            if (View.CurrentCardIndex == _deck.Cards.Count)
            {
                return true;
            }
            return false;
        }

        public void GameCompleted()
        {
            View.BtnPlayAgainIsVisible = true;
            View.LabelGameFinishedIsVisible = true;
        }
    }
}
