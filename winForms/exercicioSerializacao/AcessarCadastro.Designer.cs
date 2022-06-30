namespace exercicioSerializacao
{
    partial class AcessarCadastro
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
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbData = new System.Windows.Forms.TextBox();
            this.tbCpf = new System.Windows.Forms.TextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(138, 162);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(82, 40);
            this.btnFinalizar.TabIndex = 15;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(110, 47);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(120, 20);
            this.tbNome.TabIndex = 14;
            // 
            // tbData
            // 
            this.tbData.Location = new System.Drawing.Point(110, 78);
            this.tbData.Name = "tbData";
            this.tbData.Size = new System.Drawing.Size(120, 20);
            this.tbData.TabIndex = 13;
            // 
            // tbCpf
            // 
            this.tbCpf.Location = new System.Drawing.Point(110, 113);
            this.tbCpf.Name = "tbCpf";
            this.tbCpf.Size = new System.Drawing.Size(120, 20);
            this.tbCpf.TabIndex = 12;
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(58, 120);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(30, 13);
            this.lblCpf.TabIndex = 11;
            this.lblCpf.Text = "CPF:";
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Location = new System.Drawing.Point(-1, 85);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(105, 13);
            this.lblDataNascimento.TabIndex = 10;
            this.lblDataNascimento.Text = "Data de nascimento:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(50, 54);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 9;
            this.lblNome.Text = "Nome:";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(29, 162);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(82, 40);
            this.btnAdicionar.TabIndex = 8;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // AcessarCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 313);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.tbData);
            this.Controls.Add(this.tbCpf);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblDataNascimento);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnAdicionar);
            this.Name = "AcessarCadastro";
            this.ShowIcon = false;
            this.Text = "AcessarCadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbData;
        private System.Windows.Forms.TextBox tbCpf;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnAdicionar;
    }
}