using System.Drawing;
using Layout;

namespace Calculadora
{
    class Operadores
    {

        public static decimal ObterValor()
        {
        repetir:
            Console.Write("Informar o valor: ", ConsoleColor.Green);
            if (!decimal.TryParse(Console.ReadLine(), out decimal valor))
            {
                Formatacao.Cor("Valor inválido!", ConsoleColor.Red);
                goto repetir;
            }
            else
            {
                return valor;
            }
        }

        // Adição
        public static void RealizarAdicao()
        {
            decimal valor1 = Operadores.ObterValor();
            decimal valor2 = Operadores.ObterValor();

            Console.WriteLine($"A soma dos valores {valor1} e {valor2} é {valor1 + valor2}");
        }


        // Subtração

        public static void RealizarSubtração()
        {
            decimal valor3 = Operadores.ObterValor();
            decimal valor4 = Operadores.ObterValor();
            Console.WriteLine($"A Subtração dos valores {valor3} e {valor4} é {valor3 - valor4}");
        }

        // Multiplicação
        public static void RealizarMultiplicação()
        {
            decimal valor5 = Operadores.ObterValor();
            decimal Valor6 = Operadores.ObterValor();
            Console.WriteLine($"A Multiplicação dos valores {valor5} e {Valor6} é {valor5 * Valor6}");
        }

        // Divisão
        public static void RealizarDivisão()
        {
            decimal valor7 = Operadores.ObterValor();
            decimal valor8 = Operadores.ObterValor();
            Console.WriteLine($"A divisão dos valores {valor7} e {valor8} é {valor7/valor8}");
        }
    }
}