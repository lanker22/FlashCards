using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace src.Views
{
    public partial class ExportDecksView : Form, IExportDecksView
    {
        public ExportDecksView()
        {
            InitializeComponent();
            btnBrowseFilesystem.Click += BtnBrowseFilesystem_Click;
            btnCreateExcelFile.Click += BtnCreateExcelFile_Click;
            var presenter = PresenterFactory.CreateForView(this);
            presenter.InitialSetup();
        }

        public string FileLocation
        {
            get { return textboxFileLocation.Text; }
            set { textboxFileLocation.Text = value; }
        }
        public string FileName
        {
            get { return textboxFileName.Text; }
            set { textboxFileName.Text = value; }
        }

        public event EventHandler BrowseFileButtonClicked;
        public event EventHandler CreateExcelFileButtonClicked;

        private void BtnCreateExcelFile_Click(object sender, EventArgs e)
        {
            CreateExcelFileButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void BtnBrowseFilesystem_Click(object sender, System.EventArgs e)
        {
            BrowseFileButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
