using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
              "You want to ESC",
              "confirm",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Question
              );
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           string name = txtname.Text;
           string pass = txtpass.Text;
            string confirm = txtcf.Text;

           if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter name", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtname.Focus();
            }
            if (string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Please enter password", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtpass.Focus();
            }
            if (string.IsNullOrEmpty(confirm))
            {
                MessageBox.Show("please enter confirm", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtcf.Focus();
            }
           else if (txtpass.Text == txtcf.Text)
            {
                Form1 from1 = new Form1();
                from1.Show();
                this.Hide();
            }
            else 
            {
                MessageBox.Show("register un succers", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtpass.Text = ""; txtpass.Focus();
                txtcf.Text = ""; txtpass.Focus();
            }
        }

        private void txtcf_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
