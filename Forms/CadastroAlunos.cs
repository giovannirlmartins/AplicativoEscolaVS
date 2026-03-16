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
            Aluno aluno = new Aluno(txtNomeEstudante.ToString(), txtDataNascimentoAluno.ToString(), txtNomeResponsavel.ToString(), txtDataNascimentoResponsavel.ToString(), txtTelefoneResponsavel.ToString(), txtCpfResponsavel.ToString());
            aluno.CadastrarAluno();
        }
    }
}
