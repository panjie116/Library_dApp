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
    public partial class NewMemberForm : DevExpress.XtraEditors.XtraForm
    {
        public NewMemberForm()
        {
            InitializeComponent();
            memberBindingSource.DataSource = new Member();
        }

        private void CancelsimpleButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void SavesimpleButton_Click(object sender, EventArgs e)
        {
            var newmember = (Member)memberBindingSource.DataSource;
            var db = new LibraryEntities();

            db.Members.Add(newmember);
            db.SaveChanges();

            DialogResult = DialogResult.OK;
            XtraMessageBox.Show("new member added sucessfully");


        }
    }
}