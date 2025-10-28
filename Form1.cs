using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aaroncocabancomat
{
    public partial class Form1 : Form
    {
        private decimal saldo = 1000m;
        private string pinCorretto = "4321";
        public Form1()
        {
            InitializeComponent();
            pnlOperazioni.Visible = false;
            lblSaldo.Text = $"Saldo: €{saldo}";
            lblMessaggio.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtPIN_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAccedi_Click(object sender, EventArgs e)
        {
            if (txtPIN.Text == pinCorretto)
            {
                pnlOperazioni.Visible = true;
                lblMessaggio.Text = "Accesso riuscito.";
            }
            else
            {
                pnlOperazioni.Visible = false; 
                lblMessaggio.Text = "PIN errato.";
                txtPIN.Clear();
            }

        }

        private void pnlOperazioni_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtImporto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPreleva_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtImporto.Text, out decimal importo))
            {
                if (importo <= saldo)
                {
                    saldo -= importo;
                    lblSaldo.Text = $"Saldo: €{saldo}";
                    lblMessaggio.Text = "Prelievo effettuato.";
                }
                else
                {
                    lblMessaggio.Text = "Saldo insufficiente.";
                }
            }
            else
            {
                lblMessaggio.Text = "Importo non valido.";
            }

            txtImporto.Clear();

        }

        private void btnDeposita_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtImporto.Text, out decimal importo))
            {
                saldo += importo;
                lblSaldo.Text = $"Saldo: €{saldo}";
                lblMessaggio.Text = "Deposito effettuato.";
            }
            else
            {
                lblMessaggio.Text = "Importo non valido.";
            }

            txtImporto.Clear();
        }

        private void btnEsci_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void lblMessaggio_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtPIN.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtPIN.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtPIN.Text += "3";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtPIN.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtPIN.Text += "6";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtPIN.Text += "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtPIN.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtPIN.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtPIN.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtPIN.Text += "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (txtPIN.Text.Length > 0)
            {
                txtPIN.Text = txtPIN.Text.Substring(0, txtPIN.Text.Length - 1);
            }
        }
    }
}
