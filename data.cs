using Community.CsharpSqlite.SQLiteClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace CashCalc
{
    public class dataCon
    {
        SqliteConnection connection = new SqliteConnection("Data Source = data.db");

        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
        public SqliteConnection getConnection()
        {
            return connection;
        }
    }
}
