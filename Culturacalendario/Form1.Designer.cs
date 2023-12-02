namespace Culturacalendario
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
            this.cbxDiasSemana = new System.Windows.Forms.ComboBox();
            this.btnPreencherDiasSemana = new System.Windows.Forms.Button();
            this.lblDia = new System.Windows.Forms.Label();
            this.bntCalendario = new System.Windows.Forms.Button();
            this.bntCalculadora = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(47, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dias da Semana";
            // 
            // cbxDiasSemana
            // 
            this.cbxDiasSemana.FormattingEnabled = true;
            this.cbxDiasSemana.Location = new System.Drawing.Point(31, 49);
            this.cbxDiasSemana.Name = "cbxDiasSemana";
            this.cbxDiasSemana.Size = new System.Drawing.Size(169, 21);
            this.cbxDiasSemana.TabIndex = 1;
            // 
            // btnPreencherDiasSemana
            // 
            this.btnPreencherDiasSemana.Location = new System.Drawing.Point(31, 94);
            this.btnPreencherDiasSemana.Name = "btnPreencherDiasSemana";
            this.btnPreencherDiasSemana.Size = new System.Drawing.Size(169, 23);
            this.btnPreencherDiasSemana.TabIndex = 2;
            this.btnPreencherDiasSemana.Text = "Preencher dias da semana";
            this.btnPreencherDiasSemana.UseVisualStyleBackColor = true;
            this.btnPreencherDiasSemana.Click += new System.EventHandler(this.btnPreencherDiasSemana_Click);
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Location = new System.Drawing.Point(38, 138);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(0, 13);
            this.lblDia.TabIndex = 3;
            // 
            // bntCalendario
            // 
            this.bntCalendario.Location = new System.Drawing.Point(12, 172);
            this.bntCalendario.Name = "bntCalendario";
            this.bntCalendario.Size = new System.Drawing.Size(75, 23);
            this.bntCalendario.TabIndex = 4;
            this.bntCalendario.Text = "Caledario";
            this.bntCalendario.UseVisualStyleBackColor = true;
            this.bntCalendario.Click += new System.EventHandler(this.bntCalendario_Click);
            // 
            // bntCalculadora
            // 
            this.bntCalculadora.Location = new System.Drawing.Point(168, 172);
            this.bntCalculadora.Name = "bntCalculadora";
            this.bntCalculadora.Size = new System.Drawing.Size(75, 23);
            this.bntCalculadora.TabIndex = 5;
            this.bntCalculadora.Text = "Calculadora";
            this.bntCalculadora.UseVisualStyleBackColor = true;
            this.bntCalculadora.Click += new System.EventHandler(this.bntCalculadora_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(255, 207);
            this.Controls.Add(this.bntCalculadora);
            this.Controls.Add(this.bntCalendario);
            this.Controls.Add(this.lblDia);
            this.Controls.Add(this.btnPreencherDiasSemana);
            this.Controls.Add(this.cbxDiasSemana);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxDiasSemana;
        private System.Windows.Forms.Button btnPreencherDiasSemana;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Button bntCalendario;
        private System.Windows.Forms.Button bntCalculadora;
    }
}

