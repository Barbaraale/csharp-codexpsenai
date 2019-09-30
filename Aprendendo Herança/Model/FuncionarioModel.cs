using System;
namespace Aprendendo_Herança.Model

{
    public class FuncionarioModel : PessoaModel
    {
        public string Cargo { get; set; }

        public void Trabalhar(){
            Console.WriteLine("Agora vamos trabalhar!");
        }

        public void CadastrarFuncionario(){
            
            Console.Write("Digite o nome do funcionário: ");
            Nome = Console.ReadLine();

            Console.Write("Digite a idade do funcionário: ");
            Idade = int.Parse(Console.ReadLine());

            Console.Write("Digite o cargo do funcionário: ");
            Cargo = Console.ReadLine();
        }

    }
}