using System;

namespace Exercício_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 6");

            float mercadoria, percentual;

            Console.WriteLine("Digite o valor da mercadoria");
            mercadoria = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o percentual de acrescimo");
            percentual = float.Parse(Console.ReadLine());

            float acrescimo = mercadoria * percentual;
            float valortotal = mercadoria + acrescimo;

            Console.WriteLine($"O valor total é de: {valortotal}");



        }
    }
}
