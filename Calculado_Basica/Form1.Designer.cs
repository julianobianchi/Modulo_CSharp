namespace Calculado_Basica
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtVisor = new TextBox();
            btnPorcento = new Button();
            btnCe = new Button();
            btnC = new Button();
            button3 = new Button();
            button4 = new Button();
            btnRaiz = new Button();
            btnXquadrado = new Button();
            btn1x = new Button();
            btnMultiplicar = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btnSubtrair = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btnSoma = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btnIgual = new Button();
            btnVirgula = new Button();
            btn0 = new Button();
            btnMaisOuMenos = new Button();
            lblOperacao = new Label();
            SuspendLayout();
            // 
            // txtVisor
            // 
            txtVisor.BackColor = SystemColors.Menu;
            txtVisor.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            txtVisor.Location = new Point(12, 60);
            txtVisor.Multiline = true;
            txtVisor.Name = "txtVisor";
            txtVisor.Size = new Size(186, 61);
            txtVisor.TabIndex = 0;
            txtVisor.TextAlign = HorizontalAlignment.Right;
            // 
            // btnPorcento
            // 
            btnPorcento.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnPorcento.Location = new Point(12, 127);
            btnPorcento.Name = "btnPorcento";
            btnPorcento.Size = new Size(43, 44);
            btnPorcento.TabIndex = 1;
            btnPorcento.Text = "%";
            btnPorcento.UseVisualStyleBackColor = false;
            btnPorcento.Click += btnPorcento_Click;
            // 
            // btnCe
            // 
            btnCe.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnCe.Location = new Point(57, 127);
            btnCe.Name = "btnCe";
            btnCe.Size = new Size(43, 44);
            btnCe.TabIndex = 2;
            btnCe.Text = "CE";
            btnCe.UseVisualStyleBackColor = false;
            btnCe.Click += btnCe_Click;
            // 
            // btnC
            // 
            btnC.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnC.Location = new Point(105, 127);
            btnC.Name = "btnC";
            btnC.Size = new Size(43, 44);
            btnC.TabIndex = 3;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = false;
            btnC.Click += btnC_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(155, 127);
            button3.Name = "button3";
            button3.Size = new Size(43, 44);
            button3.TabIndex = 4;
            button3.Text = "←";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(155, 177);
            button4.Name = "button4";
            button4.Size = new Size(43, 44);
            button4.TabIndex = 8;
            button4.Text = "÷";
            button4.UseVisualStyleBackColor = false;
            button4.Click += btnOperacao;
            // 
            // btnRaiz
            // 
            btnRaiz.BackgroundImageLayout = ImageLayout.Stretch;
            btnRaiz.Font = new Font("Segoe MDL2 Assets", 20F, FontStyle.Bold, GraphicsUnit.Point);
            btnRaiz.Location = new Point(105, 177);
            btnRaiz.Name = "btnRaiz";
            btnRaiz.Size = new Size(43, 44);
            btnRaiz.TabIndex = 7;
            btnRaiz.Text = "√";
            btnRaiz.UseVisualStyleBackColor = false;
            btnRaiz.Click += btnRaiz_Click;
            // 
            // btnXquadrado
            // 
            btnXquadrado.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnXquadrado.Location = new Point(57, 177);
            btnXquadrado.Name = "btnXquadrado";
            btnXquadrado.Size = new Size(43, 44);
            btnXquadrado.TabIndex = 6;
            btnXquadrado.Text = "x²";
            btnXquadrado.UseVisualStyleBackColor = false;
            btnXquadrado.Click += btnXquadrado_Click;
            // 
            // btn1x
            // 
            btn1x.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn1x.Location = new Point(12, 177);
            btn1x.Name = "btn1x";
            btn1x.Size = new Size(43, 44);
            btn1x.TabIndex = 5;
            btn1x.Text = "1/x";
            btn1x.UseVisualStyleBackColor = false;
            btn1x.Click += btn1x_Click;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnMultiplicar.Location = new Point(155, 227);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(43, 44);
            btnMultiplicar.TabIndex = 12;
            btnMultiplicar.Text = "X";
            btnMultiplicar.UseVisualStyleBackColor = false;
            btnMultiplicar.Click += btnOperacao;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn9.Location = new Point(105, 227);
            btn9.Name = "btn9";
            btn9.Size = new Size(43, 44);
            btn9.TabIndex = 11;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btnNumero;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn8.Location = new Point(57, 227);
            btn8.Name = "btn8";
            btn8.Size = new Size(43, 44);
            btn8.TabIndex = 10;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btnNumero;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn7.Location = new Point(12, 227);
            btn7.Name = "btn7";
            btn7.Size = new Size(43, 44);
            btn7.TabIndex = 9;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btnNumero;
            // 
            // btnSubtrair
            // 
            btnSubtrair.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubtrair.Location = new Point(155, 277);
            btnSubtrair.Name = "btnSubtrair";
            btnSubtrair.Size = new Size(43, 44);
            btnSubtrair.TabIndex = 16;
            btnSubtrair.Text = "-";
            btnSubtrair.UseVisualStyleBackColor = false;
            btnSubtrair.Click += btnOperacao;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn6.Location = new Point(105, 277);
            btn6.Name = "btn6";
            btn6.Size = new Size(43, 44);
            btn6.TabIndex = 15;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btnNumero;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn5.Location = new Point(57, 277);
            btn5.Name = "btn5";
            btn5.Size = new Size(43, 44);
            btn5.TabIndex = 14;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btnNumero;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn4.Location = new Point(12, 277);
            btn4.Name = "btn4";
            btn4.Size = new Size(43, 44);
            btn4.TabIndex = 13;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btnNumero;
            // 
            // btnSoma
            // 
            btnSoma.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnSoma.Location = new Point(155, 327);
            btnSoma.Name = "btnSoma";
            btnSoma.Size = new Size(43, 44);
            btnSoma.TabIndex = 20;
            btnSoma.Text = "+";
            btnSoma.UseVisualStyleBackColor = false;
            btnSoma.Click += btnOperacao;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn3.Location = new Point(105, 327);
            btn3.Name = "btn3";
            btn3.Size = new Size(43, 44);
            btn3.TabIndex = 19;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btnNumero;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn2.Location = new Point(57, 327);
            btn2.Name = "btn2";
            btn2.Size = new Size(43, 44);
            btn2.TabIndex = 18;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btnNumero;
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn1.Location = new Point(12, 327);
            btn1.Name = "btn1";
            btn1.Size = new Size(43, 44);
            btn1.TabIndex = 17;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btnNumero;
            // 
            // btnIgual
            // 
            btnIgual.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnIgual.Location = new Point(155, 373);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(43, 44);
            btnIgual.TabIndex = 24;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = false;
            btnIgual.Click += btnOperacao;
            // 
            // btnVirgula
            // 
            btnVirgula.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnVirgula.Location = new Point(105, 373);
            btnVirgula.Name = "btnVirgula";
            btnVirgula.Size = new Size(43, 44);
            btnVirgula.TabIndex = 23;
            btnVirgula.Text = ",";
            btnVirgula.UseVisualStyleBackColor = false;
            btnVirgula.Click += btnNumero;
            // 
            // btn0
            // 
            btn0.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn0.Location = new Point(57, 373);
            btn0.Name = "btn0";
            btn0.Size = new Size(43, 44);
            btn0.TabIndex = 22;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += btnNumero;
            // 
            // btnMaisOuMenos
            // 
            btnMaisOuMenos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnMaisOuMenos.Location = new Point(12, 373);
            btnMaisOuMenos.Name = "btnMaisOuMenos";
            btnMaisOuMenos.Size = new Size(43, 44);
            btnMaisOuMenos.TabIndex = 21;
            btnMaisOuMenos.Text = "+/-";
            btnMaisOuMenos.UseVisualStyleBackColor = false;
            btnMaisOuMenos.Click += btnMaisOuMenos_Click;
            // 
            // lblOperacao
            // 
            lblOperacao.AutoSize = true;
            lblOperacao.Location = new Point(16, 26);
            lblOperacao.Name = "lblOperacao";
            lblOperacao.Size = new Size(0, 19);
            lblOperacao.TabIndex = 25;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(212, 432);
            Controls.Add(lblOperacao);
            Controls.Add(btnIgual);
            Controls.Add(btnVirgula);
            Controls.Add(btn0);
            Controls.Add(btnMaisOuMenos);
            Controls.Add(btnSoma);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btnSubtrair);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btnMultiplicar);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(button4);
            Controls.Add(btnRaiz);
            Controls.Add(btnXquadrado);
            Controls.Add(btn1x);
            Controls.Add(button3);
            Controls.Add(btnC);
            Controls.Add(btnCe);
            Controls.Add(btnPorcento);
            Controls.Add(txtVisor);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtVisor;
        private Button btnPorcento;
        private Button btnCe;
        private Button btnC;
        private Button button3;
        private Button button4;
        private Button btnRaiz;
        private Button btnXquadrado;
        private Button btn1x;
        private Button btnMultiplicar;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btnSubtrair;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btnSoma;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btnIgual;
        private Button btnVirgula;
        private Button btn0;
        private Button btnMaisOuMenos;
        private Label lblOperacao;
    }
}