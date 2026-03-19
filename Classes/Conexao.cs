using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace AplicativoEscola
{
    public class Conexao
    {
        // 4 informações principais
        //string servidor = "localhost";
        //string bancoDeDados = "aplicativoescola";
        //string usuario = "root";
        //string senha = "";

        // objeto de conexão
        public MySqlConnection conexao = null;


        public void AbrirConexao()
        {
            try
            {
                // string de conexão
                string caminhoConexao = ConfigurationManager.ConnectionStrings["MinhaConexaoMysql"].ConnectionString;
                //$"server={servidor}; database={bancoDeDados}; user={usuario}; password={senha}";
                conexao = new MySqlConnection(caminhoConexao);

                conexao.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Abrir banco de dados. Erro: " + ex.Message);
            }
        }

        public void FecharConexao()
        {
            try
            {
                // string de conexão
                string caminhoConexao = ConfigurationManager.ConnectionStrings["MinhaConexaoMysql"].ConnectionString;
                conexao = new MySqlConnection(caminhoConexao);

                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Fechar banco de dados. Erro: " + ex.Message);
            }
        }






    }
}
