using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covariancia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("string para object");

            string titulo = "meses";
            object obj = titulo;

            Console.WriteLine(obj);
            
            Console.WriteLine();

            Console.WriteLine("List<string> para List<object>");

            string[] arrayMeses = new string[]
            {
                "Janeiro", "Fevereiro", "Março",
                "Abril", "Maio", "Junho",
                "Julho", "Agosto", "Setembro",
                "Outubro", "Novembro", "Dezembro"
            };

            object[] arrayObj = arrayMeses;
            
            Imprimir(arrayObj);

            arrayObj[0] = "PRIMEIRO MÊS";
            Console.WriteLine(arrayObj[0]);

            Console.ReadLine();
        }

        private static void Imprimir(Object[] obj)
        {
            foreach (var item in obj)
                Console.WriteLine(item);

            Console.WriteLine();
        }
    }
}
