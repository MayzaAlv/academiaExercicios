namespace exercicioSerializacao
{
    partial class Serializacao
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
            this.btnSerializar = new System.Windows.Forms.Button();
            this.btnDesserializar = new System.Windows.Forms.Button();
            this.tbLista = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(18, 111);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(79, 40);
            this.btnAdicionar.TabIndex = 0;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(15, 26);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(97, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome do paciente:";
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Location = new System.Drawing.Point(15, 54);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(105, 13);
            this.lblDataNascimento.TabIndex = 2;
            this.lblDataNascimento.Text = "Data de nascimento:";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(67, 78);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(30, 13);
            this.lblCpf.TabIndex = 3;
            this.lblCpf.Text = "CPF:";
            // 
            // tbCpf
            // 
            this.tbCpf.Location = new System.Drawing.Point(119, 73);
            this.tbCpf.Name = "tbCpf";
            this.tbCpf.Size = new System.Drawing.Size(187, 20);
            this.tbCpf.TabIndex = 4;
            // 
            // tbData
            // 
            this.tbData.Location = new System.Drawing.Point(119, 47);
            this.tbData.Name = "tbData";
            this.tbData.Size = new System.Drawing.Size(187, 20);
            this.tbData.TabIndex = 5;
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(119, 19);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(187, 20);
            this.tbNome.TabIndex = 6;
            // 
            // btnSerializar
            // 
            this.btnSerializar.Location = new System.Drawing.Point(119, 111);
            this.btnSerializar.Name = "btnSerializar";
            this.btnSerializar.Size = new System.Drawing.Size(82, 40);
            this.btnSerializar.TabIndex = 7;
            this.btnSerializar.Text = "Serializar";
            this.btnSerializar.UseVisualStyleBackColor = true;
            this.btnSerializar.Click += new System.EventHandler(this.btnSerializar_Click);
            // 
            // btnDesserializar
            // 
            this.btnDesserializar.Location = new System.Drawing.Point(224, 111);
            this.btnDesserializar.Name = "btnDesserializar";
            this.btnDesserializar.Size = new System.Drawing.Size(82, 40);
            this.btnDesserializar.TabIndex = 8;
            this.btnDesserializar.Text = "Desserializar";
            this.btnDesserializar.UseVisualStyleBackColor = true;
            this.btnDesserializar.Click += new System.EventHandler(this.btnDesserializar_Click);
            // 
            // tbLista
            // 
            this.tbLista.Location = new System.Drawing.Point(18, 171);
            this.tbLista.Multiline = true;
            this.tbLista.Name = "tbLista";
            this.tbLista.Size = new System.Drawing.Size(288, 142);
            this.tbLista.TabIndex = 9;
            // 
            // Serializacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 325);
            this.Controls.Add(this.tbLista);
            this.Controls.Add(this.btnDesserializar);
            this.Controls.Add(this.btnSerializar);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.tbData);
            this.Controls.Add(this.tbCpf);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblDataNascimento);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnAdicionar);
            this.Name = "Serializacao";
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
        private System.Windows.Forms.Button btnSerializar;
        private System.Windows.Forms.Button btnDesserializar;
        private System.Windows.Forms.TextBox tbLista;
    }
}

