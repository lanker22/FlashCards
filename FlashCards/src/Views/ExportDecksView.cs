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
    }
}
