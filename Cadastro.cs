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
    public partial class frmCadastro : Form
    {
        public string nome;
        public string dataNascimento;
        public string telefone;
        public string cidade;
        public string estado;
        public string usuario;
        public string cpf;
        public string senha;
        Professor professorObjeto = new Professor();
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {
            
        }


        private void btnCadastro_Click(object sender, EventArgs e)
        {
            nome = txtNome.Text;
            dataNascimento = txtDataNascimento.Text;
            telefone = txtTelefone.Text;
            cidade = txtCidade.Text;
            estado = txtEstado.Text;
            cpf = txtCPF.Text;
            usuario = txtUsuario.Text;
            senha = txtSenha.Text;
            professorObjeto.CadastrarProfessor();
        }
    }
}
