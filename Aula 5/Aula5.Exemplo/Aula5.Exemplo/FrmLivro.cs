﻿using System;
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
    public partial class FrmLivro : Form
    {
        public FrmLivro()
        {
            InitializeComponent();
        }

        public FrmLivro(string titulo, string autor)
        {
            InitializeComponent();

            lblTitulo.Text = titulo;
            lblAutor.Text = autor;
        }
    }
}
