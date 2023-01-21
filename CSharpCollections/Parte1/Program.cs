using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCollections
{
    public class Program
    {
        static void Main(string[] args)
        {
            var aulaIntro = new Aula("Introdução às Coleções.", 20);
            var aulaModelando = new Aula("Modelando a Classe Aula.", 18);
            var aulaSets = new Aula("Trabalhando com Conjuntos.", 16);

            List<Aula> aulas = new List<Aula>();
            aulas.Add(aulaIntro);
            aulas.Add(aulaModelando);
            aulas.Add(aulaSets);

            Imprimir(aulas);

            aulas.Sort();
            Imprimir(aulas);

            aulas.Sort((este, outro) => este.Tempo.CompareTo(outro.Tempo));
            Imprimir(aulas);

            Console.ReadLine();
        }

        private static void Imprimir(List<Aula> aulas)
        {
            Console.Clear();

            foreach (var aula in aulas)
            {
                Console.WriteLine(aula);
            }

            Console.WriteLine();
        }
    }
}
