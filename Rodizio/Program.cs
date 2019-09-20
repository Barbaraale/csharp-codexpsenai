using System;

namespace Rodizio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rodizio");

            Console.Write("\nDigite sua placa: ");
            // int numero = int.Parse(Console.ReadLine());
            string placa = Console.ReadLine();

            int caracteres = placa.Length;

            int final = int.Parse(placa.Substring(caracteres - 1));

            Console.WriteLine($"A posição 0 é: {final}");

            if(final == 0 || final == 1){
                Console.WriteLine("Segunda-feira\n");
            }else if(final == 2 || final == 3){
                Console.WriteLine("Terça-feira\n");
            }else if(final == 4 || final == 5){
                Console.WriteLine("Quarta-feira\n");
            }else if(final == 6 || final == 7){
                Console.WriteLine("Quinta-feira\n");
            }else if(final == 8 || final == 9){
                Console.WriteLine("Sexta-feira\n");
            }
        }
    }
}
