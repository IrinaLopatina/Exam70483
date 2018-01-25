using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Exam70483_13
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string msg;
            if (String.IsNullOrEmpty(userNameText.Text) || String.IsNullOrEmpty(passwordText.Text))
            {
                msg = "Validation error. Empty fields are not allowed.";
                MessageBox.Show(msg);
                return;
            }

            try
            {
                bool result = AuthenticationObjectDataAccess.VerifyLogin(userNameText.Text, passwordText.Text);
                msg = result ? "Login verified." : "Incorrect user name or password.";
                MessageBox.Show(msg);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
