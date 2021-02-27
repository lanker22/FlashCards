using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace src.Views
{
    public partial class FolderBrowser : Form
    {
        public FolderBrowserDialog Browser
        {
            get { return folderBrowserDialog1; }
        }
        public FolderBrowser()
        {
            InitializeComponent();
        }
    }
}
