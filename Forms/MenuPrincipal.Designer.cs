namespace AplicativoEscola
{
    partial class frmPrincipal
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
            this.lblBemVindo = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.turmasMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroTurmasMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.buscaTurmas = new System.Windows.Forms.ToolStripMenuItem();
            this.alunosMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.alunosCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.buscaAlunos = new System.Windows.Forms.ToolStripMenuItem();
            this.avaliacoesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.novaAvaliacaoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlConteudo = new System.Windows.Forms.Panel();
            this.adicionarNotasMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBemVindo
            // 
            this.lblBemVindo.AutoSize = true;
            this.lblBemVindo.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBemVindo.ForeColor = System.Drawing.Color.White;
            this.lblBemVindo.Location = new System.Drawing.Point(529, 32);
            this.lblBemVindo.Name = "lblBemVindo";
            this.lblBemVindo.Size = new System.Drawing.Size(219, 19);
            this.lblBemVindo.TabIndex = 0;
            this.lblBemVindo.Text = "Bem-Vindo Prof.  Fulanenilson";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.turmasMenu,
            this.alunosMenu,
            this.avaliacoesMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // turmasMenu
            // 
            this.turmasMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroTurmasMenu,
            this.buscaTurmas});
            this.turmasMenu.Name = "turmasMenu";
            this.turmasMenu.Size = new System.Drawing.Size(59, 20);
            this.turmasMenu.Text = "Turmas";
            // 
            // cadastroTurmasMenu
            // 
            this.cadastroTurmasMenu.Name = "cadastroTurmasMenu";
            this.cadastroTurmasMenu.Size = new System.Drawing.Size(180, 22);
            this.cadastroTurmasMenu.Text = "Cadastro";
            // 
            // buscaTurmas
            // 
            this.buscaTurmas.Name = "buscaTurmas";
            this.buscaTurmas.Size = new System.Drawing.Size(180, 22);
            this.buscaTurmas.Text = "Busca";
            this.buscaTurmas.Click += new System.EventHandler(this.buscaToolStripMenuItem1_Click);
            // 
            // alunosMenu
            // 
            this.alunosMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alunosCadastro,
            this.buscaAlunos});
            this.alunosMenu.Name = "alunosMenu";
            this.alunosMenu.Size = new System.Drawing.Size(56, 20);
            this.alunosMenu.Text = "Alunos";
            // 
            // alunosCadastro
            // 
            this.alunosCadastro.Name = "alunosCadastro";
            this.alunosCadastro.Size = new System.Drawing.Size(180, 22);
            this.alunosCadastro.Text = "Cadastro";
            this.alunosCadastro.Click += new System.EventHandler(this.alunosCadastro_Click);
            // 
            // buscaAlunos
            // 
            this.buscaAlunos.Name = "buscaAlunos";
            this.buscaAlunos.Size = new System.Drawing.Size(180, 22);
            this.buscaAlunos.Text = "Busca";
            this.buscaAlunos.Click += new System.EventHandler(this.buscaAlunos_Click);
            // 
            // avaliacoesMenu
            // 
            this.avaliacoesMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaAvaliacaoMenu,
            this.adicionarNotasMenu});
            this.avaliacoesMenu.Name = "avaliacoesMenu";
            this.avaliacoesMenu.Size = new System.Drawing.Size(75, 20);
            this.avaliacoesMenu.Text = "Avaliações";
            // 
            // novaAvaliacaoMenu
            // 
            this.novaAvaliacaoMenu.Name = "novaAvaliacaoMenu";
            this.novaAvaliacaoMenu.Size = new System.Drawing.Size(180, 22);
            this.novaAvaliacaoMenu.Text = "Nova Avaliação";
            // 
            // pnlConteudo
            // 
            this.pnlConteudo.Location = new System.Drawing.Point(1, 59);
            this.pnlConteudo.Name = "pnlConteudo";
            this.pnlConteudo.Size = new System.Drawing.Size(798, 389);
            this.pnlConteudo.TabIndex = 2;
            // 
            // adicionarNotasMenu
            // 
            this.adicionarNotasMenu.Name = "adicionarNotasMenu";
            this.adicionarNotasMenu.Size = new System.Drawing.Size(180, 22);
            this.adicionarNotasMenu.Text = "Adicionar Notas";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(44)))), ((int)(((byte)(89)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlConteudo);
            this.Controls.Add(this.lblBemVindo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "Escola Viver Bem";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBemVindo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem turmasMenu;
        private System.Windows.Forms.ToolStripMenuItem cadastroTurmasMenu;
        private System.Windows.Forms.ToolStripMenuItem buscaTurmas;
        private System.Windows.Forms.ToolStripMenuItem alunosMenu;
        private System.Windows.Forms.ToolStripMenuItem alunosCadastro;
        private System.Windows.Forms.ToolStripMenuItem buscaAlunos;
        private System.Windows.Forms.ToolStripMenuItem avaliacoesMenu;
        private System.Windows.Forms.ToolStripMenuItem novaAvaliacaoMenu;
        private System.Windows.Forms.Panel pnlConteudo;
        private System.Windows.Forms.ToolStripMenuItem adicionarNotasMenu;
    }
}

