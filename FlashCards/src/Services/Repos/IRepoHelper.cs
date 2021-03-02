using src.Models;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace src.Services.Repos
{
    public interface IRepoHelper
    {
        void AddParameterToCommand<T>(string paramName, T value, IDbCommand command);
        List<Deck> GenerateListOfAllDecksFromReader(IDataReader reader);
        Deck GeneratePopulatedDeckFromReader(IDataReader reader);
        string GetDeckNameFromReader(IDataReader sqlDataReader);
    }
}