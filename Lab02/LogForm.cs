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
using System.ComponentModel.Design;


namespace Lab02
{
    public static class GetLog
    {
        public static string val;

        public static string Loggeter(string log)
        {
            val = log;

            return log;
        }
    }
    
    public partial class LogForm : Form
    {
        
        public LogForm()
        {
            InitializeComponent();
            this.PassField.AutoSize = false;
            this.PassField.Size = new Size(this.PassField.Size.Width, 49);
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.ForeColor = Color.Red;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.ForeColor = Color.White;
        }

        Point lastpoint;
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void buttonlog_Click(object sender, EventArgs e)
        {
            //[Required]
            String loginUser = LoginField.Text;
            String passUser = PassField.Text;
            DataBase dataBase = new DataBase();
            dataBase.OpenConnection();

            

            DataTable dataTable = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand mySqlCommand = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `pass` = @uP ", dataBase.GetConnection());
            mySqlCommand.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            mySqlCommand.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;
            adapter.SelectCommand = mySqlCommand;
            adapter.Fill(dataTable);
            dataBase.CloseConnection();

            if (dataTable.Rows.Count > 0)
            {
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.Show();
                GetLog.Loggeter(loginUser);
            }

            else
                MessageBox.Show("not");

        }

        private void reglabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegForm regForm = new RegForm();
            regForm.Show();
        }
       
    }
}
