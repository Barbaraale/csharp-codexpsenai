using System;

namespace Exercício_Classe___Mouse.Models
{
    public class MouseModel
    {
        public string Marca { get; set;}

        public string Modelo { get; set; }

        public string Material { get; set; }

        public string Cor { get; set; }

        public string Tamanho { get; set; }

        public void CadastrarProduto(){
            
            Console.WriteLine("Mouse 1");

            Console.Write("\nDigite a marca: ");
            Marca = Console.ReadLine();

            Console.Write("\nDigite a modelo: ");
            Modelo = Console.ReadLine();

            Console.Write("\nDigite a material: ");
            Material = Console.ReadLine();
            
            Console.Write("\nDigite a cor: ");
            Cor = Console.ReadLine();

            Console.Write("\nDigite o tamanho: ");
            Tamanho = Console.ReadLine();
        }

        public void ListarProdutos(){
            Console.WriteLine($@"
            Mouse 1
            Marca: {Marca}
            Modelo: {Modelo}
            Material: {Material}
            Cor: {Cor}
            Tamanho: {Tamanho}
            ");
        }       
    }
}