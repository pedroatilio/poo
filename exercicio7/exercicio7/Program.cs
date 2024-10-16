using Atv._07;

ContaCorrente conta1 = new ContaCorrente
{
    Banco = "Bradesco",
    Agencia = "Brotas",
    Conta = "Corrente",
    Saldo = "3000",
    limite = "17000",
};
Console.WriteLine($"Seu banco é: {conta1.Banco}, sua agencia é: {conta1.Agencia}, sua conta é: {conta1.Conta}, seu saldo é de: {conta1.Saldo}, seu limite é de: {conta1.limite}.");
Console.ReadKey();
