namespace Projeto_Jogo
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bntLimpar = new System.Windows.Forms.Button();
            this.bntCadastro = new System.Windows.Forms.Button();
            this.ckbMaiorIdade = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbLogin = new System.Windows.Forms.TextBox();
            this.txbData = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbCPF = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.bntSelecao = new System.Windows.Forms.Button();
            this.bntSair = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.bntLimpar);
            this.groupBox1.Controls.Add(this.bntCadastro);
            this.groupBox1.Controls.Add(this.ckbMaiorIdade);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txbSenha);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txbLogin);
            this.groupBox1.Controls.Add(this.txbData);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txbCPF);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txbEmail);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txbNome);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(93, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(620, 328);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro Jogador";
            // 
            // bntLimpar
            // 
            this.bntLimpar.BackColor = System.Drawing.SystemColors.MenuBar;
            this.bntLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntLimpar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bntLimpar.Location = new System.Drawing.Point(474, 270);
            this.bntLimpar.Name = "bntLimpar";
            this.bntLimpar.Size = new System.Drawing.Size(117, 40);
            this.bntLimpar.TabIndex = 15;
            this.bntLimpar.Text = "LIMPAR";
            this.bntLimpar.UseVisualStyleBackColor = false;
            // 
            // bntCadastro
            // 
            this.bntCadastro.BackColor = System.Drawing.SystemColors.MenuBar;
            this.bntCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntCadastro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bntCadastro.Location = new System.Drawing.Point(344, 270);
            this.bntCadastro.Name = "bntCadastro";
            this.bntCadastro.Size = new System.Drawing.Size(117, 40);
            this.bntCadastro.TabIndex = 14;
            this.bntCadastro.Text = "CADASTRAR";
            this.bntCadastro.UseVisualStyleBackColor = false;
            this.bntCadastro.Click += new System.EventHandler(this.bntCadastro_Click);
            // 
            // ckbMaiorIdade
            // 
            this.ckbMaiorIdade.AutoSize = true;
            this.ckbMaiorIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.ckbMaiorIdade.Location = new System.Drawing.Point(31, 293);
            this.ckbMaiorIdade.Name = "ckbMaiorIdade";
            this.ckbMaiorIdade.Size = new System.Drawing.Size(145, 17);
            this.ckbMaiorIdade.TabIndex = 13;
            this.ckbMaiorIdade.Text = "Possuo mais de 18 Anos!";
            this.ckbMaiorIdade.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label7.Location = new System.Drawing.Point(27, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(268, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Para você poder apostar precisar ser maior de 18 anos!";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Senha:";
            // 
            // txbSenha
            // 
            this.txbSenha.Location = new System.Drawing.Point(206, 230);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.PasswordChar = '*';
            this.txbSenha.Size = new System.Drawing.Size(143, 26);
            this.txbSenha.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Login:";
            // 
            // txbLogin
            // 
            this.txbLogin.Location = new System.Drawing.Point(206, 195);
            this.txbLogin.Name = "txbLogin";
            this.txbLogin.Size = new System.Drawing.Size(143, 26);
            this.txbLogin.TabIndex = 8;
            // 
            // txbData
            // 
            this.txbData.Location = new System.Drawing.Point(206, 160);
            this.txbData.Name = "txbData";
            this.txbData.Size = new System.Drawing.Size(362, 26);
            this.txbData.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data de Nascimento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "CPF:";
            // 
            // txbCPF
            // 
            this.txbCPF.Location = new System.Drawing.Point(206, 120);
            this.txbCPF.Name = "txbCPF";
            this.txbCPF.Size = new System.Drawing.Size(143, 26);
            this.txbCPF.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email:";
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(206, 85);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(385, 26);
            this.txbEmail.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(206, 50);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(385, 26);
            this.txbNome.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(295, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(213, 31);
            this.label8.TabIndex = 1;
            this.label8.Text = "MEGA JOGOS ";
            // 
            // bntSelecao
            // 
            this.bntSelecao.BackColor = System.Drawing.SystemColors.MenuBar;
            this.bntSelecao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bntSelecao.Location = new System.Drawing.Point(282, 398);
            this.bntSelecao.Name = "bntSelecao";
            this.bntSelecao.Size = new System.Drawing.Size(260, 40);
            this.bntSelecao.TabIndex = 16;
            this.bntSelecao.Text = "SELECIONE SEU JOGO AQUI...";
            this.bntSelecao.UseVisualStyleBackColor = false;
            this.bntSelecao.Click += new System.EventHandler(this.bntSelecao_Click);
            // 
            // bntSair
            // 
            this.bntSair.BackColor = System.Drawing.SystemColors.MenuBar;
            this.bntSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bntSair.Location = new System.Drawing.Point(701, 398);
            this.bntSair.Name = "bntSair";
            this.bntSair.Size = new System.Drawing.Size(87, 40);
            this.bntSair.TabIndex = 17;
            this.bntSair.Text = "SAIR";
            this.bntSair.UseVisualStyleBackColor = false;
            this.bntSair.Click += new System.EventHandler(this.bntSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projeto_Jogo.Properties.Resources.fundo1;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bntSair);
            this.Controls.Add(this.bntSelecao);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MEGA JOGOS";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbCPF;
        private System.Windows.Forms.CheckBox ckbMaiorIdade;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbLogin;
        private System.Windows.Forms.DateTimePicker txbData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bntLimpar;
        private System.Windows.Forms.Button bntCadastro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bntSelecao;
        private System.Windows.Forms.Button bntSair;
    }
}

