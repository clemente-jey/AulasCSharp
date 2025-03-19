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
    public partial class LoginMain : Form
    {
        public LoginMain()
        {
            InitializeComponent();
            this.FormClosing += ApplicationClose;
        }

        private void LoginMain_Load(object sender, EventArgs e)
        {

        }

        private void ApplicationClose(object sender, FormClosingEventArgs evento)
        {

            DialogResult resultadoAcao = MessageBox.Show("Deseja realmente sair?", "Sair", MessageBoxButtons.YesNo);

            if (resultadoAcao == DialogResult.No)
            {
                evento.Cancel = true;
            }
            else
            {
                Application.ExitThread();
            }
        }
    }
}
