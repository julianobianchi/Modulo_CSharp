using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Culturacalendario
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            txtDifference.Items.Clear();

            TimeSpan difference = dateTimePicker2.Value - dateTimePicker1.Value;
            int ano = dateTimePicker2.Value.Year - dateTimePicker1.Value.Year;



                txtDifference.Items.Add($"A diferença entre as datas");
                txtDifference.Items.Add($"{dateTimePicker1.Value}");
                txtDifference.Items.Add("e");
                txtDifference.Items.Add($"{dateTimePicker2.Value}");
                txtDifference.Items.Add("é de");
                txtDifference.Items.Add($"{ano} anos");
                txtDifference.Items.Add($"{difference.TotalDays:00} dias");
                txtDifference.Items.Add($"{difference.TotalHours:00} horas");
                txtDifference.Items.Add($"{difference.TotalMinutes:00} minutos");
                txtDifference.Items.Add($"{ difference.TotalSeconds:00} segundos");
            
           
            
        }
    }
}

