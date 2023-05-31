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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace View
{
    public partial class TelaCadastroUser : Form
    {
        //referencia da conexao
        public SqlConnection connection;
        private string connectionString = "Data Source=DESKTOP-JMUCA02;Initial Catalog=dbBOOkstore;Integrated Security=True";

        public TelaCadastroUser()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
        }
        //função para verificar se já existe
        private bool VerificarUserExistente(string username)
        {
            try
            {
                connection.Open();

                string query = "SELECT COUNT(1) FROM tb_user  WHERE username = @username";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);

                int count = (int)command.ExecuteScalar();

                connection.Close();

                return count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao verificar se o nome de usuário já existe: " + ex.Message);
                return false;
            }
        }

        private void btnCadUser_Click(object sender, EventArgs e)
        {
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textCadSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textCadUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
