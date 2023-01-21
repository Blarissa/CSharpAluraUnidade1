using SetNoModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDictionary<string, Aluno> sorted
                        = new SortedDictionary<string, Aluno>();

            sorted.Add("SH", new Aluno("Sherlock Holmes", 231694));
            sorted.Add("MH", new Aluno("Mycroft Holmes", 123456));
            sorted.Add("JM", new Aluno("James Moriarty", 321456));

            Console.WriteLine("Imprimindo SortedDictionary\n");
            Imprimir(sorted);

            // vamos remover: JM
            sorted.Remove("JM");
            //vamos.adicionar: MO
            sorted.Add("IA", new Aluno("Irene Adler", 321488));

            Imprimir(sorted);

            Console.ReadLine();
        }

        private static void Imprimir(IDictionary<string, Aluno> alunos)
        {
            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }

            Console.WriteLine();
        } 
    
    }
}
