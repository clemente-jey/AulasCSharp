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

    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        private DateTime horaEntrada;
        private DateTime horaSaida;
        private TimeSpan tempoTrabalhado;


        private void button1_Click(object sender, EventArgs e)
        {
            horaEntrada = DateTime.Now;
            MessageBox.Show($"Entrada registrada ás {horaEntrada:HH:mm:ss}", "Entrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (horaEntrada == DateTime.MinValue)
            {
                MessageBox.Show("Registre a entrada primeiro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime horaSaida = DateTime.Now;
            tempoTrabalhado = horaSaida - horaEntrada;

            Random random = new Random();
            TimeSpan horaExtra = TimeSpan.FromMinutes(random.Next(0, 120));
            tempoTrabalhado = tempoTrabalhado.Add(horaExtra);

            iblTempoTrabalhado.Text = $"Tempo trabalhado: {tempoTrabalhado:hh\\:mm\\:ss}";

            MessageBox.Show(

                $"Saída registrada ás {horaSaida:HH:mm:ss}\n" +
                $"Tempo trabalhado: {tempoTrabalhado:hh\\:mm\\:ss}\n" +
                $"Hora extra: {horaExtra:hh\\:mm\\:ss}","Relatório",MessageBoxButtons.OK, MessageBoxIcon.Information
                        
                );

            horaEntrada = DateTime.MinValue;
        }
    }
}
