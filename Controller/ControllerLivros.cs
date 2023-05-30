using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ListView = System.Windows.Forms.ListView;

namespace Controller
{
   
    public class ControllerLivros
    {
        public static ControllerLivros controllerLivrosStatic;

        public static ControllerLivros ConfirmarExistenciaDaClasse
        {
            get
            {
                if (controllerLivrosStatic == null)
                {
                    controllerLivrosStatic = new ControllerLivros();

                }
                return controllerLivrosStatic;
            }
        }

        public void mostrarLivros(DataGridView dataGridView, DataTable dataTable)
        {

            
            //codigo, image, titulo, preco,autor,descricao,genero,quantidadeEstoque
            foreach (Livro livro in ListaDeLivros.ListaLivros)
            {

              dataTable.Rows.Add(livro.getCodigo(),livro.getTitulo(),livro.getPreco(),livro.getAutor());
                
            }

            dataGridView.DataSource = dataTable;


        }


        public void cadastrarLivro(int codigo, Image image, String titulo, double preco, String autor,
            String Descricao, String genero, int quantidadeEstoque)

        {
            Livro livro = new Livro(codigo, image, titulo, preco, autor,
            Descricao, genero,  quantidadeEstoque);

            ListaDeLivros.ListaLivros.Add(livro);




        }

        public String PesquisarLivro(String tituloLivro)
        {
            Livro livroOne = new Livro();
            bool foiEncontrado = false;
            foreach(Livro livro in ListaDeLivros.ListaLivros)
            {
                if(livro.getTitulo() == tituloLivro)
                {
                    foiEncontrado = true;
                    livroOne = livro;
                    
                }

                if (foiEncontrado)
                {
                    break;
                }


            }

            if(foiEncontrado == false)
            {
                return "any book was find";
            }
            else
            {
                return livroOne.getTitulo();
            }

            

        }

        public void removerLivro(String tituloLivro)
        {
            foreach(Livro livro in ListaDeLivros.ListaLivros)
            {
                if(livro.getTitulo() == tituloLivro)
                {
                    ListaDeLivros.ListaLivros.Remove(livro);
                    MessageBox.Show("Livro removido com sucesso");
                }
                else
                {
                    MessageBox.Show("Livro não encontrado, tente novamente");
                }
            }
        }
    }
}
