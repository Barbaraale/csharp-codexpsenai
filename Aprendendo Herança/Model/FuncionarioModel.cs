using System;
using System.Collections.Generic;

namespace Aprendendo_Herança.Model

{
    public class FuncionarioModel : PessoaModel
    {
        public string Cargo { get; set; }

        

        public void Trabalhar(){
            Console.WriteLine("Agora vamos trabalhar!");
        }

        public FuncionarioModel CadastrarFuncionario(){

            FuncionarioModel funcionario = new FuncionarioModel();
            
            Console.Write("Digite o nome do funcionário: ");
            funcionario.Nome = Console.ReadLine();

            Console.Write("Digite a idade do funcionário: ");
            funcionario.Idade = int.Parse(Console.ReadLine());

            Console.Write("Digite o cargo do funcionário: ");
            funcionario.Cargo = Console.ReadLine();

            return funcionario;
        }

    }
}