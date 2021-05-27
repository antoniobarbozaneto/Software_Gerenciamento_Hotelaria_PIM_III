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
    public partial class Frm_Pagamento : Form
    {
        Pagamento pagamento;
        public Frm_Pagamento()
        {
            pagamento = new Pagamento();
            InitializeComponent();
        }

        private void btn_BuscarReserva_Click(object sender, EventArgs e)
        {
            txb_NumReserva.Text = pagamento.reserva.Num_Reserva.ToString();
            txb_ValorTotal.Text = pagamento.reserva.ResFinal.ToString();
        }

        private void Frm_Pagamento_Load(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void cbx_FormaPag_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_FormaPag.Text == "Dinheiro")
            {
                MessageBox.Show("Forma de pagamento escolhida foi em Dinheiro");
                txb_ValorPago.Enabled = true;
                cbx_Parcelas.Enabled = false;
            }
            else
            {
                if (cbx_FormaPag.Text == "Cartão Débito")
                {
                    txb_Troco.Text = "";
                    MessageBox.Show("Forma de pagamento escolhida foi em Cartão Débito");
                    cbx_Parcelas.Enabled = false;
                    txb_ValorPago.Enabled = false;
                    txb_ValorPago.Text = txb_ValorTotal.Text;
                }
                else
                {
                    if (cbx_FormaPag.Text == "Cartão Crédito")
                    {
                        txb_Troco.Text = "";
                        MessageBox.Show("Forma de pagamento escolhida foi em Cartão Crédito");
                        cbx_Parcelas.Enabled = true;
                        txb_ValorPago.Enabled = false;
                        txb_ValorPago.Text = txb_ValorTotal.Text;
                    }
                }
            }
        }

        private void cbx_Parcelas_SelectedIndexChanged(object sender, EventArgs e)
        {
            pagamento.PagCredito(Convert.ToDouble(txb_ValorTotal.Text), Convert.ToInt32(cbx_Parcelas.Text));
            txb_ValorParcela.Text = pagamento.ValorParcela.ToString();
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            if (cbx_FormaPag.Text == "Dinheiro")
            {
                pagamento.PagDin(Convert.ToDouble(txb_ValorPago.Text), Convert.ToDouble(txb_ValorTotal.Text));
                txb_Troco.Text = pagamento.ValorTroco.ToString();

                if (Convert.ToDouble(txb_ValorPago.Text) < Convert.ToDouble(txb_ValorTotal.Text))
                {
                    MessageBox.Show("Valor de pagamento inválido!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Pagamento Realizado com sucesso!!!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                }
            }
            else
            {
                if (cbx_FormaPag.Text == "Cartão Débito")
                {
                    pagamento.PagDebito(Convert.ToDouble(txb_ValorTotal.Text));
                    txb_ValorPago.Text = pagamento.ValorPago.ToString();
                    MessageBox.Show("Pagamento Realizado com sucesso!!!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (cbx_FormaPag.Text == "Cartão Crédito")
                    {
                        pagamento.PagCredito(Convert.ToDouble(txb_ValorTotal.Text), Convert.ToInt32(cbx_Parcelas.Text));
                        txb_ValorParcela.Text = pagamento.ValorParcela.ToString();
                        MessageBox.Show("Pagamento Realizado com sucesso!!!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimparCampos();
                    }
                }
            }
        }

        //Métodos úteis.
        public void LimparCampos()
        {
            cbx_FormaPag.Text = "";
            cbx_Parcelas.Text = "";
            txb_NumReserva.Text = "";
            txb_ValorTotal.Text = "";
            txb_ValorPago.Text = "";
            txb_ValorParcela.Text = "";
            txb_Troco.Text = "";
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
