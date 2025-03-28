using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassesImportantes
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMessageBox_Click(object sender, EventArgs e)
        {
           // MessageBox.Show("Sou uma janela de mensagem :)");
           // MessageBox.Show("Sou uma janela de mensagem :)","Titulo da minha Janela";
            //MessageBox.Show("Sou uma janela de mensagem :)","Titulo da minha Janela",MessageBoxButtons.YesNoCancel);
            DialogResult resultadoJanela = MessageBox.Show("Sou uma janela de mensagem :)","Titulo da minha Janela",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Stop);

            labelResult.Text = resultadoJanela.ToString();

            if (resultadoJanela == DialogResult.Yes)
            {
              labelResult.Text = "Você clicou em Yes";

            }
            else if (resultadoJanela==DialogResult.No)
            {
                labelResult.Text = "Você clicou em No";
            }
            else 
            {
                labelResult.Text = string.Empty;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random numeroAleatorio = new Random(DateTime.Now.Millisecond);
            //instanciando a classe Random
        labelResult.Text = numeroAleatorio.Next(50,100).ToString();
         // labelResult.Text = numeroAleatorio.NextDouble().ToString();

        }

        private void btnDateTime_Click(object sender, EventArgs e)
        {
            DateTime dateTime = new DateTime();

            //  labelResult.Text = DateTime.Now.ToString();
            // labelResult.Text = DateTime.Now.ToLongDateString();
            // labelResult.Text = DateTime.Now.ToShortDateString();
            //  labelResult.Text = DateTime.Now.ToLongTimeString();
         // labelResult.Text = DateTime.Now.ToShortTimeString();
    //   labelResult.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
     //    labelResult.Text = DateTime.Now.Day.ToString();
      //   labelResult.Text = DateTime.Now.DayOfWeek.ToString();
      //      labelResult.Text = DateTime.Now.DayOfYear.ToString();   


            labelResult.Text = DateTime.IsLeapYear(2024).ToString();
            //ano bissexto
        }

        private void btnTimeSpan_Click(object sender, EventArgs e)
        {
            TimeSpan time1 = new TimeSpan(3,30,0);
            TimeSpan time2 = TimeSpan.FromHours(2.5);
            TimeSpan time3 = TimeSpan.FromMinutes(3);
            TimeSpan time4 = new TimeSpan(4,5,0);

            //   labelResult.Text = time1.ToString();
            //   labelResult.Text = time2.ToString();
            //    labelResult.Text = time3.ToString();

           // DateTime inicio = DateTime.Now;
          //  DateTime fim = DateTime.Now.AddHours(2);

          //  TimeSpan duracao = fim - inicio;

            //labelResult.Text = duracao.ToString();
            TimeSpan time5 = time1.Add(time4);

            labelResult.Text = time5.ToString();
        }
    }
}
