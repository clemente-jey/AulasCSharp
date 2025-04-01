using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoListMVC
{


    public class TarefaService
    {
        private List<Tarefa> _tarefas = new List<Tarefa>();
        private int _proximoId = 1;

        public void AdicionarTarefa(string descricao)
        {
            Tarefa novaTarefa = new Tarefa(_proximoId, descricao);
            _tarefas.Add(novaTarefa);
            _proximoId++;
        }
        
        public List<Tarefa> ObterTodas()
        {
            return _tarefas;
        }

        internal void MarcarComoConcluida(int id)
        {
            throw new NotImplementedException();
        }
    }
}
