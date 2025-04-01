using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TodoListMVC
{
    public partial class FormTodoList : Form
    {
        private TodoController _controller;

        public FormTodoList()
        {
            InitializeComponent();
            _controller = new TodoController();
            AtualizarLista();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTarefa.Text))
            {
                _controller.AdicionarTarefa(txtTarefa.Text);
                txtTarefa.Clear();
                AtualizarLista();
            }
        }

        private void AtualizarLista()
        {
            listBoxTarefas.Items.Clear();
            foreach (Tarefa tarefa in _controller.ObterTarefas())
            {
                listBoxTarefas.Items.Add(tarefa.Descricao);
            }
        }
    }

}