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
        string idAluno;
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
            idAluno = gridBusca.CurrentRow.Cells[7].Value.ToString();
            dataNascimentoAluno = gridBusca.CurrentRow.Cells[1].Value.ToString();
            nomeResponsavel = gridBusca.CurrentRow.Cells[2].Value.ToString();
            dataNascimentoResponsavel = gridBusca.CurrentRow.Cells[3].Value.ToString();
            telefoneResponsavel = gridBusca.CurrentRow.Cells[4].Value.ToString();
            cpfResponsavel = gridBusca.CurrentRow.Cells[5].Value.ToString();

            // Exemplo: Se você quiser retornar alguma informação do datagrid, basta usar o exemplo acima.
        }

        public Aluno AlunoSelecionado()
        {
            Aluno alunoSelecionado = new Aluno(nomeAluno, dataNascimentoAluno, nomeResponsavel, dataNascimentoResponsavel, telefoneResponsavel, cpfResponsavel);
            return alunoSelecionado;
        }

        private void btnEditarAluno_Click(object sender, EventArgs e)
        {
            frmAlterarAlunos editarAluno = new frmAlterarAlunos();
            editarAluno.ShowDialog();
            editarAluno.Focus();

            editarAluno.Dispose();
        }
    }
}
