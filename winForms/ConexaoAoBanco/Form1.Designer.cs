namespace ConexaoAoBanco
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
            this.lvDados = new System.Windows.Forms.ListView();
            this.idMedidaGlicemia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.valorGlicemia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataMedida = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idPaciente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnConectar = new System.Windows.Forms.Button();
            this.lblidMedidaGlicemia = new System.Windows.Forms.Label();
            this.lblvalorGlicemia = new System.Windows.Forms.Label();
            this.lbldataMedida = new System.Windows.Forms.Label();
            this.lblidPaciente = new System.Windows.Forms.Label();
            this.txtvalorGlicemia = new System.Windows.Forms.TextBox();
            this.txtidMedidaGlicemia = new System.Windows.Forms.TextBox();
            this.txtdataMedida = new System.Windows.Forms.TextBox();
            this.txtidPaciente = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvDados
            // 
            this.lvDados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idMedidaGlicemia,
            this.valorGlicemia,
            this.dataMedida,
            this.idPaciente});
            this.lvDados.HideSelection = false;
            this.lvDados.Location = new System.Drawing.Point(12, 12);
            this.lvDados.Name = "lvDados";
            this.lvDados.Size = new System.Drawing.Size(544, 161);
            this.lvDados.TabIndex = 0;
            this.lvDados.UseCompatibleStateImageBehavior = false;
            this.lvDados.View = System.Windows.Forms.View.Details;
            // 
            // idMedidaGlicemia
            // 
            this.idMedidaGlicemia.Text = "idMedidaGlicemia";
            this.idMedidaGlicemia.Width = 100;
            // 
            // valorGlicemia
            // 
            this.valorGlicemia.Text = "valorGlicemia";
            this.valorGlicemia.Width = 100;
            // 
            // dataMedida
            // 
            this.dataMedida.Text = "dataMedida";
            this.dataMedida.Width = 120;
            // 
            // idPaciente
            // 
            this.idPaciente.Text = "idPaciente";
            this.idPaciente.Width = 100;
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(206, 187);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(108, 34);
            this.btnConectar.TabIndex = 1;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // lblidMedidaGlicemia
            // 
            this.lblidMedidaGlicemia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidMedidaGlicemia.Location = new System.Drawing.Point(30, 243);
            this.lblidMedidaGlicemia.Name = "lblidMedidaGlicemia";
            this.lblidMedidaGlicemia.Size = new System.Drawing.Size(131, 22);
            this.lblidMedidaGlicemia.TabIndex = 2;
            this.lblidMedidaGlicemia.Text = "idMedidaGlicemia:";
            // 
            // lblvalorGlicemia
            // 
            this.lblvalorGlicemia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvalorGlicemia.Location = new System.Drawing.Point(30, 265);
            this.lblvalorGlicemia.Name = "lblvalorGlicemia";
            this.lblvalorGlicemia.Size = new System.Drawing.Size(131, 22);
            this.lblvalorGlicemia.TabIndex = 3;
            this.lblvalorGlicemia.Text = "valorGlicemia:";
            // 
            // lbldataMedida
            // 
            this.lbldataMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldataMedida.Location = new System.Drawing.Point(30, 287);
            this.lbldataMedida.Name = "lbldataMedida";
            this.lbldataMedida.Size = new System.Drawing.Size(131, 22);
            this.lbldataMedida.TabIndex = 4;
            this.lbldataMedida.Text = "dataMedida:";
            // 
            // lblidPaciente
            // 
            this.lblidPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidPaciente.Location = new System.Drawing.Point(30, 310);
            this.lblidPaciente.Name = "lblidPaciente";
            this.lblidPaciente.Size = new System.Drawing.Size(131, 24);
            this.lblidPaciente.TabIndex = 5;
            this.lblidPaciente.Text = "idPaciente:";
            // 
            // txtvalorGlicemia
            // 
            this.txtvalorGlicemia.Location = new System.Drawing.Point(167, 265);
            this.txtvalorGlicemia.Name = "txtvalorGlicemia";
            this.txtvalorGlicemia.Size = new System.Drawing.Size(118, 20);
            this.txtvalorGlicemia.TabIndex = 6;
            // 
            // txtidMedidaGlicemia
            // 
            this.txtidMedidaGlicemia.Location = new System.Drawing.Point(167, 242);
            this.txtidMedidaGlicemia.Name = "txtidMedidaGlicemia";
            this.txtidMedidaGlicemia.Size = new System.Drawing.Size(118, 20);
            this.txtidMedidaGlicemia.TabIndex = 7;
            // 
            // txtdataMedida
            // 
            this.txtdataMedida.Location = new System.Drawing.Point(167, 288);
            this.txtdataMedida.Name = "txtdataMedida";
            this.txtdataMedida.Size = new System.Drawing.Size(118, 20);
            this.txtdataMedida.TabIndex = 8;
            // 
            // txtidPaciente
            // 
            this.txtidPaciente.Location = new System.Drawing.Point(167, 314);
            this.txtidPaciente.Name = "txtidPaciente";
            this.txtidPaciente.Size = new System.Drawing.Size(118, 20);
            this.txtidPaciente.TabIndex = 9;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(322, 242);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(94, 42);
            this.btnCadastrar.TabIndex = 10;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(322, 293);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(94, 41);
            this.btnRemover.TabIndex = 11;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 360);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtidPaciente);
            this.Controls.Add(this.txtdataMedida);
            this.Controls.Add(this.txtidMedidaGlicemia);
            this.Controls.Add(this.txtvalorGlicemia);
            this.Controls.Add(this.lblidPaciente);
            this.Controls.Add(this.lbldataMedida);
            this.Controls.Add(this.lblvalorGlicemia);
            this.Controls.Add(this.lblidMedidaGlicemia);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.lvDados);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvDados;
        private System.Windows.Forms.ColumnHeader idMedidaGlicemia;
        private System.Windows.Forms.ColumnHeader valorGlicemia;
        private System.Windows.Forms.ColumnHeader dataMedida;
        private System.Windows.Forms.ColumnHeader idPaciente;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Label lblidMedidaGlicemia;
        private System.Windows.Forms.Label lblvalorGlicemia;
        private System.Windows.Forms.Label lbldataMedida;
        private System.Windows.Forms.Label lblidPaciente;
        private System.Windows.Forms.TextBox txtvalorGlicemia;
        private System.Windows.Forms.TextBox txtidMedidaGlicemia;
        private System.Windows.Forms.TextBox txtdataMedida;
        private System.Windows.Forms.TextBox txtidPaciente;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnRemover;
    }
}

