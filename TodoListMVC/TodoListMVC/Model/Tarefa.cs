
public class Tarefa
{
    public int Id;
    public string Descricao;
    public bool Concluida;

    // Construtor para inicializar os campos  
    public Tarefa(int id, string descricao)
    {
        this.Id = id;
        this.Descricao = descricao;
        this.Concluida = false; // Tarefa começa não concluída  
    }
}
