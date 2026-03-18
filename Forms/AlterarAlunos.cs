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
        Aluno alunoEditar;

        public frmAlterarAlunos(Aluno alunoAlterar)
        {
            InitializeComponent();
            
            txtNomeEstudante.Text = alunoAlterar.nomeAluno;
            txtDataNascimentoAluno.Text = alunoAlterar.dataNascimentoAluno;
            txtNomeResponsavel.Text = alunoAlterar.nomeResponsavel;
            txtDataNascimentoResponsavel.Text = alunoAlterar.dataNascimentoResponsavel;
            txtCpfResponsavel.Text = alunoAlterar._cpfResponsavel;
            txtTelefoneResponsavel.Text = alunoAlterar._telefoneResponsavel;
            Console.WriteLine("Nome do Aluno na alterar aluno: " + alunoAlterar.nomeAluno);
            alunoEditar = alunoAlterar;
            Console.WriteLine("Id do Aluno na alterar aluno: " + alunoEditar._idAluno);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            alunoEditar.nomeAluno = txtNomeEstudante.Text;
            alunoEditar.dataNascimentoAluno = txtDataNascimentoAluno.Text;
            alunoEditar.nomeResponsavel = txtNomeResponsavel.Text;
            alunoEditar.dataNascimentoResponsavel = txtDataNascimentoResponsavel.Text;
            string cpfResponsavel = txtCpfResponsavel.Text;
            string telefoneResponsavel = txtTelefoneResponsavel.Text;
   
            Console.WriteLine("Id do Aluno no clique do botao: " + alunoEditar._idAluno);
            alunoEditar.EditarAluno(alunoEditar, cpfResponsavel, telefoneResponsavel);
            this.Close();
        }

        private void frmCadastroAlunos_Load(object sender, EventArgs e)
        {
            
            //frmBuscarAlunos buscarAlunos = new frmBuscarAlunos();
            //Aluno alunoEditar = buscarAlunos.AlunoSelecionado();
            //txtNomeEstudante.Text = alunoEditar.nomeAluno;
            //txtDataNascimentoAluno.Text = alunoEditar.dataNascimentoAluno;
            //txtNomeResponsavel.Text = alunoEditar.nomeResponsavel;
            //txtDataNascimentoResponsavel.Text = alunoEditar.dataNascimentoResponsavel;
            //txtCpfResponsavel.Text = alunoEditar._cpfResponsavel;
            //txtTelefoneResponsavel.Text = alunoEditar._telefoneResponsavel;
      
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }
    }
}
