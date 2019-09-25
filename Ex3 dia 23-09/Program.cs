using System;

namespace Ex3_dia_23_09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 3 - 23/09");

            int idade = 0;
            int contador = 0;
            int maiores = 0;
            int menores = 0;

            while (contador < 10)
            {
                Console.WriteLine($"Digite a {contador+1}ª idade");
                idade = int.Parse(Console.ReadLine());
               
                contador++;

                if(idade >= 18){
                    maiores++;
                }else{
                    menores++;
                }
            } 

            Console.WriteLine($"Pessoas maiores de idade: {maiores}");
            Console.WriteLine($"Pessoas menores de idade: {menores}");
        }
    }
}
