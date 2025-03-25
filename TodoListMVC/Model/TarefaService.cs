using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoListMVC.Model
{
    public class TarefaService
    {
        private List<Tarefa> _tarefas = new List<Tarefa>();
        private int _proximoId = 1;

        public void AdicionarTarefa(string descricao)
        {
            _tarefas.Add(new Tarefa { Id = _proximoId++, Descricao = descricao });
        }

        public List <Tarefa> ObterTodas()
        {
            return _tarefas;
        }

        public void MarcarComoConcluida(int id)
        {
            var tarefa = _tarefas.FirstOrDefault(t => t.Id == id);
            if (tarefa != null)
                tarefa.Concluida = true;
        }
    }

}