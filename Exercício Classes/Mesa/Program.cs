using System;
using Mesa.Models;

namespace Mesa
{
    class Program
    {
        static void Main(string[] args)
        {
            MesaModel mesa1 = new MesaModel();

            mesa1.CadastrarProduto();

            mesa1.ListarProdutos();
            
            
        }
    }
}
