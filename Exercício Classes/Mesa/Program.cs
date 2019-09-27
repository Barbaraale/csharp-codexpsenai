using System;
using Mesa.Models;

namespace Mesa
{
    class Program
    {
        static void Main(string[] args)
        {
            MesaModel mesa1 = new MesaModel();

            Console.Write("\nDigite o modelo: ");
            mesa1.Modelo = Console.ReadLine();

            Console.Write("\nDigite o fabricante: ");
            mesa1.Fabricante = Console.ReadLine();

            Console.Write("\nDigite o material: ");
            mesa1.Material = Console.ReadLine();

            Console.Write("\nDigite o cor: ");
            mesa1.Cor = Console.ReadLine();

            Console.Write("\nDigite o tamanho: ");
            mesa1.Tamanho = Console.ReadLine();

            Console.Write("\nDigite o peso: ");
            mesa1.Peso = Console.ReadLine();

            Console.WriteLine($@"
            Mesa 1
            Modelo: {mesa1.Modelo}
            Fabricante: {mesa1.Fabricante}
            Meterial: {mesa1.Material}
            Cor: {mesa1.Cor}
            Tamanho: {mesa1.Tamanho}
            Peso: {mesa1.Peso}
            ");
            
        }
    }
}
