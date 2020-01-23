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
    public partial class NewBookForm : DevExpress.XtraEditors.XtraForm
    {
        public NewBookForm()
        {
            InitializeComponent();
            bookBindingSource.DataSource = new Book();
        }

        private void CancelsimpleButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void SavesimpleButton_Click(object sender, EventArgs e)
        {
            var newbook = (Book)bookBindingSource.DataSource;
            var db = new LibraryEntities();

            db.Books.Add(newbook);
            db.SaveChanges();

            XtraMessageBox.Show("book added sucessfully");
            DialogResult = DialogResult.OK;

        }
    }
}