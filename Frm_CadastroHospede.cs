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
        bool IsEdit = false;
        Hospede Hp = new Hospede();
        public Frm_CadastroHospede()
        {
            InitializeComponent();
        }

        private void btn_Gravar_Click(object sender, EventArgs e)
        {
            if (IsEdit == true)
            {
                Hp.Editar(txb_Nome.Text, maskedtxb_DtNasc.Text, maskedtxb_Rg.Text, maskedtxb_Cpf.Text, maskedtxb_Passaporte.Text, txb_Rua.Text, txb_Numero.Text, txb_Bairro.Text, txb_Cidade.Text, maskedtxb_Cep.Text, maskedtxb_Telefone.Text, maskedtxb_CelularUm.Text, maskedtxb_CelularDois.Text, txb_Email.Text, txb_Obs.Text);
                VerificaNull();
                IsEdit = false;
            }
            else
            {
                if (lbl_CpfPassaporte.Text == "...")
                {

                    Hp.Incluir(txb_Nome.Text, maskedtxb_DtNasc.Text, maskedtxb_Rg.Text, maskedtxb_Cpf.Text, maskedtxb_Passaporte.Text, txb_Rua.Text, txb_Numero.Text, txb_Bairro.Text, txb_Cidade.Text, maskedtxb_Cep.Text, maskedtxb_Telefone.Text, maskedtxb_CelularUm.Text, maskedtxb_CelularDois.Text, txb_Email.Text, txb_Obs.Text);
                    VerificaNull();
                }
                else
                {
                    MessageBox.Show("Esgotou o limite de Hóspedes cadastrados suportado pelo sistema, por favor exclua algum registro!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
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

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hóspede:" + Hp.Nome + " Excluido com Sucesso!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Hp.Excluir();
            lbl_Nome.Text = "...";
            lbl_CpfPassaporte.Text = "...";
            lbl_DtNascimento.Text = "...";
            btn_Editar.Enabled = false;
            btn_Deletar.Enabled = false;
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            CarregaObjHp();
            IsEdit = true;
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Métodos úteis
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

        public void CarregaObjHp() //Verifica se o Obj Hospede já está Cadastrado.
        {
            txb_Nome.Text = Hp.Nome;
            maskedtxb_DtNasc.Text = Hp.Dt_Nasc;
            maskedtxb_Rg.Text = Hp.Rg;
            maskedtxb_Cpf.Text = Hp.Cpf;
            maskedtxb_Passaporte.Text = Hp.Passaporte;
            txb_Rua.Text = Hp.Rua;
            txb_Numero.Text = Hp.Num;
            txb_Bairro.Text = Hp.Bairro;
            txb_Cidade.Text = Hp.Cidade;
            maskedtxb_Cep.Text = Hp.Cep;
            maskedtxb_Telefone.Text = Hp.Telefone;
            maskedtxb_CelularUm.Text = Hp.Celular_Um;
            maskedtxb_CelularDois.Text = Hp.Celular_Dois;
            txb_Email.Text = Hp.Email;
            txb_Obs.Text = Hp.Obs;
        }

        public void VerificaNull()
        {
            if (txb_Nome.Text != null && maskedtxb_DtNasc.MaskCompleted && (maskedtxb_Cpf.MaskCompleted || maskedtxb_Passaporte.MaskCompleted))
            {
                if (IsEdit == true)
                {
                    MessageBox.Show("Hóspede editado com sucesso!!!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btn_Editar.Enabled = true;
                    btn_Deletar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Hóspede cadastrado com sucesso!!!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btn_Editar.Enabled = true;
                    btn_Deletar.Enabled = true;
                }
                lbl_Nome.Text = Hp.Nome;
                lbl_CpfPassaporte.Text = Hp.Cpf;
                lbl_DtNascimento.Text = Hp.Dt_Nasc;
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Campos obrigatórios não foram preenchidos", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

