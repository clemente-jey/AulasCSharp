using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPontoEletronico
{
    public partial class frmLogin: Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "adm" && txtSenha.Text == "123")
            {
                MessageBox.Show("Login efetuado com sucesso!","Acesso",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Hide();
                new frmPrincipal().Show();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
