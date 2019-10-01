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

            Console.Write("\nDigite seu E-mail: ");
            string email = Console.ReadLine();

            Console.Write("\nDigite sua Senha: ");     
            string senha = Console.ReadLine();

            //Instanciando um novo usuário
            UsuarioModel usuario = new UsuarioModel();

            //Populando o objeto
            usuario.Id = 1;
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
                Console.WriteLine($@"
                ------------------------------------
                Usuário: {usuario.Nome}
                Id: {usuario.Id}
                E-mail: {usuario.Email}
                Data do Cadastro: {usuario.DataCriacao}
                ------------------------------------
                ");
            }
        }

        
    }
}