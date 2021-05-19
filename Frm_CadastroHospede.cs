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
    public partial class Frm_CadastroHospede : Form
    {
        public Frm_CadastroHospede()
        {
            InitializeComponent();
        }

        private void btn_Gravar_Click(object sender, EventArgs e)
        {
            Hospede Hp = new Hospede();
            Hp.Cadastro(txb_Nome.Text, maskedtxb_DtNasc.Text, maskedtxb_Rg.Text, maskedtxb_Cpf.Text, maskedtxb_Passaporte.Text, txb_Rua.Text, txb_Numero.Text, txb_Bairro.Text, txb_Cidade.Text, maskedtxb_Cep.Text, maskedtxb_Telefone.Text, maskedtxb_CelularUm.Text, maskedtxb_CelularDois.Text, txb_Email.Text, txb_Obs.Text);
            MessageBox.Show("Hóspede cadastrado com sucesso!!!");
            LimparCampos();
        }

        private void checkBox_Estrang_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Estrang.Checked)
            {
                maskedtxb_Passaporte.ReadOnly = false;
                maskedtxb_Cpf.ReadOnly = true;
                maskedtxb_Cpf.Text = "";
            }
            else
            {
                maskedtxb_Passaporte.ReadOnly = true;
                maskedtxb_Cpf.ReadOnly = false;
                maskedtxb_Passaporte.Text = "";
            }
        }

        private void Frm_CadastroHospede_Load(object sender, EventArgs e)
        {

        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //Mtd LimparCampos
        public void LimparCampos()
        {
            txb_Nome.Text = "";
            maskedtxb_DtNasc.Text = "";
            maskedtxb_Rg.Text = "";
            maskedtxb_Cpf.Text = "";
            maskedtxb_Passaporte.Text = "";
            txb_Rua.Text = "";
            txb_Numero.Text = "";
            txb_Bairro.Text = "";
            txb_Cidade.Text = "";
            maskedtxb_Cep.Text = "";
            maskedtxb_Telefone.Text = "";
            maskedtxb_CelularUm.Text = "";
            maskedtxb_CelularDois.Text = "";
            txb_Email.Text = "";
            txb_Obs.Text = "";
        }
    }
}
