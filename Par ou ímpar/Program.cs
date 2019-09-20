using System;

namespace Par_ou_ímpar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Par ou ímpar");

            Console.WriteLine("\nDigite o primeiro número");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite o segundo número");
            int n2 = int.Parse(Console.ReadLine());

            float modulo = n1 % n2;

            if(modulo == 0){
                Console.WriteLine("\nNúmero par");
            }else{
                Console.WriteLine("\nNúmero ímpar");
            }

            if(n1 > n2){
                Console.WriteLine("Primeiro número maior\n");
            }else{
                Console.WriteLine("Segundo número maior\n");
            }

        }
    }
}
