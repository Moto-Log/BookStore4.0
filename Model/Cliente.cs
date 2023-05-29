using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    internal class Cliente: Usuario
    {
        private String enderecoResidencial {get; set;}
        private long cpf { get; set;}

        public long getCpf()
        {
            return cpf ;

        }

        public void setCpf(long cpf)
        {
            this.cpf = cpf;
        }
        public String getEnderecoResidencial()
        {
            return enderecoResidencial;

        }

        public void setEnderecoResidencial(String enderecoResidencial)
        {
            this.enderecoResidencial = enderecoResidencial;
        }

          public Cliente()
            {

            }
        public Cliente(string email, string senha,string enderecoResidencial, long cpf)
        {
            this.enderecoResidencial = enderecoResidencial;
            this.cpf = cpf;
            this.email = email;
            this.senha = senha;
        }
    }

}
