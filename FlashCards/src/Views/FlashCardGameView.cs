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
            btnNextItem.Click += BtnNextItem_Click;
            btnPlayAgain.Click += BtnPlayAgain_Click;
            textboxQuestionOrAnswer.BackColor = Color.LightGoldenrodYellow;
        }

        public void WireUpView()
        {
            var presenter = PresenterFactory.CreateForView(this);
            presenter.InitialSetup();
        }

        public int DeckId { get; set; }

        public string DeckName
        {
            get { return labelDeckName.Text; }
            set { labelDeckName.Text = value; }
        }
        public int CurrentCardIndex { get; set; }
        public int NumOfCards { get; set; }
        public bool IsAnswerShowing { get; set; }
        public string QuestionOrAnswerDisplay
        {
            get { return textboxQuestionOrAnswer.Text; }
            set { textboxQuestionOrAnswer.Text = value; }
        }

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

        public string BtnNextItemText
        {
            get { return btnNextItem.Text; }
            set { btnNextItem.Text = value; }
        }

        public string LabelProgressText
        {
            get { return labelProgress.Text; }
            set { labelProgress.Text = value; }
        }

        public bool BtnNextItemIsVisible
        {
            get { return btnNextItem.Visible; }
            set { btnNextItem.Visible = value; }
        }

        public event EventHandler PlayAgainButtonClicked;
        public event EventHandler NextItemButtonClicked;

        private void BtnPlayAgain_Click(object sender, EventArgs e)
        {
            PlayAgainButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void BtnNextItem_Click(object sender, EventArgs e)
        {
            NextItemButtonClicked?.Invoke(sender, EventArgs.Empty);
        }
    }
}
