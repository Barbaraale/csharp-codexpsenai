using System;
using System.Collections.Generic;
using Cadastrar_mvc.Models;

namespace Cadastrar_mvc.Controllers
{
    public class UsuarioController
    {
        List<UsuarioModel> listaDeUsuarios = new List<UsuarioModel>();

        /// <summary>
        /// Método para cadastro de usuários
        /// </summary>
        public void CadastroUsuario()
        {

            Console.WriteLine("\nVamos Cadastrar");

            Console.Write("\nDigite seu Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite seu E-mail: ");
            string email = Console.ReadLine();

            Console.Write("Digite sua Senha: ");     
            string senha = Console.ReadLine();

            //Instanciando um novo usuário
            UsuarioModel usuario = new UsuarioModel();

            //Populando o objeto
            usuario.Id = listaDeUsuarios.Count + 1;
            usuario.Nome = nome;
            usuario.Email = email;
            usuario.Senha = senha;
            usuario.DataCriacao = DateTime.Now;

            listaDeUsuarios.Add(usuario);

        }//fim CadastroUsuario

        public void ListarUsuarios()
        {
            foreach (var usuario in listaDeUsuarios)
            {

                Console.WriteLine("----------------------------------------");
                Console.WriteLine($"Usuário: {usuario.Nome}");
                Console.WriteLine($"Id: {usuario.Id}");
                Console.WriteLine($"E-mail: {usuario.Email}");
                Console.WriteLine($"E-mail: {usuario.Email}");
                Console.WriteLine($"Data do Cadastro: {usuario.DataCriacao}");
                Console.WriteLine("----------------------------------------");
                
            }

        }// fim listar usuários

        public bool Logar()
        {
            Console.Write("\nInsira o E-mail: ");
            string email = Console.ReadLine();
            
            Console.Write("Insira sua Senha: ");
            string senha = Console.ReadLine();

            foreach (var usuario in listaDeUsuarios)
            {
                if (usuario.Email == email && usuario.Senha == senha)
                {
                    return true;
                }
            }//fim foreach

            return false;
            
        }//fim Logar
    }
}