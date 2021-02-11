using System;
using System.Collections.Generic;
using System.Text;

namespace src.Views
{
    public interface IGameCompletedView
    {
        event EventHandler PlayingAgain;

        event EventHandler NotPlayingAgain;
    }
}
