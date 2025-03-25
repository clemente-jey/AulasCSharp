using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoListMVC.Model;

namespace TodoListMVC.Controller
{

    public class TodoController
    {
        private TarefaService _tarefaService = new TarefaService();

        public void AdicionarTarefa(string descricao)
        {
            _tarefaService.AdicionarTarefa(descricao);
        }

        public List <Tarefa> ObterTarefas()
        {
            return _tarefaService.ObterTodas();
        }

        public void ConcluirTarefa(int id)
        {
            _tarefaService.MarcarComoConcluida(id);
        }
    }
}
