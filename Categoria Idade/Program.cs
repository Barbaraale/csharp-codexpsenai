using System;

namespace Categoria_Idade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Categoria por idade");

            Console.WriteLine("Digite sua idade");
            int idade = int.Parse(Console.ReadLine());

            if(idade <= 7){
                Console.WriteLine("Infantil A");
            }else if(idade <= 10){
                Console.WriteLine("Infantil B");
            }else if(idade <= 13){
                Console.WriteLine("Juvenil A");
            }else if(idade <= 17){
                Console.WriteLine("Juvenil B");
            }else{
                Console.WriteLine("Adulto");
            }


        }
    }
}
