using System;
using System.Collections.Generic;

namespace Atividade_CadastroAlunos
{
    internal class Program
    {
        static List<Aluno> ListaAlunos = new List<Aluno>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Portal de Cadastro dos Alunos");
                Console.WriteLine("");
                Console.WriteLine("Para adicionar um cadastro digite 1, para visualizar os alunos já cadastrados digite 2");
                string opcao = Console.ReadLine();
                
                if (string.IsNullOrEmpty(opcao))
                {
                    Console.WriteLine("Opção inválida");
                    continue;
                }

                switch (opcao)
                {
                    case "1":
                        AdicionarAluno();
                        break;
                    case "2":
                        Aluno.VisualizarAlunos(ListaAlunos);
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            }
        }
        static void AdicionarAluno()
        {
            Console.WriteLine("Digite o nome do aluno");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite a matrícula do aluno");
            string matricula = Console.ReadLine();
            Console.WriteLine("Digite o curso do aluno");
            string curso = Console.ReadLine();
            Console.WriteLine("Digite o email do aluno");
            string email = Console.ReadLine();
            Console.WriteLine("Digite o telefone do aluno");
            string telefone = Console.ReadLine();

            Console.WriteLine("Confirme os dados cadastrados:");
            Console.WriteLine($"Nome: {nome} Matrícula: {matricula} Curso: {curso} Email: {email} Telefone: {telefone}");
            Aluno novoAluno = new Aluno(nome, matricula, curso, email, telefone);

            Console.WriteLine("Confirmar cadastro? (S/N)");
            string confirmacao = Console.ReadLine();
            if (confirmacao.ToUpper() == "S")
            {
                ListaAlunos.Add(novoAluno);
                Console.WriteLine("Cadastro realizado com sucesso.");
            }
            else
            {
                Console.WriteLine("Cadastro cancelado.");
            }
        }
        

        
    }
}
