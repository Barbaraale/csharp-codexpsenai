using System;
using System.Collections.Generic;
using Atividade_OO.Models;

namespace Atividade_OO.Controllers
{
    public class ProdutoController
    {
        //Criando lista do tipo CadastroProdutosModel 
        List<CadastroProdutosModel> listaProdutos = new List<CadastroProdutosModel>();

        //Instanciando produto
        CadastroProdutosModel produto = new CadastroProdutosModel();

        //Começo cadastro produtos
        public void CadastroProduto(){

            Console.Write("\nDigite o nome do produto: ");
            string nome = Console.ReadLine();

            Console.Write("Digite a categoria do produto: ");
            string categoria = Console.ReadLine();

            Console.Write("Digite o preço do produto: ");
            float preco = float.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade em estoque do produto: ");
            int quantidade = int.Parse(Console.ReadLine());

            produto.Id = listaProdutos.Count + 1;
            produto.Nome = nome;
            produto.Categoria = categoria;
            produto.Preco = preco;
            produto.QuantidadeEstoque = quantidade;
            produto.DataCadastro = DateTime.Now;

            //Adicionar lista
            listaProdutos.Add(produto);
        
        }//Fim cadastro produto

        //Começo lista do produto
        public void ListaProduto()
        {
            foreach (var produto in listaProdutos)
            {
                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine($"Id: {produto.Id}");
                Console.WriteLine($"Nome: {produto.Nome}");
                Console.WriteLine($"Categoria: {produto.Categoria}");
                Console.WriteLine($"Preço: {produto.Preco}");
                Console.WriteLine($"Quantidade em estoque: {produto.QuantidadeEstoque}");
                Console.WriteLine($"Data de Cadastro: {produto.DataCadastro}");
                Console.WriteLine("-----------------------------------------------------");
            }
        }// fim lista do produto

        //Começo total preço em estoque
        float precoTotal = 0;

        public void TotalPrecoEstoque(){

            foreach (var preco in listaProdutos)
            {
                precoTotal += (produto.Preco * produto.QuantidadeEstoque);
            }
            Console.Write($"Preço total dos produtos em estoque: {precoTotal}");

        }


    }
}