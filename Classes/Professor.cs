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
        public string nome { get; set; }
        public string dataNascimento { get; set; }
        protected string estado { get; set; }
        protected string cidade { get; set; }
        private string usuario { get; set; }
        private string senha { get; set; }
        private string cpf { get; set; }
        private string telefone { get; set; }

        Conexao conexao = new Conexao();
        string sql;
        MySqlCommand comando;

        public Professor(string nomeConst, string dataNascimentoConst, string estadoConst, string cidadeConst, string cpfConst, string telefoneConst, string usuarioConst, string senhaConst) { 
            
            nome = nomeConst;
            dataNascimento = dataNascimentoConst;
            estado = estadoConst;
            cidade = cidadeConst;
            cpf = cpfConst;
            telefone = telefoneConst;
            usuario = usuarioConst;
            senha = senhaConst;

        }


        public void CadastrarProfessor()
        {
            try
            {
                conexao.AbrirConexao();
                sql = "INSERT INTO professor (nome, dataNascimento, telefone, cpf, estado, cidade, usuario, senha) VALUES (@nome, @dataNascimento, @telefone, @cpf, @estado, @cidade, @usuario, @senha)";
                comando = new MySqlCommand(sql, conexao.conexao);
                comando.Parameters.AddWithValue("@nome", nome);
                comando.Parameters.AddWithValue("@dataNascimento", dataNascimento);
                comando.Parameters.AddWithValue("@telefone", telefone);
                comando.Parameters.AddWithValue("@cpf", cpf);
                comando.Parameters.AddWithValue("@estado", estado);
                comando.Parameters.AddWithValue("@cidade", cidade);
                comando.Parameters.AddWithValue("@usuario", usuario);
                comando.Parameters.AddWithValue("@senha", senha);
                comando.ExecuteNonQuery();
                MessageBox.Show("Professor cadastrado com sucesso!");
                

                //se der erro usar o .hide para esconder a tela cadastro e depois o .dispose para desocupar escpaço na memória
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar Professor. Erro: " + ex.Message);
            }

        }
    }
}
