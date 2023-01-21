using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class Program
    {
        static void Main(string[] args)
        {
            var navegador = new Navegador();

            navegador.NavegarPara("google.com");
            navegador.NavegarPara("caelum.com.br");
            navegador.NavegarPara("alura.com.br");
            
            navegador.Anterior();
            navegador.Anterior();
            navegador.Anterior();
            navegador.Proximo();

            Console.ReadLine();
        }
    }
}
