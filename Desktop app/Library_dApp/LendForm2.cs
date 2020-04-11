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
    public partial class LendForm2 : DevExpress.XtraEditors.XtraForm
    {
        public LendForm2()
        {
            InitializeComponent();
            borrowedhistoryBindingSource.DataSource = new Borrowedhistory();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var lendbook = (Borrowedhistory)borrowedhistoryBindingSource.DataSource;

            var db = new LibraryEntities();

            db.Borrowedhistories.Add(lendbook);
            db.SaveChanges();

            DialogResult = DialogResult.OK;
            XtraMessageBox.Show("book lent sucessfully");
        }
    }
}