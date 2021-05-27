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
        Hospede hospede;
        Quarto quarto;
        Reserva reserva;
        Frm_Pagamento frm_Pagamento;

        //Frm_ConsultaHospede frm_ConsultaHospede;
        //Frm_ConsultaQuarto frm_ConsultaQuarto;
        public Frm_FazerReserva()
        {
            hospede = new Hospede();
            quarto = new Quarto();
            reserva = new Reserva();
            frm_Pagamento = new Frm_Pagamento();
            //frm_ConsultaHospede = new Frm_ConsultaHospede();
            //frm_ConsultaQuarto = new Frm_ConsultaQuarto();
            InitializeComponent();
        }

        private void Frm_FazerReserva_Load(object sender, EventArgs e)
        {
        }

        private void btn_BuscarHospede_Click(object sender, EventArgs e)
        {
            txb_Nome.Text = hospede.Nome;
            maskedtxb_Cpf.Text = hospede.Cpf;
            maskedtxb_Passaporte.Text = hospede.Passaporte;
            //frm_ConsultaHospede.btn_Confirmar.Show();
            //frm_ConsultaHospede.btn_Atualizar.Show();
            //frm_ConsultaHospede.btn_Editar.Hide();
            //frm_ConsultaHospede.btn_Excluir.Hide();
            //frm_ConsultaHospede.ShowDialog();            
        }

        private void btn_BuscarQuarto_Click(object sender, EventArgs e)
        {
            txb_NumQuarto.Text = quarto.Numero;
            txb_TipoQuarto.Text = quarto.tipoQuarto.Tipo;
            //frm_ConsultaQuarto.btn_Confirmar.Show();
            //frm_ConsultaQuarto.btn_Atualizar.Show();
            //frm_ConsultaQuarto.btn_Editar.Hide();
            //frm_ConsultaQuarto.btn_Excluir.Hide();
            //frm_ConsultaQuarto.ShowDialog();            
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            if (txb_Nome.Text != "" && (maskedtxb_Cpf.Text != "" || maskedtxb_Passaporte.Text != "") && txb_NumQuarto.Text != "" && txb_TipoQuarto.Text != "" && maskedtxb_dt_Checkin.MaskCompleted && maskedtxb_dtCheckout.MaskCompleted && txb_QtdHospede.Text != "")
            {
                if (Convert.ToInt32(txb_QtdHospede.Text) > quarto.tipoQuarto.QtdMax_Hp)
                {
                    MessageBox.Show("Esse quarto não suporta hospedar mais que [" + quarto.tipoQuarto.QtdMax_Hp + "] Hóspedes, escolha outro tipo de quarto", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    txb_ValorTotal.Text = reserva.CalcValorReserva(DateTime.Parse(maskedtxb_dt_Checkin.Text), DateTime.Parse(maskedtxb_dtCheckout.Text), Convert.ToInt32(txb_QtdHospede.Text)).ToString();
                    MessageBox.Show("Valor Diária por Cada Pessoa: R$: " + quarto.tipoQuarto.Valor_Diaria + "\n" +
                        "Quantidade de Hospedes: " + reserva.Qtd_Hospede + "\n" +
                        "Valor Diária X Quantidade de hóspedes: " + reserva.Res + "\n" +
                        "Quantidade de Dias de Hospedagem: " + reserva.QtDias + "\n" +
                        "Valor Total da Reserva: " + reserva.ResFinal);
                    //
                    lbl_NumReserva.Text = reserva.Num_Reserva.ToString();
                    lbl_Nome.Text = hospede.Nome;
                    lbl_DtCheckin.Text = reserva.dt_Checkin.ToString("dd/mm/yyyy");
                    lbl_DtCheckout.Text = reserva.dt_Checkout.ToString("dd/mm/yyyy");
                    lbl_ValorTotal.Text = reserva.ResFinal.ToString();
                    //
                    if (maskedtxb_Cpf.MaskCompleted)
                    {
                        lbl_CpfPassaporte.Text = hospede.Cpf;
                    }
                    else
                    {
                        lbl_CpfPassaporte.Text = hospede.Passaporte;
                    }
                    //
                }
            }
            else
            {
                MessageBox.Show("Campos obrigatórios não foram preenchidos", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Métodos úteis.
        public void LimparCampos()
        {
            txb_Nome.Text = "";
            maskedtxb_Cpf.Text = "";
            maskedtxb_Passaporte.Text = "";
            txb_NumQuarto.Text = "";
            txb_TipoQuarto.Text = "";
            maskedtxb_dt_Checkin.Text = "";
            maskedtxb_dtCheckout.Text = "";
            txb_QtdHospede.Text = "";
            txb_ValorTotal.Text = "";
        }

        private void btn_DarBaixa_Click(object sender, EventArgs e)
        {
            frm_Pagamento.ShowDialog();
        }
    }
}
