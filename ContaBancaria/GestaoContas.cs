using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    public class GestaoContas
    {
        List<IConta> conta  =  new List<IConta>();

        public void Adicionar(Conta contas)
        {
            conta.Add(contas);
        }

        public void Listar() 
        {
            foreach(Conta contas in conta) 
            {
                Console.WriteLine($"Titular : {contas.Titular}" +
                    $"\nSaldo : {contas.Saldo}");
            }
        }
    }
}
