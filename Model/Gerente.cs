using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    internal class Gerente : Usuario
    {
        public Gerente(String email, string senha) { 
            this.email = email; 
            this.senha = senha;

        }
        public Gerente() { }
    }
}
