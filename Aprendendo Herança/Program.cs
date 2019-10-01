using System;
using System.Collections.Generic;
using Aprendendo_Herança.Model;

namespace Aprendendo_Herança
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aprendendo Herança");

            List<FuncionarioModel> listaDeFuncionarios = new List<FuncionarioModel>(); 

            int opcao;
            
            FuncionarioModel funcionario = new FuncionarioModel();

            do
            {
                Console.WriteLine("\nEscolha uma opção: ");
                Console.WriteLine("1 - Cadastrar Funcionários");
                Console.WriteLine("2 - Executar Ações");
                Console.WriteLine("0 - Sair\n");
                
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        //Cadastrar
                        FuncionarioModel fun = funcionario.CadastrarFuncionario();
                        listaDeFuncionarios.Add(fun);

                        foreach (var func in listaDeFuncionarios)
                        {
                            Console.WriteLine($"Funcionário: {func.Nome}, Cargo: {func.Cargo}");
                        }
                    break;

                    case 2:
                        //Executar
                        int acao = 0;

                        do
                        {
                            Console.WriteLine($"Selecione uma ação para {funcionario.Nome}");
                            Console.WriteLine("1 - Andar");
                            Console.WriteLine("2 - Comer");
                            Console.WriteLine("3 - Trabalhar");
                            Console.WriteLine("0 - Sair");

                            acao = int.Parse(Console.ReadLine());

                            switch (acao)
                            {
                                case 1:
                                    funcionario.Andar();
                                break;

                                case 2:
                                    funcionario.Comer();
                                break;

                                case 3:
                                    funcionario.Trabalhar();
                                break;

                                case 0:
                                    Console.WriteLine("Tchau!");
                                break;

                                default:
                                    Console.WriteLine("Opção inválida!");
                                break;
                                
                            }

                        } while (acao != 0);
                    break;

                    case 0:
                        //Sair
                        
                    break;

                    default:
                        //Diferente de 1,2 e 0

                    break;
                }

            } while (opcao != 0);
        }
    }
}
