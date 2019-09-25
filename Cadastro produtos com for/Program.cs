using System;

namespace Cadastro_produtos_com_for
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cadastro produtos com for");

            string[] produtoNome = new string[3];
            double[] produtoPreco = new double[3];

            for(int i = 0; i < 3; i++){

                Console.WriteLine($"Digite o nome do {i+1}º produto");
                produtoNome[i] = Console.ReadLine();
                
                Console.WriteLine("Digite o preço");
                produtoPreco[i] = int.Parse(Console.ReadLine());
            }

            foreach (var produto in produtoNome){
                Console.WriteLine($"Produto: {produto}");
            }

          
            {
                
            }
        }
    }
}
