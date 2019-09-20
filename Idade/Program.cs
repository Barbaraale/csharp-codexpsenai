using System;

namespace Idade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Idade");

            int idade;

        Console.WriteLine("Digite sua idade");
        idade = int.Parse(Console.ReadLine());

        int meses = idade * 12;
        int dias = idade * 365;
        int horas = dias * 24;
        int minutos = horas * 60;

        Console.WriteLine($"O resultado é: {meses} meses");
        Console.WriteLine($"O resultado é: {dias} dias");
        Console.WriteLine($"O resultado é: {horas} horas");
        Console.WriteLine($"O resultado é: {minutos} minutos");
        

        }
    }
}
