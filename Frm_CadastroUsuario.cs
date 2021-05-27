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
    public partial class Frm_CadastroUsuario : Form
    {
        bool IsEdit = false;
        Usuario usuario;
        public Frm_CadastroUsuario()
        {
            usuario = new Usuario();
            InitializeComponent();
        }

        private void btn_Gravar_Click(object sender, EventArgs e)
        {
            if (IsEdit == true)
            {
                usuario.Incluir(txb_Usuario.Text, txb_Senha.Text);
                VerificaNull();
                IsEdit = false;
            }
            else
            {
                if (lbl_Usuario.Text == "...")
                {
                    usuario.Incluir(txb_Usuario.Text, txb_Senha.Text);
                    VerificaNull();
                }
                else
                {
                    MessageBox.Show("Esgotou o limite de Usuários cadastrados suportado pelo sistema, por favor exclua algum registro!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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
            CarregaObjUsuario();
            IsEdit = true;
        }
        private void btn_Deletar_Click(object sender, EventArgs e)
        {
            usuario.Excluir();
            lbl_Id.Text = "...";
            lbl_Usuario.Text = "...";
            lbl_Senha.Text = "...";
            btn_Editar.Enabled = false;
            btn_Deletar.Enabled = false;
        }
        //Métodos úteis.
        public void CarregaObjUsuario()
        {
            txb_Usuario.Text = usuario.User;
            txb_Senha.Text = usuario.Senha;
        }
        public void LimparCampos()
        {
            txb_Usuario.Text = "";
            txb_Senha.Text = "";
        }
        public void VerificaNull()
        {
            if (txb_Usuario.Text != null && txb_Senha.Text != null)
            {
                if (IsEdit == true)
                {
                    MessageBox.Show("Usuário editado com sucesso!!!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btn_Editar.Enabled = true;
                    btn_Deletar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Usuário cadastrado com sucesso!!!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btn_Editar.Enabled = true;
                    btn_Deletar.Enabled = true;
                }
                lbl_Id.Text = usuario.Id.ToString();
                lbl_Usuario.Text = usuario.User;
                lbl_Senha.Text = usuario.Senha;
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Campos obrigatórios não foram preenchidos", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
