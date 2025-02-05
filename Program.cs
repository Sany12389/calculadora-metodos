using Ola;
using Calculadora;

// Cumprimento.ImprimirMensagem();
// Cumprimento.ImprimirBomdia();

repetir_valo1:
Console.Write("Informar o primeiro valo?: ");
if(!decimal.TryParse(Console.ReadLine(), out decimal valor1))
{
    Console.WriteLine("Valor inválido!");
    goto repetir_valo1;
}

repetir_valo2:
Console.Write("Informar o segundo valo?: ");
if(!decimal.TryParse(Console.ReadLine(), out decimal valor2))
{
    Console.WriteLine("Valor inválido!");
    goto repetir_valo1;
}

Operadores.RealizarAdicao(valor1,valor2);