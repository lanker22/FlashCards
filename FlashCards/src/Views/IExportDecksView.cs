using System;
using System.Collections.Generic;
using System.Text;

namespace src.Views
{
    public interface IExportDecksView
    {
        public string FileLocation { get; set; }

        public string FileName { get; set; }

        public event EventHandler BrowseFileButtonClicked;

        public event EventHandler CreateExcelFileButtonClicked;

        void Close();
    }
}
