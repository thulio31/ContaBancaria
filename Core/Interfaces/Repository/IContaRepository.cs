using ContaBancaria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces.Repository
{
    public interface IContaRepository
    {
        void Adicionar(Conta cont);
        List<Conta> Listar();
        void Editar(Conta cont);
        void Remover(int id);
        Conta Buscar(int id);
    }
}
