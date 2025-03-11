using System.Data;

namespace Atividade_CadastroAlunos
{
    internal class Program

        
    {
        static void Main(string[] args)


        {
            
            List<String> alunosList = new List<String>();
            Console.WriteLine("Portal de Cadastro dos Alunos");
            Console.WriteLine("");
            Console.WriteLine("Para adicionar um cadastro digite 1, para visualizar os alunos já cadastrados digite 2");
            String opcao = Console.ReadLine();

            if (opcao == null) { 
            Console.WriteLine("Opção inválida");
            }
            else if (opcao == "1")
            {
                Console.WriteLine("Digite o nome do aluno");
                String nome = Console.ReadLine();
                Console.WriteLine("Digite a matrícula do aluno");
                int matricula = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o curso do aluno");
                string curso = Console.ReadLine();
                Console.WriteLine("Digite o email do aluno");
                string email = Console.ReadLine();
                Console.WriteLine("Digite o telefone do aluno");
                string telefone = Console.ReadLine();

                Console.WriteLine("Confirme os dados cadastrados:");
                Console.WriteLine($"Nome: {nome}Matricula: {matricula} Curso: {curso} Email: {email} Telefone: {telefone}");
                Aluno aluno = new Aluno(nome, matricula, curso, email, telefone);
                "Nome: {aluno.Nome}Matricula: {aluno.Matricula} Curso: {aluno.Curso} Email: {aluno.Email} Telefone: {aluno.Telefone}");
                Console.WriteLine("Confirmar cadastro? (S/N)");

                if (Console.ReadLine().ToUpper() == "S")
                {
                    alunosList.Add(aluno);
                    Console.WriteLine("Cadastro realizado com sucesso, para voltar ao inicio digiti 1");
                    string opcao2 = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Cadastro cancelado, para voltar ao inicio digite 1.");
                }   string opcao2 = Console.ReadLine();

            }
            }
            else if (opcao == "2")
            {
                Console.WriteLine("Alunos cadastrados: ");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Opção inválida");
            }
        }
    }
}
