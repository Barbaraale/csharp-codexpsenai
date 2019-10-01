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
                Console.WriteLine(" \n 1 - Cadastrar Usuários");
                Console.WriteLine(" 2 - Listar Usuários");
                Console.WriteLine(" 3 - Autenticação");
                Console.WriteLine(" 0 - Sair\n");

                opcao = int.Parse(Console.ReadLine());

            

                switch (opcao)
                {
                    case 1:
                        //Cadastrar
                        usuarioController.CadastroUsuario();
                    break;

                    case 2:
                        //Listar
                        usuarioController.ListarUsuarios();
                    break;

                    case 3:
                        //Autenticação Email e Senha
                        bool usuarioRetornado = usuarioController.Logar();
                        if (usuarioRetornado)// se o usuário encontrado for verdadeiro
                        {
                            Console.WriteLine("\nUsuário encontrado");
                        }else{
                            Console.WriteLine("\nUsuário não encontrado");
                        }
                    break;

                    case 0:
                        //Sair
                        Console.WriteLine("Tchau");
                    break;

                    default:
                        Console.WriteLine("Opcão Inválida");
                    break;
                    
                }

            } while (opcao != 0);

        }
    }
}
