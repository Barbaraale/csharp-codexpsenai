using System;

namespace Conta_Bancária.Models
{
    public class ContaBancariaModel
    {
        public string Banco { get; set; }

        public string Tipo { get; set; }

        public string Dono { get; set; }

        public float Saldo { get; set; }

        public void CadastrarConta(){

            Console.WriteLine("Conta Bancária 1");

            Console.Write("\nDigite o nome do Banco: ");
            Banco = Console.ReadLine();

            Console.Write("\nDigite o tipo de conta: ");
            Tipo = Console.ReadLine();

            Console.Write("\nDigite o nome: ");
            Dono = Console.ReadLine();

            Console.Write("\nSaldo: ");
            Saldo = float.Parse(Console.ReadLine());
        }

        public void ListarConta(){
            Console.WriteLine($@"
            Conta Bancária 1
            Banco: {Banco}
            Tipo da Conta: {Tipo}
            Dono: {Dono}
            Saldo: {Saldo}
            ");
        }

    }
}