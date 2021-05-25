namespace Software_Pim_3_Semestre
{
    partial class Frm_CadastroTipoQuarto
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
            this.txb_QtdHospede = new System.Windows.Forms.TextBox();
            this.txb_Tipo = new System.Windows.Forms.TextBox();
            this.txb_ValorDiaria = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckb_Almoco = new System.Windows.Forms.CheckBox();
            this.ckb_CafeDaManha = new System.Windows.Forms.CheckBox();
            this.ckb_Jantar = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.btn_Gravar = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.lbl_ValorD = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Deletar = new System.Windows.Forms.Button();
            this.lbl_QtdMaxp = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_Tipo = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txb_QtdHospede
            // 
            this.txb_QtdHospede.Location = new System.Drawing.Point(231, 51);
            this.txb_QtdHospede.Name = "txb_QtdHospede";
            this.txb_QtdHospede.Size = new System.Drawing.Size(100, 20);
            this.txb_QtdHospede.TabIndex = 2;
            // 
            // txb_Tipo
            // 
            this.txb_Tipo.Location = new System.Drawing.Point(231, 25);
            this.txb_Tipo.Name = "txb_Tipo";
            this.txb_Tipo.Size = new System.Drawing.Size(100, 20);
            this.txb_Tipo.TabIndex = 1;
            // 
            // txb_ValorDiaria
            // 
            this.txb_ValorDiaria.Location = new System.Drawing.Point(231, 78);
            this.txb_ValorDiaria.Name = "txb_ValorDiaria";
            this.txb_ValorDiaria.Size = new System.Drawing.Size(100, 20);
            this.txb_ValorDiaria.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(39, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "*Valor Diária por Pessoa:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckb_Almoco);
            this.groupBox1.Controls.Add(this.ckb_CafeDaManha);
            this.groupBox1.Controls.Add(this.ckb_Jantar);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(107, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Refeições";
            // 
            // ckb_Almoco
            // 
            this.ckb_Almoco.AutoSize = true;
            this.ckb_Almoco.Location = new System.Drawing.Point(6, 47);
            this.ckb_Almoco.Name = "ckb_Almoco";
            this.ckb_Almoco.Size = new System.Drawing.Size(75, 20);
            this.ckb_Almoco.TabIndex = 5;
            this.ckb_Almoco.Text = "Almoço";
            this.ckb_Almoco.UseVisualStyleBackColor = true;
            // 
            // ckb_CafeDaManha
            // 
            this.ckb_CafeDaManha.AutoSize = true;
            this.ckb_CafeDaManha.Location = new System.Drawing.Point(6, 24);
            this.ckb_CafeDaManha.Name = "ckb_CafeDaManha";
            this.ckb_CafeDaManha.Size = new System.Drawing.Size(124, 20);
            this.ckb_CafeDaManha.TabIndex = 4;
            this.ckb_CafeDaManha.Text = "Café Da Manhã";
            this.ckb_CafeDaManha.UseVisualStyleBackColor = true;
            // 
            // ckb_Jantar
            // 
            this.ckb_Jantar.AutoSize = true;
            this.ckb_Jantar.Location = new System.Drawing.Point(6, 70);
            this.ckb_Jantar.Name = "ckb_Jantar";
            this.ckb_Jantar.Size = new System.Drawing.Size(67, 20);
            this.ckb_Jantar.TabIndex = 6;
            this.ckb_Jantar.Text = "Jantar";
            this.ckb_Jantar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(14, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "*Quantidade Máx. de Hóspedes:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(113, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "*Tipo do Quarto:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(92, 25);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(218, 19);
            this.label17.TabIndex = 43;
            this.label17.Text = "Cadastro Novo Tipo Quarto";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Sair);
            this.groupBox2.Controls.Add(this.btn_Limpar);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.btn_Gravar);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txb_QtdHospede);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txb_Tipo);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txb_ValorDiaria);
            this.groupBox2.Location = new System.Drawing.Point(12, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(379, 284);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            // 
            // btn_Sair
            // 
            this.btn_Sair.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sair.ForeColor = System.Drawing.Color.DarkBlue;
            this.btn_Sair.Location = new System.Drawing.Point(164, 233);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(89, 33);
            this.btn_Sair.TabIndex = 8;
            this.btn_Sair.Text = "SAIR";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Limpar.ForeColor = System.Drawing.Color.Red;
            this.btn_Limpar.Location = new System.Drawing.Point(259, 233);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(89, 33);
            this.btn_Limpar.TabIndex = 9;
            this.btn_Limpar.Text = "LIMPAR";
            this.btn_Limpar.UseVisualStyleBackColor = true;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // btn_Gravar
            // 
            this.btn_Gravar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Gravar.ForeColor = System.Drawing.Color.ForestGreen;
            this.btn_Gravar.Location = new System.Drawing.Point(69, 233);
            this.btn_Gravar.Name = "btn_Gravar";
            this.btn_Gravar.Size = new System.Drawing.Size(89, 33);
            this.btn_Gravar.TabIndex = 45;
            this.btn_Gravar.Text = "GRAVAR";
            this.btn_Gravar.UseVisualStyleBackColor = true;
            this.btn_Gravar.Click += new System.EventHandler(this.btn_Gravar_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label19.Location = new System.Drawing.Point(250, 340);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(142, 15);
            this.label19.TabIndex = 48;
            this.label19.Text = "(* Campos obrigatórios)";
            // 
            // lbl_ValorD
            // 
            this.lbl_ValorD.AutoSize = true;
            this.lbl_ValorD.Location = new System.Drawing.Point(173, 58);
            this.lbl_ValorD.Name = "lbl_ValorD";
            this.lbl_ValorD.Size = new System.Drawing.Size(20, 16);
            this.lbl_ValorD.TabIndex = 54;
            this.lbl_ValorD.Text = "...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 16);
            this.label6.TabIndex = 53;
            this.label6.Text = "Valor Díaria por Pessoa:";
            // 
            // btn_Editar
            // 
            this.btn_Editar.Enabled = false;
            this.btn_Editar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Editar.ForeColor = System.Drawing.Color.DarkBlue;
            this.btn_Editar.Location = new System.Drawing.Point(283, 15);
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
            this.btn_Deletar.Location = new System.Drawing.Point(283, 51);
            this.btn_Deletar.Name = "btn_Deletar";
            this.btn_Deletar.Size = new System.Drawing.Size(89, 30);
            this.btn_Deletar.TabIndex = 49;
            this.btn_Deletar.Text = "Deletar";
            this.btn_Deletar.UseVisualStyleBackColor = true;
            this.btn_Deletar.Click += new System.EventHandler(this.btn_Deletar_Click);
            // 
            // lbl_QtdMaxp
            // 
            this.lbl_QtdMaxp.AutoSize = true;
            this.lbl_QtdMaxp.Location = new System.Drawing.Point(173, 40);
            this.lbl_QtdMaxp.Name = "lbl_QtdMaxp";
            this.lbl_QtdMaxp.Size = new System.Drawing.Size(20, 16);
            this.lbl_QtdMaxp.TabIndex = 51;
            this.lbl_QtdMaxp.Text = "...";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 16);
            this.label8.TabIndex = 50;
            this.label8.Text = "Qtd Max. Hóspedes:";
            // 
            // lbl_Tipo
            // 
            this.lbl_Tipo.AutoSize = true;
            this.lbl_Tipo.Location = new System.Drawing.Point(173, 24);
            this.lbl_Tipo.Name = "lbl_Tipo";
            this.lbl_Tipo.Size = new System.Drawing.Size(20, 16);
            this.lbl_Tipo.TabIndex = 49;
            this.lbl_Tipo.Text = "...";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(127, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 16);
            this.label10.TabIndex = 48;
            this.label10.Text = "Tipo:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_ValorD);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btn_Editar);
            this.groupBox3.Controls.Add(this.btn_Deletar);
            this.groupBox3.Controls.Add(this.lbl_QtdMaxp);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.lbl_Tipo);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(397, 52);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(378, 90);
            this.groupBox3.TabIndex = 49;
            this.groupBox3.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(485, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(191, 19);
            this.label11.TabIndex = 50;
            this.label11.Text = "Tipos Quarto Cadastros";
            // 
            // Frm_CadastroTipoQuarto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 364);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label17);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Frm_CadastroTipoQuarto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Tipo Quarto";
            this.Load += new System.EventHandler(this.Frm_CadastroTipoQuarto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_QtdHospede;
        private System.Windows.Forms.TextBox txb_Tipo;
        private System.Windows.Forms.TextBox txb_ValorDiaria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ckb_Almoco;
        private System.Windows.Forms.CheckBox ckb_CafeDaManha;
        private System.Windows.Forms.CheckBox ckb_Jantar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Button btn_Limpar;
        private System.Windows.Forms.Button btn_Gravar;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lbl_ValorD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_Deletar;
        private System.Windows.Forms.Label lbl_QtdMaxp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_Tipo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
    }
}