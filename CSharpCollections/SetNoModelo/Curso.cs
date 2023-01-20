using CSharpCollections;
using SetNoModelo;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaSomenteLeitura
{
    public class Curso
    {
        private IDictionary<int, Aluno> dicionarioAlunos = new Dictionary<int, Aluno>();

        private ISet<Aluno> alunos = new HashSet<Aluno>();

        public IList<Aluno> Alunos
        {
            get
            {
                return new ReadOnlyCollection<Aluno>(alunos.ToList());
            }
        }
        private IList<Aula> aulas;

        public IList<Aula> Aulas
        {
            get { return new ReadOnlyCollection<Aula>(aulas); }
        }

        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private string instrutor;

        public string Instrutor
        {
            get { return instrutor; }
            set { instrutor = value; }
        }

        public int TempoTotal {
            get
            {
                return aulas.Sum(aula => aula.Tempo);
            }
        }

        public Curso(string nome, string instrutor) 
        { 
            this.nome = nome;
            this.instrutor = instrutor;
            this.aulas = new List<Aula>();    
        }

        public void Adiciona(Aula aula)
        {
            this.aulas.Add(aula);
        }

        public override string ToString()
        {
            return $"Curso: {nome}, Tempo: {TempoTotal}, Aulas: {string.Join(",", aulas)}";
        }

        public void Matricula(Aluno aluno)
        {
            this.alunos.Add(aluno);
            this.dicionarioAlunos.Add(aluno.NumeroMatricula, aluno);
        }

        public bool EstaMatriculado(Aluno aluno)
        {
            return alunos.Contains(aluno);
        }

        public Aluno BuscaMatriculado(int numeroMatricula)
        {
            Aluno aluno = null;
            
            this.dicionarioAlunos.TryGetValue(numeroMatricula, out aluno);

            return aluno;
        }
    }
}
