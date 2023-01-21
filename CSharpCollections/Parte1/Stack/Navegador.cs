using System;
using System.Collections.Generic;
using System.Linq;

namespace Stack
{
    public class Navegador
    {
        private string atual = "vazia";
        private readonly Stack<string> historicoAnterior = new Stack<string>();
        private readonly Stack<string> historicoProximo = new Stack<string>();

        public Navegador()
        {
            Console.WriteLine("Página atual: " + atual);
            Console.WriteLine();
        }
        
        public void NavegarPara(string url)
        {
            historicoAnterior.Push(atual);
            atual = url;
            Console.WriteLine("Página atual: " + atual);
            Console.WriteLine();
        }
        
        public void Anterior()
        {
            if (historicoAnterior.Any())
            {
                historicoProximo.Push(atual);
                atual = historicoAnterior.Pop();
                Console.WriteLine("Página atual: " + atual);
                Console.WriteLine();
            }
            
        }

        public void Proximo()
        {
            if (historicoProximo.Any())
            {
                historicoAnterior.Push(atual);
                atual = historicoProximo.Pop();
                Console.WriteLine("Página atual: " + atual);
            }
        }
    }
}