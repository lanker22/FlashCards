using System;
using System.Collections.Generic;
using System.Text;

namespace src.Views
{
    public interface IFlashCardGameView
    {
        string CardDisplay { get; set; }

        event EventHandler RevealAnswerClicked;

        event EventHandler NextCardClicked;
    }
}
