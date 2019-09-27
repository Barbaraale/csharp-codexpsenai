using System;
using Exercício_Classe___Mouse.Models;

namespace Mouse
{
    class Program
    {
        static void Main(string[] args)
        {
            MouseModel mouse1 = new MouseModel();

            mouse1.CadastrarProduto();

            mouse1.ListarProdutos();
            
        }
    }
}
