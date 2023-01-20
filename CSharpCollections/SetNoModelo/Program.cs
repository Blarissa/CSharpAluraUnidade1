using CSharpCollections;
using ListaSomenteLeitura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetNoModelo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Curso csharpColecoes = new Curso("C# Coleções","Charles Xavier");

            //Adicionando aulas
            csharpColecoes.Adiciona(new Aula("Trabalhando com Listas", 21));
            csharpColecoes.Adiciona(new Aula("Criando uma Aula", 20));
            csharpColecoes.Adiciona(new Aula("Modelando com Coleções", 24));

            Aluno a1 = new Aluno("Sherlock Holmes", 231694);
            Aluno a2 = new Aluno("Mycroft Holmes", 123456);
            Aluno a3 = new Aluno("James Moriarty", 321456);

            csharpColecoes.Matricula(a1);
            csharpColecoes.Matricula(a2);
            csharpColecoes.Matricula(a3);

            Console.WriteLine("Alunos matriculados");

            foreach (var aluno in csharpColecoes.Alunos)
            {
                Console.WriteLine(aluno);
            }

            Console.ReadLine();
        }
    }
}
