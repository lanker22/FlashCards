using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace src.Factories
{
    public interface IDbFactory
    {
        IDbCommand CreateCommand(string queryString, IDbConnection conn);

        IDbConnection CreateConnection();
    }
}
