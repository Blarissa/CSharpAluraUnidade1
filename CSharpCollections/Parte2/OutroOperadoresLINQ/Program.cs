using ConsultandoCollections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutroOperadoresLINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Mes> meses = new List<Mes>()
            {
                new Mes("Janeiro", 31),
                new Mes("Fevereiro", 28),
                new Mes("Janeiro", 31),
                new Mes("Março", 30),
                new Mes("Abril", 31),
                new Mes("Junho", 30),
                new Mes("Julho", 31),
                new Mes("Agosto", 30),
                new Mes("Setembro", 30),
                new Mes("Outubro", 31),
                new Mes("Novembro", 30),
                new Mes("Dezembro", 31)
            };

            //Pegar o primeiro trimestre
            var consulta = meses.Take(5);
            Imprimir(consulta);

            //Pegar os meses depois do primeiro trimestre
            consulta = meses.Skip(3);
            Imprimir(consulta);

            //Pegar os meses do terceiro trimestre
            consulta = meses.Skip(6).Take(3);
            Imprimir(consulta);

            //Pegar os meses até que o mês comece com a letra 'S'
            consulta = meses.TakeWhile(m => !m.Nome.StartsWith("S"));
            Imprimir(consulta);

            //Pular os meses até que o mês comece com a letra 'S'
            consulta = meses.SkipWhile(m => !m.Nome.StartsWith("S"));
            Imprimir(consulta);

            Console.ReadLine();
        }

        private static void Imprimir(IEnumerable<Mes> consulta)
        {
            foreach (var item in consulta)
                Console.WriteLine(item);

            Console.WriteLine();
        }
    }
}
