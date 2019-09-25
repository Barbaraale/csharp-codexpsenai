using System;

namespace PesquisaIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] nome = new string[2];
            int[] idade = new int[2];
            double[] peso = new double[2];
            double[] altura = new double[2];
            string[] sexo = new string[2];
            int quantidadeM = 0;
            int quantidadeF = 0;
            int opcao;
            int somaIdadeM = 0;
            int somaIdadeF = 0;
            
            for(int i = 0; i < 2; i++)
            {
                Console.WriteLine("Digite o nome:");
                nome[i] = Console.ReadLine();
                Console.WriteLine("Digite a idade");
                idade[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o Peso");
                peso[i] = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite a altura");
                altura[i] = double.Parse(Console.ReadLine());
                            
                do
                {
                 Console.WriteLine("Qual seu Sexo");
                 Console.WriteLine("Selecione uma das opções:");
                 Console.WriteLine("1 - Masculino");
                 Console.WriteLine("2 - Feminino");
                 opcao = int.Parse(Console.ReadLine());

                 switch (opcao)
                 {
                     case 1:
                       sexo[i] = "M";
                       somaIdadeM += idade[i];
                     break;
                     case 2:
                        sexo[i] = "F";
                        somaIdadeF += idade[i];
                     break;
                     default:
                     Console.WriteLine("Opção Inválida digite 1 ou 2");
                     break;
                 }
                } while (opcao != 1 && opcao != 2);
                if(sexo[i] == "M"){
                    quantidadeM++;

                }else{
                    quantidadeF++;
                }
            }//fim do for

            Console.WriteLine($"O total de homens é de:{quantidadeM} e o total de Mulheres é de: {quantidadeF}");
            Console.WriteLine($"A Média de idade dos homens é de {somaIdadeM/quantidadeM} e das mulheres é de {somaIdadeF/quantidadeF}");

            for(int i = 0; i < 2; i++){
                Console.WriteLine($"Nome: {nome[i]}, sexo: {sexo[i]} possui o imc:{peso[i]/(altura[i]*altura[i])}");
            }    

        }
    }
}
