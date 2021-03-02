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

        public void SetupSqliteDatabaseForTesting()
        {
            using(var conn = new SqliteConnection(_connectionString))
            {
                conn.Open();
                using(var cmd = new SqliteCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS decks(DeckID INTEGER, " +
                        "Name TEXT)";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS cards(Question TEXT, " +
                        "Answer TEXT, DeckID INTEGER," +
                        "FOREIGN KEY (DeckID) REFERENCES decks(DeckID))";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "INSERT INTO decks (DeckID, Name) " +
                                      "VALUES ('1', 'test1')";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "INSERT INTO decks (DeckID, Name) " +
                                      "VALUES ('2', 'test2')";
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
