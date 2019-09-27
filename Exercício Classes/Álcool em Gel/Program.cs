using System;
using Álcool_em_Gel.Models;

namespace Álcool_em_Gel
{
    class Program
    {
        static void Main(string[] args)
        {
        
            AlcoolGelModel alcool1 = new AlcoolGelModel();
            
            alcool1.CadastrarProduto();

            alcool1.ListarProdutos();

        }
    }
}
