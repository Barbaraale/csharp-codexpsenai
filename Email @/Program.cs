using System;

namespace Email__
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Validação com Do While");

        string email;

        do{
            Console.WriteLine("Digite o email");
            email = Console.ReadLine();
        }while(!email.Contains("@") || !email.Contains("."));

        string senha;

        do{
            Console.WriteLine("Digite a senha");
            senha = Console.ReadLine();
        }while(senha.Length <= 6);
        

        }
    }
}
