using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula5.Exercicio
{
    public partial class FrmUlbra : Form
    {

        public FrmUlbra()
        {
            InitializeComponent();
        }

        public FrmUlbra(
            string nome,
            string sexo,
            bool eCasado,
            string conjuge,
            string endRua,
            string endBairro,
            string endCidade,
            string endEstado 
        )
        {
            InitializeComponent();

            lblNome.Text = nome;
            lblSexo.Text = sexo;
            lblCasado.Text = string.Format(
                "{0} - {1}",
                (eCasado) ? "Casado" : "Solteiro",
                conjuge
            );
            lblEndereco1.Text = string.Format(
                "{0} - {1}",
                endRua,
                endBairro
            );
            lblEndereco2.Text = string.Format(
                "{0} - {1}",
                endCidade,
                endEstado
            );

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            var nota1 = float.Parse(txtG1.Text);
            var nota2 = float.Parse(txtG2.Text);

            var resultado = (nota1 + (nota2 * 2)) / 3;

            if (resultado >= 6)
            {
                lblResultado.Text = "Aprovado";
                lblResultado.ForeColor = Color.Blue;
                txtNota.ForeColor = Color.Blue;
            }
            else
            {
                lblResultado.Text = "Reprovado";
                lblResultado.ForeColor = Color.Red;
                txtNota.ForeColor = Color.Red;
            }

            txtNota.Text = resultado.ToString("0.00");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampo();
        }

        private void LimparCampo()
        {
            lblResultado.Text = "Pendente";
            lblResultado.ForeColor = Color.Black;
            txtG1.Text = "";
            txtG2.Text = "";
            txtNota.Text = "0";
        }
    }
}
