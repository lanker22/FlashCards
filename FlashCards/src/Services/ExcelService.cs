using OfficeOpenXml;
using src.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace src.Services
{
    public class ExcelService : IExcelService
    {
        private readonly IDeckService _deckService;

        public ExcelService(IDeckService deckService)
        {
            _deckService = deckService;
        }

        public async Task<object> SaveExcelFile(string fileLocation, string fileName)
        {
            var file = GenerateEmptyWorkbook(fileLocation, fileName);
        }

        private async Task<object> CreateExcelFile(FileInfo file)
        {
            var decks = _deckService.GetAllDecks();
            DeleteIfExists(file);
            using (var package = new ExcelPackage(file))
            {
                AddSheetForEachDeck(package, decks);

            }
        }

        private void AddSheetForEachDeck(ExcelPackage package, IEnumerable<Deck> decks)
        {
            foreach(var deck in decks)
            {
                package.Workbook.Worksheets.Add($"{deck.Name}");
            }
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
