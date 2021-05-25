namespace Software_Pim_3_Semestre
{
    partial class Frm_CadastroQuarto
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
            this.txb_Andar = new System.Windows.Forms.TextBox();
            this.txb_QtdHospede = new System.Windows.Forms.TextBox();
            this.txb_ValorDiaria = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_NumQuarto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.btn_Gravar = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbx_Tipo = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_Tipo = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Deletar = new System.Windows.Forms.Button();
            this.lbl_Andar = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_Numero = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txb_Andar
            // 
            this.txb_Andar.Location = new System.Drawing.Point(225, 50);
            this.txb_Andar.Name = "txb_Andar";
            this.txb_Andar.Size = new System.Drawing.Size(100, 20);
            this.txb_Andar.TabIndex = 2;
            // 
            // txb_QtdHospede
            // 
            this.txb_QtdHospede.Location = new System.Drawing.Point(225, 103);
            this.txb_QtdHospede.Name = "txb_QtdHospede";
            this.txb_QtdHospede.ReadOnly = true;
            this.txb_QtdHospede.Size = new System.Drawing.Size(100, 20);
            this.txb_QtdHospede.TabIndex = 3;
            // 
            // txb_ValorDiaria
            // 
            this.txb_ValorDiaria.Location = new System.Drawing.Point(225, 130);
            this.txb_ValorDiaria.Name = "txb_ValorDiaria";
            this.txb_ValorDiaria.ReadOnly = true;
            this.txb_ValorDiaria.Size = new System.Drawing.Size(100, 20);
            this.txb_ValorDiaria.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(152, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "*Número:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(13, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Quantidade Máx. de Hóspedes:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(164, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "*Andar:";
            // 
            // txb_NumQuarto
            // 
            this.txb_NumQuarto.Location = new System.Drawing.Point(225, 23);
            this.txb_NumQuarto.Name = "txb_NumQuarto";
            this.txb_NumQuarto.Size = new System.Drawing.Size(51, 20);
            this.txb_NumQuarto.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(38, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Valor da Diária por Pessoa:";
            // 
            // btn_Sair
            // 
            this.btn_Sair.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sair.ForeColor = System.Drawing.Color.DarkBlue;
            this.btn_Sair.Location = new System.Drawing.Point(167, 166);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(89, 33);
            this.btn_Sair.TabIndex = 6;
            this.btn_Sair.Text = "SAIR";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Limpar.ForeColor = System.Drawing.Color.Red;
            this.btn_Limpar.Location = new System.Drawing.Point(262, 166);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(89, 33);
            this.btn_Limpar.TabIndex = 7;
            this.btn_Limpar.Text = "LIMPAR";
            this.btn_Limpar.UseVisualStyleBackColor = true;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // btn_Gravar
            // 
            this.btn_Gravar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Gravar.ForeColor = System.Drawing.Color.ForestGreen;
            this.btn_Gravar.Location = new System.Drawing.Point(72, 166);
            this.btn_Gravar.Name = "btn_Gravar";
            this.btn_Gravar.Size = new System.Drawing.Size(89, 33);
            this.btn_Gravar.TabIndex = 5;
            this.btn_Gravar.Text = "GRAVAR";
            this.btn_Gravar.UseVisualStyleBackColor = true;
            this.btn_Gravar.Click += new System.EventHandler(this.btn_Gravar_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(152, 24);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(158, 19);
            this.label17.TabIndex = 42;
            this.label17.Text = "Cadastro de Quarto";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cbx_Tipo);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txb_Andar);
            this.groupBox2.Controls.Add(this.btn_Sair);
            this.groupBox2.Controls.Add(this.txb_QtdHospede);
            this.groupBox2.Controls.Add(this.btn_Limpar);
            this.groupBox2.Controls.Add(this.btn_Gravar);
            this.groupBox2.Controls.Add(this.txb_ValorDiaria);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txb_NumQuarto);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(18, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(420, 215);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(29, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "*Tipo de Quarto já existente:";
            // 
            // cbx_Tipo
            // 
            this.cbx_Tipo.FormattingEnabled = true;
            this.cbx_Tipo.Location = new System.Drawing.Point(225, 76);
            this.cbx_Tipo.Name = "cbx_Tipo";
            this.cbx_Tipo.Size = new System.Drawing.Size(100, 21);
            this.cbx_Tipo.TabIndex = 16;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label19.Location = new System.Drawing.Point(296, 271);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(142, 15);
            this.label19.TabIndex = 47;
            this.label19.Text = "(* Campos obrigatórios)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(575, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(172, 19);
            this.label14.TabIndex = 50;
            this.label14.Text = "Quartos Cadastrados";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_Tipo);
            this.groupBox1.Controls.Add(this.label50);
            this.groupBox1.Controls.Add(this.btn_Editar);
            this.groupBox1.Controls.Add(this.btn_Deletar);
            this.groupBox1.Controls.Add(this.lbl_Andar);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.lbl_Numero);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(444, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 90);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            // 
            // lbl_Tipo
            // 
            this.lbl_Tipo.AutoSize = true;
            this.lbl_Tipo.Location = new System.Drawing.Point(131, 56);
            this.lbl_Tipo.Name = "lbl_Tipo";
            this.lbl_Tipo.Size = new System.Drawing.Size(20, 16);
            this.lbl_Tipo.TabIndex = 54;
            this.lbl_Tipo.Text = "...";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(85, 56);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(40, 16);
            this.label50.TabIndex = 53;
            this.label50.Text = "Tipo:";
            // 
            // btn_Editar
            // 
            this.btn_Editar.Enabled = false;
            this.btn_Editar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Editar.ForeColor = System.Drawing.Color.DarkBlue;
            this.btn_Editar.Location = new System.Drawing.Point(282, 15);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(89, 30);
            this.btn_Editar.TabIndex = 52;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // btn_Deletar
            // 
            this.btn_Deletar.Enabled = false;
            this.btn_Deletar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Deletar.ForeColor = System.Drawing.Color.Red;
            this.btn_Deletar.Location = new System.Drawing.Point(282, 49);
            this.btn_Deletar.Name = "btn_Deletar";
            this.btn_Deletar.Size = new System.Drawing.Size(89, 30);
            this.btn_Deletar.TabIndex = 49;
            this.btn_Deletar.Text = "Deletar";
            this.btn_Deletar.UseVisualStyleBackColor = true;
            this.btn_Deletar.Click += new System.EventHandler(this.btn_Deletar_Click);
            // 
            // lbl_Andar
            // 
            this.lbl_Andar.AutoSize = true;
            this.lbl_Andar.Location = new System.Drawing.Point(131, 40);
            this.lbl_Andar.Name = "lbl_Andar";
            this.lbl_Andar.Size = new System.Drawing.Size(20, 16);
            this.lbl_Andar.TabIndex = 51;
            this.lbl_Andar.Text = "...";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(75, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 16);
            this.label12.TabIndex = 50;
            this.label12.Text = "Andar:";
            // 
            // lbl_Numero
            // 
            this.lbl_Numero.AutoSize = true;
            this.lbl_Numero.Location = new System.Drawing.Point(131, 24);
            this.lbl_Numero.Name = "lbl_Numero";
            this.lbl_Numero.Size = new System.Drawing.Size(20, 16);
            this.lbl_Numero.TabIndex = 49;
            this.lbl_Numero.Text = "...";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(63, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 16);
            this.label11.TabIndex = 48;
            this.label11.Text = "Número:";
            // 
            // Frm_CadastroQuarto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 298);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label17);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Frm_CadastroQuarto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Quarto";
            this.Load += new System.EventHandler(this.Frm_CadastroQuarto_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_Andar;
        private System.Windows.Forms.TextBox txb_QtdHospede;
        private System.Windows.Forms.TextBox txb_ValorDiaria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_NumQuarto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Button btn_Limpar;
        private System.Windows.Forms.Button btn_Gravar;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbx_Tipo;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_Tipo;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_Deletar;
        private System.Windows.Forms.Label lbl_Andar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl_Numero;
        private System.Windows.Forms.Label label11;
    }
}