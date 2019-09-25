using System;

namespace ForEach_Exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ForEach Exemplo");

            string[] nomes = new string[10];
            nomes[0] = "Carlos";
            nomes[1] = "Ronaldo";

            foreach (var nome in nomes)
            {
                if(!string.IsNullOrEmpty(nome)){
                    Console.WriteLine(nome);
                }
                    
            }

            int[] numeros = new int[10];
            numeros[0] = 100;
            numeros[1] = 200;

            foreach (var numero in numeros)
            {
                if(numero != 0 ){
                    Console.WriteLine(numero);
                }
            }

        }
    }
}
