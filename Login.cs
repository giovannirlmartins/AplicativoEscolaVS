using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AplicativoEscola
{
    public partial class frmLogin : Form
    {
        Conexao conexao = new Conexao();
        string sql;
        MySqlCommand comando;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.AbrirConexao();
                sql = "SELECT * FROM professor WHERE usuario = @usuario AND senha = @senha";
                comando = new MySqlCommand(sql, conexao.conexao);
                // responsável por ler os dados retornados do banco de dados
                MySqlDataReader reader;
                // responsável por preencher os dados retornados do banco de dados em um DataTable ou DataSet
                MySqlDataAdapter adapter = new MySqlDataAdapter(); 
                adapter.SelectCommand = comando;
                comando.Parameters.AddWithValue("@usuario", txtUsuario.Text);
                comando.Parameters.AddWithValue("@senha", txtSenha.Text);
                reader = comando.ExecuteReader();

                if(reader.HasRows)
                {
                    MessageBox.Show("Login realizado com sucesso!");
                    this.Hide();
                    frmPrincipal menuPrincipal = new frmPrincipal();
                    menuPrincipal.ShowDialog();                    
                    this.Dispose();
                    
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorretos. Tente novamente.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao realizar login. Erro: " + ex.Message);
            }
        }
    }
}
