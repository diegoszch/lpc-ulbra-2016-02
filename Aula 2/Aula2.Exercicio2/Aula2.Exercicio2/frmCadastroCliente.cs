using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Aula2.Exercicio2
{
    public partial class frmCadastroCliente : Form
    {
        public frmCadastroCliente()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void Limpar()
        {
            txtNome.Text = "";
            txtEndereco.Text = "";
            txtNumero.Text = "";
            txtComplemento.Text = "";
            txtBairro.Text = "";
            txtMunicipio.Text = "";
            txtCep.Text = "";
            txtUf.Text = "";
            txtPais.Text = "";
            txtTelefone.Text = "";
            txtEmail.Text = "";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var dados = string.Format(
                "Nome: {0} | Endereco: {1} | Numero: {2} | Complemento: {3} | Bairro: {4} | Municipio: {5} | Cep: {6} | Uf: {7} | Pais: {8} | Telefone: {9} | Email: {10}",
                txtNome.Text,
                txtEndereco.Text,
                txtNumero.Text,
                txtComplemento.Text,
                txtBairro.Text,
                txtMunicipio.Text,
                txtCep.Text,
                txtUf.Text,
                txtPais.Text,
                txtTelefone.Text,
                txtEmail.Text
            );
            
            using (StreamWriter escrever = File.AppendText(@"c:\temp\arquivotexto.txt"))
            {
                escrever.WriteLine(dados);
            }

            MessageBox.Show("Arquivo salvo com sucesso", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Limpar();
        }
    }
}
