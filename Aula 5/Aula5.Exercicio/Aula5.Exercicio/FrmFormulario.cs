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
    public partial class FrmFormulario : Form
    {
        public FrmFormulario()
        {
            InitializeComponent();
        }

        private void btnLimparCampos_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtNome.Text = "";
            rbtMasculino.Checked = true;
            chkCasado.Checked = false;
            txtConjuge.Text = "";
            txtEndRua.Text = "";
            txtEndBairro.Text = "";
            txtEndCidade.Text = "";
            cmbEstado.SelectedIndex = 0;
        }

        private void chkCasado_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkCasado.Checked)
            {
                txtConjuge.Enabled = true;
            }                
            else
            {
                txtConjuge.Enabled = false;
                txtConjuge.Text = "";
            }
                
        }

        private void FrmFormulario_Load(object sender, EventArgs e)
        {
            CarregarCombobox();
        }

        private void CarregarCombobox()
        {
            var estados = new Dictionary<string, string>();
            estados.Add("-", "-");
            estados.Add("AC","AC");
            estados.Add("AL","AL");
            estados.Add("AP","AP");
            estados.Add("AM","AM");
            estados.Add("BA","BA");
            estados.Add("CE","CE");
            estados.Add("DF","DF");
            estados.Add("ES","ES");
            estados.Add("GO","GO");
            estados.Add("MA","MA");
            estados.Add("MT","MT");
            estados.Add("MS","MS");
            estados.Add("MG","MG");
            estados.Add("PA","PA");
            estados.Add("PB","PB");
            estados.Add("PR","PR");
            estados.Add("PE","PE");
            estados.Add("PI","PI");
            estados.Add("RJ","RJ");
            estados.Add("RN","RN");
            estados.Add("RS","RS");
            estados.Add("RO","RO");
            estados.Add("RR","RR");
            estados.Add("SC","SC");
            estados.Add("SP","SP");
            estados.Add("SE","SE");
            estados.Add("TO","TO");

            cmbEstado.DataSource = new BindingSource(estados, null);
            cmbEstado.DisplayMember = "Value";
            cmbEstado.ValueMember = "Key";
        }

        private void btnEnviarDados_Click(object sender, EventArgs e)
        {
            var frm = new FrmUlbra(
                txtNome.Text,
                (rbtMasculino.Checked) ? "Masculino" : "Feminino",
                chkCasado.Checked,
                txtConjuge.Text,
                txtEndRua.Text,
                txtEndBairro.Text,
                txtEndCidade.Text,
                cmbEstado.SelectedValue.ToString()
            );

            frm.ShowDialog();
        }
    }
}
