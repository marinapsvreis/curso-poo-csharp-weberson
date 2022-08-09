using BancoCSharp.Enums;
using BancoCSharp.Models;

Console.WriteLine("*******************************");
Console.WriteLine("**********Banco CSharp*********");
Console.WriteLine("*******************************");
Console.WriteLine();

var endereco = new Endereco
{
  Cep = "28900630",
  Rua = "Rua XYZ",
  Numero = 53
};

var titular01 = new Titular("José da Silva", "1234567901", "21999997700", endereco);
var titular02 = new Titular("Maria Conceição", "1234567902", "21999997711", endereco);

// var conta01 = new ContaCorrente(titular01, 100.0);
// var conta02 = new ContaPoupanca(titular02);
// var conta03 = new ContaInvestimento(titular02);
var conta04 = new ContaCorrente(titular01, 500.0);
var conta05 = new ContaPoupanca(titular02, 1000.0);

// var m1 = new Movimentacao(TipoMovimentacao.SAQUE, 100);
// var m2 = new Movimentacao(TipoMovimentacao.DEPOSITO, 100);

// Console.WriteLine(m1);
// Console.WriteLine(m2);

try
{
  //conta01.Sacar(101);
  //conta01.Sacar(1);
  //conta01.Sacar(10);
  //conta01.Depositar(1);
  //conta01.Depositar(10);
  //conta01.Transferir(conta02, 101);
  //conta01.Transferir(conta02, 1);
  // conta01.Transferir(conta02, 10);

  // conta01.Depositar(50.0);
  // conta02.Depositar(500.0);
  // conta02.Sacar(100.0);
  // conta02.Transferir(conta03, 100.0);

  // conta03.Sacar(25.0);

  // Console.WriteLine("Extrato da Conta 1:");
  // conta01.ImprimirExtrato();
  // Console.WriteLine();
  // Console.WriteLine("Extrato da Conta 2:");
  // conta02.ImprimirExtrato();
  // Console.WriteLine();
  // Console.WriteLine("Extrato da Conta 3:");
  // conta03.ImprimirExtrato();

  //conta04.Sacar(550);
  conta04.Transferir(conta05, 550);
}
catch (System.Exception ex)
{
  Console.WriteLine(ex.Message);
}

// Console.WriteLine("Saldo da conta 01: " + conta01.Saldo);
// Console.WriteLine("Saldo da conta 02: " + conta02.Saldo);

Console.WriteLine("Saldo da conta 04: " + conta04.Saldo);
Console.WriteLine("Limite da conta 04: " + conta04.LimiteDisponivel);
Console.WriteLine("Saldo da conta 05: " + conta05.Saldo);
Console.WriteLine("Limite da conta 05: " + conta05.LimiteDisponivel);
Console.WriteLine();

conta04.ImprimirExtrato();

// Console.WriteLine("Extrato conta 01: ");
// conta01.ImprimirExtrato();

// Console.WriteLine("Extrato conta 02: ");
// conta02.ImprimirExtrato();

Console.WriteLine();
