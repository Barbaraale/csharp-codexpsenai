using System;

namespace Idade_semana
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Idade Semana");

            int nascimento, atual;

            Console.WriteLine("Digite seu ano de nascimento");
            nascimento = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o ano atual");
            atual = int.Parse(Console.ReadLine());

            int idade = atual - nascimento;
            int idadesemana = idade * (365 / 7);

            Console.WriteLine($"O resultado é: {idade} anos de idade, e {idadesemana} em semanas");
        }
    }
}
