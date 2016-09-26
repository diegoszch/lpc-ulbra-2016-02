using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula4.Exercicio
{
    public partial class FrmAvaliacao : Form
    {
        public FrmAvaliacao()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            var pontuacao = 0;

            if (rbtQuestao1Sim.Checked)
                pontuacao += 10;
            if (rbtQuestao2Sim.Checked)
                pontuacao += 10;
            if (rbtQuestao3Sim.Checked)
                pontuacao += 10;

            if(checkBox1.Checked)
                pontuacao += 1;
            if (checkBox2.Checked)
                pontuacao += 1;
            if (checkBox3.Checked)
                pontuacao += 1;
            if (checkBox4.Checked)
                pontuacao += 1;
            if (checkBox5.Checked)
                pontuacao += 1;
            if (checkBox6.Checked)
                pontuacao += 1;
            if (checkBox7.Checked)
                pontuacao += 1;
            if (checkBox8.Checked)
                pontuacao += 1;
            if (checkBox9.Checked)
                pontuacao += 1;
            if (checkBox10.Checked)
                pontuacao += 1;
            if (checkBox11.Checked)
                pontuacao += 1;
            if (checkBox12.Checked)
                pontuacao += 1;

            if(pontuacao <= 23)
            {
                MessageBox.Show(
                    "Ansiedade normal",
                    "Avaliação positiva",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
            {
                MessageBox.Show(
                    "Ansiedade fora do normal.\nProcure um profissional.",
                    "Avaliação negativa",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation
                );
            }
        }
    }
}
