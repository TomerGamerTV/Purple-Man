using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Purple_Man
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FlatButton4_Click(object sender, EventArgs e)
        {
            Process.Start("https://pastebin.com/raw/LhLJRbdj");
        }

        private void FlatButton3_Click(object sender, EventArgs e)
        {
            if (flatTextBox1.Text == "godlykillzzz")
            {

                MessageBox.Show("Welcome godlykillzzz");
                this.Hide();
                Form3 main = new Form3();
                main.Show();
            }
            else
            {
                MessageBox.Show("Error Key Dont work");
            }
        }
    }
}
