using OfficeOpenXml;
using src.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace src.Services
{
    public class ExcelService : IExcelService
    {
        private readonly IDeckService _deckService;

        public ExcelService(IDeckService deckService)
        {
            _deckService = deckService;
        }

        public async Task<string> CreateExcelFile(string fileLocation, string fileName)
        {
            var file = GenerateEmptyWorkbook(fileLocation, fileName);
            var decks = _deckService.GetAllDecks();
            DeleteIfExists(file);
            using (var package = new ExcelPackage(file))
            {
                PopulateWorkbook(decks, package.Workbook);
                await package.SaveAsync();
                return file.FullName;
            }
        }

        public void OpenExcelFile(string filePath)
        {
            var xl = new Excel.Application();
            xl.Workbooks.Open(filePath);
        }

        private void PopulateWorkbook(List<Deck> decks, ExcelWorkbook wb)
        {
            foreach (var deck in decks)
            {
                var ws = CreateWorkSheet(deck.Name, wb);
                PopulateWorkSheet(ws, deck);
            }
        }

        private ExcelWorksheet CreateWorkSheet(string name, ExcelWorkbook wb)
        {
            return wb.Worksheets.Add($"{name}");
        }


        private void PopulateWorkSheet(ExcelWorksheet ws, Deck deck)
        {
            var range = ws.Cells.LoadFromCollection(deck.Cards, true);
            range.AutoFitColumns();
        }

        private void DeleteIfExists(FileInfo file)
        {
            if (file.Exists)
            {
                file.Delete();
            }
        }

        private FileInfo GenerateEmptyWorkbook(string fileLocation, string fileName)
        {
            return new FileInfo($@"{fileLocation}\{fileName}.xlsx");
        }
    }
}
