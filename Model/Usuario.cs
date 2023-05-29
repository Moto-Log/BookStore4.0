using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    internal class Usuario
    {

        protected String email;
        protected String senha;

        public String getEmail()
        {
            return email;

        }

        public void setEmail(String email)
        {
            this.email = email;
           
        }

        public String getSenha()
        {
            return senha;

        }

        public void setSenha(String senha)
        {
            this.senha = senha;
        }

        public Usuario(string email, string senha)
        {
            this.email = email;
            this.senha = senha;
        }
        public Usuario() { }
    }
}
