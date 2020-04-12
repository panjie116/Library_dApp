using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_dApp
{
    public partial class ListLent : Form
    {
        public ListLent()
        {
            InitializeComponent();

            var db = new LibraryEntities();
            var user = db.Borrowedhistories.ToArray();

            borrowedhistoryBindingSource.DataSource = user;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = borrowedhistoryBindingSource;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
