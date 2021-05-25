namespace Software_Pim_3_Semestre
{
    partial class Frm_ConsultaPagamento
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nfe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Num_Reserva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Forma_Pagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Num_Parcelas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor_Pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Troco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dt_Pagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Atualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nfe,
            this.Num_Reserva,
            this.Forma_Pagamento,
            this.Num_Parcelas,
            this.Valor_Total,
            this.Valor_Pago,
            this.Troco,
            this.Dt_Pagamento});
            this.dataGridView1.Location = new System.Drawing.Point(12, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(776, 327);
            this.dataGridView1.TabIndex = 0;
            // 
            // Nfe
            // 
            this.Nfe.HeaderText = "NFE";
            this.Nfe.Name = "Nfe";
            this.Nfe.ReadOnly = true;
            // 
            // Num_Reserva
            // 
            this.Num_Reserva.HeaderText = "Número Reserva";
            this.Num_Reserva.Name = "Num_Reserva";
            this.Num_Reserva.ReadOnly = true;
            // 
            // Forma_Pagamento
            // 
            this.Forma_Pagamento.HeaderText = "Forma Pagamento";
            this.Forma_Pagamento.Name = "Forma_Pagamento";
            this.Forma_Pagamento.ReadOnly = true;
            // 
            // Num_Parcelas
            // 
            this.Num_Parcelas.HeaderText = "Número Parcelas";
            this.Num_Parcelas.Name = "Num_Parcelas";
            this.Num_Parcelas.ReadOnly = true;
            // 
            // Valor_Total
            // 
            this.Valor_Total.HeaderText = "Valor Total";
            this.Valor_Total.Name = "Valor_Total";
            this.Valor_Total.ReadOnly = true;
            // 
            // Valor_Pago
            // 
            this.Valor_Pago.HeaderText = "Valor Pago";
            this.Valor_Pago.Name = "Valor_Pago";
            this.Valor_Pago.ReadOnly = true;
            // 
            // Troco
            // 
            this.Troco.HeaderText = "Troco";
            this.Troco.Name = "Troco";
            this.Troco.ReadOnly = true;
            // 
            // Dt_Pagamento
            // 
            this.Dt_Pagamento.HeaderText = "Data Pagamento";
            this.Dt_Pagamento.Name = "Dt_Pagamento";
            this.Dt_Pagamento.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(279, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 19);
            this.label2.TabIndex = 21;
            this.label2.Text = "Consulta de Pagamentos";
            // 
            // btn_Atualizar
            // 
            this.btn_Atualizar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Atualizar.ForeColor = System.Drawing.Color.DarkBlue;
            this.btn_Atualizar.Location = new System.Drawing.Point(12, 412);
            this.btn_Atualizar.Name = "btn_Atualizar";
            this.btn_Atualizar.Size = new System.Drawing.Size(87, 30);
            this.btn_Atualizar.TabIndex = 23;
            this.btn_Atualizar.Text = "ATUALIZAR";
            this.btn_Atualizar.UseVisualStyleBackColor = true;
            // 
            // Frm_ConsultaPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 453);
            this.Controls.Add(this.btn_Atualizar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Frm_ConsultaPagamento";
            this.Text = "Consulta Pagamentos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nfe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num_Reserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn Forma_Pagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num_Parcelas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor_Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor_Pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn Troco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dt_Pagamento;
        public System.Windows.Forms.Button btn_Atualizar;
    }
}