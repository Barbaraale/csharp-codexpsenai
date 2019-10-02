using System;
using Atividade_OO.Controllers;

namespace Atividade_OO
{
    class Program
    {
        static void Main(string[] args)
        {
            ProdutoController produtoController = new ProdutoController();

            int opcao = 0;

            do
            {
                Console.WriteLine("\n1 - Cadastrar Produtos");
                Console.WriteLine("2 - Listar Produtos");
                Console.WriteLine("3 - Preço total dos produtos em estoque");
                Console.WriteLine("0 - Sair\n");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        produtoController.CadastroProduto();
                    break;

                    case 2:
                        produtoController.ListaProduto();
                    break;

                    case 3:
                        produtoController.TotalPrecoEstoque();
                    break;

                    case 0:
                        Console.WriteLine("Obrigada por usar o sistema!");
                    break;

                    default:
                        Console.WriteLine("Opção inválida");
                    break;
                }
                
            } while (opcao != 0);
        }
    }
}
