namespace Aula11.Exemplo
{
    partial class FrmAula11
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
            this.btnSqlConnection = new System.Windows.Forms.Button();
            this.btnSqlTransaction = new System.Windows.Forms.Button();
            this.btnSqlCommand = new System.Windows.Forms.Button();
            this.btnSqlCommandParameter = new System.Windows.Forms.Button();
            this.btnSqlDataAdapter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSqlConnection
            // 
            this.btnSqlConnection.Location = new System.Drawing.Point(11, 12);
            this.btnSqlConnection.Name = "btnSqlConnection";
            this.btnSqlConnection.Size = new System.Drawing.Size(107, 51);
            this.btnSqlConnection.TabIndex = 0;
            this.btnSqlConnection.Text = "SqlConnection";
            this.btnSqlConnection.UseVisualStyleBackColor = true;
            this.btnSqlConnection.Click += new System.EventHandler(this.btnSqlConnection_Click);
            // 
            // btnSqlTransaction
            // 
            this.btnSqlTransaction.Location = new System.Drawing.Point(124, 12);
            this.btnSqlTransaction.Name = "btnSqlTransaction";
            this.btnSqlTransaction.Size = new System.Drawing.Size(107, 51);
            this.btnSqlTransaction.TabIndex = 1;
            this.btnSqlTransaction.Text = "SqlTransaction";
            this.btnSqlTransaction.UseVisualStyleBackColor = true;
            this.btnSqlTransaction.Click += new System.EventHandler(this.btnSqlTransaction_Click);
            // 
            // btnSqlCommand
            // 
            this.btnSqlCommand.Location = new System.Drawing.Point(237, 12);
            this.btnSqlCommand.Name = "btnSqlCommand";
            this.btnSqlCommand.Size = new System.Drawing.Size(107, 51);
            this.btnSqlCommand.TabIndex = 2;
            this.btnSqlCommand.Text = "SqlCommand";
            this.btnSqlCommand.UseVisualStyleBackColor = true;
            this.btnSqlCommand.Click += new System.EventHandler(this.btnSqlCommand_Click);
            // 
            // btnSqlCommandParameter
            // 
            this.btnSqlCommandParameter.Location = new System.Drawing.Point(350, 12);
            this.btnSqlCommandParameter.Name = "btnSqlCommandParameter";
            this.btnSqlCommandParameter.Size = new System.Drawing.Size(107, 51);
            this.btnSqlCommandParameter.TabIndex = 2;
            this.btnSqlCommandParameter.Text = "SqlCommand com Parametros";
            this.btnSqlCommandParameter.UseVisualStyleBackColor = true;
            this.btnSqlCommandParameter.Click += new System.EventHandler(this.btnSqlCommandParameter_Click);
            // 
            // btnSqlDataAdapter
            // 
            this.btnSqlDataAdapter.Location = new System.Drawing.Point(12, 88);
            this.btnSqlDataAdapter.Name = "btnSqlDataAdapter";
            this.btnSqlDataAdapter.Size = new System.Drawing.Size(107, 51);
            this.btnSqlDataAdapter.TabIndex = 3;
            this.btnSqlDataAdapter.Text = "SqlDataAdapter";
            this.btnSqlDataAdapter.UseVisualStyleBackColor = true;
            this.btnSqlDataAdapter.Click += new System.EventHandler(this.btnSqlDataAdapter_Click);
            // 
            // FrmAula11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 152);
            this.Controls.Add(this.btnSqlDataAdapter);
            this.Controls.Add(this.btnSqlCommandParameter);
            this.Controls.Add(this.btnSqlCommand);
            this.Controls.Add(this.btnSqlTransaction);
            this.Controls.Add(this.btnSqlConnection);
            this.Name = "FrmAula11";
            this.Text = "Aula 11";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSqlConnection;
        private System.Windows.Forms.Button btnSqlTransaction;
        private System.Windows.Forms.Button btnSqlCommand;
        private System.Windows.Forms.Button btnSqlCommandParameter;
        private System.Windows.Forms.Button btnSqlDataAdapter;
    }
}

