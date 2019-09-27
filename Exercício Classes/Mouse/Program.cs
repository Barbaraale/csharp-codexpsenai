using System;
using Exercício_Classe___Mouse.Models;

namespace Mouse
{
    class Program
    {
        static void Main(string[] args)
        {
            MouseModel mouse1 = new MouseModel();

            Console.Write("\nDigite a marca: ");
            mouse1.Marca = Console.ReadLine();

            Console.Write("\nDigite a modelo: ");
            mouse1.Modelo = Console.ReadLine();

            Console.Write("\nDigite a material: ");
            mouse1.Material = Console.ReadLine();
            
            Console.Write("\nDigite a cor: ");
            mouse1.Cor = Console.ReadLine();

            Console.Write("\nDigite o tamanho: ");
            mouse1.Tamanho = Console.ReadLine();

            Console.WriteLine($@"
            Mouse 1
            Marca: {mouse1.Marca}
            Modelo: {mouse1.Modelo}
            Material: {mouse1.Material}
            Cor: {mouse1.Cor}
            Tamanho: {mouse1.Tamanho}
            ");
        }
    }
}
