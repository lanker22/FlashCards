using src.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace src.Services.Repos
{
    public interface IRepoHelper
    {
        List<Deck> GenerateListOfAllDecksFromReader(SqlDataReader reader);
        Deck GeneratePopulatedDeckFromReader(SqlDataReader reader);
        string GetDeckNameFromReader(SqlDataReader sqlDataReader);
    }
}