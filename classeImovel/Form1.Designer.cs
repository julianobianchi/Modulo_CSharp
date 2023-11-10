namespace classeImovel
{
    partial class Form0
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
            bntImovel = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // bntImovel
            // 
            bntImovel.BackColor = SystemColors.Menu;
            bntImovel.BackgroundImageLayout = ImageLayout.Stretch;
            bntImovel.Location = new Point(298, 169);
            bntImovel.Name = "bntImovel";
            bntImovel.Size = new Size(180, 74);
            bntImovel.TabIndex = 46;
            bntImovel.Text = "IMÓVEL";
            bntImovel.UseVisualStyleBackColor = false;
            bntImovel.Click += bntImovel_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.Menu;
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.Location = new Point(644, 12);
            button4.Name = "button4";
            button4.Size = new Size(90, 32);
            button4.TabIndex = 50;
            button4.Text = "SAIR";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Form0
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SandyBrown;
            ClientSize = new Size(746, 460);
            Controls.Add(button4);
            Controls.Add(bntImovel);
            Name = "Form0";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button bntImovel;
        private Button button4;
    }
}