using System;

namespace Média_Escolar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Média Escolar");

            Console.WriteLine("Digite o seu nome");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite a primeira nota");
            float nota1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota");
            float nota2 = float.Parse(Console.ReadLine());

            float media = (nota1 + nota2)/2;   
            
            string resultado;

            if(media>=7){
                resultado = "Aprovado(a)";
            }else{
                resultado = "Reprovado(a)";
            }

            Console.WriteLine($"O(a) aluno(a) {nome} com a média {media} está {resultado}");
        }
    }
}
