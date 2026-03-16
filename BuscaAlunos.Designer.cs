namespace AplicativoEscola
{
    partial class btnPesquisar
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
            // 
            // cbxTipoBusca
            // 
            this.cbxTipoBusca.FormattingEnabled = true;
            this.cbxTipoBusca.Items.AddRange(new object[] {
            "NOME DO ALUNO",
            "NOME DO RESP.",
            "CPF RESP.",
            ""});
            this.cbxTipoBusca.Location = new System.Drawing.Point(461, 65);
            this.cbxTipoBusca.Name = "cbxTipoBusca";
            this.cbxTipoBusca.Size = new System.Drawing.Size(121, 21);
            this.cbxTipoBusca.TabIndex = 1;
            this.cbxTipoBusca.Text = "Tipo de Busca";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(124, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(318, 20);
            this.textBox1.TabIndex = 2;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.ForeColor = System.Drawing.Color.White;
            this.lblBuscar.Location = new System.Drawing.Point(49, 64);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(57, 19);
            this.lblBuscar.TabIndex = 3;
            this.lblBuscar.Text = "Busca:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(598, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(44)))), ((int)(((byte)(89)))));
            this.ClientSize = new System.Drawing.Size(800, 372);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cbxTipoBusca);
            this.Controls.Add(this.gridBusca);
            this.Name = "btnPesquisar";
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
    }
}