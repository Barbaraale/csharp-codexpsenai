using System;

namespace Inteira_ou_meia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inteira ou meia entrada");

            Console.Write("\nDigite sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            if(idade < 18 || idade >= 60){
                Console.WriteLine("Meia\n");
            }else{
                Console.WriteLine("Inteira\n");
            }
        }
    }
}
