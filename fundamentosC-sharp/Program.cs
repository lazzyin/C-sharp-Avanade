using ExemploFundamentos.Models;

Pessoa pessoa1 = new Pessoa();
Pessoa pessoa2 = new Pessoa();

pessoa1.Name="V";
pessoa1.Age=20;
pessoa1.Height=1.75;
pessoa1.Mount=50000.0M;
pessoa1.Status=true;

pessoa2.Name="David";
pessoa2.Age=18;
pessoa2.Height=1.80;
pessoa2.Mount=200.0M;
pessoa2.Status=false;

pessoa1.Apresentar();
pessoa2.Apresentar();
