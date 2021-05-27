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
    public partial class Frm_Principal : Form
    {
        Frm_CadastroHospede frm_CadastroHospede;
        Frm_CadastroQuarto frm_CadastroQuarto;
        Frm_FazerReserva frm_FazerReserva;
        Frm_CadastroUsuario frm_CadastroUsuario;
        Frm_CadastroTipoQuarto frm_CadastroTipoQuarto;
        //Frm_ConsultaHospede frm_ConsultaHospede;
        //Frm_ConsultaReserva frm_ConsultaReserva;
        //Frm_ConsultaQuarto frm_ConsultaQuarto;
        //Frm_ConsultaPagamento frm_ConsultaPagamento;
        public Frm_Principal()
        {
            frm_CadastroHospede = new Frm_CadastroHospede();
            frm_CadastroQuarto = new Frm_CadastroQuarto();
            frm_FazerReserva = new Frm_FazerReserva();
            frm_CadastroUsuario = new Frm_CadastroUsuario();
            frm_CadastroTipoQuarto = new Frm_CadastroTipoQuarto();
            //frm_ConsultaHospede = new Frm_ConsultaHospede();            
            //frm_ConsultaReserva = new Frm_ConsultaReserva();
            //frm_ConsultaQuarto = new Frm_ConsultaQuarto();
            //frm_ConsultaPagamento = new Frm_ConsultaPagamento();
            InitializeComponent();
        }

        private void Frm_Principal_Load(object sender, EventArgs e)
        {

        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_CadastroHospede.ShowDialog();
        }

        private void cadastroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_CadastroQuarto.ShowDialog();
        }

        private void reservarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_FazerReserva.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           //frm_ConsultaHospede.btn_Confirmar.Hide();
           //frm_ConsultaHospede.ShowDialog();
            
        }

        private void consultaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           //frm_ConsultaQuarto.btn_Confirmar.Hide();
           // frm_ConsultaQuarto.ShowDialog();
        }

        private void reservaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cADASTROToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frm_CadastroUsuario.ShowDialog();
        }

        private void consultaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //frm_ConsultaReserva.ShowDialog();
        }

        private void consultaToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            //frm_ConsultaPagamento.ShowDialog();
        }

        private void cadastroNovoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_CadastroTipoQuarto.ShowDialog();
        }
    }
}
