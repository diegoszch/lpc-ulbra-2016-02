using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula5.Exemplo
{
    public partial class FrmAula5 : Form
    {
        public FrmAula5()
        {
            InitializeComponent();
        }
        
        private void CarregarCombobox()
        {
            var tipo = new Dictionary<int, string>();
            tipo.Add(-1, "-- Selecione uma opção --");
            tipo.Add(1, "Filme");
            tipo.Add(2, "Livro");
            
            cmbTipo.DataSource = new BindingSource(tipo, null);
            cmbTipo.DisplayMember = "Value";
            cmbTipo.ValueMember = "Key";
        }
        
        private void FrmAula5_Load(object sender, EventArgs e)
        {
            CarregarCombobox();
        }

        private void DesabilitarGroups()
        {
            grpFilme.Enabled = false;
            grpLivro.Enabled = false;
        }

        private void HabilitarGroupLivro()
        {
            grpFilme.Enabled = false;
            grpLivro.Enabled = true;
        }

        private void HabilitarGroupFilme()
        {
            grpFilme.Enabled = true;
            grpLivro.Enabled = false;
        }


        private void cmbTipo_SelectionChangeCommitted(object sender, EventArgs e)
        {            
            switch (cmbTipo.SelectedValue.ToString())
            {                
                case "1":
                    HabilitarGroupFilme();                    
                    break;
                case "2":
                    HabilitarGroupLivro();
                    break;
                default:                    
                    DesabilitarGroups();
                    break;
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            switch (cmbTipo.SelectedValue.ToString())
            {
                case "1":
                    ChamarFormularioFilme();                            
                    break;
                case "2":
                    ChamarFormularioLivro();
                    break;
                default:
                    MessageBox.Show("Selecione alguma opção!");
                    break;
            }
        }


        private void ChamarFormularioLivro()
        {
            var formulario = new FrmLivro(
                txtLivroTitulo.Text,
                txtLivroAutor.Text
            );
            formulario.ShowDialog();
        }

        private void ChamarFormularioFilme()
        {
            var formulario = new FrmFilme(
                txtFilmeTitulo.Text,
                txtFilmeDiretor.Text
            );
            formulario.ShowDialog();
        }

    }
}
