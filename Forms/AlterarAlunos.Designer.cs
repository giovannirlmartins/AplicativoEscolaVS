namespace AplicativoEscola
{
    partial class frmAlterarAlunos
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
            this.txtNomeEstudante = new System.Windows.Forms.TextBox();
            this.lblEditarEstudante = new System.Windows.Forms.Label();
            this.clbTurmas = new System.Windows.Forms.CheckedListBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblNomeEstudante = new System.Windows.Forms.Label();
            this.lblDataNascimentoResponsavel = new System.Windows.Forms.Label();
            this.lblNomeResponsavel = new System.Windows.Forms.Label();
            this.txtNomeResponsavel = new System.Windows.Forms.TextBox();
            this.lblDataNascimentoAluno = new System.Windows.Forms.Label();
            this.lblTelefoneResponsavel = new System.Windows.Forms.Label();
            this.txtDataNascimentoAluno = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDataNascimentoResponsavel = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefoneResponsavel = new System.Windows.Forms.MaskedTextBox();
            this.txtCpfResponsavel = new System.Windows.Forms.MaskedTextBox();
            this.lblTurma = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNomeEstudante
            // 
            this.txtNomeEstudante.Location = new System.Drawing.Point(154, 67);
            this.txtNomeEstudante.Name = "txtNomeEstudante";
            this.txtNomeEstudante.Size = new System.Drawing.Size(255, 20);
            this.txtNomeEstudante.TabIndex = 0;
            // 
            // lblEditarEstudante
            // 
            this.lblEditarEstudante.AutoSize = true;
            this.lblEditarEstudante.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditarEstudante.ForeColor = System.Drawing.Color.White;
            this.lblEditarEstudante.Location = new System.Drawing.Point(29, 28);
            this.lblEditarEstudante.Name = "lblEditarEstudante";
            this.lblEditarEstudante.Size = new System.Drawing.Size(134, 19);
            this.lblEditarEstudante.TabIndex = 1;
            this.lblEditarEstudante.Text = "Editar Estudante";
            // 
            // clbTurmas
            // 
            this.clbTurmas.FormattingEnabled = true;
            this.clbTurmas.Location = new System.Drawing.Point(427, 88);
            this.clbTurmas.Name = "clbTurmas";
            this.clbTurmas.Size = new System.Drawing.Size(210, 139);
            this.clbTurmas.TabIndex = 2;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(33, 243);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(175, 23);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblNomeEstudante
            // 
            this.lblNomeEstudante.AutoSize = true;
            this.lblNomeEstudante.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeEstudante.ForeColor = System.Drawing.Color.White;
            this.lblNomeEstudante.Location = new System.Drawing.Point(30, 68);
            this.lblNomeEstudante.Name = "lblNomeEstudante";
            this.lblNomeEstudante.Size = new System.Drawing.Size(118, 16);
            this.lblNomeEstudante.TabIndex = 4;
            this.lblNomeEstudante.Text = "Nome do Aluno(a):";
            // 
            // lblDataNascimentoResponsavel
            // 
            this.lblDataNascimentoResponsavel.AutoSize = true;
            this.lblDataNascimentoResponsavel.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNascimentoResponsavel.ForeColor = System.Drawing.Color.White;
            this.lblDataNascimentoResponsavel.Location = new System.Drawing.Point(30, 205);
            this.lblDataNascimentoResponsavel.Name = "lblDataNascimentoResponsavel";
            this.lblDataNascimentoResponsavel.Size = new System.Drawing.Size(165, 16);
            this.lblDataNascimentoResponsavel.TabIndex = 6;
            this.lblDataNascimentoResponsavel.Text = "Data de Nascimento Resp.:";
            // 
            // lblNomeResponsavel
            // 
            this.lblNomeResponsavel.AutoSize = true;
            this.lblNomeResponsavel.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeResponsavel.ForeColor = System.Drawing.Color.White;
            this.lblNomeResponsavel.Location = new System.Drawing.Point(30, 138);
            this.lblNomeResponsavel.Name = "lblNomeResponsavel";
            this.lblNomeResponsavel.Size = new System.Drawing.Size(143, 16);
            this.lblNomeResponsavel.TabIndex = 8;
            this.lblNomeResponsavel.Text = "Nome do Responsável:";
            // 
            // txtNomeResponsavel
            // 
            this.txtNomeResponsavel.Location = new System.Drawing.Point(179, 138);
            this.txtNomeResponsavel.Name = "txtNomeResponsavel";
            this.txtNomeResponsavel.Size = new System.Drawing.Size(230, 20);
            this.txtNomeResponsavel.TabIndex = 7;
            // 
            // lblDataNascimentoAluno
            // 
            this.lblDataNascimentoAluno.AutoSize = true;
            this.lblDataNascimentoAluno.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNascimentoAluno.ForeColor = System.Drawing.Color.White;
            this.lblDataNascimentoAluno.Location = new System.Drawing.Point(30, 104);
            this.lblDataNascimentoAluno.Name = "lblDataNascimentoAluno";
            this.lblDataNascimentoAluno.Size = new System.Drawing.Size(201, 16);
            this.lblDataNascimentoAluno.TabIndex = 9;
            this.lblDataNascimentoAluno.Text = "Data de Nascimento do Aluno(a):";
            // 
            // lblTelefoneResponsavel
            // 
            this.lblTelefoneResponsavel.AutoSize = true;
            this.lblTelefoneResponsavel.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefoneResponsavel.ForeColor = System.Drawing.Color.White;
            this.lblTelefoneResponsavel.Location = new System.Drawing.Point(30, 172);
            this.lblTelefoneResponsavel.Name = "lblTelefoneResponsavel";
            this.lblTelefoneResponsavel.Size = new System.Drawing.Size(96, 16);
            this.lblTelefoneResponsavel.TabIndex = 10;
            this.lblTelefoneResponsavel.Text = "Telefone Resp.:";
            // 
            // txtDataNascimentoAluno
            // 
            this.txtDataNascimentoAluno.Location = new System.Drawing.Point(238, 104);
            this.txtDataNascimentoAluno.Mask = "00/00/0000";
            this.txtDataNascimentoAluno.Name = "txtDataNascimentoAluno";
            this.txtDataNascimentoAluno.Size = new System.Drawing.Size(72, 20);
            this.txtDataNascimentoAluno.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(243, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "CPF Resp.:";
            // 
            // txtDataNascimentoResponsavel
            // 
            this.txtDataNascimentoResponsavel.Location = new System.Drawing.Point(201, 205);
            this.txtDataNascimentoResponsavel.Mask = "00/00/0000";
            this.txtDataNascimentoResponsavel.Name = "txtDataNascimentoResponsavel";
            this.txtDataNascimentoResponsavel.Size = new System.Drawing.Size(72, 20);
            this.txtDataNascimentoResponsavel.TabIndex = 13;
            // 
            // txtTelefoneResponsavel
            // 
            this.txtTelefoneResponsavel.Location = new System.Drawing.Point(137, 172);
            this.txtTelefoneResponsavel.Mask = "(00)00000-0000";
            this.txtTelefoneResponsavel.Name = "txtTelefoneResponsavel";
            this.txtTelefoneResponsavel.Size = new System.Drawing.Size(94, 20);
            this.txtTelefoneResponsavel.TabIndex = 14;
            // 
            // txtCpfResponsavel
            // 
            this.txtCpfResponsavel.Location = new System.Drawing.Point(316, 172);
            this.txtCpfResponsavel.Mask = "000.000.000-00";
            this.txtCpfResponsavel.Name = "txtCpfResponsavel";
            this.txtCpfResponsavel.Size = new System.Drawing.Size(93, 20);
            this.txtCpfResponsavel.TabIndex = 15;
            // 
            // lblTurma
            // 
            this.lblTurma.AutoSize = true;
            this.lblTurma.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurma.ForeColor = System.Drawing.Color.White;
            this.lblTurma.Location = new System.Drawing.Point(424, 67);
            this.lblTurma.Name = "lblTurma";
            this.lblTurma.Size = new System.Drawing.Size(47, 16);
            this.lblTurma.TabIndex = 16;
            this.lblTurma.Text = "Turma:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(238, 243);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(175, 23);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmAlterarAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(44)))), ((int)(((byte)(89)))));
            this.ClientSize = new System.Drawing.Size(667, 288);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblTurma);
            this.Controls.Add(this.txtCpfResponsavel);
            this.Controls.Add(this.txtTelefoneResponsavel);
            this.Controls.Add(this.txtDataNascimentoResponsavel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDataNascimentoAluno);
            this.Controls.Add(this.lblTelefoneResponsavel);
            this.Controls.Add(this.lblDataNascimentoAluno);
            this.Controls.Add(this.lblNomeResponsavel);
            this.Controls.Add(this.txtNomeResponsavel);
            this.Controls.Add(this.lblDataNascimentoResponsavel);
            this.Controls.Add(this.lblNomeEstudante);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.clbTurmas);
            this.Controls.Add(this.lblEditarEstudante);
            this.Controls.Add(this.txtNomeEstudante);
            this.Name = "frmAlterarAlunos";
            this.Text = "Editar Alunos";
            this.Load += new System.EventHandler(this.frmCadastroAlunos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeEstudante;
        private System.Windows.Forms.Label lblEditarEstudante;
        private System.Windows.Forms.CheckedListBox clbTurmas;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblNomeEstudante;
        private System.Windows.Forms.Label lblDataNascimentoResponsavel;
        private System.Windows.Forms.Label lblNomeResponsavel;
        private System.Windows.Forms.TextBox txtNomeResponsavel;
        private System.Windows.Forms.Label lblDataNascimentoAluno;
        private System.Windows.Forms.Label lblTelefoneResponsavel;
        private System.Windows.Forms.MaskedTextBox txtDataNascimentoAluno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtDataNascimentoResponsavel;
        private System.Windows.Forms.MaskedTextBox txtTelefoneResponsavel;
        private System.Windows.Forms.MaskedTextBox txtCpfResponsavel;
        private System.Windows.Forms.Label lblTurma;
        private System.Windows.Forms.Button btnCancelar;
    }
}