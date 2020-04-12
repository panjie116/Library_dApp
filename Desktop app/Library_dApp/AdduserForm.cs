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
    public partial class AdduserForm : DevExpress.XtraEditors.XtraForm
    {
        public AdduserForm()
        {
            InitializeComponent();
            userBindingSource.DataSource = new User();
        }

        private void cancelsimpleButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void SavesimpleButton_Click(object sender, EventArgs e)
        {
            var db = new LibraryEntities();
            var newuser = (User)userBindingSource.DataSource;

            db.Users.Add(newuser);
            db.SaveChanges();

            DialogResult = DialogResult.OK;
            XtraMessageBox.Show("new user added sucessfully");

        }   
    }
}