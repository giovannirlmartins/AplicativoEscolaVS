using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicativoEscola
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblBemVindo.Text = "Bem-vindo, Prof. " + SessãoSistema.nomeUsuario.Split(' ')[0] + "!";
        }

        private void buscaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // precisa chamar a tela de busca de alunos
        }

        private void alunosCadastro_Click(object sender, EventArgs e)
        {
            // precisa chamar a tela de cadastro de alunos
            frmCadastroAlunos cadastroAlunos = new frmCadastroAlunos();
            cadastroAlunos.TopLevel = false;
            cadastroAlunos.FormBorderStyle = FormBorderStyle.None;
            cadastroAlunos.Dock = DockStyle.Fill;
            pnlConteudo.Controls.Clear();
            pnlConteudo.Controls.Add(cadastroAlunos);
            cadastroAlunos.Show();
        }

        private void novaAvaliaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void buscaAlunos_Click(object sender, EventArgs e)
        {
            //precisa chamar a tela de busca de alunos
            frmBuscarAlunos buscaAlunos = new frmBuscarAlunos();
            buscaAlunos.TopLevel = false;
            buscaAlunos.FormBorderStyle = FormBorderStyle.None;
            buscaAlunos.Dock = DockStyle.Fill;
            pnlConteudo.Controls.Clear();
            pnlConteudo.Controls.Add(buscaAlunos);
            buscaAlunos.Show();

        }
    }
}
