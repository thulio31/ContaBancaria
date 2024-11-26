using ContaBancaria;
using Core.Interfaces.Repository;
using Dapper.Contrib.Extensions;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core._02Repository
{
    public class ContaCorrenteRepository : IContaCorrenteRepository
    {
        private readonly string ConnectionString;

        public ContaCorrenteRepository(IConfiguration config)
        {
            ConnectionString = config.GetConnectionString("DefaultConnection");
        }

        public void Adicionar(ContaCorrenteRepository cont)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Insert(cont);
        }

        public List<ContaCorrenteRepository> Listar()
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.GetAll<ContaCorrenteRepository>().ToList();
        }

        public void Editar(ContaCorrenteRepository cont)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Update<ContaCorrenteRepository>(cont);
        }
        public void Remover(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            ContaCorrenteRepository novoconta = Buscar(id);
            connection.Delete(novoconta);
        }

        public ContaCorrenteRepository Buscar(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Get<ContaCorrenteRepository>(id);
        }
    }
}
