namespace AplicativoEscola
{
    partial class frmBuscarAlunos
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
            this.gridBusca = new System.Windows.Forms.DataGridView();
            this.cbxTipoBusca = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEditarAluno = new System.Windows.Forms.Button();
            this.btnExcluirAluno = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridBusca)).BeginInit();
            this.SuspendLayout();
            // 
            // gridBusca
            // 
            this.gridBusca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBusca.Location = new System.Drawing.Point(12, 92);
            this.gridBusca.Name = "gridBusca";
            this.gridBusca.Size = new System.Drawing.Size(776, 256);
            this.gridBusca.TabIndex = 0;
            this.gridBusca.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridBusca_CellContentClick);
            // 
            // cbxTipoBusca
            // 
            this.cbxTipoBusca.FormattingEnabled = true;
            this.cbxTipoBusca.Items.AddRange(new object[] {
            "NOME DO ALUNO",
            "NOME DO RESP.",
            "CPF RESP.",
            ""});
            this.cbxTipoBusca.Location = new System.Drawing.Point(402, 65);
            this.cbxTipoBusca.Name = "cbxTipoBusca";
            this.cbxTipoBusca.Size = new System.Drawing.Size(103, 21);
            this.cbxTipoBusca.TabIndex = 1;
            this.cbxTipoBusca.Text = "Tipo de Busca";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(76, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(318, 20);
            this.textBox1.TabIndex = 2;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.ForeColor = System.Drawing.Color.White;
            this.lblBuscar.Location = new System.Drawing.Point(13, 64);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(57, 19);
            this.lblBuscar.TabIndex = 3;
            this.lblBuscar.Text = "Busca:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(511, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnEditarAluno
            // 
            this.btnEditarAluno.Location = new System.Drawing.Point(596, 65);
            this.btnEditarAluno.Name = "btnEditarAluno";
            this.btnEditarAluno.Size = new System.Drawing.Size(93, 23);
            this.btnEditarAluno.TabIndex = 5;
            this.btnEditarAluno.Text = "Editar";
            this.btnEditarAluno.UseVisualStyleBackColor = true;
            this.btnEditarAluno.Click += new System.EventHandler(this.btnEditarAluno_Click);
            // 
            // btnExcluirAluno
            // 
            this.btnExcluirAluno.Location = new System.Drawing.Point(695, 65);
            this.btnExcluirAluno.Name = "btnExcluirAluno";
            this.btnExcluirAluno.Size = new System.Drawing.Size(93, 23);
            this.btnExcluirAluno.TabIndex = 6;
            this.btnExcluirAluno.Text = "Excluir";
            this.btnExcluirAluno.UseVisualStyleBackColor = true;
            // 
            // frmBuscarAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(44)))), ((int)(((byte)(89)))));
            this.ClientSize = new System.Drawing.Size(800, 372);
            this.Controls.Add(this.btnExcluirAluno);
            this.Controls.Add(this.btnEditarAluno);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cbxTipoBusca);
            this.Controls.Add(this.gridBusca);
            this.Name = "frmBuscarAlunos";
            this.Load += new System.EventHandler(this.btnPesquisar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridBusca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridBusca;
        private System.Windows.Forms.ComboBox cbxTipoBusca;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEditarAluno;
        private System.Windows.Forms.Button btnExcluirAluno;
    }
}