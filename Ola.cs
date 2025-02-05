using System.Threading.Channels;

namespace Ola
{
    class Cumprimento
    {
        // public diz respeito se outros métodos poderão agir dentro, além disso, poder alterar os atributos
        // static diz respeito se a minha classe deverá ser instanciada

        //Isso aqui é um método
        public static void ImprimirMensagem()
        {
            Console.WriteLine("Olá!");
        }

        public static void ImprimirBomdia()
        {
            Console.WriteLine("Bom dia!!!");
        }

    }
}

// alt + shift + f     serve para identar o código (organizar)