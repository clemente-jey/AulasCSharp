namespace TodoListMVC
{
    partial class FormTodoList
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTarefa = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.listBoxTarefas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtTarefa
            // 
            this.txtTarefa.Location = new System.Drawing.Point(197, 121);
            this.txtTarefa.Name = "txtTarefa";
            this.txtTarefa.Size = new System.Drawing.Size(146, 20);
            this.txtTarefa.TabIndex = 0;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(397, 121);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(181, 20);
            this.btnAdicionar.TabIndex = 1;
            this.btnAdicionar.Text = "Adicionar Tarefa";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // listBoxTarefas
            // 
            this.listBoxTarefas.FormattingEnabled = true;
            this.listBoxTarefas.Location = new System.Drawing.Point(223, 202);
            this.listBoxTarefas.Name = "listBoxTarefas";
            this.listBoxTarefas.Size = new System.Drawing.Size(120, 95);
            this.listBoxTarefas.TabIndex = 2;
            // 
            // FormTodoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxTarefas);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtTarefa);
            this.Name = "FormTodoList";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormTodoList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTarefa;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.ListBox listBoxTarefas;
    }
}

