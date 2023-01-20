using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public class SaldoInsulficienteException : Exception
    {
        public double Saldo { get; }
        public double ValorSaque { get; }

        public SaldoInsulficienteException()
        {

        }

        public SaldoInsulficienteException(double saldo, double valorSaque)
            : this("Tentativa de saque do valor de " + valorSaque + " em uma conta com saldo de " + saldo)
        {
            Saldo = saldo;
            ValorSaque = valorSaque;
        }

        public SaldoInsulficienteException(string mensagem)
            : base(mensagem)
        {
        }
    }
}
