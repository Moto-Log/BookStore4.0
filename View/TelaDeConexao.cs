using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class TelaDeConexao : Form
    {
        public TelaDeConexao()
        {
            InitializeComponent();
        }

        private void TelaDeConexao_Load(object sender, EventArgs e)
        {
            AddStaticPanel();

            // Criando uma instância do formulário 'TelaMenu'
            TelaMenu menu = new TelaMenu();

            // Define a propriedade 'TopLevel' do formulário 'menu' como 'false'
            // Isso faz com que o formulário seja tratado como um controle filho do painel estático
            menu.TopLevel = false;

            // Adiciona o formulário 'menu' como um controle filho do painel estático
            staticPanel.Controls.Add(menu);

            // Define a propriedade 'FormBorderStyle' do formulário ''menu' como 'None'
            // Isso remove a barra de título e a borda do formulário
            // O formulário será exibido sem decorações
            menu.FormBorderStyle = FormBorderStyle.None;

            // Exibe o formulário 'menu'
            // Agora o formulário será visível dentro do painel estático
            menu.Show();
        }
        public static Panel staticPanel;

        public void AddStaticPanel()
        {
            // vai criar uma nova instância de static panel
            staticPanel = new Panel();

            // Define a cor de fundo do painel como cinza claro
            staticPanel.BackColor = Color.LightGray;

            // Define o tamanho do painel como 720 pixels de largura e 480 pixels de altura
            staticPanel.Size = new Size(1280,788);

            // Define a posição do painel no canto superior esquerdo da janela, com coordenadas (0, 0)
            staticPanel.Location = new Point(0, 0);

            // Define o estilo de ancoragem do painel como 'None' (Nenhum)
            // Isso significa que o painel não estará ancorado em nenhum dos lados da janela
            staticPanel.Dock = DockStyle.None;

            // Adiciona o painel 'staticPanel' como um controle filho da janela atual
            Controls.Add(staticPanel);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrarLivro_Click(object sender, EventArgs e)
        {
            TelaDeConexao.staticPanel.Controls.Clear();


            TelaGerente telaGerente = TelaGerente.staticGerente;


            telaGerente.TopLevel = false;


            TelaDeConexao.staticPanel.Controls.Add(telaGerente);


            telaGerente.FormBorderStyle = FormBorderStyle.None;

            telaGerente.Show();
        }
    }
}
