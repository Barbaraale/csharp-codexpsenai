using System;

namespace Exercicio_com_for
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício com for");

            string[] nome = new string[2];
            int[] idade = new int[2];
            float[] peso = new float[2];
            float[] altura = new float[2];
            string[] sexo = new string[2];
            int masculino = 0;
            int feminino = 0;
            int idadeMas = 0;
            int idadeFem = 0;


            for(int i = 0; i < 2; i++){

                Console.WriteLine($"{i+1}ª pessoa");

                Console.WriteLine($"Digite o {i+1}º nome");
                nome[i] = Console.ReadLine();
                
                Console.WriteLine($"Digite a {i+1}ª idade");
                idade[i] = int.Parse(Console.ReadLine());

                Console.WriteLine($"Digite o {i+1}º peso");
                peso[i] = float.Parse(Console.ReadLine());

                Console.WriteLine($"Digite o {i+1}ª altura");
                altura[i] = float.Parse(Console.ReadLine());

                Console.WriteLine($"Digite o {i+1}º sexo (masculino/feminino)");
                sexo[i] = Console.ReadLine();

                if(i == masculino){
                    masculino++;
                }else{
                    feminino++;
                }

            }

            Console.WriteLine($"Quant h: {masculino}, quant. f: {feminino}, h: {idadeMas}  f:{idadeFem}");
        }
    }
}
