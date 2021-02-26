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
    }
}
