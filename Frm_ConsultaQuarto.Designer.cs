namespace Software_Pim_3_Semestre
{
    partial class Frm_ConsultaQuarto
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
            this.btn_Atualizar = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView_Hospedes = new System.Windows.Forms.DataGridView();
            this.Num_Quarto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Andar_Quarto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qnt_Hospedes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_Quarto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor_Diaria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ref_Quarto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status_Quarto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txb_Consulta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Confirmar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Hospedes)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Atualizar
            // 
            this.btn_Atualizar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Atualizar.Location = new System.Drawing.Point(245, 483);
            this.btn_Atualizar.Name = "btn_Atualizar";
            this.btn_Atualizar.Size = new System.Drawing.Size(87, 30);
            this.btn_Atualizar.TabIndex = 12;
            this.btn_Atualizar.Text = "ATUALIZAR";
            this.btn_Atualizar.UseVisualStyleBackColor = true;
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Excluir.ForeColor = System.Drawing.Color.Red;
            this.btn_Excluir.Location = new System.Drawing.Point(431, 483);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(87, 30);
            this.btn_Excluir.TabIndex = 11;
            this.btn_Excluir.Text = "EXCLUIR";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            // 
            // btn_Editar
            // 
            this.btn_Editar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Editar.ForeColor = System.Drawing.Color.DarkBlue;
            this.btn_Editar.Location = new System.Drawing.Point(338, 483);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(87, 30);
            this.btn_Editar.TabIndex = 8;
            this.btn_Editar.Text = "EDITAR";
            this.btn_Editar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.dataGridView_Hospedes);
            this.groupBox1.Controls.Add(this.txb_Consulta);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_Buscar);
            this.groupBox1.Location = new System.Drawing.Point(12, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(745, 408);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(12, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "FILTRO";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Número",
            "Andar",
            "Tipo"});
            this.comboBox1.Location = new System.Drawing.Point(15, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 13;
            // 
            // dataGridView_Hospedes
            // 
            this.dataGridView_Hospedes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Hospedes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num_Quarto,
            this.Andar_Quarto,
            this.Qnt_Hospedes,
            this.Tipo_Quarto,
            this.Valor_Diaria,
            this.Ref_Quarto,
            this.Status_Quarto});
            this.dataGridView_Hospedes.Location = new System.Drawing.Point(15, 65);
            this.dataGridView_Hospedes.Name = "dataGridView_Hospedes";
            this.dataGridView_Hospedes.ReadOnly = true;
            this.dataGridView_Hospedes.Size = new System.Drawing.Size(715, 323);
            this.dataGridView_Hospedes.TabIndex = 4;
            // 
            // Num_Quarto
            // 
            this.Num_Quarto.HeaderText = "Número";
            this.Num_Quarto.Name = "Num_Quarto";
            this.Num_Quarto.ReadOnly = true;
            // 
            // Andar_Quarto
            // 
            this.Andar_Quarto.HeaderText = "Andar";
            this.Andar_Quarto.Name = "Andar_Quarto";
            this.Andar_Quarto.ReadOnly = true;
            // 
            // Qnt_Hospedes
            // 
            this.Qnt_Hospedes.HeaderText = "Quantidade Hóspedes";
            this.Qnt_Hospedes.Name = "Qnt_Hospedes";
            this.Qnt_Hospedes.ReadOnly = true;
            // 
            // Tipo_Quarto
            // 
            this.Tipo_Quarto.HeaderText = "Tipo";
            this.Tipo_Quarto.Name = "Tipo_Quarto";
            this.Tipo_Quarto.ReadOnly = true;
            // 
            // Valor_Diaria
            // 
            this.Valor_Diaria.HeaderText = "Valor Diária";
            this.Valor_Diaria.Name = "Valor_Diaria";
            this.Valor_Diaria.ReadOnly = true;
            // 
            // Ref_Quarto
            // 
            this.Ref_Quarto.HeaderText = "Refeições";
            this.Ref_Quarto.Name = "Ref_Quarto";
            this.Ref_Quarto.ReadOnly = true;
            // 
            // Status_Quarto
            // 
            this.Status_Quarto.HeaderText = "Status";
            this.Status_Quarto.Name = "Status_Quarto";
            this.Status_Quarto.ReadOnly = true;
            // 
            // txb_Consulta
            // 
            this.txb_Consulta.Location = new System.Drawing.Point(142, 39);
            this.txb_Consulta.Name = "txb_Consulta";
            this.txb_Consulta.Size = new System.Drawing.Size(495, 20);
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
            this.btn_Buscar.Location = new System.Drawing.Point(643, 29);
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
            this.label2.Location = new System.Drawing.Point(278, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Consulta de Quartos";
            // 
            // btn_Confirmar
            // 
            this.btn_Confirmar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Confirmar.ForeColor = System.Drawing.Color.ForestGreen;
            this.btn_Confirmar.Location = new System.Drawing.Point(12, 483);
            this.btn_Confirmar.Name = "btn_Confirmar";
            this.btn_Confirmar.Size = new System.Drawing.Size(102, 30);
            this.btn_Confirmar.TabIndex = 13;
            this.btn_Confirmar.Text = "CONFIRMAR";
            this.btn_Confirmar.UseVisualStyleBackColor = true;
            this.btn_Confirmar.Click += new System.EventHandler(this.btn_Confirmar_Click);
            // 
            // Frm_ConsultaQuarto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 525);
            this.Controls.Add(this.btn_Confirmar);
            this.Controls.Add(this.btn_Atualizar);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Frm_ConsultaQuarto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Quartos";
            this.Load += new System.EventHandler(this.Frm_ConsultaQuarto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Hospedes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txb_Consulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView_Hospedes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num_Quarto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Andar_Quarto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qnt_Hospedes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Quarto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor_Diaria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ref_Quarto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status_Quarto;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button btn_Confirmar;
        public System.Windows.Forms.Button btn_Atualizar;
        public System.Windows.Forms.Button btn_Excluir;
        public System.Windows.Forms.Button btn_Editar;
    }
}