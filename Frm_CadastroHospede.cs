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
                Hp.Editar();
            }
            else
            {
                Hp.Incluir(txb_Nome.Text, maskedtxb_DtNasc.Text, maskedtxb_Rg.Text, maskedtxb_Cpf.Text, maskedtxb_Passaporte.Text, txb_Rua.Text, txb_Numero.Text, txb_Bairro.Text, txb_Cidade.Text, maskedtxb_Cep.Text, maskedtxb_Telefone.Text, maskedtxb_CelularUm.Text, maskedtxb_CelularDois.Text, txb_Email.Text, txb_Obs.Text);

                if (maskedtxb_Passaporte.MaskCompleted && txb_Nome.Text != null && maskedtxb_DtNasc.MaskCompleted)
                {
                    lblNome.Text = Hp.Nome;
                    lbl_CpfPassaporte.Text = Hp.Passaporte;
                    lbl_DtNascimento.Text = Hp.Dt_Nasc;
                    LimparCampos();
                    MessageBox.Show("Hóspede cadastrado com sucesso!!!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btn_Editar.Enabled = true;
                    btn_Excluir.Enabled = true;
                }
                else
                {
                    if (maskedtxb_Cpf.MaskCompleted && txb_Nome.Text != null && maskedtxb_DtNasc.MaskCompleted)
                    {
                        lblNome.Text = Hp.Nome;
                        lbl_CpfPassaporte.Text = Hp.Cpf;
                        lbl_DtNascimento.Text = Hp.Dt_Nasc;
                        LimparCampos();
                        MessageBox.Show("Hóspede cadastrado com sucesso!!!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btn_Editar.Enabled = true;
                        btn_Excluir.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Campos obrigatórios não foram preenchidos", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
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

        public void CarregaObjHp() //Verifica se o Obj Hospede já está Cadastrado.
        {
            if (Hp.Cpf != null || Hp.Passaporte != null)
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
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            Hp.Excluir();
            lblNome.Text = "...";
            lbl_CpfPassaporte.Text = "...";
            lbl_DtNascimento.Text = "...";
            btn_Editar.Enabled = false;
            btn_Excluir.Enabled = false;
            MessageBox.Show("Hóspede Excluido com Sucesso!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            CarregaObjHp();
            btn_Editar.Enabled = false;
            btn_Excluir.Enabled = false;
            IsEdit = true;
        }
    }
}
