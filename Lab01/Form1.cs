using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double value1, value2;

            
          
            value1 = Convert.ToDouble(textBox1.Text);
            value2 = Convert.ToDouble(textBox2.Text);

            


            switch (comboBox1.Text)
            {
                case "+":
                    textBox3.Text = ConvertToString(value1 + value2);

                    comboBox2.Items.Add(textBox3.Text);
                    break;
                case "-":
                    textBox3.Text = ConvertToString(value1 - value2);
               
                    break;
                case "*":
                    textBox3.Text = ConvertToString(value1 * value2);
                   
                    break;
                case "/":
                    if (value2 == 0) textBox3.Text = "Ты серьёзно пытаешься делить на ноль?)";
                    else
                    {
                        textBox3.Text = ConvertToString(value1 / value2);
                     
                    }
                        break;
                case "%":
                    if (value2 == 0 || value1 == 0) textBox3.Text = "я так не умею:(";
                    else
                    {
                        textBox3.Text = ConvertToString(value1 % value2);
                    
                    }
                        break;
                case "%/":
                    if (value2 == 0) textBox3.Text = "Ты серьёзно пытаешься делить на ноль?)";
                    else
                    {
                        textBox3.Text = ConvertToString((int)value1 / (int)value2);
             
                    }
                        break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.Text = "";

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
             if (e.KeyChar<=47 || e.KeyChar >=58)
            {
                e.Handled = true;
            }
        }

        public string ConvertToString(double value)
        {
            return Convert.ToString(value);
        }
    }
}
