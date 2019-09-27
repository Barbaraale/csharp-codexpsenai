using System;
using Conta_Bancária.Models;

namespace Conta_Bancária
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancariaModel conta1 = new ContaBancariaModel();

            conta1.CadastrarConta();

            conta1.ListarConta();
            
        }
    }
}
