using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Lab02
{
    [Serializable]
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            textBox1.Text = "Введите дату покупки";
            textBox1.ForeColor = Color.Gray;
        }

        private void labe1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox3_MouseEnter(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Ноутбук")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("Apple");
                comboBox3.Items.Add("Aser");
                comboBox3.Items.Add("Dell");
            }
            if(comboBox1.Text == "Сервер")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("Сервер 1");
                comboBox3.Items.Add("Сервер 2");
                comboBox3.Items.Add("Сервер 3");
            }
            if(comboBox1.Text == "Рабочая станция")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("Рабочая станция 1");
                comboBox3.Items.Add("Рабочая станция 2");
                comboBox3.Items.Add("Рабочая станция 3");
            }
        }

        private void comboBox1_Enter(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Ноутбук");
            comboBox1.Items.Add("Рабочая станция");
            comboBox1.Items.Add("Сервер");

           
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            comboBox3.Text = "";
            GraphAdapterField.Text = "";
            MemoryField.Text = "";
           
        }

        private void ProcField_Enter(object sender, EventArgs e)
        {
            if(comboBox3.Text == "Acer")
            {
                ProcField.Items.Clear();
                ProcField.Items.Add("Intel");
                ProcField.Items.Add("AMD");
                
            }
            if(comboBox3.Text == "Dell")
            {
                ProcField.Items.Clear();
                ProcField.Items.Add("Intel");
                ProcField.Items.Add("AMD");
            }
            if(comboBox3.Text == "Apple")
            {
                ProcField.Items.Clear();
                ProcField.Items.Add("Intel");
                ProcField.Items.Add("AMD");
            }
        }

        private void GraphAdapterField_Enter(object sender, EventArgs e)
        {
            if(comboBox3.Text == "Acer")
            {
                GraphAdapterField.Items.Clear();
                GraphAdapterField.Items.Add("NVIDIA GeForce GTX 1650");
                GraphAdapterField.Items.Add("NVIDIA GeForce GTX 1660");
                GraphAdapterField.Items.Add("NVIDIA GeForce GTX 1500");
            }
            if (comboBox3.Text == "Dell")
            {
                GraphAdapterField.Items.Clear();
                GraphAdapterField.Items.Add("NVIDIA GeForce MX230");
                GraphAdapterField.Items.Add("NVIDIA GeForce MV250");
                GraphAdapterField.Items.Add("NVIDIA GeForce RTX 2060");
            }
            if (comboBox3.Text == "Apple")
            {
                GraphAdapterField.Items.Clear();
                GraphAdapterField.Items.Add("AMD Radeon Pro 5300M");
                GraphAdapterField.Items.Add("AMD Radeon Pro 555X");
                GraphAdapterField.Items.Add("AMD Radeon Pro 5300M");
            }

        }

        private void MemoryField_Enter(object sender, EventArgs e)
        {
            if (comboBox3.Text == "Acer")
            {
                MemoryField.Items.Clear();
                MemoryField.Items.Add("16 ГБ, SSD 256 ГБ");
                MemoryField.Items.Add("8 ГБ, SSD 256 ГБ");
                MemoryField.Items.Add("4 ГБ, SSD 128 ГБ");
            }
            if (comboBox3.Text == "Dell")
            {
                MemoryField.Items.Clear();
                MemoryField.Items.Add("32 ГБ, SSD 256 ГБ");
                MemoryField.Items.Add("16 ГБ, SSD 512 ГБ");
                MemoryField.Items.Add("8 ГБ, SSD 256 ГБ");
            }
            if (comboBox3.Text == "Apple")
            {
                MemoryField.Items.Clear();
                MemoryField.Items.Add("64 ГБ, SSD 256 ГБ");
                MemoryField.Items.Add("32 ГБ, SSD 512 ГБ");
                MemoryField.Items.Add("64 ГБ, SSD 512 ГБ");
            }

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(textBox1.Text == "Введите дату покупки")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void buttonlog_Click(object sender, EventArgs e)
        {
            DateTime dt;
            if (!DateTime.TryParse(textBox1.Text, out dt))
            {
                MessageBox.Show("Введите корректную дату");
                return;
            }

           
            var contact = new XElement("computer", new XAttribute("name", comboBox1.Text), new XElement("company", comboBox3.Text),
               new XElement("CPU", ProcField.Text),
               new XElement("GraphAdapter", GraphAdapterField.Text),
               new XElement("OZU", MemoryField.Text),
               new XElement("Date", textBox1.Text));
            var doc = new XDocument();

            if (File.Exists("Computers.xml"))
            {
                doc = XDocument.Load("Computers.xml");
                doc.Element("computers").Add(contact);
            }
            else
            {
                doc = new XDocument(new XElement("computers", contact));
            }
            doc.Save("Computers.xml");


        }
    }
}
