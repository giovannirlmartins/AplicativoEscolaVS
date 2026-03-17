using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicativoEscola
{
    public partial class frmAlterarAlunos : Form
    {
        
        public frmAlterarAlunos()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno(txtNomeEstudante.Text, txtDataNascimentoAluno.Text, txtNomeResponsavel.Text, txtDataNascimentoResponsavel.Text, txtTelefoneResponsavel.Text, txtCpfResponsavel.Text);
            aluno.EditarAluno();
        }

        private void frmCadastroAlunos_Load(object sender, EventArgs e)
        {
            
            frmBuscarAlunos buscarAlunos = new frmBuscarAlunos();
            Aluno alunoEditar = buscarAlunos.AlunoSelecionado();
            txtNomeEstudante.Text = alunoEditar.nomeAluno;
            txtDataNascimentoAluno.Text = alunoEditar.dataNascimentoAluno;
            txtNomeResponsavel.Text = alunoEditar.nomeResponsavel;
            txtDataNascimentoResponsavel.Text = alunoEditar.dataNascimentoResponsavel;
            txtCpfResponsavel.Text = alunoEditar._cpfResponsavel;
            txtTelefoneResponsavel.Text = alunoEditar._telefoneResponsavel;
      
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }
    }
}
