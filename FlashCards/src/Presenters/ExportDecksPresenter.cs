using src.Services;
using src.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace src.Presenters
{
    class ExcelPresenter<TView> : IPresenter<TView> where TView : IExportDecksView
    {
        private readonly IDeckService _deckService;
        private readonly IExcelService _excelService;

        public ExcelPresenter(IDeckService deckService, IExcelService excelService)
        {
            _deckService = deckService;
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
                await _excelService.SaveExcelFile(View.FileLocation, View.FileName);
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
            using (var dialog = new FolderBrowser())
            {
                var result = dialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    directory = dialog.Browser.SelectedPath;
                }
            }
            return directory;
        }
    }
}
