using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Cronometro
{
    public partial class Form1 : Form
    {
        private Stopwatch stopwatch;
        private int totalDeSegundos;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            stopwatch = new Stopwatch(); // Inicia Classe Stopwatch para cronometro.

            this.button2.Enabled = false;
            this.button3.Enabled = false;
            this.button5.Enabled = false;
            this.label1.Visible = false;
            this.label6.Visible = false;

            for (int i = 0; i <= 59; i++) // Add minutos e segundos nos comboBox 
            {
                this.comboBox1.Items.Add(i.ToString());
                this.comboBox2.Items.Add(i.ToString());
            }
            this.comboBox1.SelectedIndex = 00; //Add valores iniciais e habilita radio buton
            this.comboBox2.SelectedIndex = 59;
            this.radioButton2.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            stopwatch.Start(); //Inicia cronometro
            this.label6.Visible = false;
            this.label1.Visible = true;
            this.button1.Enabled = false;
            this.button2.Enabled = true;
            this.button3.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            stopwatch.Stop(); //Pausa cronometro
            this.button1.Enabled = true;
            this.button2.Enabled = false;
            this.button3.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            stopwatch.Reset(); //Reinicia cronometro
            this.button1.Enabled = true;
            this.button2.Enabled = false;
            this.button3.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label1.Text = string.Format("{0:hh\\:mm\\:ss\\:fff}", stopwatch.Elapsed);//Label do Timer
        }

        private void button4_Click(object sender, EventArgs e) //botão iniciar temporizador
        {
            this.label1.Visible = false;
            this.label6.Visible = true;
            this.button4.Enabled = false;
            this.button5.Enabled = true;

            int minutos = int.Parse(comboBox1.SelectedItem.ToString());
            int segundos = int.Parse(comboBox2.SelectedItem.ToString()); 
            

            totalDeSegundos = (minutos * 60) + segundos;
            timer2.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e) //Botão Parar
        {

            this.button4.Enabled = true;
            this.button5.Enabled = false;
            timer2.Enabled = false;
        }

        private void timer2_Tick(object sender, EventArgs e) //Evento para Temporizador
        {
           

                if (radioButton1.Checked)
                {
                    if (totalDeSegundos > 0)
                    {

                        int minutos = (totalDeSegundos / 60);
                        int segundos = totalDeSegundos - (minutos * 60);
                        this.label6.Text = minutos.ToString() + ":" + segundos.ToString();

                        totalDeSegundos--;
                    }
                    else
                    {
                        this.timer2.Enabled = false;
                        MessageBox.Show("Contatos acabou!");

                    }
                }
                if (radioButton2.Checked)
                {
                    if (totalDeSegundos > 0)
                    {

                        int minutos = (totalDeSegundos / 60);
                        int segundos = totalDeSegundos - (minutos * 60);
                        this.label6.Text = minutos.ToString() + ":" + segundos.ToString();

                        totalDeSegundos--;
                    }
                    else
                    {
                        this.timer2.Enabled = false;
                        MessageBox.Show("Contatos acabou!");

                    }

                }
                 

        }
    }
}
