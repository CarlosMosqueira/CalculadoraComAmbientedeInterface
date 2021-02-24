using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Ambiente_Visual
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        int operacao = 1;

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            operacao = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            operacao = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            operacao = 3;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            operacao = 4;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double numero1;
            double numero2;
            double resultado;

            numero1 = Double.Parse(textBox1.Text);
            numero2 = Double.Parse(textBox2.Text);

            if(operacao == 1)
            {
                resultado = numero1 + numero2;
                textBox3.Text = resultado.ToString();
            }

            if (operacao == 2)
            {
                resultado = numero1 - numero2;
                textBox3.Text = resultado.ToString();
            }

            if (operacao == 3)
            {
                resultado = numero1 * numero2;
                textBox3.Text = resultado.ToString();
            }

            if (operacao == 4 && numero2 != 0)
            {
                resultado = numero1 / numero2;
                textBox3.Text = resultado.ToString();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
        }
    }
}
