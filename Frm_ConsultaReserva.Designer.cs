namespace Software_Pim_3_Semestre
{
    partial class Frm_ConsultaReserva
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_Atualizar = new System.Windows.Forms.Button();
            this.btn_DarBaixa = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView_Hospedes = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Passaporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_Checkin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_Checkout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_Quarto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qtd_Pessoas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txb_Consulta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Hospedes)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Atualizar
            // 
            this.Btn_Atualizar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.Btn_Atualizar.ForeColor = System.Drawing.Color.DarkBlue;
            this.Btn_Atualizar.Location = new System.Drawing.Point(12, 478);
            this.Btn_Atualizar.Name = "Btn_Atualizar";
            this.Btn_Atualizar.Size = new System.Drawing.Size(87, 30);
            this.Btn_Atualizar.TabIndex = 17;
            this.Btn_Atualizar.Text = "ATUALIZAR";
            this.Btn_Atualizar.UseVisualStyleBackColor = true;
            // 
            // btn_DarBaixa
            // 
            this.btn_DarBaixa.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_DarBaixa.ForeColor = System.Drawing.Color.ForestGreen;
            this.btn_DarBaixa.Location = new System.Drawing.Point(105, 478);
            this.btn_DarBaixa.Name = "btn_DarBaixa";
            this.btn_DarBaixa.Size = new System.Drawing.Size(87, 30);
            this.btn_DarBaixa.TabIndex = 13;
            this.btn_DarBaixa.Text = "DAR BAIXA";
            this.btn_DarBaixa.UseVisualStyleBackColor = true;
            this.btn_DarBaixa.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.dataGridView_Hospedes);
            this.groupBox1.Controls.Add(this.txb_Consulta);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_Buscar);
            this.groupBox1.Location = new System.Drawing.Point(12, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(848, 408);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(12, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "FILTRO";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Número Quarto",
            "Nome"});
            this.comboBox1.Location = new System.Drawing.Point(15, 39);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // dataGridView_Hospedes
            // 
            this.dataGridView_Hospedes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Hospedes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Cpf,
            this.Passaporte,
            this.Data_Checkin,
            this.Data_Checkout,
            this.Tipo_Quarto,
            this.Qtd_Pessoas,
            this.Valor_Total});
            this.dataGridView_Hospedes.Location = new System.Drawing.Point(15, 65);
            this.dataGridView_Hospedes.Name = "dataGridView_Hospedes";
            this.dataGridView_Hospedes.ReadOnly = true;
            this.dataGridView_Hospedes.Size = new System.Drawing.Size(818, 323);
            this.dataGridView_Hospedes.TabIndex = 1;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome Reservante";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Cpf
            // 
            this.Cpf.HeaderText = "Cpf";
            this.Cpf.Name = "Cpf";
            this.Cpf.ReadOnly = true;
            // 
            // Passaporte
            // 
            this.Passaporte.HeaderText = "Passaporte";
            this.Passaporte.Name = "Passaporte";
            this.Passaporte.ReadOnly = true;
            // 
            // Data_Checkin
            // 
            this.Data_Checkin.HeaderText = "Data Check-in";
            this.Data_Checkin.Name = "Data_Checkin";
            this.Data_Checkin.ReadOnly = true;
            // 
            // Data_Checkout
            // 
            this.Data_Checkout.HeaderText = "Data Check-out";
            this.Data_Checkout.Name = "Data_Checkout";
            this.Data_Checkout.ReadOnly = true;
            // 
            // Tipo_Quarto
            // 
            this.Tipo_Quarto.HeaderText = "Tipo Quarto";
            this.Tipo_Quarto.Name = "Tipo_Quarto";
            this.Tipo_Quarto.ReadOnly = true;
            // 
            // Qtd_Pessoas
            // 
            this.Qtd_Pessoas.HeaderText = "Quantidade Hóspedes";
            this.Qtd_Pessoas.Name = "Qtd_Pessoas";
            this.Qtd_Pessoas.ReadOnly = true;
            // 
            // Valor_Total
            // 
            this.Valor_Total.HeaderText = "Valor Total";
            this.Valor_Total.Name = "Valor_Total";
            this.Valor_Total.ReadOnly = true;
            // 
            // txb_Consulta
            // 
            this.txb_Consulta.Location = new System.Drawing.Point(142, 39);
            this.txb_Consulta.Name = "txb_Consulta";
            this.txb_Consulta.Size = new System.Drawing.Size(598, 20);
            this.txb_Consulta.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(139, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "PESQUISAR";
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Buscar.Location = new System.Drawing.Point(746, 29);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(87, 30);
            this.btn_Buscar.TabIndex = 2;
            this.btn_Buscar.Text = "BUSCAR";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(323, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "Consulta Hospedagem";
            // 
            // Frm_ConsultaReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 522);
            this.Controls.Add(this.Btn_Atualizar);
            this.Controls.Add(this.btn_DarBaixa);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Frm_ConsultaReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Reservas";
            this.Load += new System.EventHandler(this.Frm_ConsultaReserva_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Hospedes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Atualizar;
        private System.Windows.Forms.Button btn_DarBaixa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView_Hospedes;
        private System.Windows.Forms.TextBox txb_Consulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Passaporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_Checkin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_Checkout;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Quarto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qtd_Pessoas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor_Total;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}