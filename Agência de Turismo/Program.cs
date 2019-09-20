using System;

namespace Agência_de_Turismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Agência de Turismo");

            string[] nome = new string[5];
            string[] origem = new string[5];
            string[] destino = new string[5];
            DateTime[] data = new DateTime[5];
        
            int opcao = 0, i = 0, j = 0;

            do{

                Console.WriteLine("\nSelecione uma Opção");
                Console.WriteLine("1 - Cadastrar passagem");
                Console.WriteLine("2 - Listar passagem");
                Console.WriteLine("0 - Sair\n");
                opcao = int.Parse(Console.ReadLine());

                switch(opcao){
                    case 1:
                        string resposta = "";

                        do
                        {
                            if(i <= 2){
                            Console.WriteLine("\n---------------------------------------------");
                            Console.Write("\nDigite o nome do passageiro: ");
                            nome[i] = Console.ReadLine();

                            Console.Write("\nDigite a origem: ");
                            origem[i] = Console.ReadLine();

                            Console.Write("\nDigite o destino: ");
                            destino[i] = Console.ReadLine();

                            Console.Write("\nDigite a data: ");
                            data[i] = DateTime.Parse(Console.ReadLine());

                            Console.Write("\nVocê deseja cadastrar mais um? (S/N): ");
                            resposta = Console.ReadLine();
                            }

                            else{
                                Console.WriteLine("Número de passagens excedida");
                                break;
                            }
                            i++;
                        }while(resposta == "S");
                    
                    break;

                    case 2:
                        
                        Console.WriteLine("\n---------------------------------------------");
                        Console.WriteLine("\nListando as passagens\n");

                        while( j < 2){
                            Console.WriteLine($"Nome do passageiro: {nome[j]}   Origem: {origem[j]}   Destino {destino[j]}   Data {data[j]}\n");
                            j++;
                        }

                    break;

                    case 0:
                        Console.WriteLine("\nObrigado por usar nosso sistema!\n");
                    break;

                    default:
                        Console.WriteLine("\nOpção inválida\n");
                    break;
                } 
            
            }while(opcao != 0);       
             
               
        }
    }
}
