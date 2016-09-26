namespace Aula5.Exemplo
{
    partial class FrmAula5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.grpLivro = new System.Windows.Forms.GroupBox();
            this.txtLivroAutor = new System.Windows.Forms.TextBox();
            this.txtLivroTitulo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpFilme = new System.Windows.Forms.GroupBox();
            this.txtFilmeDiretor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFilmeTitulo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.grpLivro.SuspendLayout();
            this.grpFilme.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo";
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(47, 19);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(203, 21);
            this.cmbTipo.TabIndex = 1;
            this.cmbTipo.SelectionChangeCommitted += new System.EventHandler(this.cmbTipo_SelectionChangeCommitted);
            // 
            // grpLivro
            // 
            this.grpLivro.Controls.Add(this.txtLivroAutor);
            this.grpLivro.Controls.Add(this.txtLivroTitulo);
            this.grpLivro.Controls.Add(this.label3);
            this.grpLivro.Controls.Add(this.label2);
            this.grpLivro.Enabled = false;
            this.grpLivro.Location = new System.Drawing.Point(12, 46);
            this.grpLivro.Name = "grpLivro";
            this.grpLivro.Size = new System.Drawing.Size(258, 83);
            this.grpLivro.TabIndex = 3;
            this.grpLivro.TabStop = false;
            this.grpLivro.Text = "Livro";
            // 
            // txtLivroAutor
            // 
            this.txtLivroAutor.Location = new System.Drawing.Point(76, 49);
            this.txtLivroAutor.Name = "txtLivroAutor";
            this.txtLivroAutor.Size = new System.Drawing.Size(100, 20);
            this.txtLivroAutor.TabIndex = 1;
            // 
            // txtLivroTitulo
            // 
            this.txtLivroTitulo.Location = new System.Drawing.Point(76, 25);
            this.txtLivroTitulo.Name = "txtLivroTitulo";
            this.txtLivroTitulo.Size = new System.Drawing.Size(100, 20);
            this.txtLivroTitulo.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Autor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Titulo";
            // 
            // grpFilme
            // 
            this.grpFilme.Controls.Add(this.txtFilmeDiretor);
            this.grpFilme.Controls.Add(this.label5);
            this.grpFilme.Controls.Add(this.txtFilmeTitulo);
            this.grpFilme.Controls.Add(this.label6);
            this.grpFilme.Enabled = false;
            this.grpFilme.Location = new System.Drawing.Point(276, 46);
            this.grpFilme.Name = "grpFilme";
            this.grpFilme.Size = new System.Drawing.Size(258, 83);
            this.grpFilme.TabIndex = 3;
            this.grpFilme.TabStop = false;
            this.grpFilme.Text = "Filme";
            // 
            // txtFilmeDiretor
            // 
            this.txtFilmeDiretor.Location = new System.Drawing.Point(90, 49);
            this.txtFilmeDiretor.Name = "txtFilmeDiretor";
            this.txtFilmeDiretor.Size = new System.Drawing.Size(100, 20);
            this.txtFilmeDiretor.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Titulo";
            // 
            // txtFilmeTitulo
            // 
            this.txtFilmeTitulo.Location = new System.Drawing.Point(90, 25);
            this.txtFilmeTitulo.Name = "txtFilmeTitulo";
            this.txtFilmeTitulo.Size = new System.Drawing.Size(100, 20);
            this.txtFilmeTitulo.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Diretor";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(451, 135);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(83, 32);
            this.btnEnviar.TabIndex = 4;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // FrmAula5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 177);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.grpFilme);
            this.Controls.Add(this.grpLivro);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.label1);
            this.Name = "FrmAula5";
            this.Text = "Formulario";
            this.Load += new System.EventHandler(this.FrmAula5_Load);
            this.grpLivro.ResumeLayout(false);
            this.grpLivro.PerformLayout();
            this.grpFilme.ResumeLayout(false);
            this.grpFilme.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.GroupBox grpLivro;
        private System.Windows.Forms.GroupBox grpFilme;
        private System.Windows.Forms.TextBox txtLivroAutor;
        private System.Windows.Forms.TextBox txtLivroTitulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFilmeDiretor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFilmeTitulo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEnviar;
    }
}

