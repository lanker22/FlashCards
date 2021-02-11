using src.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace src.Services.Repos
{
    public interface IRepoHelper
    {
        Card GenerateCardFromReader(SqlDataReader reader);
        Models.Deck GenerateEmptyDeckFromReader(SqlDataReader reader);
        List<Models.Deck> GenerateListOfAllDecksFromReader(SqlDataReader reader);
        Models.Deck GeneratePopulatedDeckFromReader(SqlDataReader reader);
    }
}