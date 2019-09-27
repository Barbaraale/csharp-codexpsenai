using System;

namespace Álcool_em_Gel.Models
{
    public class AlcoolGelModel
    {
        public string Marca { get; set; }

        public string Cor { get; set; }

        public double Gramatura { get; set; }

        public void CadastrarProduto(){
            
            Console.Write("\nÁlcool em Gel 1");

            Console.Write("\nDigite a marca: ");
            Marca = Console.ReadLine();

            Console.Write("\nO álcool gel possui cor? (Sim/Não): ");
            Cor = Console.ReadLine();

            Console.Write("\nDigite a quantidade(g): ");
            Gramatura = double.Parse(Console.ReadLine());

        }

        public void ListarProdutos(){
            Console.WriteLine($@"
            Álcool em Gel 1
            Marca: {Marca}
            Cor: {Cor}
            Quantidade: {Gramatura}
            ");
        }
    }
}