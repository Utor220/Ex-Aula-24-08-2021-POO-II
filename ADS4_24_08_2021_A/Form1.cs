using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADS4_24_08_2021_A
{
    public partial class Form1 : Form
    {
        //  Pessoa P1 = new Pessoa(); // errado "funciona"
        Pessoa P1; // coreto
        Individuo I1;

        public Form1()
        {
            InitializeComponent();
            P1 = new Pessoa(); // correto
            I1 = new Individuo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //    textBox2.Text = textBox1.Text;

            //Pessoa P1;
            //P1 = new Pessoa();
            //P1 = new Pessoa("Ola Mundo");
            //P1 = new Pessoa(textBox1.Text);

            Pessoa P1 = new Pessoa();

            P1.Nome = textBox1.Text;
            P1.SetCPF(Convert.ToDouble(textBox2.Text));
            P1.RA = Convert.ToInt32(textBox3.Text);

            textBox4.Text = P1.Nome;
            textBox5.Text = Convert.ToString(P1.GetCPF());
            textBox6.Text = Convert.ToString(P1.RA);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //  Pessoa P1 = new Pessoa();
           

            P1.Nome = textBox1.Text;
            P1.SetCPF(Convert.ToDouble(textBox2.Text));
            P1.RA = Convert.ToInt32(textBox3.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
         //   Pessoa P1 = new Pessoa();

            textBox4.Text = P1.Nome;
            textBox5.Text = Convert.ToString(P1.GetCPF());
            textBox6.Text = Convert.ToString(P1.RA);
        }

        //Minha parte que criei, tentei fazer mais ou menos igual para não complicar muito.

        private void button5_Click(object sender, EventArgs e)
        {
            I1.Apelido = textBox7.Text;
            I1.SetIdade(Convert.ToDouble(textBox8.Text));
            I1.Salário = Math.Round(Convert.ToDouble(textBox9.Text), 2);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            textBox10.Text = I1.Apelido;
            textBox11.Text = Convert.ToString(I1.GetIdade());
            textBox12.Text = Convert.ToString(I1.Salário);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            I1.Apelido = textBox7.Text;
            I1.SetIdade(Convert.ToDouble(textBox8.Text));
            I1.Salário = Math.Round(Convert.ToDouble(textBox9.Text),2);

            textBox10.Text = I1.Apelido;
            textBox11.Text = Convert.ToString(I1.GetIdade());
            textBox12.Text = Convert.ToString(I1.Salário);
        }
    }
}
