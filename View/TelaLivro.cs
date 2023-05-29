using Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            ControllerLivros controllerLivros = ControllerLivros.ConfirmarExistenciaDaClasse;

            //int codigo, Image image, String titulo, double preco, String autor,
            //String Descricao, String genero, int quantidadeEstoque
            int codigo = int.Parse(txtCodigo.Text);
            System.Drawing.Image image = pictureBoxCapa.Image;
            String titulo = txtTitulo.Text;
            double preco = double.Parse(txtPreco.Text);
            String autor = txtAutor.Text;   
            String descricao = txtDescricao.Text;
            String genero = txtGenero.Text;
            int quantidadeEstoque = int.Parse(txtNumeroEstoque.Text);
            // adicionar o numero de paginas

            controllerLivros.cadastrarLivro(codigo, image, titulo, preco,autor,descricao,genero,quantidadeEstoque);
        }
    }
}
