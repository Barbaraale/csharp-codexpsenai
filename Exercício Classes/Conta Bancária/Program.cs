using System;
using Conta_Bancária.Models;

namespace Conta_Bancária
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancariaModel conta1 = new ContaBancariaModel();

            Console.Write("\nDigite o nome do Banco: ");
            conta1.Banco = Console.ReadLine();

            Console.Write("\nDigite o tipo de conta: ");
            conta1.Tipo = Console.ReadLine();

            Console.Write("\nDigite o nome: ");
            conta1.Dono = Console.ReadLine();

            Console.Write("\nSaldo: ");
            conta1.Saldo = float.Parse(Console.ReadLine());

            Console.WriteLine($@"
            Conta Bancária 1
            Banco: {conta1.Banco}
            Tipo da Conta: {conta1.Tipo}
            Dono: {conta1.Dono}
            Saldo: {conta1.Saldo}
            ");
            
        }
    }
}
