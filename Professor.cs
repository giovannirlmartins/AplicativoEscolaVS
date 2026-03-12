using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicativoEscola
{
    public class Professor
    {
        public string nome;
        public string dataNascimento;
        protected string estado;
        protected string cidade;
        private string usuario;
        private string senha;
        private string cpf;
        private string telefone;

        Conexao conexao = new Conexao();
        string sql;
        MySqlCommand comando;
        frmCadastro telaCadastro = new frmCadastro();
        frmLogin telaLogin = new frmLogin();

        public Professor() { }


        public void CadastrarProfessor()
        {
            try
            {
                conexao.AbrirConexao();
                sql = "INSERT INTO professor (nome, dataNascimento, telefone, cpf, estado, cidade, usuario, senha) VALUES " +
                    "(@nome, @datanascimento, @telefone, @cpf, @estado, @cidade, @usuario, @senha)";
                comando = new MySqlCommand(sql, conexao.conexao);
                comando.Parameters.AddWithValue("@nome", telaCadastro.nome);
                comando.Parameters.AddWithValue("@datanascimento", telaCadastro.dataNascimento);
                comando.Parameters.AddWithValue("@telefone", telaCadastro.telefone);
                comando.Parameters.AddWithValue("@cpf", telaCadastro.cpf);
                comando.Parameters.AddWithValue("@estado", telaCadastro.estado);
                comando.Parameters.AddWithValue("@cidade", telaCadastro.cidade);
                comando.Parameters.AddWithValue("@usuario", telaCadastro.usuario);
                comando.Parameters.AddWithValue("@senha", telaCadastro.senha);
                comando.ExecuteNonQuery();
                MessageBox.Show("Professor cadastrado com sucesso!");
                telaLogin.ShowDialog();
                telaCadastro.Close();
                //se der erro usar o .hide para esconder a tela cadastro e depois o .dispose para desocupar escpaço na memória
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar Professor. Erro: " + ex.Message);
            }

        }
    }
}
