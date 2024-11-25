using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    public class ContaPoupanca : Conta
    {
        public double TaxaJuros { get; set; }
        public ContaPoupanca(string titular, double saldo, double taxajuros) : base(titular, saldo) 
        {
            TaxaJuros = taxajuros;
        }
        public void Depositar(double valor)
        {
            Saldo = Saldo + valor + (valor * TaxaJuros);
        }

    }
}
