using System;
using Atividade_Vingadores.Models;

namespace Atividade_Vingadores.Controllers
{
    public class JogoController
    {
      
            string equipe = "Vingadores";
            
            string vida = "3";

            HomemFerroModel homemFerro = new HomemFerroModel();

            CapitaoAmericaModel capitaoAmerica = new CapitaoAmericaModel();
            
            public void CapitaoAmerica(){

                string cor = "Azul";

                capitaoAmerica.Equipe = equipe;
                capitaoAmerica.Vida = vida;
                capitaoAmerica.Cor = cor;

                Console.Write("\nO Capitão América está com escudo? (true ou false): ");
                bool escudo = bool.Parse(Console.ReadLine());
            
                if (escudo)
                {
                    Console.WriteLine("\nEle está com o escudo!");
                    Console.WriteLine("\n-------------------------------------------------------------");
                }else{
                    Console.WriteLine("\nEle não está com escudo!");
                    Console.WriteLine("\n-------------------------------------------------------------");
                }

                capitaoAmerica.Escudo = escudo;
        
            }

            public void ListaCapitãoAmérica(){

                // System.Console.Write("\nListar informações do personagem? (true ou false): ");
                // bool lista = bool.Parse(Console.ReadLine());

                // if (lista)
                // {
                
                    Console.WriteLine("\nInformações do Personagem\n");
                    Console.WriteLine("Capitão América:");
                    Console.WriteLine($"Equipe: {capitaoAmerica.Equipe}");
                    Console.WriteLine($"Vida: {capitaoAmerica.Vida}");
                    Console.WriteLine($"Escudo: {capitaoAmerica.Escudo}");
                    Console.WriteLine($"Cor: {capitaoAmerica.Cor}");
                    Console.WriteLine("\n-------------------------------------------------------------");

                // }else{

                // }
            
            }



            public void HomemFerro(){

                string cor = "Vermelho";

                homemFerro.Equipe = equipe;
                homemFerro.Vida = vida;
                homemFerro.Cor = cor;
            
                Console.Write("\nO Homem de Ferro está com a armadura? (true ou false): ");
                bool armadura = bool.Parse(Console.ReadLine());

                if (armadura)
                {
                    Console.WriteLine("\nEle está com armadura!");
                    Console.WriteLine("\n-------------------------------------------------------------");
                }else{
                    Console.WriteLine("\nEle não está com armadura!");
                    Console.WriteLine("\n-------------------------------------------------------------");
                }

                homemFerro.Armadura = armadura;

            }
        
            public void ListaHomemFerro(){
                
                Console.WriteLine("\nInformações do Personagem\n");
                Console.WriteLine("\nHomem de Ferro:");
                Console.WriteLine($"Equipe: {homemFerro.Equipe}");
                Console.WriteLine($"Vida: {homemFerro.Vida}");
                Console.WriteLine($"Armadura: {homemFerro.Armadura}");
                Console.WriteLine($"Cor: {homemFerro.Cor}");
                Console.WriteLine("\n-------------------------------------------------------------");

            }
    }
}   