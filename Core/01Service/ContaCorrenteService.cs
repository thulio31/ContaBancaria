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
   
        public class ContaCorrenteService : IContaCorrenteService
        {
            private readonly IContaCorrenteRepository repository;
            public ContaCorrenteService(IContaCorrenteRepository _repository)
            {
                repository = _repository;
            }

            public void Adicionar(ContaCorrenteService cont)
            {
                repository.Adicionar(cont);
            }

            public ContaCorrenteService BuscarPorId(int id)
            {
                return repository.Buscar(id);
            }

            public void Editar(ContaCorrenteService cont)
            {
                repository.Editar(caminhao);
            }

            public List<ContaCorrenteService> Listar()
            {
                return repository.Listar();
            }

            public void Remover(int id)
            {
                repository.Delete(id);
            }

    }
}
