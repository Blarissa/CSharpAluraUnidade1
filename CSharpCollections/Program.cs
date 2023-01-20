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
            string aulaIntro = "Introdução às Coleções.";
            string aulaModelando = "Modelando a Classe Aula.";
            string aulaSets = "Trabalhando com Conjuntos.";

            List<string> aulas = new List<string>
            {
                aulaIntro, aulaModelando, aulaSets
            };
            
            Imprimir(aulas);

            

            Console.ReadLine();
        }

        private static void Imprimir(List<string> aulas)
        {
            foreach (var aula in aulas)
                Console.WriteLine(aula);
            Console.WriteLine();
        }
    }
}
