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
    public partial class TelaGerente : Form
    {
        public TelaGerente()
        {
            InitializeComponent();
        }
        public static TelaGerente staticGerente = new TelaGerente();    
        private void TelaGerente_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrarLivro_Click(object sender, EventArgs e)
        {
            TelaDeConexao.staticPanel.Controls.Clear();


            TelaLivro telaLivro = TelaLivro.ConfirmarExistenciaDaClasse;


            telaLivro.TopLevel = false;


            TelaDeConexao.staticPanel.Controls.Add(telaLivro);


            telaLivro.FormBorderStyle = FormBorderStyle.None;

            telaLivro.Show();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            TelaDeConexao.staticPanel.Controls.Clear();
            TelaMenu telaMenu = TelaMenu.ConfirmarExistenciaDaTela;
            telaMenu.TopLevel = false;
            TelaDeConexao.staticPanel.Controls.Add(telaMenu);
            telaMenu.FormBorderStyle = FormBorderStyle.None;
            telaMenu.Show();
        }
    }
}
