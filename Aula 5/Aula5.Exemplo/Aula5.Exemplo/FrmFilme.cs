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
    public partial class FrmFilme : Form
    {        
        public FrmFilme()
        {
            InitializeComponent();
        }

        public FrmFilme(string titulo, string diretor)
        {
            InitializeComponent();

            lblTitulo.Text = titulo;
            lblDiretor.Text = diretor;            
        }
    }
}
