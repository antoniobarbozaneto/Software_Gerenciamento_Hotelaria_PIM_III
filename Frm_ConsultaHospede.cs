using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Pim_3_Semestre
{
    public partial class Frm_ConsultaHospede : Form
    {
        public Frm_CadastroHospede frm_CadastroHospede;
        Hospede Hp;
        public Frm_ConsultaHospede()
        {
            Hp = new Hospede();
            frm_CadastroHospede = new Frm_CadastroHospede();

            InitializeComponent();
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            frm_CadastroHospede.txb_Nome.Text = Hp.Nome; //Preciso pegar o valolr do atr do Obj Hp
            frm_CadastroHospede.ShowDialog();

        }
    }
}
