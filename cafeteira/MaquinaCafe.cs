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
    public partial class MaquinaCafe : Form
    {
        public MaquinaCafe()
        {
            InitializeComponent();
            inicio();  
        }
        public void inicio()
        {
            progressBar1.Increment(50);
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            btnCreditos.Enabled = false;
            atualizaCreditos();
        }
        public static string textopreparo;
        public void invocaimg()
        {
            Form formulario1 = new giphycafe();
            formulario1.Show();
            this.Hide();
        }
        
        public void atualizaCreditos()
        {
            btnCreditos.Text = "Créditos:R$" + dinheiro.inicial;
        }
        
        public void preparocafe(string texto)
        {
            
            if(texto =="CAFÉ C/LEITE")
            {
                if(dinheiro.inicial>=2)
                {
                    dinheiro.inicial -= 2;
                    textopreparo = "CAFÉ C/LEITE\nAÇUCAR:" + progressBar1.Value + "%";
                    atualizaCreditos();
                    invocaimg();
                }
                else
                {
                    MessageBox.Show("Creditos insuficientes");
                }
            }
            else if (texto == "CAFÉ SIMPLES")
            {
                if (dinheiro.inicial >= 1)
                {
                    dinheiro.inicial -= 1;
                    textopreparo = "CAFÉ SIMPLES\nAÇUCAR:" + progressBar1.Value + "%";
                    atualizaCreditos();
                    invocaimg();
                }
                else
                {
                    MessageBox.Show("Creditos insuficientes");
                }
            }
            else if (texto == "CAPUCCINO")
            {
                if (dinheiro.inicial >= 2)
                {
                    dinheiro.inicial -= 2;
                    textopreparo = "CAPUCCINO\nAÇUCAR:" + progressBar1.Value + "%";
                    atualizaCreditos();
                    invocaimg();
                }
                else
                {
                    MessageBox.Show("Creditos insuficientes");
                }
            }
            else if (texto == "CHOCOLATE")
            {
                if (dinheiro.inicial >= 1.5)
                {
                    dinheiro.inicial -= 1.5;
                    textopreparo = "CHOCOLATE\nAÇUCAR:" + progressBar1.Value + "%";
                    atualizaCreditos();
                    invocaimg();
                }
                else
                {
                    MessageBox.Show("Creditos insuficientes");
                }
            }
        }
        public static void devolvetroco()
        {
            if (dinheiro.inicial > 0)
            {
                if (DialogResult.Yes == MessageBox.Show("deseja Pegar o Troco?", "Troco", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                {
                    dinheiro.inicial = 0;
                    MessageBox.Show("Troco devolvido com Sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.progressBar1.Increment(25);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.progressBar1.Increment(-25);
        }

        private void btnAddCreditos_Click(object sender, EventArgs e)
        {
            Form formulario1 = new dinheiro();
            formulario1.Show();
            this.Hide();
        }

        private void btnCleite_Click(object sender, EventArgs e)
        {
            preparocafe(btnCleite.Text);
        }

        private void btnSimples_Click(object sender, EventArgs e)
        {
            preparocafe(btnSimples.Text);
        }

        private void btnCapuccino_Click(object sender, EventArgs e)
        {
            preparocafe(btnCapuccino.Text);
        }

        private void btnChocolate_Click(object sender, EventArgs e)
        {
            preparocafe(btnChocolate.Text);
        }
    }
}
