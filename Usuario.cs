using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Pim_3_Semestre
{
    class Usuario
    {
        public int Id { get; set; }
        public string User { get;set;}
        public string Senha { get; set; }

        public Usuario()
        {

        }

        public void Incluir(string User, string Senha)
        {
            this.Id++;
            this.User = User;
            this.Senha = Senha;
        }
        public void Editar()
        {
            this.Id = Id;
            this.User = User;
            this.Senha = Senha;
        }
        public void Excluir()
        {
            this.Id = 0;
            this.User = "";
            this.Senha = "";
        }
    }
}
