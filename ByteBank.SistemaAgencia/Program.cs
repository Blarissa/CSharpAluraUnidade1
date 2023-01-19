using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Metodo();
            Console.ReadLine();
        }

        private static void Metodo()
        {
            TestaDivisao(0);
        }

        private static void TestaDivisao(int divisor)
        {
            int resultado = Dividir(10, divisor);

            if (resultado == -1)
                Console.WriteLine("Não é possível fazer divisão por 0");
            else
                Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é  " + resultado);
        }

        private static int Dividir(int numero, int divisor)
        {
            if (divisor == 0)
                return -1;
            if (divisor > numero)
                return -2;

            return numero / divisor;
        }
    }
}
