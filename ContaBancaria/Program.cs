using ContaBancaria;

ContaPoupanca poup = new ContaPoupanca("Paulao", 100000, 1.2);
ContaCorrente corr = new ContaCorrente("Vencio", 1, 1);

GestaoContas gestao = new GestaoContas();
gestao.Adicionar(poup);
gestao.Adicionar(corr);

poup.Transferir(1000, corr);

gestao.Listar();