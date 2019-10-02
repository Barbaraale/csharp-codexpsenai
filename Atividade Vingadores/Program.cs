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
                Console.WriteLine("\nEscolha o Personagem:");
                Console.WriteLine("1 - Capitão América");
                Console.WriteLine("2 - Homem de Ferro");
                Console.WriteLine("0 - Sair\n");

                jogador = int.Parse(Console.ReadLine());

                switch (jogador)
                {
                    case 1:
                        jogoController.CapitaoAmerica();

                        do
                        {
                            Console.WriteLine("\nEscolha a ação:");
                            Console.WriteLine("1 - Atirar Escudo");
                            Console.WriteLine("2 - Defender com Escudo");
                            Console.WriteLine("0 - Sair");

                            acao = int.Parse(Console.ReadLine());

                            switch (acao)
                            {
                                case 1:
                                    Console.Write("Atirando o Escudo!");
                                break;

                                case 2:
                                    Console.Write("Defendendo-se!");
                                break;

                                case 0:
                                break;

                                default:
                                    Console.WriteLine("Opção Inválida");
                                break;
                            }
                        } while (acao != 2);
                    break;

                    case 2:
                        jogoController.HomemFerro();
                        
                        do
                        {
                            Console.WriteLine("\nEscolha a ação:");
                            Console.WriteLine("1 - Voar");
                            Console.WriteLine("2 - Atirar");
                            Console.WriteLine("0 - Sair");

                            acao = int.Parse(Console.ReadLine());

                            switch (acao)
                            {
                                case 1:
                                    Console.Write("Voando!");
                                break;

                                case 2:
                                    Console.Write("Atirando!");
                                break;

                                default:
                                    Console.WriteLine("Opção Inválida");
                                break;
                            }
                        } while (acao != 2);
                    break;
                    
                    case 0:
                        Console.WriteLine("Obrigada por jogar!");
                    break;

                    default:
                        System.Console.WriteLine("Opção inválida! Escolha de 0 a 2");
                    break;
                }

            } while (jogador != 0);
        }
    }
}
