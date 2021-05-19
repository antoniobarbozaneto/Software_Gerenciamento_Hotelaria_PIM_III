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
    public partial class Frm_Login : Form
    {
        public Frm_Principal frm_Principal;

        public Frm_Login()
        {
            frm_Principal = new Frm_Principal();
            InitializeComponent();
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            frm_Principal.ShowDialog();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txb_Senha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txb_Usuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
