﻿using System;
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
        public string Senha { get; set; }

        public Funcionario(string cpf, double salario) {
            TotalDeFuncionarios++;
            Console.WriteLine("Criando FUNCIONARIO");
            CPF = cpf;
            Salario = salario;           
        }

        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }

        public abstract void AumentarSalario();

        public abstract double GetBonificacao();
    }
}
