using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewGenicPos.Views
{
    public partial class FormLogin1 : Form
    {
        public FormLogin1()
        {
            InitializeComponent();
        }
        private void EmptyBox()
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FormLogin1_Load(object sender, EventArgs e)
        {

        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void picHide_Click(object sender, EventArgs e)
        {
            if (picHide.Visible == true)
            {
                txtPassword.UseSystemPasswordChar = true;
                picHide.Visible = false;
                picShow.Visible = true;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void picShow_Click(object sender, EventArgs e)
        {
            if (picShow.Visible == true)
            {
                txtPassword.UseSystemPasswordChar = false;
                picShow.Visible = false;
                picHide.Visible = true;
            }
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter user name", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtPassword.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter Password", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                bool check = Computer.Computer.IsValidNamePass(txtUsername.Text.Trim(), txtPassword.Text.Trim());
                if (check)
                {
                    FormMain formMain = new FormMain();
                    formMain.ShowDialog();
                    EmptyBox();
                }
                else
                {
                    MessageBox.Show("Username or password Incorrect", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            FormForgotPassword formForgotPassword = new FormForgotPassword();
            formForgotPassword.ShowDialog();
        }
    }
}
