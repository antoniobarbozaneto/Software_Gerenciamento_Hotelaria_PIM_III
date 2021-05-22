using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Pim_3_Semestre
{
    class TipoQuarto
    {
        private static string tipo;
        private static int qtdmax_hp;
        private static double valor_diaria;
        string Refeicao { get; set; }

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        public int QtdMax_Hp
        {
            get { return qtdmax_hp; }
            set { qtdmax_hp = value; }
        }
        public double Valor_Diaria
        {
            get { return valor_diaria; }
            set { valor_diaria = value; }
        }

        public TipoQuarto()
        {
        }


        public void Incluir(string Tipo, string QtdMax_Hp, string Valor_Diaria)
        {
            this.Tipo = Tipo;
            this.QtdMax_Hp = Convert.ToInt32(QtdMax_Hp);
            this.Valor_Diaria = Convert.ToDouble(Valor_Diaria);
        }

        public void Editar(string Tipo, string QtdMax_Hp, string Valor_Diaria)
        {
            this.Tipo = Tipo;
            this.QtdMax_Hp = Convert.ToInt32(QtdMax_Hp);
            this.Valor_Diaria = Convert.ToDouble(Valor_Diaria);
        }

        public void Excluir()
        {
            this.Tipo = "";
            this.QtdMax_Hp = 0;
            this.Valor_Diaria = 0;
        }
    }
}
