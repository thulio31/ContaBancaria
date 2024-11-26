using ContaBancaria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces.Service
{
    public interface IContaService
    {
        void Adicionar(Conta cont);
        Conta BuscarPorId(int id);
        void Editar(Conta cont);
        List<Conta> Listar();
        void Remover(int id);
    }
}
