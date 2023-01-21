using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SetNoModelo;

namespace SortedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDictionary<string, Aluno> alunos = new Dictionary<string, Aluno>();
            
            //adicionando alunos
            alunos.Add("SH", new Aluno("Sherlock Holmes", 231694));
            alunos.Add("MH", new Aluno("Mycroft Holmes", 123456));
            alunos.Add("JM", new Aluno("James Moriarty", 321456));

            Imprimir(alunos);

            //vamos remover: JM
            alunos.Remove("JM");
            //vamos.adicionar: MO
            alunos.Add("IA", new Aluno("Irene Adler", 321488));

            Imprimir(alunos);

            //apresentando nova coleção...SortedList

            IDictionary<string, Aluno> sorted
                    = new SortedList<string, Aluno>();

            sorted.Add("SH", new Aluno("Sherlock Holmes", 231694));
            sorted.Add("MH", new Aluno("Mycroft Holmes", 123456));
            sorted.Add("JM", new Aluno("James Moriarty", 321456));

            Console.WriteLine("Imprimindo SortedList");
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
