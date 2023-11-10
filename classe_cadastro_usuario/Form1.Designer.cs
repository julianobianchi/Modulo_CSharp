namespace classe_cadastro_usuario
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
            groupBox1 = new GroupBox();
            txbEndereco = new TextBox();
            txbMatricula = new TextBox();
            txbNome = new TextBox();
            dtpDataNasc = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnCadastrar = new Button();
            groupBox2 = new GroupBox();
            btnCadastrarAluno = new Button();
            txbNota2 = new TextBox();
            txbNota1 = new TextBox();
            txbTurma = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            groupBox3 = new GroupBox();
            btnCadastrarProfessor = new Button();
            txbCargaHoraria = new TextBox();
            label9 = new Label();
            groupBox4 = new GroupBox();
            txbTipoProfessor = new ComboBox();
            btnCadastrarTipoProfessor = new Button();
            label8 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txbEndereco);
            groupBox1.Controls.Add(txbMatricula);
            groupBox1.Controls.Add(txbNome);
            groupBox1.Controls.Add(dtpDataNasc);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(782, 192);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Usuário";
            // 
            // txbEndereco
            // 
            txbEndereco.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txbEndereco.Location = new Point(161, 138);
            txbEndereco.Name = "txbEndereco";
            txbEndereco.Size = new Size(570, 29);
            txbEndereco.TabIndex = 7;
            // 
            // txbMatricula
            // 
            txbMatricula.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txbMatricula.Location = new Point(161, 65);
            txbMatricula.Name = "txbMatricula";
            txbMatricula.Size = new Size(195, 29);
            txbMatricula.TabIndex = 6;
            // 
            // txbNome
            // 
            txbNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txbNome.Location = new Point(161, 28);
            txbNome.Name = "txbNome";
            txbNome.Size = new Size(570, 29);
            txbNome.TabIndex = 5;
            // 
            // dtpDataNasc
            // 
            dtpDataNasc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpDataNasc.Location = new Point(161, 103);
            dtpDataNasc.Name = "dtpDataNasc";
            dtpDataNasc.Size = new Size(369, 29);
            dtpDataNasc.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(6, 146);
            label4.Name = "label4";
            label4.Size = new Size(85, 21);
            label4.TabIndex = 3;
            label4.Text = "Endereço:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(6, 109);
            label3.Name = "label3";
            label3.Size = new Size(146, 21);
            label3.TabIndex = 2;
            label3.Text = "Data Nascimento:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(6, 73);
            label2.Name = "label2";
            label2.Size = new Size(87, 21);
            label2.TabIndex = 1;
            label2.Text = "Matrícula:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(6, 31);
            label1.Name = "label1";
            label1.Size = new Size(61, 21);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = SystemColors.Menu;
            btnCadastrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCadastrar.Location = new Point(222, 210);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(108, 36);
            btnCadastrar.TabIndex = 1;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnCadastrarAluno);
            groupBox2.Controls.Add(txbNota2);
            groupBox2.Controls.Add(txbNota1);
            groupBox2.Controls.Add(txbTurma);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(12, 260);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(241, 187);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Aluno";
            // 
            // btnCadastrarAluno
            // 
            btnCadastrarAluno.BackColor = SystemColors.Menu;
            btnCadastrarAluno.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCadastrarAluno.Location = new Point(76, 145);
            btnCadastrarAluno.Name = "btnCadastrarAluno";
            btnCadastrarAluno.Size = new Size(108, 36);
            btnCadastrarAluno.TabIndex = 3;
            btnCadastrarAluno.Text = "Cadastrar";
            btnCadastrarAluno.UseVisualStyleBackColor = false;
            btnCadastrarAluno.Click += btnCadastrarAluno_Click;
            // 
            // txbNota2
            // 
            txbNota2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txbNota2.Location = new Point(76, 108);
            txbNota2.Name = "txbNota2";
            txbNota2.Size = new Size(142, 29);
            txbNota2.TabIndex = 10;
            // 
            // txbNota1
            // 
            txbNota1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txbNota1.Location = new Point(76, 73);
            txbNota1.Name = "txbNota1";
            txbNota1.Size = new Size(142, 29);
            txbNota1.TabIndex = 9;
            // 
            // txbTurma
            // 
            txbTurma.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txbTurma.Location = new Point(76, 36);
            txbTurma.Name = "txbTurma";
            txbTurma.Size = new Size(142, 29);
            txbTurma.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(8, 116);
            label7.Name = "label7";
            label7.Size = new Size(65, 21);
            label7.TabIndex = 6;
            label7.Text = "Nota 2:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(8, 81);
            label6.Name = "label6";
            label6.Size = new Size(65, 21);
            label6.TabIndex = 5;
            label6.Text = "Nota 1:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(8, 44);
            label5.Name = "label5";
            label5.Size = new Size(62, 21);
            label5.TabIndex = 4;
            label5.Text = "Turma:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnCadastrarProfessor);
            groupBox3.Controls.Add(txbCargaHoraria);
            groupBox3.Controls.Add(label9);
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.Location = new Point(278, 260);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(241, 187);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            groupBox3.Text = "Professor";
            // 
            // btnCadastrarProfessor
            // 
            btnCadastrarProfessor.BackColor = SystemColors.Menu;
            btnCadastrarProfessor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCadastrarProfessor.Location = new Point(76, 145);
            btnCadastrarProfessor.Name = "btnCadastrarProfessor";
            btnCadastrarProfessor.Size = new Size(108, 36);
            btnCadastrarProfessor.TabIndex = 3;
            btnCadastrarProfessor.Text = "Cadastrar";
            btnCadastrarProfessor.UseVisualStyleBackColor = false;
            btnCadastrarProfessor.Click += btnCadastrarProfessor_Click;
            // 
            // txbCargaHoraria
            // 
            txbCargaHoraria.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txbCargaHoraria.Location = new Point(126, 73);
            txbCargaHoraria.Name = "txbCargaHoraria";
            txbCargaHoraria.Size = new Size(109, 29);
            txbCargaHoraria.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(8, 81);
            label9.Name = "label9";
            label9.Size = new Size(119, 21);
            label9.TabIndex = 5;
            label9.Text = "Carga Horária:";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txbTipoProfessor);
            groupBox4.Controls.Add(btnCadastrarTipoProfessor);
            groupBox4.Controls.Add(label8);
            groupBox4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox4.Location = new Point(559, 260);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(241, 187);
            groupBox4.TabIndex = 12;
            groupBox4.TabStop = false;
            groupBox4.Text = "Tipo de Professor";
            // 
            // txbTipoProfessor
            // 
            txbTipoProfessor.FormattingEnabled = true;
            txbTipoProfessor.Items.AddRange(new object[] { "Temporário", "Efetivo", "Estagiario" });
            txbTipoProfessor.Location = new Point(6, 73);
            txbTipoProfessor.Name = "txbTipoProfessor";
            txbTipoProfessor.Size = new Size(229, 29);
            txbTipoProfessor.TabIndex = 6;
            // 
            // btnCadastrarTipoProfessor
            // 
            btnCadastrarTipoProfessor.BackColor = SystemColors.Menu;
            btnCadastrarTipoProfessor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCadastrarTipoProfessor.Location = new Point(76, 145);
            btnCadastrarTipoProfessor.Name = "btnCadastrarTipoProfessor";
            btnCadastrarTipoProfessor.Size = new Size(108, 36);
            btnCadastrarTipoProfessor.TabIndex = 3;
            btnCadastrarTipoProfessor.Text = "Cadastrar";
            btnCadastrarTipoProfessor.UseVisualStyleBackColor = false;
            btnCadastrarTipoProfessor.Click += btnCadastrarTipoProfessor_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(6, 44);
            label8.Name = "label8";
            label8.Size = new Size(147, 21);
            label8.TabIndex = 5;
            label8.Text = "Tipo de Professor:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(812, 457);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(btnCadastrar);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro Usuário";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txbEndereco;
        private TextBox txbMatricula;
        private TextBox txbNome;
        private DateTimePicker dtpDataNasc;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnCadastrar;
        private GroupBox groupBox2;
        private Button btnCadastrarAluno;
        private TextBox txbNota2;
        private TextBox txbNota1;
        private TextBox txbTurma;
        private Label label7;
        private Label label6;
        private Label label5;
        private GroupBox groupBox3;
        private Button btnCadastrarProfessor;
        private TextBox txbCargaHoraria;
        private Label label9;
        private GroupBox groupBox4;
        private ComboBox txbTipoProfessor;
        private Button btnCadastrarTipoProfessor;
        private Label label8;
    }
}