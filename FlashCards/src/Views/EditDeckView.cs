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
    }
}
