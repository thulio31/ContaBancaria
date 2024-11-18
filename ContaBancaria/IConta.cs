﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    public interface IConta
    {
        void Depositar(double valor);
        bool Sacar(double valor);
        void Transferir(double valor, IConta contaDestino);
        void ExibirInformacoes();
    }
}
