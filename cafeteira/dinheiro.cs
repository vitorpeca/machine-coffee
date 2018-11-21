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
    public partial class dinheiro : Form
    {
        public dinheiro()
        {
            InitializeComponent();
            inicio();
            btnCreditos.Enabled = false;
        }
        public static double inicial = 0;
        public void inicio()
        {
            btnCreditos.Text = "Créditos:R$"+inicial;
            btnCreditos.Enabled = false;
        }
        private void btnAddCreditos_Click(object sender, EventArgs e)
        {
            Form f3 = new MaquinaCafe();
            f3.Show(); 
            this.Close(); 
        }
        private void UmReal_Click(object sender, EventArgs e)
        {
            if (inicial >= 5)
            {
                MessageBox.Show("AVISO LIMITE DE CREDITOS R$5");
            }
            else
            {
                inicial += 1;
                btnCreditos.Text = "Créditos:R$" + inicial;
            }
        }

        private void cinquenta_Click(object sender, EventArgs e)
        {
            if (inicial >= 5)
            {
                MessageBox.Show("AVISO LIMITE DE CREDITOS R$5");
            }
            else
            {
                inicial += 0.50;
                btnCreditos.Text = "Créditos:R$" + inicial;
            }
        }

        private void vintecinco_Click(object sender, EventArgs e)
        {
            if (inicial >= 5)
            {
                MessageBox.Show("AVISO LIMITE DE CREDITOS R$5");
            }
            else
            {
                inicial += 0.25;
                btnCreditos.Text = "Créditos:R$" + inicial;
            }
        }

        private void dez_Click(object sender, EventArgs e)
        {
            if (inicial >= 5)
            {
                MessageBox.Show("AVISO LIMITE DE CREDITOS R$5");
            }
            else
            {
                inicial += 0.10;
                btnCreditos.Text = "Créditos:R$" + inicial;
            }
        }

        private void cincocents_Click(object sender, EventArgs e)
        {
            if (inicial >= 5)
            {
                MessageBox.Show("AVISO LIMITE DE CREDITOS R$5");
            }
            else
            {
                inicial += 0.05;
                btnCreditos.Text = "Créditos:R$" + inicial;
            }
        }
    }
}
