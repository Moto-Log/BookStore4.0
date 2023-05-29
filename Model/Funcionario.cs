using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Model
{
    internal class Funcionario : Usuario
    {
    

        private String nomeDoFuncionario;

            public String getNomeDoFuncionario()
        {
            return nomeDoFuncionario;

        }

        public void setNomeDoFuncionario(String nomeDoFuncionario)
        {
            this.nomeDoFuncionario = nomeDoFuncionario;
        }
        private long cpf;

                 public long getcpf()
        { 
            return cpf;

        }

        public void setCpf(long cpf)
        {
            this.cpf = cpf;
        }


        public Funcionario(String email, String senha, String nomeDoFuncionario, long cpf) {
            this.email = email;
            this.senha = senha;
            this.nomeDoFuncionario = nomeDoFuncionario;
            this.cpf = cpf;

        
        }

        public Funcionario() { 
        
        }
    }
}
