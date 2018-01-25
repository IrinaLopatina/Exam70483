using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security;

namespace Exam70483_13
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string msg;
            if (String.IsNullOrEmpty(userNameText.Text) || String.IsNullOrEmpty(passwordText.Text))
            {
                msg = "Validation error. Empty fields are not allowed.";
                MessageBox.Show(msg);
                return;
            }

            var auth = new AuthenticationObject(userNameText.Text, passwordText.Text);

            try
            {
                int result = AuthenticationObjectDataAccess.Save(auth);
                msg = result > 0 ? "Data is inserted." : "Error while inserting.";
                MessageBox.Show(msg);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
