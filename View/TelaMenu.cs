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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace View
{
    public partial class TelaMenu : Form
    {
        public TelaMenu()
        {
            InitializeComponent();
            ControllerLivros controllerLivros = new ControllerLivros();
           
            controllerLivros.mostrarLivros(listView1);
            
        }
        public static TelaMenu staticMenu;

        public static TelaMenu ConfirmarExistenciaDaTela
        {
            get
            {   
                if (staticMenu == null)
                {
                    staticMenu = new TelaMenu();
                  
                } 
                return staticMenu;
            }
        }


        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
           
        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                // Obtém o item selecionado no ListView
                ListViewItem selectedItem = listView1.SelectedItems[0];

                // Obtém as informações do item selecionado
                string informacao = selectedItem.SubItems[1].Text; // Subitem desejado, neste caso, o índice 1

                // Exibe a informação no TextBox
                txtTitulo.Text = informacao;
            }
        }
        private void TelaMenu_Load(object sender, EventArgs e)
        {

        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gerenteToolStripMenuItem_Click(object sender, EventArgs e)
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
