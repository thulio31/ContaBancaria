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

        public Conta(string titular)
        {
            Titular = titular;
            Saldo = 0.0;
        }

        public virtual void Depositar(double valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
                Console.WriteLine($"Depósito de R$ {valor} realizado com sucesso.");
            }
            else
            {
                Console.WriteLine("Valor de depósito inválido.");
            }
        }
        public virtual bool Sacar(double valor)
        {
            if (valor <= Saldo)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de R$ {valor} realizado com sucesso.");
                return true;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para saque.");
                return false;
            }
        }
        public void Transferir(double valor, IConta contaDestino)
        {
            if (Sacar(valor))
            {
                contaDestino.Depositar(valor);
            }
        }
        public virtual void ExibirInformacoes() 
        {
            Console.WriteLine($"Titular: {Titular}");
            Console.WriteLine($"Saldo: {Saldo}");
        }
    }
}
