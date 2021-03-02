using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace src.Factories
{
    public class SqlFactory : IDbFactory
    {
        private readonly string _connectionString;

        public SqlFactory(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IDbCommand CreateCommand(string queryString, IDbConnection conn)
        {
            var command = new SqlCommand(queryString, (SqlConnection)conn);
            return command;
        }

        public IDbConnection CreateConnection()
        {
            var conn = new SqlConnection(_connectionString);
            conn.Open();
            return conn;
        }
    }
}
