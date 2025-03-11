using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_CadastroAlunos
{
    internal class Aluno
    {

        public string Nome;
        public int Matricula;
        public string Curso;
        public string Email;
        public string Telefone;

        public Aluno(string nome, int matricula, string curso, string email, string telefone)
        {
            Nome = nome;
            Matricula = matricula;
            Curso = curso;
            Email = email;
            Telefone = telefone;
        }
    }
}
