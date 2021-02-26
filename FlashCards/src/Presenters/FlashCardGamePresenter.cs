using Prism.Events;
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
    public class FlashCardGamePresenter<TView> : IPresenter<TView> where TView : IFlashCardGameView
    {
        private readonly IDeckService _deckService;
        private IEventAggregator _eventAggregator;
        private Card _currentCard;
        private Deck _deck;

        public TView View { get; set; }

        public FlashCardGamePresenter(IDeckService deckService, IEventAggregator eventAggregator)
        {
            _deckService = deckService;
            _eventAggregator = eventAggregator;
        }

        public void InitialSetup()
        {
            View.NextItemButtonClicked += View_NextItemButtonClicked;
            View.PlayAgainButtonClicked += View_PlayAgainButtonClicked;
            BeginGame();
        }

        private void View_PlayAgainButtonClicked(object sender, EventArgs e)
        {
            BeginGame();
        }

        private void View_NextItemButtonClicked(object sender, EventArgs e)
        {
            if (View.IsAnswerShowing && !IsGameComplete())
            {
                GetNextCard();
                SetDisplay(_currentCard.Question);
                SetNextItemButtonText("Reveal Answer");
                View.IsAnswerShowing = false;
            }
            else if (View.IsAnswerShowing && IsGameComplete())
            {
                GameCompleted();       
            }
            else 
            {
                SetDisplay(_currentCard.Answer);
                SetNextItemButtonText("Next Question");
                View.IsAnswerShowing = true;
            }
            UpdateProgress();
        }

        private void BeginGame()
        {
            View.BtnPlayAgainIsVisible = false;
            View.LabelGameFinishedIsVisible = false;
            View.CurrentCardIndex = 0;
            View.IsAnswerShowing = false;
            _deck = _deckService.ShuffleDeck(_deckService.GetDeck(View.DeckId));
            View.NumOfCards = _deck.Cards.Count;
            View.DeckName = _deck.Name;
            SetCurrentCard();
            SetDisplay(_currentCard.Question);
            SetNextItemButtonText("Reveal Answer");
            UpdateProgress();
            View.BtnNextItemIsVisible = true;
        }

        private void SetDisplay(string questionOrAnswer)
        {
            View.QuestionOrAnswerDisplay = questionOrAnswer;
        }

        private void GetNextCard()
        {
            View.CurrentCardIndex += 1;
            SetCurrentCard();
        }

        private void SetCurrentCard()
        {
            _currentCard = _deck.Cards.ElementAt(View.CurrentCardIndex);
        }

        private bool IsGameComplete()
        {
            if (View.CurrentCardIndex == _deck.Cards.Count-1)
            {
                return true;
            }
            return false;
        }

        private void GameCompleted()
        {
            View.BtnPlayAgainIsVisible = true;
            View.LabelGameFinishedIsVisible = true;
            View.BtnNextItemIsVisible = false;
            SetDisplay(" ");
        }

        private void SetNextItemButtonText(string text)
        {
            View.BtnNextItemText = text;
        }

        private void UpdateProgress()
        {
            View.LabelProgressText = $"{View.CurrentCardIndex + 1} / {View.NumOfCards}";
        }
    }
}
