using src.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace src.Services.Repos
{
    public interface IRepoHelper
    {
        Card GenerateCardFromReader(SqlDataReader reader);
        Deck GenerateEmptyDeckFromReader(SqlDataReader reader);
        List<Deck> GenerateListOfAllDecksFromReader(SqlDataReader reader);
        Deck GeneratePopulatedDeckFromReader(SqlDataReader reader);
    }
}