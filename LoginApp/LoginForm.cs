using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtSenha.Text))
            {
                MessageBox.Show("Preencha todos os campos!");
            }
            if (txtUsuario.Text == "Admin" && txtSenha.Text == "1234")
            {

                this.Hide();

                LoginMain loginMain = new LoginMain();
                loginMain.Show();
            }

            else
            {
                MessageBox.Show("Usuário ou senha incorretos","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
