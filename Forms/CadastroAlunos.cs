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
    public partial class frmCadastroAlunos : Form
    {
        public frmCadastroAlunos()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno(txtNomeEstudante.Text, txtDataNascimentoAluno.Text, txtNomeResponsavel.Text, txtDataNascimentoResponsavel.Text, txtTelefoneResponsavel.Text, txtCpfResponsavel.Text);
            aluno.CadastrarAluno();
        }

        private void frmCadastroAlunos_Load(object sender, EventArgs e)
        {

        }
    }
}
