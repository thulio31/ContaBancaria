using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core._02Repository.Data
{
    public class InicializadorBD
    {
        private const string ConnectionString = "Data Source = Banco.db";
        public static void Inializador()
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                string commandoSQL = @" 
                CREATE TABLE IF NOT EXISTS Contas(                
                ID INTEGER PRIMARY KEY AUTOINCREMENT,
                Titular TEXT NOT NULL,
                Saldo REAL NOT NULL
                 );";

                connection.Execute(commandoSQL);

               
            }
        }
    }
}
