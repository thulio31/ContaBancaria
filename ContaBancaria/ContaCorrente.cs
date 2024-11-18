using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    public  class ContaCorrente : Conta
    {
        public double LimiteDeCredito { get; set; }

        public ContaCorrente(string titular, double limiteDeCredito)
            : base (titular)
        {
            LimiteDeCredito = limiteDeCredito;
        }

        public override bool Sacar(double valor)
        {
            if (valor <= Saldo + LimiteDeCredito)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de R$ {valor} realizado com sucesso.");
                return true;
            }
            else
            {
                Console.WriteLine("Limite de crédito e saldo insuficientes \nTa duro dorme.");
                return false;
            }
        }

        public override void ExibirInformacoes()
        {
            base.ExibirInformacoes();
            Console.WriteLine($"Limite de Crédito: {LimiteDeCredito}");
        }
    }
}
