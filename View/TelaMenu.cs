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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Image = System.Drawing.Image;

namespace View
{
    public partial class TelaMenu : Form
    {
        public TelaMenu()
        {
            InitializeComponent();
            ControllerLivros controllerLivros = new ControllerLivros();

            //codigo, image, titulo, preco,autor,descricao,genero,quantidadeEstoque
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("codigo", typeof(int));
            
            dataTable.Columns.Add("Titulo", typeof(String));
            dataTable.Columns.Add("Preço", typeof(double));
            dataTable.Columns.Add("Autor", typeof(String));
          
            controllerLivros.mostrarLivros(dataGridViewCapa, dataTable);
           

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

        private void dataGridViewCapa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          

        }
    }
}
