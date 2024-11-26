using Core._02Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces.Repository
{
    public interface IContaCorrenteRepository
    {
        void Adicionar(ContaCorrenteRepository cont);
        List<ContaCorrenteRepository> Listar();
        void Editar(ContaCorrenteRepository cont);
        void Remover(int id);
        ContaCorrenteRepository Buscar(int id);
    }
}
