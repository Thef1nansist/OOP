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
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
           
        }

        private void Exitbtnsearch_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetEmploidList();
        }

        private DataTable GetEmploidList()
        {
            DataTable dataTable = new DataTable();
            DataBase dataBase = new DataBase();
            dataBase.OpenConnection();
            MySqlCommand mySqlCommand = new MySqlCommand("SELECT * FROM `computers`", dataBase.GetConnection());
            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            dataTable.Load(reader);
            dataBase.CloseConnection();
            return dataTable;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            string company = CompanyField.Text;
            string proc = ProcField.Text;
            string graphadapter = GraphAdapterField.Text;
            string memory = MemoryField.Text;
            DateTime dateTime = DateField.Value;
            DataTable dataTable = new DataTable();
            DataBase dataBase = new DataBase();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            dataBase.OpenConnection();
            if (CompanyField.Text != "" && ProcField.Text != "" && GraphAdapterField.Text != "" && MemoryField.Text != "")
            {
                MySqlCommand mySqlCommand = new MySqlCommand("SELECT * FROM `computers` WHERE `TypeOfComputer` = @Tp AND `Graph` = @Gr AND  `OZU` = @Oz AND `CPU` = @Cp ", dataBase.GetConnection());
                mySqlCommand.Parameters.Add("@Tp", MySqlDbType.VarChar).Value = company;
                mySqlCommand.Parameters.Add("@Gr", MySqlDbType.VarChar).Value = graphadapter;
                mySqlCommand.Parameters.Add("@Oz", MySqlDbType.VarChar).Value = memory;
                mySqlCommand.Parameters.Add("@Cp", MySqlDbType.VarChar).Value = proc;
                adapter.SelectCommand = mySqlCommand;
            }
            else if (CompanyField.Text == "" && ProcField.Text == "" && GraphAdapterField.Text == "" && MemoryField.Text == "")
            {
                MySqlCommand mySqlCommand = new MySqlCommand("SELECT * FROM `computers` WHERE `Date` >= @Dt ", dataBase.GetConnection());
                mySqlCommand.Parameters.Add("@Dt", MySqlDbType.Date).Value = dateTime;
                adapter.SelectCommand = mySqlCommand;
            }
            else
            {
                MySqlCommand mySqlCommand = new MySqlCommand("SELECT * FROM `computers` WHERE `TypeOfComputer` = @Tp  OR `Graph` = @Gr OR `OZU` = @Oz OR `CPU` = @Cp OR `TypeOfComputer` = @Tp ", dataBase.GetConnection());
                mySqlCommand.Parameters.Add("@Tp", MySqlDbType.VarChar).Value = company;
                mySqlCommand.Parameters.Add("@Gr", MySqlDbType.VarChar).Value = graphadapter;
                mySqlCommand.Parameters.Add("@Oz", MySqlDbType.VarChar).Value = memory;
                mySqlCommand.Parameters.Add("@Cp", MySqlDbType.VarChar).Value = proc;
                adapter.SelectCommand = mySqlCommand;
            }
           
            adapter.Fill(dataTable);
            dataBase.CloseConnection();
            dataGridView1.DataSource = dataTable;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
          
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void DateField_ValueChanged(object sender, EventArgs e)
        {

        }

        private void MemoryField_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GraphAdapterField_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CPUCField_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ProcField_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CompanyField_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TypeField_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void searchformlabelone_Click(object sender, EventArgs e)
        {

        }
    }
}
