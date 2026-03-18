using MySql.Data.MySqlClient;  
using System;
using System.Collections.Generic;
using System.Data;
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
        public int _idAluno { get; set; }
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
                MySqlCommand comando = new MySqlCommand(sql, conexao.conexao);
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

        public void ExibirAluno(Aluno mostrarAluno)
        {

        }

        public void EditarAluno(Aluno alunoEdicao, string cpfResponsavel, string telefoneResponsavel)
        {

            try
            {
                Console.WriteLine("Id do Aluno na edição inicio: " + alunoEdicao._idAluno);
                Console.WriteLine("Nome do Aluno na edição inicio: " + alunoEdicao.nomeAluno);
                Conexao conexao = new Conexao();
                string sql = "UPDATE aluno SET nomeAluno=@nomeAluno, dataNascimentoAluno=@dataNascimentoAluno, nomeResponsavel=@nomeResponsavel, dataNascimentoResponsavel=@dataNascimentoResponsavel, telefoneResponsavel=@telefoneResponsavel, cpfResponsavel=@cpfResponsavel WHERE idAluno=@idAluno";
                conexao.AbrirConexao();
                MySqlCommand comando = new MySqlCommand(sql, conexao.conexao);
                comando.Parameters.AddWithValue("@nomeAluno", alunoEdicao.nomeAluno);
                comando.Parameters.AddWithValue("@dataNascimentoAluno", alunoEdicao.dataNascimentoAluno);
                comando.Parameters.AddWithValue("@nomeResponsavel", alunoEdicao.nomeResponsavel);
                comando.Parameters.AddWithValue("@dataNascimentoResponsavel", alunoEdicao.dataNascimentoResponsavel);
                comando.Parameters.AddWithValue("@telefoneResponsavel", telefoneResponsavel);
                comando.Parameters.AddWithValue("@cpfResponsavel", cpfResponsavel);
                comando.Parameters.AddWithValue("@idAluno", alunoEdicao._idAluno);

                Console.WriteLine("Id do Aluno na edição final: " + alunoEdicao._idAluno);
                Console.WriteLine("Nome do Aluno na edição final: " + alunoEdicao.nomeAluno);
                comando.ExecuteNonQuery();
                MessageBox.Show("Aluno editado com sucesso!");
                conexao.FecharConexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar aluno. Erro: " + ex.Message);
            }

        }

        public void ExcluirAluno(Aluno alunoExcluir)
        {
            try
            {
                Conexao conexao = new Conexao();
                string sql = "DELETE FROM aluno WHERE idAluno=@idAluno";
                conexao.AbrirConexao();
                MySqlCommand comando = new MySqlCommand(sql, conexao.conexao);
                comando.Parameters.AddWithValue("@idAluno", alunoExcluir._idAluno);
                comando.ExecuteNonQuery();
                MessageBox.Show("Aluno excluído com sucesso!");
                conexao.FecharConexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir aluno. Erro: " + ex.Message);
            }
        }

       
    }
}
