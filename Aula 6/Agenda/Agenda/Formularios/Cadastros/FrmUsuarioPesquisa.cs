using Agenda.Classes;
using Agenda.Classes.BancoDeDados;
using Agenda.Classes.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda.Formularios.Cadastros
{
    public partial class FrmUsuarioPesquisa : Form
    {
        private Usuario user;
        private UsuarioDTO userReturn;
        
        public FrmUsuarioPesquisa(DataBase db)
        {
            user = new Usuario(db);

            InitializeComponent();   
        }

        public FrmUsuarioPesquisa()
        {
            user = new Usuario();

            InitializeComponent();
        }

        public UsuarioDTO GetUsuarioDto()
        {
            return this.userReturn;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            var filtros = new Filtro();

            dataGridViewUsuario.AutoGenerateColumns = false;

            if(txtCodigo.Text != "")
            {
                filtros.AddFiltro(FiltroOperador.IGUAL, "Id", txtCodigo.Text);
            }

            if (txtLogin.Text != "")
            {
                filtros.AddFiltro(FiltroOperador.LIKE, "Login", txtLogin.Text);
            }

            if (txtNome.Text != "")
            {
                filtros.AddFiltro(FiltroOperador.LIKE, "Nome", txtNome.Text);
            }

            dataGridViewUsuario.DataSource = user.FiltroRetornoDataTable(filtros);            
        }

        private void dataGridViewUsuario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var grid = (DataGridView)sender;

            int selectedRowCount =
            grid.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount == 1)
            {
                var idxColuna = grid.Columns["Id"].Index;
                var idSelecionado = (int)grid.SelectedCells[idxColuna].Value;
                userReturn = user.Selecionar(idSelecionado);

                this.DialogResult = DialogResult.OK;
            }
            else
            {
                userReturn = null;
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
