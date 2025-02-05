using Ola;
using Calculadora;
using System.Drawing;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

// Cumprimento.ImprimirMensagem();
// Cumprimento.ImprimirBomdia();

// repetir_valo1:
// Console.Write("Informar o primeiro valor?: ");
// if(!decimal.TryParse(Console.ReadLine(), out decimal valor1))
// {
//     Console.WriteLine("Valor inválido!");
//     goto repetir_valo1;
// }

// repetir_valo2:
// Console.Write("Informar o segundo valor?: ");
// if(!decimal.TryParse(Console.ReadLine(), out decimal valor2))
// {
//     Console.WriteLine("Valor inválido!");
//     goto repetir_valo2;
// }

// repetir_valor3:
// Console.Write("Informar o terceiro valor? ");
// if(!decimal.TryParse(Console.ReadLine(), out decimal valor3))
// {
//     Console.WriteLine("Valor inválido");
//     goto repetir_valor3;
// }

// repetir_valor4:
// Console.Write("Informar o terceiro valor? ");
// if(!decimal.TryParse(Console.ReadLine(), out decimal valor4))
// {
//     Console.WriteLine("Valor inválido");
//     goto repetir_valor4;
// }

// repetir_valor5:
// Console.Write("Informar o quarta valor? ");
// if(!decimal.TryParse(Console.ReadLine(), out decimal valor5))
// {
//     Console.WriteLine("Valor Inválido");
//     goto repetir_valor5
// }

// repetir_valo6
// Console.Write("Informar o quinta valor? ");
// if(!decimal.TryParse(Console.ReadLine(), out decimal Valor6))
// {
//     Console.WriteLine("Valor inválido");
//     goto repetir_valo6
// }
public static void DarkRed(string RealizarAdicao, ConsoleColor DarkRed)
{
    Console.ForegroundColor = ConsoleColor.DarkRed
    Console.Write(RealizarAdicao);
    Console.ResetColor();
}

// Operadores.RealizarAdicao(valor1,valor2);
// Operadores.RealizarSubtração(valor3,valor4);

Operadores.RealizarAdicao(); // Vai pedir que digite duas vezes e vai somar

// Toda vez que precisar que o usuário te informe algum valor (decimal) você só irá chamar ométodo Operadores.ObterValor();



Operadores.RealizarSubtração();
Operadores.RealizarMultiplicação();
Operadores.RealizarDivisão();