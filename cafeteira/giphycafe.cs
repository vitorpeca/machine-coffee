using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafeteira
{
    public partial class giphycafe : Form
    {
        public giphycafe()
        {
            InitializeComponent();
            iniciando();
        }
        int porcentagem;
        private void iniciando()
        {
            timer1.Enabled = true;
            timer1.Start();
            timer1.Interval = 1000;
            progressBar1.Maximum = 10;
            timer1.Tick += new EventHandler(timer1_Tick);
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            label1.Text = "Preparando:" +porcentagem;
        }
        public void close()
        {
            if(progressBar1.Value == 10)
            {
                MessageBox.Show(""+MaquinaCafe.textopreparo,"Pronto");
                MaquinaCafe.devolvetroco();
                this.Close();
                Form formulario = new MaquinaCafe();
                formulario.Show();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value != 10)
            {
                progressBar1.Value++;
                porcentagem+=10;
                label1.Text = "Preparando:" + porcentagem+"%";
                if(progressBar1.Value==10)
                {
                    label1.Text = "Pronto:" + porcentagem + "%";
                }
            }
            else
            {
                timer1.Stop();
                close();
                progressBar1.Value = 0;
            }
        }
    }
}
