using System;

namespace Celular.Models
{
    public class CelularModel
    {
        public string Modelo { get; set; }

        public string Fabricante { get; set; }

        public string Cor { get; set; }

        public string Tamanho { get; set; }

        public void CadastrarProduto(){

            Console.WriteLine("Celular 1");

            Console.Write("\nDigite o modelo: ");
            Modelo = Console.ReadLine();
            
            Console.Write("\nDigite o fabricante: ");
            Fabricante = Console.ReadLine();
            
            Console.Write("\nDigite a cor: ");
            Cor = Console.ReadLine();
            
            Console.Write("\nDigite o tamanho: ");
            Tamanho = Console.ReadLine();
        }

        public void ListarProduto(){
            Console.WriteLine($@"
            Celular 1
            Modelo: {Modelo}
            Fabricante: {Fabricante}
            Cor: {Cor}
            Tamanho: {Tamanho}
            ");
        }
    }
}