using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Library_dApp
{
    public partial class logInForm : DevExpress.XtraEditors.XtraForm
    {
        public logInForm()
        {
            InitializeComponent();
        }

        private void CancelsimpleButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SavesimpleButton_Click(object sender, EventArgs e)
        {
            var db = new LibraryEntities();

            if (UsernametextBox.Text != string.Empty && PasswordtextBox.Text != string.Empty)
            {
                var userExist = db.Users.SingleOrDefault(a => a.Username.Equals(UsernametextBox.Text));
                if(userExist != null)
                {
                    if (userExist.Password.Equals(PasswordtextBox.Text))
                    {
                        XtraMessageBox.Show("Welcome: " + userExist.Username, "logged in", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        XtraMessageBox.Show("wrong password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    XtraMessageBox.Show("user not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                   

            }

            else
            {
                XtraMessageBox.Show("insert fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}