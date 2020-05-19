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
    public partial class lendForm : DevExpress.XtraEditors.XtraForm
    {
        public lendForm()
        {
            InitializeComponent();
            borrowedhistoryBindingSource.DataSource = new Borrowedhistory();
        }

        private void CancelsimpleButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void SavesimpleButton_Click(object sender, EventArgs e)
        {
            var lend = (Borrowedhistory)borrowedhistoryBindingSource.DataSource;
            var db = new LibraryEntities();

            db.Borrowedhistories.Add(lend);
            db.SaveChanges();

            XtraMessageBox.Show("lent");
            DialogResult = DialogResult.OK;


        }
    }
}