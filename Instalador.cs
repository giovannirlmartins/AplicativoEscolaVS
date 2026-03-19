using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace AplicativoEscola
{
    [RunInstaller(true)]
    public partial class Installer1 : System.Configuration.Install.Installer
    {
        public Installer1()
        {
            InitializeComponent();
        }

        public override void Install(System.Collections.IDictionary stateSaver)
        {
            base.Install(stateSaver); // Chama o método de instalação base

            // Caminho onde o arquivo .sql foi instalado
            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location); // Obtém o diretório do executável
            string scriptFile = Path.Combine(path, "aplicativoescola.sql"); // Ajuste o nome do arquivo conforme necessário

            // String de conexão (Mestre para criar o banco)
            string connString = "Server=localhost;Uid=root;Pwd=;";

            using (var conn = new MySqlConnection(connString))
            {
                conn.Open();
                // 1. Cria o banco se não existir
                using (var cmd = new MySqlCommand("CREATE DATABASE IF NOT EXISTS aplicativoescola;", conn))
                {
                    cmd.ExecuteNonQuery();
                }

                // 2. Executa o script das tabelas
                conn.ChangeDatabase("aplicativoescola"); // Muda para o banco criado
                string scriptContent = File.ReadAllText(scriptFile); // Lê o conteúdo do arquivo .sql
                MySqlScript script = new MySqlScript(conn, scriptContent); // Cria um objeto MySqlScript para executar o script
                script.Execute();
            }
        }
    }
}
