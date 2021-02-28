using src.Services;
using src.Views;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace src.Presenters
{
    class ExportDecksPresenter<TView> : IPresenter<TView> where TView : IExportDecksView
    {
        private readonly IExcelService _excelService;

        public ExportDecksPresenter(IExcelService excelService)
        {
            _excelService = excelService;
        }

        public TView View { get; set; }

        public void InitialSetup()
        {
            View.BrowseFileButtonClicked += View_BrowseFileButtonClicked;
            View.CreateExcelFileButtonClicked += async (s, e) => await View_CreateExcelFileButtonClicked();
            View.FileName = "";
        }

        private async Task View_CreateExcelFileButtonClicked()
        {
            if (FileNameInputIsBlank())
            {
                NotifyUserOfBlankFileNameInput();
            }
            else
            {
                var file = await _excelService.CreateExcelFile(View.FileLocation, View.FileName);
                try
                {
                    _excelService.OpenExcelFile(file);
                    View.Close();
                }
                catch (FileNotFoundException)
                {
                    View.Close();
                }
            }
        }

        private bool FileNameInputIsBlank()
        {
            return View.FileName == "";
        }

        private static void NotifyUserOfBlankFileNameInput()
        {
            MessageBox.Show("Please provide a name for your excel file.");
        }

        private void View_BrowseFileButtonClicked(object sender, EventArgs e)
        {
            View.FileLocation = GetDirectoryFromUser();
        }

        private string GetDirectoryFromUser()
        {
            var directory = "";
            using (var dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog()== DialogResult.OK)
                {
                    directory = dialog.SelectedPath;
                }
            }
            return directory;
        }
    }
}
