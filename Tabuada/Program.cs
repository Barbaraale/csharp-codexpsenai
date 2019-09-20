using System;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tabuada");

            Console.WriteLine("Digite o multiplicador");
            int multiplicador = int.Parse(Console.ReadLine());

            int contador = 0;
            while(contador <= 10){
                int produto = contador * multiplicador;
                Console.WriteLine($"O produto de {contador} x {multiplicador} é {produto}");
                contador++;
            }

            }
        }
    }
}
