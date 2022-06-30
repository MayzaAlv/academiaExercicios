namespace exercicioSerializacao
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.tbCpf = new System.Windows.Forms.TextBox();
            this.tbData = new System.Windows.Forms.TextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(38, 171);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(82, 40);
            this.btnAdicionar.TabIndex = 0;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(59, 63);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Location = new System.Drawing.Point(8, 94);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(105, 13);
            this.lblDataNascimento.TabIndex = 2;
            this.lblDataNascimento.Text = "Data de nascimento:";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(67, 129);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(30, 13);
            this.lblCpf.TabIndex = 3;
            this.lblCpf.Text = "CPF:";
            // 
            // tbCpf
            // 
            this.tbCpf.Location = new System.Drawing.Point(119, 122);
            this.tbCpf.Name = "tbCpf";
            this.tbCpf.Size = new System.Drawing.Size(120, 20);
            this.tbCpf.TabIndex = 4;
            // 
            // tbData
            // 
            this.tbData.Location = new System.Drawing.Point(119, 87);
            this.tbData.Name = "tbData";
            this.tbData.Size = new System.Drawing.Size(120, 20);
            this.tbData.TabIndex = 5;
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(119, 56);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(120, 20);
            this.tbNome.TabIndex = 6;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(147, 171);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(82, 40);
            this.btnFinalizar.TabIndex = 7;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 40);
            this.button1.TabIndex = 8;
            this.button1.Text = "oi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 313);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.tbData);
            this.Controls.Add(this.tbCpf);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblDataNascimento);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnAdicionar);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.TextBox tbCpf;
        private System.Windows.Forms.TextBox tbData;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button button1;
    }
}

