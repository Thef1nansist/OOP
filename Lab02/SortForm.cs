using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class SortForm : Form
    {
        public SortForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CompanyField_SelectedIndexChanged(object sender, EventArgs e)
        {
            CompanyField.Items.Add("+");
            CompanyField.Items.Add("-");
        }

        private void MemoryField_SelectedIndexChanged(object sender, EventArgs e)
        {
            MemoryField.Items.Add("+");
            MemoryField.Items.Add("-");
        }

        private void sortbtn_Click(object sender, EventArgs e)
        {
            string comp = CompanyField.Text;
            string memory = MemoryField.Text;

            DateTime dateTime = DateField.Value;
            DataTable dataTable = new DataTable();
            DataBase dataBase = new DataBase();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            dataBase.OpenConnection();
           if((comp == "+" && memory == "-") || (comp == "+" && memory == ""))
            {
                MySqlCommand mySqlCommand = new MySqlCommand("SELECT * FROM `computers` ORDER BY `TypeOfComputer`", dataBase.GetConnection());
                adapter.SelectCommand = mySqlCommand;
            }
           else if ((comp == "-" && memory == "+") || (comp == "" && memory == "+"))
            {
                MySqlCommand mySqlCommand = new MySqlCommand("SELECT * FROM `computers` ORDER BY `OZU`", dataBase.GetConnection());
                adapter.SelectCommand = mySqlCommand;
            }
           else if(comp == "+" && memory == "+")
            {
                MySqlCommand mySqlCommand = new MySqlCommand("SELECT * FROM `computers` ORDER BY `TypeOfComputer` AND `OZU` ", dataBase.GetConnection());
                adapter.SelectCommand = mySqlCommand;
            }
            else
            {
                MySqlCommand mySqlCommand = new MySqlCommand("SELECT * FROM `computers` ORDER BY `Date`", dataBase.GetConnection());
                adapter.SelectCommand = mySqlCommand;
            }

            adapter.Fill(dataTable);
            dataBase.CloseConnection();
            dataField.DataSource = dataTable;
        }

        private void searchformlabelone_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DateField_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataField_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
