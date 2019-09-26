using System;

namespace Aprendendo_Função
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TemaAula());


            Console.WriteLine("Digite o primeiro número");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número");
            int numero2 = int.Parse(Console.ReadLine());


            int resultadoDaSoma = SomaDeDoisNumeros(numero1, numero2);
            Console.WriteLine($"O resultado da soma é: {resultadoDaSoma}");


           

        }//fim do main

        //funções

        /// <sumary>Efetua a soma de dois números</sumery> 
        /// <param name="a"> Primeiro valor inteiro</param>
        /// <param name="b"> Segundo valor inteiro</param>
        /// <returns> Retorna a soma dos dois números</returns>
        public static int SomaDeDoisNumeros(int a, int b)
        {
            int soma = a + b;
            return soma;
        }

        
        /// <sumary>Efetua a soma de dois números</sumery> 
        public static string TemaAula()
        {
            return "Aprendendo Função";
        }
    }
}
