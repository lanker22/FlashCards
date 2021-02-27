using System.IO;
using System.Threading.Tasks;

namespace src.Services
{
    public interface IExcelService
    {
        Task<string> CreateExcelFile(string fileLocation, string fileName);
        void OpenExcelFile(string filePath);
    }
}