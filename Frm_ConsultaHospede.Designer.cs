namespace Software_Pim_3_Semestre
{
    partial class Frm_ConsultaHospede
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_Atualizar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.dataGridView_Hospedes = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Idade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Passaporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone_Um = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone_Dois = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celular_Um = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celular_Dois = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txb_Consulta = new System.Windows.Forms.TextBox();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.btn_Confirmar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Hospedes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Nome",
            "Cpf",
            "Rg",
            "Passaporte"});
            this.comboBox1.Location = new System.Drawing.Point(19, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 24;
            // 
            // btn_Atualizar
            // 
            this.btn_Atualizar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Atualizar.Location = new System.Drawing.Point(235, 484);
            this.btn_Atualizar.Name = "btn_Atualizar";
            this.btn_Atualizar.Size = new System.Drawing.Size(87, 30);
            this.btn_Atualizar.TabIndex = 22;
            this.btn_Atualizar.Text = "ATUALIZAR";
            this.btn_Atualizar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(16, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "FILTRO";
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Excluir.ForeColor = System.Drawing.Color.Red;
            this.btn_Excluir.Location = new System.Drawing.Point(421, 484);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(87, 30);
            this.btn_Excluir.TabIndex = 21;
            this.btn_Excluir.Text = "EXCLUIR";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Hospedes
            // 
            this.dataGridView_Hospedes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Hospedes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Idade,
            this.Rg,
            this.Cpf,
            this.Passaporte,
            this.Rua,
            this.Numero,
            this.Bairro,
            this.Cidade,
            this.Cep,
            this.Uf,
            this.Pais,
            this.Telefone_Um,
            this.Telefone_Dois,
            this.Celular_Um,
            this.Celular_Dois,
            this.Email});
            this.dataGridView_Hospedes.Location = new System.Drawing.Point(19, 68);
            this.dataGridView_Hospedes.Name = "dataGridView_Hospedes";
            this.dataGridView_Hospedes.ReadOnly = true;
            this.dataGridView_Hospedes.Size = new System.Drawing.Size(715, 323);
            this.dataGridView_Hospedes.TabIndex = 17;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Idade
            // 
            this.Idade.HeaderText = "Idade";
            this.Idade.Name = "Idade";
            this.Idade.ReadOnly = true;
            // 
            // Rg
            // 
            this.Rg.HeaderText = "Rg";
            this.Rg.Name = "Rg";
            this.Rg.ReadOnly = true;
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
            // Rua
            // 
            this.Rua.HeaderText = "Rua";
            this.Rua.Name = "Rua";
            this.Rua.ReadOnly = true;
            // 
            // Numero
            // 
            this.Numero.HeaderText = "Número";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            // 
            // Bairro
            // 
            this.Bairro.HeaderText = "Bairro";
            this.Bairro.Name = "Bairro";
            this.Bairro.ReadOnly = true;
            // 
            // Cidade
            // 
            this.Cidade.HeaderText = "Cidade";
            this.Cidade.Name = "Cidade";
            this.Cidade.ReadOnly = true;
            // 
            // Cep
            // 
            this.Cep.HeaderText = "Cep";
            this.Cep.Name = "Cep";
            this.Cep.ReadOnly = true;
            // 
            // Uf
            // 
            this.Uf.HeaderText = "Uf";
            this.Uf.Name = "Uf";
            this.Uf.ReadOnly = true;
            // 
            // Pais
            // 
            this.Pais.HeaderText = "País";
            this.Pais.Name = "Pais";
            this.Pais.ReadOnly = true;
            // 
            // Telefone_Um
            // 
            this.Telefone_Um.HeaderText = "Telefone (1)";
            this.Telefone_Um.Name = "Telefone_Um";
            this.Telefone_Um.ReadOnly = true;
            // 
            // Telefone_Dois
            // 
            this.Telefone_Dois.HeaderText = "Telefone (2)";
            this.Telefone_Dois.Name = "Telefone_Dois";
            this.Telefone_Dois.ReadOnly = true;
            // 
            // Celular_Um
            // 
            this.Celular_Um.HeaderText = "Celular(1)";
            this.Celular_Um.Name = "Celular_Um";
            this.Celular_Um.ReadOnly = true;
            // 
            // Celular_Dois
            // 
            this.Celular_Dois.HeaderText = "Celular(2)";
            this.Celular_Dois.Name = "Celular_Dois";
            this.Celular_Dois.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.HeaderText = "E-mail";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // txb_Consulta
            // 
            this.txb_Consulta.Location = new System.Drawing.Point(146, 42);
            this.txb_Consulta.Name = "txb_Consulta";
            this.txb_Consulta.Size = new System.Drawing.Size(495, 20);
            this.txb_Consulta.TabIndex = 16;
            // 
            // btn_Editar
            // 
            this.btn_Editar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Editar.ForeColor = System.Drawing.Color.DarkBlue;
            this.btn_Editar.Location = new System.Drawing.Point(328, 484);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(87, 30);
            this.btn_Editar.TabIndex = 19;
            this.btn_Editar.Text = "EDITAR";
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(143, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "PESQUISAR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(273, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 19);
            this.label2.TabIndex = 20;
            this.label2.Text = "Consulta de Hóspedes";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Buscar);
            this.groupBox1.Controls.Add(this.dataGridView_Hospedes);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txb_Consulta);
            this.groupBox1.Location = new System.Drawing.Point(12, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(752, 414);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Buscar.Location = new System.Drawing.Point(647, 32);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(87, 30);
            this.btn_Buscar.TabIndex = 27;
            this.btn_Buscar.Text = "BUSCAR";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            // 
            // btn_Confirmar
            // 
            this.btn_Confirmar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Confirmar.ForeColor = System.Drawing.Color.ForestGreen;
            this.btn_Confirmar.Location = new System.Drawing.Point(12, 484);
            this.btn_Confirmar.Name = "btn_Confirmar";
            this.btn_Confirmar.Size = new System.Drawing.Size(102, 30);
            this.btn_Confirmar.TabIndex = 26;
            this.btn_Confirmar.Text = "CONFIRMAR";
            this.btn_Confirmar.UseVisualStyleBackColor = true;
            // 
            // Frm_ConsultaHospede
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 526);
            this.Controls.Add(this.btn_Confirmar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Atualizar);
            this.Controls.Add(this.btn_Editar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Frm_ConsultaHospede";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Hóspede";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Hospedes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView_Hospedes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Passaporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rua;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cep;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pais;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone_Um;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone_Dois;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celular_Um;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celular_Dois;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.TextBox txb_Consulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button btn_Confirmar;
        public System.Windows.Forms.Button btn_Atualizar;
        public System.Windows.Forms.Button btn_Excluir;
        public System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_Buscar;
    }
}