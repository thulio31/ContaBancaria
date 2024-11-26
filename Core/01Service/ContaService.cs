using ContaBancaria;
using Core.Interfaces.Repository;
using Core.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core._01Service
{
    public class ContaService : IContaService
    {
        private readonly IContaRepository repository;
        public ContaService(IContaRepository _repository)
        {
            repository = _repository;
        }

        public void Adicionar(Conta cont)
        {
            repository.Adicionar(cont);
        }

        public Conta BuscarPorId(int id)
        {
            return repository.Buscar(id);
        }

        public void Editar(Conta cont)
        {
            repository.Editar(cont);
        }

        public List<Conta> Listar()
        {
            return repository.Listar();
        }

        public void Remover(int id)
        {
            repository.Remover(id);
        }
    }
}
