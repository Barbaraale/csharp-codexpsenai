using System;

namespace Calculo_de_média
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculo da média");
            int n1, n2, n3;

            Console.WriteLine("Digite o primeiro número");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro número");
            n3 = int.Parse(Console.ReadLine());

            float resultado = (float)(n1 + n2 + n3) / 3;

            Console.WriteLine("O resultado é:" + resultado);
        }
    }
}
