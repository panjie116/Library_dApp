using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Library_dApp
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var login = new logInForm();
            login.ShowDialog();
            login.WindowState = FormWindowState.Minimized;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var newbook = new NewBookForm();
            newbook.ShowDialog();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var listBooks = new ListBooksForm();
            listBooks.Show();
            listBooks.WindowState = FormWindowState.Maximized;
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var newMember = new NewMemberForm();
            newMember.ShowDialog();
            newMember.WindowState = FormWindowState.Minimized;
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var listMembers = new ListMembersForm();
            listMembers.Show();
            listMembers.WindowState = FormWindowState.Maximized;
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var lendbook = new LendForm();
            lendbook.ShowDialog();
            lendbook.WindowState = FormWindowState.Minimized;
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var overdue = new OverdueBooksForm();
            overdue.Show();
            overdue.WindowState = FormWindowState.Maximized;

        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var lentBooks = new ListLentBooksForm();
            lentBooks.Show();
            lentBooks.WindowState = FormWindowState.Maximized;
        }
    }
}
