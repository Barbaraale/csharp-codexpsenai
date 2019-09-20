using System;

namespace Salário
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Acréscimo Salário");

            Console.Write("Digite o salário: R$");
            double salario = float.Parse(Console.ReadLine());

            if(salario < 990){
                double percentual = salario * 0.30;
                salario =  salario + percentual;
                Console.WriteLine($"O salário reajustado fica:{salario}");
            }else{
                 Console.WriteLine("Não receberá acréscimo");
            }

        }
    }
}
