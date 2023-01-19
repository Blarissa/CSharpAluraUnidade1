using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public abstract class Funcionario
    {
        public static int TotalDeFuncionarios { get; private set; }
        public string Nome { get; set; }
        public string CPF { get; set;}
        public double Salario { get; set; }
        
        public Funcionario(string cpf, double salario) {
            Console.WriteLine("Criando FUNCIONARIO");
            CPF = cpf;
            Salario = salario;
            TotalDeFuncionarios++;
        }

        public virtual void AumentarSalario()
        {
            Console.WriteLine("Atenção, não esqueça de sobrescrever o método AumentarSalario");
        }

        public virtual double GetBonificacao()
        {
            Console.WriteLine("Atenção, não esqueça de sobrescrever o método GetBonificacao");
            return 0;
        }
    }
}
