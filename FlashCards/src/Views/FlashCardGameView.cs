using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace src.Views
{
    public partial class FlashCardGameView : Form, IFlashCardGameView
    {
        public FlashCardGameView()
        {
            InitializeComponent();
            PresenterFactory.CreateForView(this);
        }

        public string Question { get; set; }
        public string Answer { get; set; }
        public int CurrentCardIndex { get; set; }
        public int DeckId { get; set; }
        public int CorrectAnswers { get; set; }
        public int IncorrectAnswers { get; set; }
        public bool IsAnswerShowing { get; set; }
        public bool LabelGameFinishedIsVisible
        {
            get { return labelGameFinished.Visible; }
            set { labelGameFinished.Visible = value; }
        }
        
        public bool BtnPlayAgainIsVisible
        {
            get { return btnPlayAgain.Visible; }
            set { btnPlayAgain.Visible = value; }
        }

        public event EventHandler NextCardClicked;
        public event EventHandler PlayAgainButtonClicked;

        private void FlashCardGameView_Click(object sender, EventArgs e)
        {
            NextCardClicked?.Invoke(this, EventArgs.Empty);
        }

        private void BtnPlayAgain_Click(object sender, EventArgs e)
        {
            PlayAgainButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
