using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public class Program
    {
        static Queue<string> pedagio = new Queue<string>();

        static void Main(string[] args)
        {
            Enfileirar("van");           
            Enfileirar("kombi");            
            Enfileirar("guincho");
            Enfileirar("pickup");

            Desenfileirar();
            Desenfileirar();
            Desenfileirar();


            Console.ReadLine();
        }

        private static void Desenfileirar()
        {
            if (pedagio.Any())
            {
                if (pedagio.Peek() == "guincho")
                    Console.WriteLine("Guincho está fazendo pagamento");

                string veiculo = pedagio.Dequeue();
                Console.Write($"Saiu na fila: {veiculo}\n");
                ImprimirFila(); 
            }
        }

        private static void Enfileirar(string veiculo)
        {
            Console.Write($"Entrou na fila: {veiculo}\n");
            pedagio.Enqueue(veiculo);
            ImprimirFila();
        }
        
        private static void ImprimirFila()
        {
            Console.WriteLine("\nFILA: ");
            foreach(var item in pedagio)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }

}
