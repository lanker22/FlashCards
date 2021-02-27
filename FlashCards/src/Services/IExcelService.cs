using System.Threading.Tasks;

namespace src.Services
{
    public interface IExcelService
    {
        Task<object> CreateExcelFile();
        Task<object> SaveExcelFile(string fileLocation, string fileName);
    }
}