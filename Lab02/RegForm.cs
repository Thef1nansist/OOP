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
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
            username.ForeColor = Color.Gray;
            surename.ForeColor = Color.Gray;
            passwordField.ForeColor = Color.Gray;
            loginF.ForeColor = Color.Gray;
            username.Text = "Введите имя";
            surename.Text = "Введите Фамилию";
            passwordField.Text = "Введите пароль";
            loginF.Text = "Введите логин";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        Point lastpoint;
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.ForeColor = Color.White;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.ForeColor = Color.Red;
        }

        private void username_Enter(object sender, EventArgs e)
        {
            if (username.Text == "Введите имя")
            {
                username.Text = "";
                username.ForeColor = Color.Black;
            }
        }

        private void username_Leave(object sender, EventArgs e)
        {
            if (username.Text == "") { 
                username.Text = "Введите имя";
                username.ForeColor = Color.Gray;
            }
        }

        private void surename_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void surename_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void loginF_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void loginF_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void passwordField_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void passwordField_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void surename_Enter(object sender, EventArgs e)
        {
            if (surename.Text == "Введите Фамилию") { 
                surename.Text = "";
                surename.ForeColor = Color.Black;
            }
        }

        private void surename_Leave(object sender, EventArgs e)
        {
            if (surename.Text == "")
            {
                surename.Text = "Введите Фамилию";
                surename.ForeColor = Color.Gray;
            }
            }

        private void loginF_Enter(object sender, EventArgs e)
        {
            if (loginF.Text == "Введите логин")
            {
                loginF.Text = "";
                loginF.ForeColor = Color.Black;
            }
        }

        private void loginF_Leave(object sender, EventArgs e)
        {
            if (loginF.Text == "")
            {
                loginF.Text = "Введите логин";
                loginF.ForeColor = Color.Gray;
            }
        }

        private void passwordField_Leave(object sender, EventArgs e)
        {
            if (passwordField.Text == "")
            {
                passwordField.Text = "Введите пароль";
                passwordField.ForeColor = Color.Gray;
            }
        }

        private void passwordField_Enter(object sender, EventArgs e)
        {
            if (passwordField.Text == "Введите пароль")
            {
                passwordField.Text = "";
                passwordField.ForeColor = Color.Black ;
            }
        }

        private void buttonreg_Click(object sender, EventArgs e)
        {
            if(username.Text == "Введите имя" )
            {
                MessageBox.Show("Введите имя");
                return;
            }
            else if(surename.Text == "Введите Фамилию")
            {
                MessageBox.Show("Введите Фамилию");
                return;
            }
            else if(loginF.Text == "Введите логин")
            {
                MessageBox.Show("Введите логин");
                return;
            }
            else if(passwordField.Text == "Введите пароль")
            {
                MessageBox.Show("Введите пароль");
                return;
            }
            if (ChekUser())
            {
                return;
            }
            DataBase dataBase = new DataBase();
            MySqlCommand mySqlCommand = new MySqlCommand("INSERT INTO `users` (`login`, `pass`, `name`, `surename`) VALUES (@log, @pas, @name, @sur);", dataBase.GetConnection());
            mySqlCommand.Parameters.Add("@log", MySqlDbType.VarChar).Value = loginF.Text;
            mySqlCommand.Parameters.Add("@pas", MySqlDbType.VarChar).Value = passwordField.Text;
            mySqlCommand.Parameters.Add("@name", MySqlDbType.VarChar).Value = username.Text;
            mySqlCommand.Parameters.Add("@sur", MySqlDbType.VarChar).Value = surename.Text;

            dataBase.OpenConnection();

            if(mySqlCommand.ExecuteNonQuery() == 1)
                MessageBox.Show("Аккаует был создан");
            else
                MessageBox.Show("Аккаует не был создан");


            dataBase.CloseConnection();
        }

        public Boolean ChekUser()
        {
            DataBase dataBase = new DataBase();

            DataTable dataTable = new DataTable();

            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();

            MySqlCommand mySqlCommand = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL", dataBase.GetConnection());

            mySqlCommand.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginF.Text;

            mySqlDataAdapter.SelectCommand = mySqlCommand;
            mySqlDataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                MessageBox.Show("Такой логин уже существует, введите другой");
                return true;

            }
            else
                return false;
        }

        private void reglabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogForm logForm = new LogForm();
            logForm.Show();
        }

        private void loginF_TextChanged(object sender, EventArgs e)
        {

        }

        private void labe1_Click(object sender, EventArgs e)
        {

        }
    }
}
