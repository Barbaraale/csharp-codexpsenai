using System;

namespace Ex4_dia_23_09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 4 - 23/09");

            int contador = 0;
            float[] nota1 = new float[2];
            float[] nota2 = new float[2];
            float[] media = new float[2];
            int aprovados = 0;
            int reprovados = 0;
            
            do
            {
                Console.WriteLine($"{contador+1}º aluno");

                Console.WriteLine($"Digite a primeira nota");
                nota1[contador] = float.Parse(Console.ReadLine());

                Console.WriteLine($"Digite a segunda nota");
                nota2[contador] = float.Parse(Console.ReadLine());

                media[contador] = (nota1[contador] + nota2[contador])/2;

                if(media[contador] >= 7){
                    aprovados++;
                }else{
                    reprovados++;
                }

                contador++;
                
            } while (contador < 2);

            int contadorB = 0;
            double somaMedia = 0;

            while (contadorB < 2)
            {
                somaMedia = somaMedia + media[contadorB];
                contadorB++;
            }

            Console.WriteLine($"A quantidade de aprovados é: {aprovados}, a de reprovado é: {reprovados}, e a média da sala é: {somaMedia}");
            
           



        }
    }
}
