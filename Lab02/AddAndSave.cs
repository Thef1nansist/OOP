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
    public partial class AddAndSave : Form
    {
        public AddAndSave()
        {
            InitializeComponent();
        }

        private void sortbtn_Click(object sender, EventArgs e)
        {
            LogForm logForm = new LogForm();
            DataBase dataBase = new DataBase();
            dataBase.OpenConnection();
            string login = GetLog.val;
            MySqlCommand connection = new MySqlCommand("INSERT INTO `computers` (`Type`, `TypeOfComputer`, `CPU`, `Graph`, `OZU`, `Date`, `User`) VALUES (@Ty,@TC, @CP, @Gr, @OZ, @Dt,  @Us);", dataBase.GetConnection());
            connection.Parameters.Add("@Ty", MySqlDbType.VarChar).Value = comboBox1.Text;
            connection.Parameters.Add("@CP", MySqlDbType.VarChar).Value = ProcField.Text;
            connection.Parameters.Add("@Gr", MySqlDbType.VarChar).Value = GraphAdapterField.Text;
            connection.Parameters.Add("@OZ", MySqlDbType.VarChar).Value = MemoryField.Text;
            connection.Parameters.Add("@Dt", MySqlDbType.Date).Value = DateField.Value;
            connection.Parameters.Add("@TC", MySqlDbType.VarChar).Value = comboBox3.Text;
            connection.Parameters.Add("@Us", MySqlDbType.VarChar).Value = login;

            

            if (connection.ExecuteNonQuery() == 1)
                MessageBox.Show("Запись была добавлена в базу");
            else
                MessageBox.Show("Запись не была добавлена в базу");


            dataBase.CloseConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
