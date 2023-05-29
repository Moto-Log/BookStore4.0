using Model;
using System;
using System.Collections.Generic;
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

        public void mostrarLivros(ListView listView1)
        {
            // public Livro(int codigo, Image image, String titulo, double preco, String autor, 
            //String Descricao, String genero, int quantidadeEstoque)
            listView1.Columns.Add("Codigo", 70).TextAlign = HorizontalAlignment.Center;
            listView1.Columns.Add("Titulo", 70).TextAlign = HorizontalAlignment.Center;
            listView1.Columns.Add("Preço", 70).TextAlign = HorizontalAlignment.Center;
            listView1.Columns.Add("Autor", 70).TextAlign = HorizontalAlignment.Center;
            listView1.Columns.Add("Descrição", 70).TextAlign = HorizontalAlignment.Center;
            listView1.Columns.Add("Genero", 70).TextAlign = HorizontalAlignment.Center;
            listView1.Columns.Add("Imagem", 70).TextAlign = HorizontalAlignment.Center;
            listView1.Columns.Add("Quantidade Estoque", 70).TextAlign = HorizontalAlignment.Center;

            listView1.View = View.Details;
           
           

            foreach (Livro livro in ListaDeLivros.ListaLivros)
            {
                String[] item = new String[8];
                item[0] = livro.getCodigo().ToString(); 
                item[1] = livro.getTitulo();
                item[2] = livro.getPreco().ToString();
                item[3] = livro.getAutor().ToString();
                item[4] = livro.getDescricao().ToString();
                item[5] = livro.getGenero().ToString();
                item[6] = livro.getimage().ToString();
                item[7] = livro.getquantidadeEstoque().ToString();
                listView1.Items.Add(new ListViewItem(item));
            }
           

        }

        public void eaiLivros(ListView listView1)
        {
            foreach(Livro livro in ListaDeLivros.ListaLivros){
                

               
            }
              
            

              
            
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
