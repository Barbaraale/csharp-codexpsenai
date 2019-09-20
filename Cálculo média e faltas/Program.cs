using System;

namespace Cálculo_média_e_falta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cálculo média e faltas");

            Console.WriteLine("Bem-vindo a Escola SENAI de Informática");

            Console.WriteLine("Digite a primeira nota");
            int nota1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota");
            int nota2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de faltas");
            int faltas = int.Parse(Console.ReadLine());

            float media = (nota1 + nota2) / 2;

            if(media >= 50 && faltas <= 30){
                Console.WriteLine("Aprovado");
            }else{
                Console.WriteLine("Reprovado");
            }
        }
    }
}
