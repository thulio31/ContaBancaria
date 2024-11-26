using Core._01Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces.Service
{
    public interface IContaCorrenteService
    {
        void Adicionar(ContaCorrenteService cont);
        ContaCorrenteService BuscarPorId(int id);
        void Editar(ContaCorrenteService cont);
        List<ContaCorrenteService> Listar();
        void Remover(int id);
    }
}
