using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula3.Modelo
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "MessageBox OK",
                "Titulo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }

        private void btnSimNao_Click(object sender, EventArgs e)
        {
            var retorno = MessageBox.Show(
                "MessageBox Sim/Nao",
                "Titulo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question    
            );

            if(retorno == DialogResult.Yes)
            {
                MessageBox.Show("Sim");
            }
            else
            {
                MessageBox.Show("Nao");
            }


        }

        private void btnTeste_Click(object sender, EventArgs e)
        {
            var retorno = MessageBox.Show(
               "Voce possui mais de 18 anos?",
               "Pergunta",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question
           );

            if (retorno == DialogResult.Yes)
            {
                txtCerveja.Enabled = true;
            }
            else
            {
                txtCerveja.Enabled = false;
            }
        }

        private void txtCerveja_Leave(object sender, EventArgs e)
        {
            if(txtCerveja.Text.ToUpper() == "POLAR")
            {
                lblDica.Text = "É UMA CERVEJA GAUCHA!";
            }
            else
            {
                lblDica.Text = "NAO É UMA CERVEJA GAUCHA!";
            }
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            var form = new AboutBox1();
            form.ShowDialog();
        }

        private void btnBotoes_Click(object sender, EventArgs e)
        {
            var form = new FrmBotoes();
            var resposta = form.ShowDialog();
            if(resposta == DialogResult.OK)
            {
                MessageBox.Show("Retornou OK");
            }
        }
    }
}
