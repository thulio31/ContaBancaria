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
    public class ContaRepository : IContaRepository
    {
        private readonly string ConnectionString;

        public ContaRepository(IConfiguration config)
        {
            ConnectionString = config.GetConnectionString("DefaultConnection");
        }

        public void Adicionar(Conta cont)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Insert(cont);
        }

        public List<Conta> Listar()
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.GetAll<Conta>().ToList();
        }

        public void Editar(Conta cont)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Update<Conta>(cont);
        }
        public void Remover(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            Conta novoconta = Buscar(id);
            connection.Delete(novoconta);
        }

        public Conta Buscar(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Get<Conta>(id);
        }
    }
}
