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
    public partial class FormForgotPassword : Form
    {
        public FormForgotPassword()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter user name", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtEmail.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter Email", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                string pass =Computer.Computer.ForgotPassword(txtUsername.Text.Trim(), txtEmail.Text.Trim());
                if (pass != string.Empty)
                {
                    MessageBox.Show($"Your password is:{pass}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show($"Username or email is incorrect", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }
    }
}
