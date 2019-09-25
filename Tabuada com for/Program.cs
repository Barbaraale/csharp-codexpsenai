using System;

namespace Tabuada_com_for
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tabuada com for");

            Console.WriteLine("Qual tabuada consegue saber?");
            int tabuada = int.Parse(Console.ReadLine());

            for( int contador = 0; contador <= 10; contador++){
                Console.WriteLine($"{tabuada} x {contador} = {tabuada * contador}");
            }
        }
    }
}
