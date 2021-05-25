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
    public partial class Frm_CadastroQuarto : Form
    {
        bool resp = false;
        bool IsEdit = false;
        Quarto quarto;
        public Frm_CadastroQuarto()
        {
            quarto = new Quarto();
            InitializeComponent();
        }

        private void Frm_CadastroQuarto_Load(object sender, EventArgs e)
        {
            cbx_Tipo.Text = quarto.tipoQuarto.Tipo;
            txb_QtdHospede.Text = quarto.tipoQuarto.QtdMax_Hp.ToString();
            txb_ValorDiaria.Text = quarto.tipoQuarto.Valor_Diaria.ToString();
        }

        private void btn_Gravar_Click(object sender, EventArgs e)
        {
            if (VerificaNull(resp) == false) //Verifico o retorno do Mtd.
            {

                if (IsEdit == true)
                {
                    //Edição
                    quarto.Editar(txb_NumQuarto.Text,txb_Andar.Text);
                    MessageBox.Show("Quarto editado com sucesso!!!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                    btn_Editar.Enabled = true;
                    btn_Deletar.Enabled = true;
                    IsEdit = false;
                }
                else
                {
                    if (lbl_Numero.Text == "...")
                    {
                        //Novo Cadastro
                        quarto.Incluir(txb_NumQuarto.Text, txb_Andar.Text);
                        MessageBox.Show("Quarto cadastrado com sucesso!!!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimparCampos();
                        btn_Editar.Enabled = true;
                        btn_Deletar.Enabled = true;
                    }
                    else
                    {
                        //Esgotou
                        MessageBox.Show("Esgotou o limite de Novos Quartos cadastrados suportado pelo sistema, por favor exclua algum registro!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                lbl_Numero.Text = quarto.Numero;
                lbl_Andar.Text = quarto.Andar;                
                lbl_Tipo.Text = quarto.tipoQuarto.Tipo;
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

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            CarregaObjQt();
            IsEdit = true;
        }

        private void btn_Deletar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Quarto Número: " + quarto.Numero + " excluido com com sucesso!!!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            quarto.Excluir();
            lbl_Numero.Text = "...";
            lbl_Andar.Text = "...";
            lbl_Tipo.Text = "...";
            btn_Editar.Enabled = false;
            btn_Deletar.Enabled = false;
        }

        //Métodos úteis.
        public bool VerificaNull(bool resp)
        {
            if (txb_NumQuarto.Text == "" || txb_Andar.Text == "" || cbx_Tipo.Text == "")
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
        public void CarregaObjQt()
        {
            txb_NumQuarto.Text = quarto.Numero;
            txb_Andar.Text = quarto.Andar;
            cbx_Tipo.Text = quarto.tipoQuarto.Tipo;
            txb_QtdHospede.Text = quarto.tipoQuarto.QtdMax_Hp.ToString();
            txb_ValorDiaria.Text = quarto.tipoQuarto.Valor_Diaria.ToString();
        }

        public void LimparCampos()
        {
            txb_NumQuarto.Text = "";
            txb_Andar.Text = "";
            cbx_Tipo.Text = "";
            txb_QtdHospede.Text = "";
            txb_ValorDiaria.Text = "";
        }
    }
}
