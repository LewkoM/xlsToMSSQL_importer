using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImporterApp
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            //if(LoginTextBox.Text == "admin" && PasswordTextBox.Text == "admin")
            //{
                new Form2().Show(); 
                this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("Login lub hasło jest nieprawidłowe, spróbuj ponownie!");
            //    LoginTextBox.Clear();
            //    PasswordTextBox.Clear();
            //}
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (PasswordTextBox.Text == "Wprowadź hasło")
                {
                    PasswordTextBox.PasswordChar = '\0';
                    PasswordTextBox.ForeColor = Color.Gray;
                }
                else
                { 
                    PasswordTextBox.PasswordChar = '*';
                    PasswordTextBox.ForeColor = Color.Black; 
                }
                
            }
            catch
            {

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (LoginTextBox.Text == "Wprowadź login")
                {
                    LoginTextBox.ForeColor = Color.Gray;
                }
                else
                {
                    LoginTextBox.ForeColor = Color.Black;
                }
            }
            catch
            {

            }
             
            
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void LoginTextBox_Click(object sender, EventArgs e)
        {
            LoginTextBox.Clear();
        }

        private void PasswordTextBox_Click(object sender, EventArgs e)
        {
            PasswordTextBox.Clear();
        }

        private void LogButton_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void LogButton_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void PasswordTextBox_Leave(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text == "")
            {
                PasswordTextBox.Text = "Wprowadź hasło";
            }
        }

        private void LoginTextBox_Leave(object sender, EventArgs e)
        {
            if (LoginTextBox.Text == "")
            {
                LoginTextBox.Text = "Wprowadź login";
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
