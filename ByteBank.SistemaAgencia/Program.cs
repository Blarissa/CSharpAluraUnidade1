﻿using System;
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
            try
            {
                TestaDivisao(2);
            }catch(DivideByZeroException) {
                Console.WriteLine("Ocorreu um erro! Não é possível dividir um número por 0!");
            }

        }

        private static void TestaDivisao(int divisor)
        {
            int resultado = Dividir(10, divisor);
            Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é  " + resultado);
        }

        private static int Dividir(int numero, int divisor)
        {
            return numero / divisor;
        }
    }
}