using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> frutas = new List<string>
            {
                "abacate", "banana", "caqui", "damasco", "figo"
            };

            //vamos imprimir essa lista
            foreach (var fruta in frutas)
            {
                Console.WriteLine(fruta);
            }

            LinkedList<string> dias = new LinkedList<string>();
            
            var d4 = dias.AddFirst("quarta");
            var d2 = dias.AddBefore(d4, "segunda");
            var d3 = dias.AddAfter(d2, "terça");
            var d6 = dias.AddAfter(d4, "sexta");
            var d7 = dias.AddAfter(d6, "sábado");
            var d5 = dias.AddBefore(d6, "quinta");
            var d1 = dias.AddBefore(d2, "domingo");

            foreach (var dia in dias)
            {
                Console.WriteLine(dia);
            }

            Console.WriteLine();

            var quarta = dias.Find("quarta");
            dias.Remove("quarta");

            foreach (var dia in dias)
            {
                Console.WriteLine(dia);
            }

            Console.ReadLine();
        }
    }
}
