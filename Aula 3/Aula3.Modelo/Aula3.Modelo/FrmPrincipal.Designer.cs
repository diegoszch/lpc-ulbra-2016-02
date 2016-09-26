namespace Aula3.Modelo
{
    partial class FrmPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnSimNao = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCerveja = new System.Windows.Forms.TextBox();
            this.btnTeste = new System.Windows.Forms.Button();
            this.lblDica = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnSobre = new System.Windows.Forms.Button();
            this.btnBotoes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(43, 39);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnSimNao
            // 
            this.btnSimNao.Location = new System.Drawing.Point(139, 39);
            this.btnSimNao.Name = "btnSimNao";
            this.btnSimNao.Size = new System.Drawing.Size(75, 23);
            this.btnSimNao.TabIndex = 1;
            this.btnSimNao.Text = "Sim / Nao";
            this.btnSimNao.UseVisualStyleBackColor = true;
            this.btnSimNao.Click += new System.EventHandler(this.btnSimNao_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Qual cerveja você prefere?";
            // 
            // txtCerveja
            // 
            this.txtCerveja.Enabled = false;
            this.txtCerveja.Location = new System.Drawing.Point(154, 106);
            this.txtCerveja.Name = "txtCerveja";
            this.txtCerveja.Size = new System.Drawing.Size(194, 20);
            this.txtCerveja.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtCerveja, "Qual a cerveja você prefere?");
            this.txtCerveja.Leave += new System.EventHandler(this.txtCerveja_Leave);
            // 
            // btnTeste
            // 
            this.btnTeste.Location = new System.Drawing.Point(84, 77);
            this.btnTeste.Name = "btnTeste";
            this.btnTeste.Size = new System.Drawing.Size(213, 23);
            this.btnTeste.TabIndex = 4;
            this.btnTeste.Text = "Iniciar Teste";
            this.btnTeste.UseVisualStyleBackColor = true;
            this.btnTeste.Click += new System.EventHandler(this.btnTeste_Click);
            // 
            // lblDica
            // 
            this.lblDica.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDica.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDica.Location = new System.Drawing.Point(12, 143);
            this.lblDica.Name = "lblDica";
            this.lblDica.Size = new System.Drawing.Size(420, 23);
            this.lblDica.TabIndex = 5;
            // 
            // btnSobre
            // 
            this.btnSobre.Location = new System.Drawing.Point(240, 39);
            this.btnSobre.Name = "btnSobre";
            this.btnSobre.Size = new System.Drawing.Size(75, 23);
            this.btnSobre.TabIndex = 6;
            this.btnSobre.Text = "Sobre";
            this.btnSobre.UseVisualStyleBackColor = true;
            this.btnSobre.Click += new System.EventHandler(this.btnSobre_Click);
            // 
            // btnBotoes
            // 
            this.btnBotoes.Location = new System.Drawing.Point(337, 39);
            this.btnBotoes.Name = "btnBotoes";
            this.btnBotoes.Size = new System.Drawing.Size(75, 23);
            this.btnBotoes.TabIndex = 7;
            this.btnBotoes.Text = "Botoes";
            this.btnBotoes.UseVisualStyleBackColor = true;
            this.btnBotoes.Click += new System.EventHandler(this.btnBotoes_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 301);
            this.Controls.Add(this.btnBotoes);
            this.Controls.Add(this.btnSobre);
            this.Controls.Add(this.lblDica);
            this.Controls.Add(this.btnTeste);
            this.Controls.Add(this.txtCerveja);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSimNao);
            this.Controls.Add(this.btnOk);
            this.Name = "FrmPrincipal";
            this.Text = "Formulario Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnSimNao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCerveja;
        private System.Windows.Forms.Button btnTeste;
        private System.Windows.Forms.Label lblDica;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnSobre;
        private System.Windows.Forms.Button btnBotoes;
    }
}

