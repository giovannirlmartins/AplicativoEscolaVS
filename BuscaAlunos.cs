using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AplicativoEscola
{
    public partial class frmBuscarAlunos : Form
    {
        Conexao conexao = new Conexao();
        string sql;
        MySqlCommand comando;
        string nomeAluno;
        int idAluno;
        string dataNascimentoAluno;
        string nomeResponsavel;
        string dataNascimentoResponsavel;
        string telefoneResponsavel;
        string cpfResponsavel;

        public frmBuscarAlunos()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Load(object sender, EventArgs e)
        {
            ListarAlunos();
        }

        private void FormatarTopoTabela()
        {
            gridBusca.Columns[0].HeaderText = "Nome do Aluno";
            gridBusca.Columns[1].HeaderText = "Data de Nasc. Aluno";
            gridBusca.Columns[2].HeaderText = "Nome do Responsável";
            gridBusca.Columns[3].HeaderText = "Data Nasc. Resp.";
            gridBusca.Columns[4].HeaderText = "Telefone";
            gridBusca.Columns[5].HeaderText = "CPF Resp.";
            gridBusca.Columns[6].HeaderText = "Turmas";
            gridBusca.Columns[7].HeaderText = "Id Aluno";
        }

        private void ListarAlunos()
        {
            try
            {
                conexao.AbrirConexao();
                sql = "SELECT * FROM aluno ORDER BY nomeAluno ASC";
                comando = new MySqlCommand(sql, conexao.conexao);
                MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                adapter.SelectCommand = comando;
                //NOVIDADES: DataTable é uma classe que representa uma tabela de dados em memória,
                //permitindo armazenar e manipular os dados retornados do banco de dados.
                DataTable tabela = new DataTable();
                adapter.Fill(tabela); // responsável por preencher a tabela com os dados retornados do banco de dados
                gridBusca.DataSource = tabela; // responsável por exibir os dados na grade de busca
                conexao.FecharConexao();
                FormatarTopoTabela();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar alunos. Erro: " + ex.Message);

            }
        }

        public void gridBusca_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Para pegar informações da linha selecionada na grade de busca, você pode usar o
            // evento CellContentClick do DataGridView. As informações da linha selecionada
            // podem ser acessadas através do índice da linha (e.RowIndex) e do índice da coluna (e.ColumnIndex).

            nomeAluno = gridBusca.CurrentRow.Cells[0].Value.ToString();
            Console.WriteLine("nome do Aluno: " + nomeAluno);
            idAluno = int.Parse(gridBusca.CurrentRow.Cells[7].Value.ToString());
            dataNascimentoAluno = gridBusca.CurrentRow.Cells[1].Value.ToString();
            nomeResponsavel = gridBusca.CurrentRow.Cells[2].Value.ToString();
            dataNascimentoResponsavel = gridBusca.CurrentRow.Cells[3].Value.ToString();
            telefoneResponsavel = gridBusca.CurrentRow.Cells[4].Value.ToString();
            cpfResponsavel = gridBusca.CurrentRow.Cells[5].Value.ToString();

            // Exemplo: Se você quiser retornar alguma informação do datagrid, basta usar o exemplo acima.
        }


        private void btnEditarAluno_Click(object sender, EventArgs e)
        {
            Aluno alunoSelecionado = new Aluno(nomeAluno, dataNascimentoAluno, nomeResponsavel, dataNascimentoResponsavel, telefoneResponsavel, cpfResponsavel);
            alunoSelecionado._idAluno = idAluno;
            Console.WriteLine("id do Aluno: " + alunoSelecionado._idAluno);
            frmAlterarAlunos editarAluno = new frmAlterarAlunos(alunoSelecionado);
            editarAluno.ShowDialog();
            editarAluno.Focus();
            editarAluno.Dispose();
            ListarAlunos();
        }

        private void btnExcluirAluno_Click(object sender, EventArgs e)
        {
            Aluno alunoSelecionado = new Aluno(nomeAluno, dataNascimentoAluno, nomeResponsavel, dataNascimentoResponsavel, telefoneResponsavel, cpfResponsavel);

            if (MessageBox.Show("Deseja excluir o aluno " + alunoSelecionado.nomeAluno + "?", "Confirmação de exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                alunoSelecionado._idAluno = idAluno;
                alunoSelecionado.ExcluirAluno(alunoSelecionado);
                ListarAlunos();
            }

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (cbxTipoBusca.Text == "Nome do Aluno")
            {
                try
                {
                    Conexao conexao = new Conexao();
                    conexao.AbrirConexao();
                    string sql = "SELECT * FROM aluno WHERE nomeAluno LIKE @nomeAluno ORDER BY nomeAluno ASC ";
                    MySqlCommand comando = new MySqlCommand(sql, conexao.conexao);
                    comando.Parameters.AddWithValue("@nomeAluno", txtBusca.Text + "%"); // O operador LIKE é usado para realizar uma busca por aproximação, onde o símbolo % é um curinga que representa qualquer sequência de caracteres. Neste caso, a busca retornará todos os alunos cujo nome comece com o texto digitado em txtBusca.
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    adapter.SelectCommand = comando;
                    //NOVIDADES: DataTable é uma classe que representa uma tabela de dados em memória,
                    //permitindo armazenar e manipular os dados retornados do banco de dados.
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela); // responsável por preencher a tabela com os dados retornados do banco de dados
                    gridBusca.DataSource = tabela;
                    conexao.FecharConexao();
                    FormatarTopoTabela();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar aluno. Erro: " + ex.Message);
                }
            }
            else if (cbxTipoBusca.Text == "Nome do Resp.")
            {
                try
                {
                    Conexao conexao = new Conexao();
                    conexao.AbrirConexao();
                    string sql = "SELECT * FROM aluno WHERE nomeResponsavel LIKE @nomeResponsavel ORDER BY nomeAluno ASC ";
                    MySqlCommand comando = new MySqlCommand(sql, conexao.conexao);
                    comando.Parameters.AddWithValue("@nomeResponsavel", txtBusca.Text + "%");
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    adapter.SelectCommand = comando;
                    //NOVIDADES: DataTable é uma classe que representa uma tabela de dados em memória,
                    //permitindo armazenar e manipular os dados retornados do banco de dados.
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela); // responsável por preencher a tabela com os dados retornados do banco de dados
                    gridBusca.DataSource = tabela;
                    conexao.FecharConexao();
                    FormatarTopoTabela();
                } catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar aluno. Erro: " + ex.Message);
                }
            } else if (cbxTipoBusca.Text == "CPF do Resp.")
            {
                try
                {
                    Conexao conexao = new Conexao();
                    conexao.AbrirConexao();
                    string sql = "SELECT * FROM aluno WHERE cpfResponsavel=@cpfResponsavel ORDER BY nomeAluno ASC ";
                    MySqlCommand comando = new MySqlCommand(sql, conexao.conexao);
                    comando.Parameters.AddWithValue("@cpfResponsavel", txtBusca.Text);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    adapter.SelectCommand = comando;
                    //NOVIDADES: DataTable é uma classe que representa uma tabela de dados em memória,
                    //permitindo armazenar e manipular os dados retornados do banco de dados.
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela); // responsável por preencher a tabela com os dados retornados do banco de dados
                    gridBusca.DataSource = tabela;
                    conexao.FecharConexao();
                    FormatarTopoTabela();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar aluno. Erro: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Selecione um tipo de busca.");
            } 
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            if(txtBusca.Text == "")
            {
                ListarAlunos();
            }
        }
    }
}
