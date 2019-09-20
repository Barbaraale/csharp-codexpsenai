using System;

namespace Cálculos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cálculos");

            Console.Write("\nDigite o primeiro número: ");
            float n1 = float.Parse(Console.ReadLine());

            Console.Write("\nDigite o segundo número: ");
            float n2 = float.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite a letra para efetuar o cálculo");
            Console.WriteLine("( a ) - Soma de dois números");
            Console.WriteLine("( b ) - Subtração do primeiro pelo segundo");
            Console.WriteLine("( c ) - Subtração do segundo pelo primeiro");
            Console.WriteLine("( d ) - Multiplicação dos dois números");
            Console.WriteLine("( e ) - Divisão do primeiro pelo segundo");
            Console.WriteLine("( f ) - Divisão do segundo pelo primeiro\n");
            
            string resposta = Console.ReadLine();

            float resultado;

            switch(resposta){
                case "a":
                    resultado = n1 + n2;
                    Console.WriteLine($"O resultado é: {resultado}\n");
                break;

                case "b":
                    resultado = n1 - n2;
                    Console.WriteLine($"O resultado é: {resultado}\n");
                break;

                case "c":
                    resultado = n2 - n1;
                    Console.WriteLine($"O resultado é: {resultado}\n");
                break;

                case "d":
                    resultado = n1 * n2;
                    Console.WriteLine($"O resultado é: {resultado}\n");
                break;

                case "e":
                    resultado = n1 / n2;
                    if(n2 == 0){
                        Console.WriteLine("Cálculo inválido\n");
                    }else{
                        Console.WriteLine($"O resultado é: {resultado}\n");
                    }
                break;

                case "f":
                    resultado = n2 / n1;
                    if(n1 == 0){
                        Console.WriteLine("Cálculo inválido\n");
                    }else{
                        Console.WriteLine($"O resultado é: {resultado}\n");
                    }
                break;

                default:
                    Console.WriteLine("Inválido, digite um valor de 'a' a 'e'");
                break;
            }
        }
    }
}
