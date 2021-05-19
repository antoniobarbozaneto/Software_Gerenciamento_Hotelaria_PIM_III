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
    public partial class Frm_FazerReserva : Form
    {
        Frm_ConsultaHospede frm_ConsultaHospede;
        Frm_ConsultaQuarto frm_ConsultaQuarto;
        public Frm_FazerReserva()
        {
            frm_ConsultaHospede = new Frm_ConsultaHospede();
            frm_ConsultaQuarto = new Frm_ConsultaQuarto();
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        
        }

        private void Frm_FazerReserva_Load(object sender, EventArgs e)
        {
        }

        private void btn_BuscarHospede_Click(object sender, EventArgs e)
        {
            frm_ConsultaHospede.btn_Confirmar.Show();
            frm_ConsultaHospede.btn_Atualizar.Show();
            frm_ConsultaHospede.btn_Editar.Hide();
            frm_ConsultaHospede.btn_Excluir.Hide();
            frm_ConsultaHospede.ShowDialog();            
        }

        private void btn_BuscarQuarto_Click(object sender, EventArgs e)
        {
            frm_ConsultaQuarto.btn_Confirmar.Show();
            frm_ConsultaQuarto.btn_Atualizar.Show();
            frm_ConsultaQuarto.btn_Editar.Hide();
            frm_ConsultaQuarto.btn_Excluir.Hide();
            frm_ConsultaQuarto.ShowDialog();            
        }
    }
}
