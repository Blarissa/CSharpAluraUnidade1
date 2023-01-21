using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadoresDeConjuntos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] seq1 = { "janeiro", "fevereiro", "março" };
            string[] seq2 = { "fevereiro", "MARÇO", "abril" };

            Console.WriteLine("Conectanto duas sequências");
            var consulta = seq1.Concat(seq2);
            
            Imprimir(consulta);

            Console.WriteLine("União de duas sequências");
            consulta = seq1.Union(seq2);
            
            Imprimir(consulta);

            Console.WriteLine("União de duas sequências com comparador");
            consulta = seq1.Union(seq2, StringComparer.InvariantCultureIgnoreCase);
            
            Imprimir(consulta);

            Console.WriteLine("Intersecção de duas sequências");
            consulta = seq1.Intersect(seq2);

            Imprimir(consulta);

            Console.WriteLine("Exceto: elementos da seq1 que não estão em seq2");
            consulta = seq1.Except(seq2);

            Imprimir(consulta);

            Console.ReadLine();
        }

        private static void Imprimir(IEnumerable<String> consulta)
        {
            foreach (var item in consulta)
                Console.WriteLine(item);

            Console.WriteLine();
        }
    }
}
