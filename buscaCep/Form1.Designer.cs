namespace buscaCep
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbCEP = new System.Windows.Forms.TextBox();
            this.btBuscar = new System.Windows.Forms.Button();
            this.txbEstado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbCidade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbBairro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbRua = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbComp1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbComp2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CEP (Ex.: 99999999)";
            // 
            // txbCEP
            // 
            this.txbCEP.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txbCEP.Location = new System.Drawing.Point(32, 43);
            this.txbCEP.Name = "txbCEP";
            this.txbCEP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txbCEP.Size = new System.Drawing.Size(103, 20);
            this.txbCEP.TabIndex = 1;
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(188, 39);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(75, 23);
            this.btBuscar.TabIndex = 2;
            this.btBuscar.Text = "BUSCAR";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // txbEstado
            // 
            this.txbEstado.Location = new System.Drawing.Point(32, 107);
            this.txbEstado.Name = "txbEstado";
            this.txbEstado.Size = new System.Drawing.Size(490, 20);
            this.txbEstado.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Estado";
            // 
            // txbCidade
            // 
            this.txbCidade.Location = new System.Drawing.Point(32, 152);
            this.txbCidade.Name = "txbCidade";
            this.txbCidade.Size = new System.Drawing.Size(490, 20);
            this.txbCidade.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cidade";
            // 
            // txbBairro
            // 
            this.txbBairro.Location = new System.Drawing.Point(32, 194);
            this.txbBairro.Name = "txbBairro";
            this.txbBairro.Size = new System.Drawing.Size(490, 20);
            this.txbBairro.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Bairro";
            // 
            // txbRua
            // 
            this.txbRua.Location = new System.Drawing.Point(32, 238);
            this.txbRua.Name = "txbRua";
            this.txbRua.Size = new System.Drawing.Size(490, 20);
            this.txbRua.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Rua/Avenida";
            // 
            // txbComp1
            // 
            this.txbComp1.Location = new System.Drawing.Point(32, 278);
            this.txbComp1.Name = "txbComp1";
            this.txbComp1.Size = new System.Drawing.Size(490, 20);
            this.txbComp1.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Complemento 1";
            // 
            // txbComp2
            // 
            this.txbComp2.Location = new System.Drawing.Point(32, 324);
            this.txbComp2.Name = "txbComp2";
            this.txbComp2.Size = new System.Drawing.Size(490, 20);
            this.txbComp2.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 308);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Complemento 2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::buscaCep.Properties.Resources.busca_cep;
            this.pictureBox1.Location = new System.Drawing.Point(301, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 461);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txbComp2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txbComp1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbRua);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbBairro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbCidade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbEstado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.txbCEP);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbCEP;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.TextBox txbEstado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbCidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbBairro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbRua;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbComp1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbComp2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

