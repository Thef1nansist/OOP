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
    public partial class PersonForm : Form
    {
        public PersonForm()
        {
            InitializeComponent();
        }

        private void PersonForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            string autor = GetLog.val;
            TimeField.Text = DateTime.Now.ToString("HH:mm:ss");
            personField.Text = autor;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeField.Text = DateTime.Now.ToString("HH:mm:ss");
            timer1.Start();
        }
    }
}
