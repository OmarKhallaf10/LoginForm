using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       

     

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            txtbxUserName.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtbxPassowrd.Clear();
            txtbxUserName.Clear();
        }

        private void chbxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(chbxShowPassword.Checked)
            txtbxPassowrd.UseSystemPasswordChar = false;
            else
                txtbxPassowrd.UseSystemPasswordChar = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wait");
        }
    }
}
