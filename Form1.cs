using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountStorage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "Close";  //when form loads.. do these properties
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Thanks for clicking."); if button is clicked; message box.

            //closes entire program

            DialogResult dr = MessageBox.Show("Are you sure you want to close?", "Confirm", 
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(dr == DialogResult.Yes)
                this.Close();

           
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // to make something clickable
            // button1.Enabled = checkBox1.Checked;
            // use groupboxes for radio buttons
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string password = textBox1.Text;
            if (password == "password")
            {
                MessageBox.Show("Welcome Back");
                button2.Visible = false;
                label1.Visible = false;
                textBox1.Visible = false;
                button3.Visible = true;
                button5.Visible = true;
                button6.Visible = true;
            }
            else
                MessageBox.Show("Incorrect");
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
