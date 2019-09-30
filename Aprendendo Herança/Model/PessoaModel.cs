using System;
namespace Aprendendo_Herança.Model

{
    public class PessoaModel
    {
        public string Nome { get; set; }

        public int Idade { get; set; }

        public void Comer(){
           Console.WriteLine("Bora Comer");
        }

        public void Andar(){
            Console.WriteLine("Bora Andar");
        }

        public void Dormir(){
            Console.WriteLine("Bora Dormir");
        }
    }
}