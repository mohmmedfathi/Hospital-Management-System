using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hospital_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "admin" || textBox1.Text == "Admin" || textBox1.Text == "ADMIN"))
            {
                if ((textBox2.Text == "admin" || textBox2.Text == "Admin" || textBox2.Text == "ADMIN"))
                {
                    MainForm obj = new MainForm();
                    obj.Show();
                }
                else
                {
                    MessageBox.Show("Erorr, Password is Wrong");
                }
            }
            else
            {
                MessageBox.Show("Erorr, User Name is Wrong");
            }
        }
    }
}
