namespace TodoListMVC.View
{
    partial class FormTodoList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtTarefa = new TextBox();
            btnAdicionar = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // txtTarefa
            // 
            txtTarefa.Location = new Point(271, 137);
            txtTarefa.Name = "txtTarefa";
            txtTarefa.Size = new Size(170, 23);
            txtTarefa.TabIndex = 0;
            txtTarefa.TextChanged += textBox1_TextChanged;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(311, 194);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 1;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(288, 254);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 94);
            listBox1.TabIndex = 2;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // FormTodoList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(btnAdicionar);
            Controls.Add(txtTarefa);
            Name = "FormTodoList";
            Text = "FormTodoList";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTarefa;
        private Button btnAdicionar;
        private ListBox listBox1;
    }
    
}