using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ISet<string> alunos = new SortedSet<string>(new ComparadorMinusculo()) 
            { 
                "Sherlock Holmes",
                "Mycroft Holmes",
                "Irene Adler",
                "James Moriarty"
            };

            Console.WriteLine("Imprimindo SortedSet\n");
            Imprimir(alunos);

            alunos.Add("John Watson");
            alunos.Add("Irene Adler");
            alunos.Add("Irene ADLER");
            alunos.Add("Mary Morstar");
            alunos.Add("Martha Hudson");

            Imprimir(alunos);


            Console.ReadLine();
        }
        private static void Imprimir(ISet<string> alunos)
        {
            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }

            Console.WriteLine();
        }
    }
}
