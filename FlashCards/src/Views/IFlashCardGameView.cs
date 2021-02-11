﻿using System;
using System.Collections.Generic;
using System.Text;

namespace src.Views
{
    public interface IFlashCardGameView
    {
        string Question { get; set; }

        string Answer { get; set; }

        int CurrentCardIndex { get; set; }

        int DeckId { get; set; }

        int CorrectAnswers { get; set; }

        int IncorrectAnswers { get; set; }

        bool IsAnswerShowing { get; set; }

        event EventHandler NextCardClicked;

        void Hide();
    }
}
