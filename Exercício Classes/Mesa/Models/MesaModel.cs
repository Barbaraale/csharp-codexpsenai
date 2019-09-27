using System;

namespace Mesa.Models
{
    public class MesaModel
    {
        public string Modelo { get; set; }

        public string Fabricante { get; set; }
        
        public string Material { get; set; }

        public string Cor { get; set; }

        public string Tamanho { get; set; }

        public string Peso { get; set; }

        public void CadastrarProduto(){

            System.Console.WriteLine("Mesa 1");

            Console.Write("\nDigite o modelo: ");
            Modelo = Console.ReadLine();

            Console.Write("\nDigite o fabricante: ");
            Fabricante = Console.ReadLine();

            Console.Write("\nDigite o material: ");
            Material = Console.ReadLine();

            Console.Write("\nDigite o cor: ");
            Cor = Console.ReadLine();

            Console.Write("\nDigite o tamanho: ");
            Tamanho = Console.ReadLine();

            Console.Write("\nDigite o peso: ");
            Peso = Console.ReadLine();

        }

        public void ListarProdutos(){
            Console.WriteLine($@"
            Mesa 1
            Modelo: {Modelo}
            Fabricante: {Fabricante}
            Meterial: {Material}
            Cor: {Cor}
            Tamanho: {Tamanho}
            Peso: {Peso}
            ");
        }
    }
    
}