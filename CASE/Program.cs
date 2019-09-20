using System;

namespace CASE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CASE");

            Console.Write("\nDigite o nome: ");
            string nome = Console.ReadLine();
            
            Console.Write("\nDigite o sálario: ");
            double salario = float.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite o código correspondente ao cargo");
            Console.WriteLine("( 1 ) - Escrituário");
            Console.WriteLine("( 2 ) - Secretário");
            Console.WriteLine("( 3 ) - Caixa");
            Console.WriteLine("( 4 ) - Gerente");
            Console.WriteLine("( 5 ) - Diretor\n");

            string codigo = Console.ReadLine();

            double percentual;
            double reajuste;

            switch(codigo){
                case "1":
                    percentual = salario * 0.50;
                    reajuste = salario + percentual;
                    Console.WriteLine($"\nNome: {nome}");
                    Console.WriteLine($"Sálario: {salario}");
                    Console.WriteLine($"Código do cargo: {codigo}");
                    Console.WriteLine($"Acréscimo: {percentual}");
                    Console.WriteLine($"Sálario reajustado: {reajuste}");

                break;

                case "2":
                    percentual = salario * 0.35;
                    reajuste = salario + percentual;
                    Console.WriteLine($"\nNome: {nome}");
                    Console.WriteLine($"Sálario: {salario}");
                    Console.WriteLine($"Código do cargo: {codigo}");
                    Console.WriteLine($"Acréscimo: {percentual}");
                    Console.WriteLine($"Sálario reajustado: {reajuste}");
                break;

                case "3":
                    percentual = salario * 0.20;
                    reajuste = salario + percentual;
                    Console.WriteLine($"\nNome: {nome}");
                    Console.WriteLine($"Sálario: {salario}");
                    Console.WriteLine($"Código do cargo: {codigo}");
                    Console.WriteLine($"Acréscimo: {percentual}");
                    Console.WriteLine($"Sálario reajustado: {reajuste}");
                break;

                case "4":
                    percentual = salario * 0.10;
                    reajuste = salario + percentual;
                    Console.WriteLine($"\nNome: {nome}");
                    Console.WriteLine($"Sálario: {salario}");
                    Console.WriteLine($"Código do cargo: {codigo}");
                    Console.WriteLine($"Acréscimo: {percentual}");
                    Console.WriteLine($"Sálario reajustado: {reajuste}");
                break;

                case "5":
                    Console.WriteLine($"Nome: {nome}");
                    Console.WriteLine($"Sálario: {salario}");
                    Console.WriteLine($"Código do cargo: {codigo}");
                    Console.WriteLine("Acréscimo: Não tem aumento");
                    Console.WriteLine($"Sálario reajustado: {salario}");
                break;

                default:
                    Console.WriteLine("\nDigite um valor entre 1 e 5");
                break;
            }


        }
    }
}
