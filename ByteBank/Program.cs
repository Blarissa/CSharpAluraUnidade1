using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario carlos = new Funcionario("546.879.157-20",2000);
            Console.WriteLine(Funcionario.TotalDeFuncionarios);

            carlos.Nome = "Carlos";           
            gerenciador.Registrar(carlos);

            Console.WriteLine(carlos.Nome);
            Console.WriteLine(carlos.GetBonificacao());

            carlos.AumentarSalario();
            Console.WriteLine("Novo salário do carlos " + carlos.Salario);
            Console.WriteLine();

            Diretor roberta = new Diretor("454.658.148-30", 5000);
            Console.WriteLine(Funcionario.TotalDeFuncionarios);

            roberta.Nome = "Roberta";
            gerenciador.Registrar(roberta);

            Console.WriteLine("Bonificacao de uma referencia de Diretor: " + roberta.GetBonificacao());
            
            roberta.AumentarSalario();
            Console.WriteLine("Novo salário do Roberta " + roberta.Salario);
            Console.WriteLine();

            Funcionario robertaTeste = roberta;            
            Console.WriteLine("Bonificacao de uma referencia de Funcionario: " + robertaTeste.GetBonificacao());            

            Console.WriteLine(roberta.Nome);
            Console.WriteLine(roberta.GetBonificacao());
            Console.WriteLine();

            Console.WriteLine("Total de bonificações: " + gerenciador.GetTotalBonificacao());            

            Console.WriteLine("Total de bonificações: " + gerenciador.GetTotalBonificacao());

            Console.ReadLine();
        }
    }
}
