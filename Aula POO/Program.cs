using System;
using Aula_POO.Models;

namespace Aula_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            AlunoModel aluno1 = new AlunoModel();

            Console.Clear();

            System.Console.Write("\nInsira o nome do aluno: ");
            aluno1.Nome = Console.ReadLine();

            System.Console.Write("\nInsira o curso do aluno: ");
            aluno1.Curso = Console.ReadLine();

            System.Console.Write("\nInsira o documento (RG) do aluno: ");
            aluno1.Rg = int.Parse(Console.ReadLine());
            
            System.Console.Write("\nInsira a idade do aluno: ");
            aluno1.Idade = int.Parse(Console.ReadLine());

            System.Console.Write($@"
            Nome: {aluno1.Nome}
            Curso: {aluno1.Curso}
            Documento: {aluno1.Rg}
            Idade: {aluno1.Idade}
            ");
            

        }
    }
}
