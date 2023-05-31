using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class TelaLoginUser : Form
    {
        //referencia da conexao
        public SqlConnection connection;
        private string connectionString = "Data Source=DESKTOP-JMUCA02;Initial Catalog=dbBOOkstore;Integrated Security=True";

        public TelaLoginUser()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
        }

        private void btnLoginUser_Click(object sender, EventArgs e)
        {
            //pego o nome e senha do login
            string usernome = textUserName.Text;
            string senha = textSenha.Text;

            //uso a função para verificar o login
            if (VerificarLoginUser(usernome, senha))
            {
                // Abre o formulário com acesso a carrinho
            }
            else
            {
                MessageBox.Show("Credenciais inválidas. Tente novamente.");
            }
        }

        //função para verificar login user
        private bool VerificarLoginUser(string username, string password)
        {
            try
            {
                //inicia 
                connection.Open();

                string query = "SELECT COUNT(1) FROM tb_user WHERE username = @username AND senha = @senha";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@senha", password);

                int count = (int)command.ExecuteScalar();
                connection.Close();

                return count > 0;
            }
            //caso erro no banco
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao verificar o login: " + ex.Message);
                return false;
            }


        }
    }
}
