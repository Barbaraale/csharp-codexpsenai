using System;
using Atividade_Vingadores.Controllers;

namespace Atividade_Vingadores
{
    class Program
    {
        static void Main(string[] args)
        {
            JogoController jogoController = new JogoController();

            int jogador;
            int acao;

            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n-------------------------------------------------------------");
                Console.WriteLine("\nMenu Principal\n");
                Console.WriteLine("Escolha o Personagem:\n");
                Console.WriteLine("1 - Capitão América");
                Console.WriteLine("2 - Homem de Ferro");
                Console.WriteLine("0 - Sair\n");

                jogador = int.Parse(Console.ReadLine());

                Console.WriteLine("\n-------------------------------------------------------------");

                switch (jogador)
                {
                    case 1:
                        jogoController.CapitaoAmerica();

                        jogoController.ListaCapitãoAmérica();

                        do 
                        {
                            Console.WriteLine("\nEscolha uma ação ou volte ao menu principal\n");
                            Console.WriteLine("1 - Atirar Escudo");
                            Console.WriteLine("2 - Defender com Escudo");
                            Console.WriteLine("0 - Menu Principal\n");

                            acao = int.Parse(Console.ReadLine());

                            switch (acao)
                            {
                                case 1:
                                    Console.Write("\nAtirando o Escudo!\n");
                                    Console.WriteLine("\n-------------------------------------------------------------");
                                break;

                                case 2:
                                    Console.Write("\nDefendendo-se!\n");
                                    Console.WriteLine("\n-------------------------------------------------------------");
                                break;

                                case 0:

                                break;

                                default:
                                    Console.WriteLine("\nOpção inválida! Escolha entre 0 e 2.\n");
                                break;
                            }
                        } while (acao != 0);
                    break;

                    case 2:
                        jogoController.HomemFerro();

                        jogoController.ListaHomemFerro();
                        
                        do
                        {
                            Console.WriteLine("\nEscolha uma ação ou volte ao menu principal\n");
                            Console.WriteLine("1 - Voar");
                            Console.WriteLine("2 - Atirar");
                            Console.WriteLine("0 - Menu Principal\n");

                            acao = int.Parse(Console.ReadLine());

                            switch (acao)
                            {
                                case 1:
                                    Console.Write("\nVoando!\n");
                                    Console.WriteLine("\n-------------------------------------------------------------");
                                break;

                                case 2:
                                    Console.Write("\nAtirando!\n");
                                    Console.WriteLine("\n-------------------------------------------------------------");
                                break;

                                case 0:

                                break;

                                default:
                                    Console.WriteLine("\nOpção inválida! Escolha entre 0 e 2.\n");
                                break;
                            }
                        } while (acao != 0);
                    break;
                    
                    case 0:
                        Console.WriteLine("\nAté a próxima!\n");
                    break;

                    default:
                        System.Console.WriteLine("\nOpção inválida! Escolha entre 0 e 2.\n");
                    break;
                }

            } while (jogador != 0);
        }
    }
}
