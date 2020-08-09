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
            closeButton.Text = "Close";  //when form loads.. do these properties
        }

        public static class Globals
        {
            public static readonly String path = @"C:\Users\Junio\source\repos\UIStorage\data.txt";
            public static List<Creds> ListOfCreds = new List<Creds>();

            public static FileStream fileStream = null;
            public static bool fileOpened = false;

            /* Notes
            public const Int32 BUFFER_SIZE = 512; // Unmodifiable
            public static String FILE_NAME = "Output.txt"; // Modifiable
            public static readonly String CODE_PREFIX = "US-"; // Unmodifiable

            in another class calling the global variables:
            String code = Globals.CODE_PREFIX + value.ToString();
            */
        }

        public class Creds
        {
            public string User { get; set; }
            public string Pass { get; set; }
            public string Secondary { get; set; }
        }

        //close button
        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Thanks for clicking."); if button is clicked; message box.

            //closes entire program

            DialogResult dr = MessageBox.Show("Are you sure you want to close?", "Confirm", 
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(dr == DialogResult.Yes)
            {
                if (Globals.fileOpened)
                    Globals.fileStream.Close();

                this.Close();
            }
 
        }

        //password text
        private void label1_Click(object sender, EventArgs e)
        {
            // to make something clickable
            // button1.Enabled = checkBox1.Checked;
            // use groupboxes for radio buttons
        }

        //password entry
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //submit button
        private void button2_Click(object sender, EventArgs e)
        {
            string password = textBox1.Text;
            if (password == "password")
            {
                MessageBox.Show("Welcome Back");
                //master password items
                button2.Visible = false;
                label1.Visible = false;
                textBox1.Visible = false;

                //authentication items
                addButton.Visible = true;
                removeButton.Visible = true;
                txtUser.Visible = true;
                txtPass.Visible = true; ;
                listView1.Visible = true;
                labelUser.Visible = true;
                labelUser.Visible = true;
                
                
                Globals.fileStream = File.Open(Globals.path, File.Exists(Globals.path) ? FileMode.Append : FileMode.OpenOrCreate);
                Globals.fileOpened = true;
            }
            else
                MessageBox.Show("Incorrect");

        }

        //remove button
        private void button6_Click(object sender, EventArgs e)
        {

        }

        //add button
        private void button3_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUser.Text) || string.IsNullOrEmpty(txtPass.Text))
                return;

            
            string[] row = { txtUser.Text, txtPass.Text };
            var listViewItem = new ListViewItem(row);
            listView1.Items.Add(listViewItem);
        }
    }
}
