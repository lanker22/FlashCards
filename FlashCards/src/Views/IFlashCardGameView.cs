using System;
using System.Collections.Generic;
using System.Text;

namespace src.Views
{
    public interface IFlashCardGameView
    {
        string QuestionOrAnswerDisplay { get; set; }

        int DeckId { get; set; }

        int CurrentCardIndex { get; set; }

        bool IsAnswerShowing { get; set; }

        bool LabelGameFinishedIsVisible { get; set; }

        bool BtnPlayAgainIsVisible { get; set; }
        string BtnNextItemText { get; set; }
        bool BtnNextItemIsVisible { get; set; }
        string DeckName { get; set; }
        int NumOfCards { get; set; }
        string LabelProgressText { get; set; }

        event EventHandler PlayAgainButtonClicked;

        event EventHandler Load;

        event EventHandler Shown;
        event EventHandler NextItemButtonClicked;

        void Show();
    }
}
