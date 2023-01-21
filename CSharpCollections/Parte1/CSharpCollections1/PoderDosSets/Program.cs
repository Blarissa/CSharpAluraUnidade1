using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoderDosSets
{
    public class Program
    {
        static void Main(string[] args)
        {
            //declarando set de alunos
            ISet<string> alunos = new HashSet<string>();

            alunos.Add("Sherlock Holmes");
            alunos.Add("Mycroft Holmes");
            alunos.Add("James Moriarty");

            Console.WriteLine($"Mostrando Set após inserir dados\n" + 
                              $"{string.Join(",", alunos)}\n");

            alunos.Add("John Watson");
            alunos.Add("Irene Adler");
            alunos.Add("Mary Morstar");
            alunos.Add("Martha Hudson");

            Console.WriteLine($"Mostrando Set após inserir mais dados\n" + 
                              $"{string.Join(",", alunos)} \n");

            alunos.Remove("John Watson");
            alunos.Add("Greg Lestrade");

            Console.WriteLine($"Mostrando Set após remover dado e inserir outro\n" +
                              $"{string.Join(",", alunos)} \n");

            //Sem duplicidade de dados
            alunos.Add("Greg Lestrade");

            Console.WriteLine($"Mostrando Set após inserir dado já inserido\n" +
                              $"{string.Join(",", alunos)}\n");

            //Ordenando Set
            List<string> listaAlunos = new List<string>(alunos);
            listaAlunos.Sort();

            Console.WriteLine($"Set ordenado\n" +
                              $"{string.Join(",",listaAlunos)} \n");

            Console.ReadLine();
        }

    }
}
