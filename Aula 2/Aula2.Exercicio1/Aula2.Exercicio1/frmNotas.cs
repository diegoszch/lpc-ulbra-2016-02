using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula2.Exercicio1
{
    public partial class frmNotas : Form
    {
        public frmNotas()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            var nota1 = float.Parse(txtG1.Text);
            var nota2 = float.Parse(txtG2.Text);

            var resultado = (nota1 + (nota2 * 2)) / 3;

            if(resultado >= 6)
            {
                lblResultado.Text = "Aprovado";
                lblResultado.ForeColor = Color.Blue;
                lblNota.ForeColor = Color.Blue;
            }
            else
            {
                lblResultado.Text = "Reprovado";
                lblResultado.ForeColor = Color.Red;
                lblNota.ForeColor = Color.Red;
            }

            lblNota.Text = resultado.ToString("0.00");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtG1.Text = "";
            txtG2.Text = "";
            lblResultado.Text = "Pendente";
            lblResultado.ForeColor = Color.Black;
            lblNota.Text = "0";
            lblNota.ForeColor = Color.Black;
        }
    }
}
