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
    public partial class Frm_CadastroTipoQuarto : Form
    {
        bool resp = false;
        bool IsEdit = false;
        TipoQuarto TipoQuarto;

        public Frm_CadastroTipoQuarto()
        {
            TipoQuarto = new TipoQuarto();
            InitializeComponent();
        }

        private void Frm_CadastroTipoQuarto_Load(object sender, EventArgs e)
        {

        }

        private void btn_Gravar_Click(object sender, EventArgs e)
        {
            if (VerificaNull(resp) == false) //Verifico o retorno do Mtd.
            {

                if (IsEdit == true)
                {
                    //Edição
                    TipoQuarto.Editar(txb_Tipo.Text, txb_QtdHospede.Text, txb_ValorDiaria.Text);
                    MessageBox.Show("Tipo de Quarto editado com sucesso!!!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                    btn_Editar.Enabled = true;
                    btn_Deletar.Enabled = true;
                    IsEdit = false;
                }
                else
                {
                    if (lbl_Tipo.Text == "...")
                    {
                        //Novo Cadastro
                        TipoQuarto.Incluir(txb_Tipo.Text, txb_QtdHospede.Text, txb_ValorDiaria.Text);
                        MessageBox.Show("Tipo de Quarto cadastrado com sucesso!!!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimparCampos();
                        btn_Editar.Enabled = true;
                        btn_Deletar.Enabled = true;
                    }
                    else
                    {
                        //Esgotou
                        MessageBox.Show("Esgotou o limite de Novos Tipos de Quartos cadastrados suportado pelo sistema, por favor exclua algum regisrtro!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                lbl_Tipo.Text = TipoQuarto.Tipo;
                lbl_QtdMaxp.Text = TipoQuarto.QtdMax_Hp.ToString();
                lbl_ValorD.Text = TipoQuarto.Valor_Diaria.ToString();
            }
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Deletar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tipo de quarto:" + TipoQuarto.Tipo + " excluido com com sucesso!!!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TipoQuarto.Excluir();
            lbl_Tipo.Text = "...";
            lbl_QtdMaxp.Text = "...";
            lbl_ValorD.Text = "...";
            btn_Editar.Enabled = false;
            btn_Deletar.Enabled = false;
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            IsEdit = true;
            CarregaObjTq();
        }

        //Métodos úteis
        public bool VerificaNull(bool resp)
        {
            if (txb_Tipo.Text == "" || txb_QtdHospede.Text == "" || txb_ValorDiaria.Text == "")
            {
                resp = true;
                MessageBox.Show("Campos obrigatórios não foram preenchidos", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //MessageBox.Show("Todos os campos estão preenchidos!");
                resp = false;
            }
            return resp;
        }
        public void CarregaObjTq()
        {
            txb_Tipo.Text = TipoQuarto.Tipo;
            txb_QtdHospede.Text = TipoQuarto.QtdMax_Hp.ToString();
            txb_ValorDiaria.Text = TipoQuarto.Valor_Diaria.ToString();
        }

        public void LimparCampos()
        {
            txb_Tipo.Text = "";
            txb_QtdHospede.Text = "";
            txb_ValorDiaria.Text = "";
        }
    }
}
