using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Desenvolvedor : Funcionario
    {
        public Desenvolvedor(string cpf) : base(cpf, 3000)
        {
        }

        public override void AumentarSalario()
        {
            base.AumentarSalario();
        }

        public override double GetBonificacao()
        {
            return base.GetBonificacao();
        }
    }
}
