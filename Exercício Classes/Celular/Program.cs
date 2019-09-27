using System;
using Celular.Models;

namespace Celular
{
    class Program
    {
        static void Main(string[] args)
        {
        
            CelularModel celular1 = new CelularModel();

            celular1.CadastrarProduto();

            celular1.ListarProduto();

        }
    }
}
