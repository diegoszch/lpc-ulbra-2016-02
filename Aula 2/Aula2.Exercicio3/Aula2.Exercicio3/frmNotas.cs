using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula2.Exercicio3
{
    public partial class frmNotas : Form
    {
        public frmNotas()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void Limpar()
        {
            txtAluno.Text = "";
            txtG1.Text = "";
            txtG2.Text = "";
            txtFaltas.Text = "";
            txtTotalAulas.Text = "";
            lblResultado.Text = "Pendente";
            lblResultado.ForeColor = Color.Black;
            lblNota.Text = "0";
            lblNota.ForeColor = Color.Black;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            var nota1 = float.Parse(txtG1.Text);
            var nota2 = float.Parse(txtG2.Text);
            var resultado = (nota1 + (nota2 * 2)) / 3;

            var totalAulas = int.Parse(txtTotalAulas.Text);
            var totalFaltas = int.Parse(txtFaltas.Text);            
            var porcentagemFaltas = (totalFaltas * 100) / totalAulas;

            

            if (resultado >= 6 && porcentagemFaltas <= 20)
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


            var dados = string.Format(
               "Aluno: {0} | G1: {1} | G2: {2} | Total de Aulas: {3} | Faltas: {4} | Nota final: {5} | Situação: {6}",
               txtAluno.Text,
               txtG1.Text,
               txtG2.Text,
               txtTotalAulas.Text,
               txtFaltas.Text,
               resultado.ToString("0.00"),
               lblResultado.Text
           );

            using (StreamWriter escrever = File.AppendText(@"c:\temp\notas.txt"))
            {
                escrever.WriteLine(dados);
            }

            MessageBox.Show("Nota salva com sucesso", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Limpar();

        }
    }
}
