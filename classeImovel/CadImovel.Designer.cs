namespace classeImovel
{
    partial class CadImovel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadImovel));
            button4 = new Button();
            bntLimpar = new Button();
            label11 = new Label();
            bntCalcular = new Button();
            bntCadastro = new Button();
            cbxTipo = new ComboBox();
            ltbResultado = new ListBox();
            txtNumG = new NumericUpDown();
            txtNumB = new NumericUpDown();
            txtNumQ = new NumericUpDown();
            txtArea = new TextBox();
            txtPreco = new TextBox();
            txtEndereco = new TextBox();
            txtNome = new TextBox();
            txtId = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)txtNumG).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtNumB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtNumQ).BeginInit();
            SuspendLayout();
            // 
            // button4
            // 
            button4.BackColor = SystemColors.Menu;
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.Location = new Point(638, 14);
            button4.Name = "button4";
            button4.Size = new Size(90, 32);
            button4.TabIndex = 49;
            button4.Text = "SAIR";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // bntLimpar
            // 
            bntLimpar.BackColor = SystemColors.Menu;
            bntLimpar.BackgroundImageLayout = ImageLayout.Stretch;
            bntLimpar.Location = new Point(400, 419);
            bntLimpar.Name = "bntLimpar";
            bntLimpar.Size = new Size(90, 32);
            bntLimpar.TabIndex = 48;
            bntLimpar.Text = "LIMPAR";
            bntLimpar.UseVisualStyleBackColor = false;
            bntLimpar.Click += bntLimpar_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(16, 419);
            label11.Name = "label11";
            label11.Size = new Size(118, 21);
            label11.TabIndex = 47;
            label11.Text = "PREÇO POR M²";
            // 
            // bntCalcular
            // 
            bntCalcular.BackColor = SystemColors.Menu;
            bntCalcular.BackgroundImageLayout = ImageLayout.Stretch;
            bntCalcular.Location = new Point(140, 419);
            bntCalcular.Name = "bntCalcular";
            bntCalcular.Size = new Size(90, 32);
            bntCalcular.TabIndex = 46;
            bntCalcular.Text = "CALCULAR";
            bntCalcular.UseVisualStyleBackColor = false;
            bntCalcular.Click += bntCalcular_Click;
            // 
            // bntCadastro
            // 
            bntCadastro.BackColor = SystemColors.Menu;
            bntCadastro.BackgroundImageLayout = ImageLayout.Stretch;
            bntCadastro.Location = new Point(271, 419);
            bntCadastro.Name = "bntCadastro";
            bntCadastro.Size = new Size(90, 32);
            bntCadastro.TabIndex = 45;
            bntCadastro.Text = "CADASTRAR";
            bntCadastro.UseVisualStyleBackColor = false;
            bntCadastro.Click += bntCadastro_Click;
            // 
            // cbxTipo
            // 
            cbxTipo.FormattingEnabled = true;
            cbxTipo.Items.AddRange(new object[] { "Apartamento", "Casa", "Sobrado", "Ponto Comercial", "Terreno" });
            cbxTipo.Location = new Point(151, 190);
            cbxTipo.Name = "cbxTipo";
            cbxTipo.Size = new Size(145, 23);
            cbxTipo.TabIndex = 44;
            // 
            // ltbResultado
            // 
            ltbResultado.FormattingEnabled = true;
            ltbResultado.ItemHeight = 15;
            ltbResultado.Location = new Point(524, 87);
            ltbResultado.Name = "ltbResultado";
            ltbResultado.Size = new Size(204, 364);
            ltbResultado.TabIndex = 43;
            // 
            // txtNumG
            // 
            txtNumG.Location = new Point(212, 303);
            txtNumG.Name = "txtNumG";
            txtNumG.Size = new Size(39, 23);
            txtNumG.TabIndex = 42;
            // 
            // txtNumB
            // 
            txtNumB.Location = new Point(212, 266);
            txtNumB.Name = "txtNumB";
            txtNumB.Size = new Size(39, 23);
            txtNumB.TabIndex = 41;
            // 
            // txtNumQ
            // 
            txtNumQ.Location = new Point(212, 225);
            txtNumQ.Name = "txtNumQ";
            txtNumQ.Size = new Size(39, 23);
            txtNumQ.TabIndex = 40;
            // 
            // txtArea
            // 
            txtArea.Location = new Point(103, 344);
            txtArea.Name = "txtArea";
            txtArea.Size = new Size(193, 23);
            txtArea.TabIndex = 39;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(103, 377);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(193, 23);
            txtPreco.TabIndex = 38;
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(151, 149);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(145, 23);
            txtEndereco.TabIndex = 37;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(151, 108);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(145, 23);
            txtNome.TabIndex = 36;
            // 
            // txtId
            // 
            txtId.Location = new Point(119, 72);
            txtId.Name = "txtId";
            txtId.Size = new Size(177, 23);
            txtId.TabIndex = 35;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(16, 379);
            label10.Name = "label10";
            label10.Size = new Size(59, 21);
            label10.TabIndex = 34;
            label10.Text = "PREÇO";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(16, 344);
            label9.Name = "label9";
            label9.Size = new Size(72, 21);
            label9.TabIndex = 33;
            label9.Text = "ÁREA M²";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(16, 305);
            label8.Name = "label8";
            label8.Size = new Size(185, 21);
            label8.TabIndex = 32;
            label8.Text = "QUANTIDADE GARAGEM";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(16, 266);
            label7.Name = "label7";
            label7.Size = new Size(187, 21);
            label7.TabIndex = 31;
            label7.Text = "QUANTIDADE BANHEIRO";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(16, 227);
            label6.Name = "label6";
            label6.Size = new Size(172, 21);
            label6.TabIndex = 30;
            label6.Text = "QUANTIDADE QUARTO";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(16, 192);
            label5.Name = "label5";
            label5.Size = new Size(103, 21);
            label5.TabIndex = 29;
            label5.Text = "TIPO IMÓVEL";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(16, 151);
            label4.Name = "label4";
            label4.Size = new Size(89, 21);
            label4.TabIndex = 28;
            label4.Text = "ENDEREÇO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(16, 110);
            label3.Name = "label3";
            label3.Size = new Size(115, 21);
            label3.TabIndex = 27;
            label3.Text = "PROPRIETÁRIO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(16, 74);
            label2.Name = "label2";
            label2.Size = new Size(85, 21);
            label2.TabIndex = 26;
            label2.Text = "ID IMÓVEL";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(335, 9);
            label1.Name = "label1";
            label1.Size = new Size(97, 37);
            label1.TabIndex = 25;
            label1.Text = "Imóvel";
            // 
            // CadImovel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SandyBrown;
            ClientSize = new Size(746, 460);
            Controls.Add(button4);
            Controls.Add(bntLimpar);
            Controls.Add(label11);
            Controls.Add(bntCalcular);
            Controls.Add(bntCadastro);
            Controls.Add(cbxTipo);
            Controls.Add(ltbResultado);
            Controls.Add(txtNumG);
            Controls.Add(txtNumB);
            Controls.Add(txtNumQ);
            Controls.Add(txtArea);
            Controls.Add(txtPreco);
            Controls.Add(txtEndereco);
            Controls.Add(txtNome);
            Controls.Add(txtId);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CadImovel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CadImovel";
            ((System.ComponentModel.ISupportInitialize)txtNumG).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtNumB).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtNumQ).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button4;
        private Button bntLimpar;
        private Label label11;
        private Button bntCalcular;
        private Button bntCadastro;
        private ComboBox cbxTipo;
        private ListBox ltbResultado;
        private NumericUpDown txtNumG;
        private NumericUpDown txtNumB;
        private NumericUpDown txtNumQ;
        private TextBox txtArea;
        private TextBox txtPreco;
        private TextBox txtEndereco;
        private TextBox txtNome;
        private TextBox txtId;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}