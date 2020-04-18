using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

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
            newbook.MdiParent = this;
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var listBooks = new ListBooksForm();
            listBooks.Show();
            listBooks.MdiParent = this;
            listBooks.WindowState = FormWindowState.Maximized;
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var newMember = new NewMemberForm();
            newMember.ShowDialog();
            newMember.MdiParent = this;
            newMember.WindowState = FormWindowState.Minimized;
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var listMembers = new ListMembersForm();
            listMembers.Show();
            listMembers.MdiParent = this;
            listMembers.WindowState = FormWindowState.Maximized;
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var lendbook = new LendForm2();
            lendbook.ShowDialog();
            lendbook.MdiParent = this;
            lendbook.WindowState = FormWindowState.Minimized;
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var overdue = new OverdueBooksForm();
            overdue.Show();
            overdue.MdiParent = this;
            overdue.WindowState = FormWindowState.Maximized;

        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var lentBooks = new ListLent();
           // var lentBooks = new ListLentBooksForm();              
            lentBooks.Show();
            lentBooks.MdiParent = this;
            lentBooks.WindowState = FormWindowState.Maximized;
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var newUser = new AdduserForm();
            newUser.ShowDialog();
            newUser.MdiParent = this;
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var ListUsers = new ListUsersForm();
            ListUsers.Show();
            ListUsers.MdiParent = this;
            ListUsers.WindowState = FormWindowState.Maximized;

        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("are you sure you want to log out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (var item in this.MdiChildren)
                {
                    item.Close();
                }

                var login = new logInForm();
                var result = login.ShowDialog();
                if (result != DialogResult.OK)
                {
                    Application.Exit();
                }

            }    

            }
        }
}
