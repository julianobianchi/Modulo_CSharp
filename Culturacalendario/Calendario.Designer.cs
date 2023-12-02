namespace Culturacalendario
{
    partial class Calendario
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
            this.mcal1 = new System.Windows.Forms.MonthCalendar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboCultura = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboFormato = new System.Windows.Forms.ComboBox();
            this.txdDataFormatada = new System.Windows.Forms.TextBox();
            this.txtDataSelecionada = new System.Windows.Forms.TextBox();
            this.btnExibirData = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mcal1
            // 
            this.mcal1.Location = new System.Drawing.Point(19, 33);
            this.mcal1.Name = "mcal1";
            this.mcal1.TabIndex = 0;
            this.mcal1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mcal1_DateChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboCultura);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(271, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(131, 162);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cultura";
            // 
            // cboCultura
            // 
            this.cboCultura.BackColor = System.Drawing.Color.Yellow;
            this.cboCultura.FormattingEnabled = true;
            this.cboCultura.Location = new System.Drawing.Point(20, 81);
            this.cboCultura.Name = "cboCultura";
            this.cboCultura.Size = new System.Drawing.Size(94, 21);
            this.cboCultura.TabIndex = 5;
            this.cboCultura.SelectedIndexChanged += new System.EventHandler(this.cboCultura_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Escolher a Cultura";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Data Selecionada";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Formato";
            // 
            // cboFormato
            // 
            this.cboFormato.FormattingEnabled = true;
            this.cboFormato.Items.AddRange(new object[] {
            "MM/dd/yyyy",
            "dddd, dd MMMM yyyy",
            "dddd, dd MMMM yyyy HH:mm",
            "MM/dd/yyyy HH:mm",
            "MM/dd/yyyy HH:mm:ss",
            "MMMM dd",
            "yyyy\'-\'MM\'-\'dd\'T\'HH\':\'mm\':\'ss",
            "HH:mm",
            "HH:mm:ss",
            "dddd, dd MMMM yyyy HH:mm:ss",
            "yyyy MMMM"});
            this.cboFormato.Location = new System.Drawing.Point(19, 302);
            this.cboFormato.Name = "cboFormato";
            this.cboFormato.Size = new System.Drawing.Size(380, 21);
            this.cboFormato.TabIndex = 6;
            // 
            // txdDataFormatada
            // 
            this.txdDataFormatada.Location = new System.Drawing.Point(19, 263);
            this.txdDataFormatada.Name = "txdDataFormatada";
            this.txdDataFormatada.Size = new System.Drawing.Size(380, 20);
            this.txdDataFormatada.TabIndex = 7;
            // 
            // txtDataSelecionada
            // 
            this.txtDataSelecionada.Location = new System.Drawing.Point(19, 371);
            this.txtDataSelecionada.Multiline = true;
            this.txtDataSelecionada.Name = "txtDataSelecionada";
            this.txtDataSelecionada.Size = new System.Drawing.Size(379, 69);
            this.txtDataSelecionada.TabIndex = 8;
            // 
            // btnExibirData
            // 
            this.btnExibirData.Location = new System.Drawing.Point(19, 341);
            this.btnExibirData.Name = "btnExibirData";
            this.btnExibirData.Size = new System.Drawing.Size(383, 23);
            this.btnExibirData.TabIndex = 9;
            this.btnExibirData.Text = "Exibir Data Formatada para a Cultura";
            this.btnExibirData.UseVisualStyleBackColor = true;
            this.btnExibirData.Click += new System.EventHandler(this.btnExibirData_Click);
            // 
            // Calendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(439, 452);
            this.Controls.Add(this.btnExibirData);
            this.Controls.Add(this.txtDataSelecionada);
            this.Controls.Add(this.txdDataFormatada);
            this.Controls.Add(this.cboFormato);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mcal1);
            this.Name = "Calendario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formatação de data e hora";
            this.Load += new System.EventHandler(this.Calendario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar mcal1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboCultura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboFormato;
        private System.Windows.Forms.TextBox txdDataFormatada;
        private System.Windows.Forms.TextBox txtDataSelecionada;
        private System.Windows.Forms.Button btnExibirData;
    }
}