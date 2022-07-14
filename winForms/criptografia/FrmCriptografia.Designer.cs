namespace criptografia
{
    partial class FrmCriptografia
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
            this.lblFrase = new System.Windows.Forms.Label();
            this.tbFrase = new System.Windows.Forms.TextBox();
            this.btnCriptoAssimetrico = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCripto = new System.Windows.Forms.Label();
            this.btnDescriptoAssimetrico = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDescripto = new System.Windows.Forms.Label();
            this.tbChave = new System.Windows.Forms.TextBox();
            this.lblChave = new System.Windows.Forms.Label();
            this.btnCriptoSimetrico = new System.Windows.Forms.Button();
            this.btnDescriptoSimetrico = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFrase
            // 
            this.lblFrase.AutoSize = true;
            this.lblFrase.Location = new System.Drawing.Point(12, 55);
            this.lblFrase.Name = "lblFrase";
            this.lblFrase.Size = new System.Drawing.Size(36, 13);
            this.lblFrase.TabIndex = 0;
            this.lblFrase.Text = "Frase:";
            // 
            // tbFrase
            // 
            this.tbFrase.Location = new System.Drawing.Point(138, 48);
            this.tbFrase.Name = "tbFrase";
            this.tbFrase.Size = new System.Drawing.Size(136, 20);
            this.tbFrase.TabIndex = 1;
            // 
            // btnCriptoAssimetrico
            // 
            this.btnCriptoAssimetrico.Location = new System.Drawing.Point(199, 86);
            this.btnCriptoAssimetrico.Name = "btnCriptoAssimetrico";
            this.btnCriptoAssimetrico.Size = new System.Drawing.Size(75, 38);
            this.btnCriptoAssimetrico.TabIndex = 2;
            this.btnCriptoAssimetrico.Text = "Cripto Assimetrico";
            this.btnCriptoAssimetrico.UseVisualStyleBackColor = true;
            this.btnCriptoAssimetrico.Click += new System.EventHandler(this.btnCriptoAssimetrico_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Frase Criptografada:";
            // 
            // lblCripto
            // 
            this.lblCripto.AutoSize = true;
            this.lblCripto.Location = new System.Drawing.Point(117, 135);
            this.lblCripto.Name = "lblCripto";
            this.lblCripto.Size = new System.Drawing.Size(0, 13);
            this.lblCripto.TabIndex = 6;
            // 
            // btnDescriptoAssimetrico
            // 
            this.btnDescriptoAssimetrico.Location = new System.Drawing.Point(199, 161);
            this.btnDescriptoAssimetrico.Name = "btnDescriptoAssimetrico";
            this.btnDescriptoAssimetrico.Size = new System.Drawing.Size(75, 35);
            this.btnDescriptoAssimetrico.TabIndex = 7;
            this.btnDescriptoAssimetrico.Text = "Descripto Assimetrico";
            this.btnDescriptoAssimetrico.UseVisualStyleBackColor = true;
            this.btnDescriptoAssimetrico.Click += new System.EventHandler(this.btnDescriptoAssimetrico_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Frase Descriptografada:";
            // 
            // lblDescripto
            // 
            this.lblDescripto.AutoSize = true;
            this.lblDescripto.Location = new System.Drawing.Point(138, 212);
            this.lblDescripto.Name = "lblDescripto";
            this.lblDescripto.Size = new System.Drawing.Size(0, 13);
            this.lblDescripto.TabIndex = 9;
            // 
            // tbChave
            // 
            this.tbChave.Location = new System.Drawing.Point(338, 48);
            this.tbChave.Name = "tbChave";
            this.tbChave.Size = new System.Drawing.Size(76, 20);
            this.tbChave.TabIndex = 10;
            // 
            // lblChave
            // 
            this.lblChave.AutoSize = true;
            this.lblChave.Location = new System.Drawing.Point(291, 55);
            this.lblChave.Name = "lblChave";
            this.lblChave.Size = new System.Drawing.Size(41, 13);
            this.lblChave.TabIndex = 11;
            this.lblChave.Text = "Chave:";
            // 
            // btnCriptoSimetrico
            // 
            this.btnCriptoSimetrico.Location = new System.Drawing.Point(339, 86);
            this.btnCriptoSimetrico.Name = "btnCriptoSimetrico";
            this.btnCriptoSimetrico.Size = new System.Drawing.Size(75, 38);
            this.btnCriptoSimetrico.TabIndex = 12;
            this.btnCriptoSimetrico.Text = "Cripto Simetrico";
            this.btnCriptoSimetrico.UseVisualStyleBackColor = true;
            this.btnCriptoSimetrico.Click += new System.EventHandler(this.btnCriptoSimetrico_Click);
            // 
            // btnDescriptoSimetrico
            // 
            this.btnDescriptoSimetrico.Location = new System.Drawing.Point(339, 158);
            this.btnDescriptoSimetrico.Name = "btnDescriptoSimetrico";
            this.btnDescriptoSimetrico.Size = new System.Drawing.Size(75, 38);
            this.btnDescriptoSimetrico.TabIndex = 13;
            this.btnDescriptoSimetrico.Text = "Descripto Simetrico";
            this.btnDescriptoSimetrico.UseVisualStyleBackColor = true;
            this.btnDescriptoSimetrico.Click += new System.EventHandler(this.btnDescriptoSimetrico_Click);
            // 
            // FrmCriptografia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 267);
            this.Controls.Add(this.btnDescriptoSimetrico);
            this.Controls.Add(this.btnCriptoSimetrico);
            this.Controls.Add(this.lblChave);
            this.Controls.Add(this.tbChave);
            this.Controls.Add(this.lblDescripto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDescriptoAssimetrico);
            this.Controls.Add(this.lblCripto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCriptoAssimetrico);
            this.Controls.Add(this.tbFrase);
            this.Controls.Add(this.lblFrase);
            this.Name = "FrmCriptografia";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFrase;
        private System.Windows.Forms.TextBox tbFrase;
        private System.Windows.Forms.Button btnCriptoAssimetrico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCripto;
        private System.Windows.Forms.Button btnDescriptoAssimetrico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDescripto;
        private System.Windows.Forms.TextBox tbChave;
        private System.Windows.Forms.Label lblChave;
        private System.Windows.Forms.Button btnCriptoSimetrico;
        private System.Windows.Forms.Button btnDescriptoSimetrico;
    }
}

