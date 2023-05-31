using Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace View
{
    public partial class TelaLivro : Form
    {
        private static TelaLivro staticLivro;
        //referencia da conexao
        public SqlConnection connection;
        private string connectionString = "Data Source=DESKTOP-JMUCA02;Initial Catalog=dbBOOkstore;Integrated Security=True";

        //visual::
        public static TelaLivro ConfirmarExistenciaDaClasse
        {
            get
            {   // se a variavel viewHomepage não estiver ainda atribuida a nenhum homePage novo
                // vai ser criada pela primeira vez
                if (staticLivro == null)
                {
                    staticLivro = new TelaLivro();
                    // MessageBox.Show("telinha nova: )");
                }
                // e em seguida vai retornar o viewHomePage

                //MessageBox.Show("Eu sou a tela feita antes");
                return staticLivro;

                // depois da classe instanciada se for necessário acessar NOVAMENTE esta classe, enquanto estiver em execução, 
                // eu vou acessar a classe que eu instanciei primeiro. 

                // eu estou acessando somente uma classe, para cada formulário, criada em toda a execução do código.


            }
        }
        public OpenFileDialog ofd = new OpenFileDialog();  // fiz um objeto para abrir um arquivo
                                                           // esse objeto vai ajudar a colocar a capa de um livro


        public TelaLivro()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
        }
        //função para add os livros no banco de dados
        private bool AddLivro(string livroname, Double valor, string genero, string autor,  string livroImagem)
        {
            try
            {
                connection.Open();

                string query = "INSERT INTO tb_livros (livroname, valor, genero, autor, livroImagem) VALUES (@livroname, @valor, @genero, @autor, @livroImagem)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@livroname", livroname);
                command.Parameters.AddWithValue("@valor", valor);
                command.Parameters.AddWithValue("@genero", genero);
                command.Parameters.AddWithValue("@autor", autor);
                command.Parameters.AddWithValue("@livroImagem", livroImagem);


                command.ExecuteNonQuery();

                connection.Close();

                return true;
            }
            //erro no banco
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao adicionar o novo usuário: " + ex.Message);
                return false;
            }
        }
        //função para verificar se já existe
        private bool VerificarLivroExistente(string livroname)
        {
            try
            {
                connection.Open();

                string query = "SELECT COUNT(1) FROM tb_livros  WHERE livroname = @livroname";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@livroname", livroname);

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
        private void TelaLivro_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxCapa_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {  // se o usuário clicou em um arquivo, o bloco de código abaixo vai ser executado
                this.pictureBoxCapa.Image = Image.FromFile(ofd.FileName);
               
                }
            }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            // Limpa todos os controles dentro do painel estático chamado 'staticPanel'
            TelaDeConexao.staticPanel.Controls.Clear();

            // Cria uma instância da classe 'ViewTelaGerente' e é atribuido o nome'frm'
            // 'ConfirmarExistenciaDaClasse' é um método estático da classe 'ViewTelaGerente', esse metódo é para usar somente
            // uma classe que já existe na classe ViewTelaGerente para, assim, evitar criar classes novas toda vez que for
            // acionado o botão voltar
            TelaGerente telaDoGerente = TelaGerente.staticGerente;

            // Define a propriedade 'TopLevel' do formulário 'telaDoGerente' como 'false'
            // Isso faz com que o formulário seja tratado como um controle filho do 'staticPanel',
            // faz com que não abra uma janela separada só para o telaDoGerente

            telaDoGerente.TopLevel = false;

            // Adiciona o formulário 'telaDoGerente' ao 'staticPanel' como um controle filho
            // adiciona a ViewTelaDeMudança uma classe feita de ViewTelaGerente
            TelaDeConexao.staticPanel.Controls.Add(telaDoGerente);

            // Define a propriedade 'FormBorderStyle' do formulário 'telaDoGerente' como 'None'
            // Isso remove a barra de título e a borda do formulário
            telaDoGerente.FormBorderStyle = FormBorderStyle.None;

            // Exibe o formulário 'telaDoGerente'
            telaDoGerente.Show();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
          
            string livroname = txtTitulo.Text;
            Double valor = Convert.ToDouble(txtPreco.Text);
            string genero = txtGenero.Text;
            string livroImagem = Path.GetDirectoryName(this.pictureBoxCapa.ImageLocation);
            string autor = txtAutor.Text;
         
            // Verificar se o nome de usuário já existe no banco de dados
            if (VerificarLivroExistente(livroname))
            {
                MessageBox.Show("O nome de usuário já existe. Escolha um nome de usuário diferente.");
            }

            // Inserir novo usuário no banco de dados
            else
            {
                if (AddLivro(livroname, valor,  genero, autor, livroImagem))
                {
                    MessageBox.Show("Novo usuário adicionado com sucesso!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro ao adicionar o novo usuário.");
                }
            }
        }

    }
}
