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
    public partial class FrmRegisterForm : Form
    {
        private Form opener;
        public FrmRegisterForm(Form ParentForm)
        {
            InitializeComponent();
            opener = ParentForm;
        }
       

        static Form frm = new Form1();
        private void chbxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxShowPassword.Checked)
            {
                txtbxPassowrd.UseSystemPasswordChar = false;
                txtConfirmPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtbxPassowrd.UseSystemPasswordChar = true;
                txtConfirmPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtbxUserName.Text == "" || txtbxPassowrd.Text == ""||txtConfirmPassword.Text=="")
            {
                MessageBox.Show("Wrong username or password", "Register Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (txtConfirmPassword.Text==txtbxPassowrd.Text&&txtbxUserName.Text!="")
            {
                MessageBox.Show("Account Sign up successfully","Registeration Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                
                this.Close(); 
                

            }
            else
            {
                MessageBox.Show("Passwords Does not match, please re-enter","Pssword faild",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtConfirmPassword.Clear();
                txtbxPassowrd.Clear();
                return;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtConfirmPassword.Clear();
            txtbxPassowrd.Clear();
            txtbxUserName.Clear();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            frm.Show();
            this.Close();
        }

        private void closeScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
