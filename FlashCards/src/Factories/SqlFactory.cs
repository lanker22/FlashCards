using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace src.Factories
{
    /// <summary>
    ///     Provides functions for establishing a SqlServer connection.
    /// </summary>
    public class SqlFactory : IDbFactory
    {
        private readonly string _connectionString;

        public SqlFactory(string connectionString)
        {
            _connectionString = connectionString;
        }

        /// <summary>
        ///     Provides a SqlCommand instance. 
        /// </summary>
        /// <param name="queryString">SqlQuery to be executed by the Command.</param>
        /// <param name="conn">The IDbConnection instance to add to the Command. </param>
        /// <returns>A SqlCommand instance.</returns>
        public IDbCommand CreateCommand(string queryString, IDbConnection conn)
        {
            var command = new SqlCommand(queryString, (SqlConnection)conn);
            return command;
        }

        /// <summary>
        ///     Provides a SqlConnection instance.
        /// </summary>
        /// <returns>A SqlConnection instance</returns>
        public IDbConnection CreateConnection()
        {
            var conn = new SqlConnection(_connectionString);
            return conn;
        }
    }
}
