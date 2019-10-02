using System;
using Atividade_Vingadores.Models;

namespace Atividade_Vingadores.Controllers
{
    public class JogoController
    {
      
            string equipe = "Vingadores";
            
            string vida = "3";
            
        public void CapitaoAmerica(){

            string escudo = "Escudo";
            string cor = "Azul";

            CapitaoAmericaModel capitaoAmerica = new CapitaoAmericaModel();
            
            capitaoAmerica.Equipe = equipe;
            capitaoAmerica.Vida = vida;
            capitaoAmerica.Escudo = escudo;
            capitaoAmerica.Cor = cor;

            Console.WriteLine("\nCapitão América:");
            Console.WriteLine($"Equipe: {capitaoAmerica.Equipe}");
            Console.WriteLine($"Vida: {capitaoAmerica.Vida}");
            Console.WriteLine($"Objeto de Defesa: {capitaoAmerica.Escudo}");
            Console.WriteLine($"Cor: {capitaoAmerica.Cor}");

            
        }

        public void HomemFerro(){

            string armadura = "Armadura";
            string cor = "Vermelho";

            HomemFerroModel homemFerro = new HomemFerroModel();
                       
            homemFerro.Equipe = equipe;
            homemFerro.Vida = vida;
            homemFerro.Armadura = armadura;
            homemFerro.Cor = cor;

            Console.WriteLine("\nHomem de Ferro:");
            Console.WriteLine($"Equipe: {homemFerro.Equipe}");
            Console.WriteLine($"Vida: {homemFerro.Vida}");
            Console.WriteLine($"Objeto de Defesa: {homemFerro.Armadura}");
            Console.WriteLine($"Cor: {homemFerro.Cor}");

            
            
        }
    }
}