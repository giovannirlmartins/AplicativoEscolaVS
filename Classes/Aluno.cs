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
        public string nomeAluno { get; set; }
        public string dataNascimentoAluno { get; set; }
        public string nomeResponsavel { get; set; }
        public string dataNascimentoResponsavel { get; set; }
        public string turmas { get; set; }
        public string _idAluno { get; private set; }
        public string _telefoneResponsavel { get; private set; }
        public string _cpfResponsavel { get; private set; }
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

        public void EditarAluno()
        {
            try
            {
                Conexao conexao = new Conexao();
                string sql = "UPDATE aluno SET nomeAluno = @nomeAluno, dataNascimentoAluno = @dataNascimentoAluno, nomeResponsavel = @nomeResponsavel, dataNascimentoResponsavel = @dataNascimentoResponsavel, telefoneResponsavel = @telefoneResponsavel, cpfResponsavel = @cpfResponsavel WHERE idAluno = @idAluno";
                conexao.AbrirConexao();
                MySql.Data.MySqlClient.MySqlCommand comando = new MySql.Data.MySqlClient.MySqlCommand(sql, conexao.conexao);
                comando.Parameters.AddWithValue("@nomeAluno", nomeAluno);
                comando.Parameters.AddWithValue("@dataNascimentoAluno", dataNascimentoAluno);
                comando.Parameters.AddWithValue("@nomeResponsavel", nomeResponsavel);
                comando.Parameters.AddWithValue("@dataNascimentoResponsavel", dataNascimentoResponsavel);
                comando.Parameters.AddWithValue("@telefoneResponsavel", _telefoneResponsavel);
                comando.Parameters.AddWithValue("@cpfResponsavel", _cpfResponsavel);
                comando.Parameters.AddWithValue("@idAluno", _idAluno);
                comando.ExecuteNonQuery();
                MessageBox.Show("Aluno editado com sucesso!");
                conexao.FecharConexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar aluno. Erro: " + ex.Message);
            }

        }
    }
}
