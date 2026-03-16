using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicativoEscola
{
    public class Aluno
    {
        public string nomeAluno;
        public string dataNascimentoAluno;
        public string nomeResponsavel;
        public string dataNascimentoResponsavel;
        public string turmas;
        private string _idAluno;
        private string _telefoneResponsavel;
        private string _cpfResponsavel;
        public Aluno(string nomeAlunofrm, string dataNascimentoAlunofrm, string nomeReponsavelfrm, string dataNascimentoResponsavelfrm, string _telefoneResponsavelfrm, string _cpfResponsavelfrm)
        {
            nomeAluno = nomeAlunofrm;
            dataNascimentoAluno = dataNascimentoAlunofrm;
            nomeResponsavel = nomeReponsavelfrm;
            dataNascimentoResponsavel = dataNascimentoResponsavelfrm;
            _telefoneResponsavel = _telefoneResponsavelfrm;
            _cpfResponsavel = _cpfResponsavelfrm;
        }

        public void CadastrarAluno()
        {
            try
            {
                Conexao conexao = new Conexao();
                string sql = "INSERT INTO aluno (nomeAluno, dataNascimentoAluno, nomeResponsavel, dataNascimentoResponsavel, telefoneResponsavel, cpfResponsavel) VALUES (@nomeAluno, @dataNascimentoAluno, @nomeResponsavel, @dataNascimentoResponsavel, @telefoneResponsavel, @cpfResponsavel)";
                conexao.AbrirConexao();
                MySql.Data.MySqlClient.MySqlCommand comando = new MySql.Data.MySqlClient.MySqlCommand(sql, conexao.conexao);
                comando.Parameters.AddWithValue("@nomeAluno", nomeAluno);
                comando.Parameters.AddWithValue("@dataNascimentoAluno", dataNascimentoAluno);
                comando.Parameters.AddWithValue("@nomeResponsavel", nomeResponsavel);
                comando.Parameters.AddWithValue("@dataNascimentoResponsavel", dataNascimentoResponsavel);
                comando.Parameters.AddWithValue("@telefoneResponsavel", _telefoneResponsavel);
                comando.Parameters.AddWithValue("@cpfResponsavel", _cpfResponsavel);
                //comando.Parameters.AddWithValue("@turmas", turmas);
                comando.ExecuteNonQuery();
                conexao.FecharConexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar aluno. Erro: " + ex.Message);
            }
        }

    }
}
