using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniCalculadora
{
    public partial class Form1 : Form
    {
        int valor1 = 0;
        int valor2 = 0;
        int resultado = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSomar_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToInt16(txtNum1.Text);
            valor2 = Convert.ToInt16(txtNum2.Text);
            resultado = valor1 + valor2;

            lblResultado.Visible = true;
            txtResultado.Visible = true;

            txtResultado.Text = resultado.ToString();
        }

        private void BtnSubtrair_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToInt16(txtNum1.Text);
            valor2 = Convert.ToInt16(txtNum2.Text);
            resultado = valor1 - valor2;

            txtResultado.Text = resultado.ToString();
        }

        private void BtnMultiplicar_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToInt16(txtNum1.Text);
            valor2 = Convert.ToInt16(txtNum2.Text);
            resultado = valor1 * valor2;

            txtResultado.Text = resultado.ToString();
        }

        private void BtnDividir_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToInt16(txtNum1.Text);
            valor2 = Convert.ToInt16(txtNum2.Text);

            if (valor2 != 0)
            {
                resultado = valor1 / valor2;
                txtResultado.Text = resultado.ToString();
            }
            else
            {
                MessageBox.Show(" Não é possível efetuar a divisão por (0)");
            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(" Deseja realmente fechar o Programa? ", " Atenção! ", MessageBoxButtons.YesNo,
                                                                                                  MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {

            }
            else
            { 
                Close();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            txtNum1.Text = String.Empty;
            txtNum2.Text = String.Empty;
            txtResultado.Text = String.Empty;
            txtNum1.Focus();
        }
    }
}
