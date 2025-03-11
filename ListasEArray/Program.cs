namespace ListasEArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[5];
            string[] arrayFrutas = {"banana", "maça", "morango"};



            // Console.WriteLine(arrayFrutas[0]);  

            List<string> fruitList = new List<string>();

            fruitList.Add("banana");
            fruitList.Add("maça");
            fruitList.Add("morango");

            //foreach (string fruit in fruitList)
            // {
            //    Console.WriteLine(fruit);
            //   }

            //fruitList.ForEach(fruit => Console.WriteLine(fruit));

            Aluno aluno1 = new Aluno("Jonas", 123, "ADM", "jonas.clemente@gmail.com", "1023456789");
            Aluno aluno2 = new Aluno("Vini", 124, "ADM", "vini.massao@gmail.com", "1023456788");
            Aluno aluno3 = new Aluno("Miguel", 125, "ADM", "miguel.pinheiro@gmail.com", "1023456787");

            List<Aluno> listaAluno = new List<Aluno>();

            listaAluno.Add(aluno1);
            listaAluno.Add(aluno2);
            listaAluno.Add(aluno3);

            foreach (Aluno aluno in listaAluno) {
                Console.WriteLine($"Nome: {aluno.Nome}");
                Console.WriteLine($"Matrícula: {aluno.Matricula}");
                Console.WriteLine($"E-mail: {aluno.Email}");
                Console.WriteLine();
            }
        }
    }
}
