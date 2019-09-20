using System;

namespace Laço_While
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Laços de repetição while (enquanto)");

            Console.Write("Digite o número inicial: ");
            int inicial = int.Parse(Console.ReadLine());
            
            Console.Write("Digite o número limite: ");
            int limite = int.Parse(Console.ReadLine());

            while(inicial <= limite){
                Console.WriteLine(inicial);
                inicial = inicial + 1;
            } 


        }
    }
}
