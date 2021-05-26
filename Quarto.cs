using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Pim_3_Semestre
{
    class Quarto
    {
        private static string numero;
        private static string andar;
        private static string status;

        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public string Andar
        {
            get { return andar; }
            set { andar = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public TipoQuarto tipoQuarto;

        public Quarto()
        {
           tipoQuarto = new TipoQuarto();
        }

        public void Incluir(string Numero, string Andar)
        {
            this.Numero = Numero;
            this.Andar = Andar;
        }

        public void Editar(string Numero, string Andar)
        {
            this.Numero = Numero;
            this.Andar = Andar;
        }

        public void Excluir()
        {
            Numero = "";
            Andar = "";
        }
    }
}
