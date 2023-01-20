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

            string[] aulas = new string[]
            {
                aulaIntro, aulaModelando, aulaSets
            };
            
            Imprimir(aulas);

            Array.Reverse(aulas);
            Imprimir(aulas);

            Array.Resize(ref aulas, 2);
            Imprimir(aulas);

            Array.Resize(ref aulas, 3);
            Imprimir(aulas);

            aulas[aulas.Length - 1] = "Conclusão";
            Imprimir(aulas);

            Array.Sort(aulas);
            Imprimir(aulas);

            Console.ReadLine();
        }

        private static void Imprimir(string[] aulas)
        {
            foreach (var aula in aulas)
                Console.WriteLine(aula);
            Console.WriteLine();
        }
    }
}
