using System;
using Celular.Models;

namespace Celular
{
    class Program
    {
        static void Main(string[] args)
        {
        
            CelularModel celular1 = new CelularModel();

            Console.Write("\nDigite o modelo: ");
            celular1.Modelo = Console.ReadLine();
            
            Console.Write("\nDigite o fabricante: ");
            celular1.Fabricante = Console.ReadLine();
            
            Console.Write("\nDigite a cor: ");
            celular1.Cor = Console.ReadLine();
            
            Console.Write("\nDigite o tamanho: ");
            celular1.Tamanho = Console.ReadLine();

            Console.WriteLine($@"
            Celular 1
            Modelo: {celular1.Modelo}
            Fabricante: {celular1.Fabricante}
            Cor: {celular1.Cor}
            Tamanho: {celular1.Tamanho}
            ");
            

        }
    }
}
