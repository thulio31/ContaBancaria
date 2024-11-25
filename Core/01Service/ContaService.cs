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

        public Caminhao BuscarPorId(int id)
        {
            return repository.Buscar(id);
        }

        public void Editar(Caminhao caminhao)
        {
            repository.Editar(caminhao);
        }

        public List<Caminhao> Listar()
        {
            return repository.Listar();
        }

        public void Remover(int id)
        {
            repository.Delete(id);
        }
    }
}
