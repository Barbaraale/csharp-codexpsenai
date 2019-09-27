using System;
using Álcool_em_Gel.Models;

namespace Álcool_em_Gel
{
    class Program
    {
        static void Main(string[] args)
        {
        
            AlcoolGelModel alcool1 = new AlcoolGelModel();

            Console.Write("\nDigite a marca: ");
            alcool1.Marca = Console.ReadLine();

            Console.Write("\nO álcool gel possui cor? (Sim/Não): ");
            alcool1.Cor = Console.ReadLine();

            Console.Write("\nDigite a quantidade(g): ");
            alcool1.Gramatura = double.Parse(Console.ReadLine());

            Console.WriteLine($@"
            Álcool em Gel 1
            Marca: {alcool1.Marca}
            Cor: {alcool1.Cor}
            Quantidade: {alcool1.Gramatura}
            ");


            


        }
    }
}
