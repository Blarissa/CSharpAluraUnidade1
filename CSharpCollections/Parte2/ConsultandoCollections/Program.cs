﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultandoCollections
{
    internal class Program
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

            IEnumerable<String> consulta = meses.Where(m => m.Dias == 31).OrderBy(m => m.Nome).Select(m => m.Nome.ToUpper());

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
