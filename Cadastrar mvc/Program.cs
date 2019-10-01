using System;
using Cadastrar_mvc.Controllers;
using Cadastrar_mvc.Models;

namespace Cadastrar_mvc
{
    /// <summary>
    /// Cadastro de usuário usando lista e csv
    /// E autenticação
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            UsuarioController usuarioController = new UsuarioController();

            int opcao = 0;
            do
            {
                Console.WriteLine(" 1 - Cadastrar Usuários");
                Console.WriteLine(" 2 - Listar Usuários");
                Console.WriteLine(" 0 - Sair");

            } while (opcao != 0);

            switch (opcao)
            {
                case 1:
                    //Cadastrar
                break;

                case 2:
                    //Listar
                break;

                case 0:
                    //Sair
                    Console.WriteLine("Tchau");
                break;

                default:
                    Console.WriteLine("Opcão Inválida");
                break;
            }

            
        }
    }
}
