using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace src.Views
{
    public partial class AddDeckView : Form, IAddDeckView
    {
        public AddDeckView()
        {
            InitializeComponent();
            btnAddDeck.Click += BtnAddDeck_Click;
            FormClosed += AddDeckView_FormClosed;
            var presenter = PresenterFactory.CreateForView(this);
            presenter.InitialSetup();
        }
        public string NewDeckName
        {
            get { return inputDeckName.Text; }
            set { inputDeckName.Text = value; }
        }

        public event EventHandler DeckAddedClicked;
        public event EventHandler AddDeckViewClosedEvent;

        private void AddDeckView_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            AddDeckViewClosedEvent?.Invoke(this, EventArgs.Empty);
        }

        private void BtnAddDeck_Click(object sender, System.EventArgs e)
        {
            DeckAddedClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
