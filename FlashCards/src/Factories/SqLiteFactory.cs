using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace src.Factories
{
    public class SqLiteFactory : IDbFactory
    {

        private readonly string _connectionString;

        public SqLiteFactory(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IDbCommand CreateCommand(string queryString, IDbConnection conn)
        {
            var command = new SqliteCommand(queryString, (SqliteConnection)conn);
            return command;
        }

        public IDbConnection CreateConnection()
        {
            var conn = new SqliteConnection(_connectionString);
            conn.Open();
            return conn;
        }
    }
}
