using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace src.Views
{
    public partial class EditDeckView : Form, IEditDeckView
    {
        public EditDeckView()
        {
            InitializeComponent();
            btnUpdateName.Click += BtnUpdateDeckName_Click;
            btnAddCard.Click += BtnAddCard_Click;
            FormClosed += EditDeckView_FormClosed;
        }

        public void InitiatePresenter()
        {
            var presenter = PresenterFactory.CreateForView(this);
            presenter.InitialSetup();
        }

        public int DeckId { get; set; }
        
        public string NewQuestion
        {
            get { return textboxQuestion.Text.Trim(); }
            set { textboxQuestion.Text = value; }
        }
        
        public string NewAnswer
        {
            get { return textboxAnswer.Text.Trim(); }
            set { textboxAnswer.Text = value; }
        }
        
        public string DeckName
        {
            get { return textboxDeckName.Text.Trim(); }
            set { textboxDeckName.Text = value; }
        }

        public event EventHandler CardAddedButtonClicked;
        public event EventHandler UpdateDeckNameButtonClicked;
        public event EventHandler EditDeckViewClosedEvent;

        private void EditDeckView_FormClosed(object sender, FormClosedEventArgs e)
        {
            EditDeckViewClosedEvent?.Invoke(this, EventArgs.Empty);
        }

        private void BtnUpdateDeckName_Click(object sender, EventArgs e)
        {
            UpdateDeckNameButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void BtnAddCard_Click(object sender, EventArgs e)
        {
            CardAddedButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
