﻿using System;

namespace primeiro_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Soma de dois números");

            int n1, n2;

            Console.WriteLine("Digite o Primeiro Número");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Segundo Número");
            n2 = int.Parse(Console.ReadLine());

            int resultado = n1 + n2;

            Console.WriteLine($"O resultado é: {resultado}");


        }
    }
}
