using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    public class Conta : IConta
    {
        
        public string Titular { get; set; }
        public double Saldo { get; set; }

        public Conta(string titular, double saldo)
        {
            Titular = titular;
            Saldo = saldo;
        }

        public virtual void Depositar(double valor)
        {
            Saldo = Saldo + valor;
        }

        public virtual void ExibirInformacoes()
        {
            Console.WriteLine($"Titular: {Titular}" +
                $"\nSaldo: {Saldo}"); 
        }

        public virtual bool Sacar(double valor)
        {
            double Saldocalcu = Saldo - valor;
            if (Saldocalcu < 0)
            {  
                Saldo = Saldo - valor;
                return false;
            }
            else
            {
                return true;
            }
        }

        public virtual void Transferir(double valor, IConta contaDestino)
        {
            double Saldocalcu = Saldo - valor;
            if (Saldocalcu > 0)
            {
                contaDestino.Depositar(valor);
            }
            else if (Saldocalcu < 0)
            {
                Console.WriteLine("Saldo insuficiente");
            }
        }
    }
}
