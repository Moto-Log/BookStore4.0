using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Livro
    {
        private String titulo;
        private double preco;
        private String autor;
        private String Descricao;
        private String genero;
        private int quantidadeEstoque;
        private Image image;
        private int codigo;

        public Livro(int codigo, Image image, String titulo, double preco, String autor, 
            String Descricao, String genero, int quantidadeEstoque)
        {
            this.titulo = titulo;
            this.preco = preco;
            this.autor = autor;
            this.Descricao = Descricao;
            this.genero = genero;
            this.quantidadeEstoque = quantidadeEstoque;
            this.image = image; 
            this.codigo = codigo;
        }

        public Livro() { }

        public String getTitulo() {  return titulo; }

        public void setTitulo(String titulo)
        {
            this.titulo = titulo;
        }

        public String getAutor() { return autor; }

        public void setAutor(String autor)
        {
            this.autor = autor;
        }

        public double getPreco() { return preco; }

        public void setPreco(double preco)
        {
            this.preco = preco;
        }
        public String getDescricao() { return Descricao; }

        public void setDescricao(String descricao)
        {
            this.Descricao = descricao;
        }

        public String getGenero() { return genero; }

        public void setGenero(String genero)
        {
            this.genero = genero;
        }
        public int getquantidadeEstoque() { return quantidadeEstoque; }

        public void setquantidadeEstoque(int quantidadeEstoque)
        {
            this.quantidadeEstoque = quantidadeEstoque;
        }
        public Image getimage() { return image; }

        public void setimage(Image image)
        {
            this.image = image; 
        }
        public int getCodigo() { return codigo; }

        public void setCodigo(int codigo)
        {
            this.codigo = codigo;
        }


    }
}
