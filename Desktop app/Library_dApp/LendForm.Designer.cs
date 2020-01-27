namespace Library_dApp
{
    partial class LendForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.MemberNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.MemberIdTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.BookISBNTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.BookTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForMemberName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForMemberId = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForBookISBN = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForStatus = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForMember = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForUser = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForBook = new DevExpress.XtraLayout.LayoutControlItem();
            this.SaveButton = new DevExpress.XtraEditors.SimpleButton();
            this.CancelButton = new DevExpress.XtraEditors.SimpleButton();
            this.DueDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.ItemForDueDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.MemberTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.UserTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForUsername = new DevExpress.XtraLayout.LayoutControlItem();
            this.StatusTextEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.UsernameTextEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.borrowedhistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MemberNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemberIdTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookISBNTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMemberName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMemberId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBookISBN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMember)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DueDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DueDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDueDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemberTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsernameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowedhistoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.MemberNameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.MemberIdTextEdit);
            this.dataLayoutControl1.Controls.Add(this.BookISBNTextEdit);
            this.dataLayoutControl1.Controls.Add(this.DueDateDateEdit);
            this.dataLayoutControl1.Controls.Add(this.BookTextEdit);
            this.dataLayoutControl1.Controls.Add(this.MemberTextEdit);
            this.dataLayoutControl1.Controls.Add(this.UserTextEdit);
            this.dataLayoutControl1.Controls.Add(this.StatusTextEdit);
            this.dataLayoutControl1.Controls.Add(this.UsernameTextEdit);
            this.dataLayoutControl1.DataSource = this.borrowedhistoryBindingSource;
            this.dataLayoutControl1.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForBook,
            this.ItemForMember,
            this.ItemForUser});
            this.dataLayoutControl1.Location = new System.Drawing.Point(-3, 25);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(639, 153, 250, 350);
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(568, 326);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // MemberNameTextEdit
            // 
            this.MemberNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.borrowedhistoryBindingSource, "MemberName", true));
            this.MemberNameTextEdit.Location = new System.Drawing.Point(83, 12);
            this.MemberNameTextEdit.Name = "MemberNameTextEdit";
            this.MemberNameTextEdit.Size = new System.Drawing.Size(473, 20);
            this.MemberNameTextEdit.StyleController = this.dataLayoutControl1;
            this.MemberNameTextEdit.TabIndex = 4;
            // 
            // MemberIdTextEdit
            // 
            this.MemberIdTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.borrowedhistoryBindingSource, "MemberId", true));
            this.MemberIdTextEdit.Location = new System.Drawing.Point(83, 36);
            this.MemberIdTextEdit.Name = "MemberIdTextEdit";
            this.MemberIdTextEdit.Size = new System.Drawing.Size(473, 20);
            this.MemberIdTextEdit.StyleController = this.dataLayoutControl1;
            this.MemberIdTextEdit.TabIndex = 5;
            // 
            // BookISBNTextEdit
            // 
            this.BookISBNTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.borrowedhistoryBindingSource, "BookISBN", true));
            this.BookISBNTextEdit.Location = new System.Drawing.Point(83, 60);
            this.BookISBNTextEdit.Name = "BookISBNTextEdit";
            this.BookISBNTextEdit.Size = new System.Drawing.Size(473, 20);
            this.BookISBNTextEdit.StyleController = this.dataLayoutControl1;
            this.BookISBNTextEdit.TabIndex = 6;
            // 
            // BookTextEdit
            // 
            this.BookTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.borrowedhistoryBindingSource, "Book", true));
            this.BookTextEdit.Location = new System.Drawing.Point(83, 84);
            this.BookTextEdit.Name = "BookTextEdit";
            this.BookTextEdit.Size = new System.Drawing.Size(473, 20);
            this.BookTextEdit.StyleController = this.dataLayoutControl1;
            this.BookTextEdit.TabIndex = 10;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(568, 326);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForMemberName,
            this.ItemForMemberId,
            this.ItemForBookISBN,
            this.ItemForDueDate,
            this.ItemForStatus,
            this.ItemForUsername});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(548, 306);
            // 
            // ItemForMemberName
            // 
            this.ItemForMemberName.Control = this.MemberNameTextEdit;
            this.ItemForMemberName.Location = new System.Drawing.Point(0, 0);
            this.ItemForMemberName.Name = "ItemForMemberName";
            this.ItemForMemberName.Size = new System.Drawing.Size(548, 24);
            this.ItemForMemberName.Text = "Member Name";
            this.ItemForMemberName.TextSize = new System.Drawing.Size(68, 13);
            // 
            // ItemForMemberId
            // 
            this.ItemForMemberId.Control = this.MemberIdTextEdit;
            this.ItemForMemberId.Location = new System.Drawing.Point(0, 24);
            this.ItemForMemberId.Name = "ItemForMemberId";
            this.ItemForMemberId.Size = new System.Drawing.Size(548, 24);
            this.ItemForMemberId.Text = "Member Id";
            this.ItemForMemberId.TextSize = new System.Drawing.Size(68, 13);
            // 
            // ItemForBookISBN
            // 
            this.ItemForBookISBN.Control = this.BookISBNTextEdit;
            this.ItemForBookISBN.Location = new System.Drawing.Point(0, 48);
            this.ItemForBookISBN.Name = "ItemForBookISBN";
            this.ItemForBookISBN.Size = new System.Drawing.Size(548, 24);
            this.ItemForBookISBN.Text = "Book ISBN";
            this.ItemForBookISBN.TextSize = new System.Drawing.Size(68, 13);
            // 
            // ItemForStatus
            // 
            this.ItemForStatus.Control = this.StatusTextEdit;
            this.ItemForStatus.Location = new System.Drawing.Point(0, 96);
            this.ItemForStatus.Name = "ItemForStatus";
            this.ItemForStatus.Size = new System.Drawing.Size(548, 24);
            this.ItemForStatus.Text = "Status";
            this.ItemForStatus.TextSize = new System.Drawing.Size(68, 13);
            // 
            // ItemForMember
            // 
            this.ItemForMember.Control = this.MemberTextEdit;
            this.ItemForMember.Location = new System.Drawing.Point(0, 168);
            this.ItemForMember.Name = "ItemForMember";
            this.ItemForMember.Size = new System.Drawing.Size(548, 24);
            this.ItemForMember.Text = "Member";
            this.ItemForMember.TextSize = new System.Drawing.Size(68, 13);
            // 
            // ItemForUser
            // 
            this.ItemForUser.Control = this.UserTextEdit;
            this.ItemForUser.Location = new System.Drawing.Point(0, 168);
            this.ItemForUser.Name = "ItemForUser";
            this.ItemForUser.Size = new System.Drawing.Size(548, 124);
            this.ItemForUser.Text = "User";
            this.ItemForUser.TextSize = new System.Drawing.Size(68, 13);
            // 
            // ItemForBook
            // 
            this.ItemForBook.Control = this.BookTextEdit;
            this.ItemForBook.Location = new System.Drawing.Point(0, 72);
            this.ItemForBook.Name = "ItemForBook";
            this.ItemForBook.Size = new System.Drawing.Size(548, 24);
            this.ItemForBook.Text = "Book Name";
            this.ItemForBook.TextSize = new System.Drawing.Size(68, 13);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(228, 362);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 37);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "Lend Book";
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(366, 362);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 37);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // DueDateDateEdit
            // 
            this.DueDateDateEdit.EditValue = null;
            this.DueDateDateEdit.Location = new System.Drawing.Point(83, 84);
            this.DueDateDateEdit.Name = "DueDateDateEdit";
            this.DueDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DueDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DueDateDateEdit.Size = new System.Drawing.Size(473, 20);
            this.DueDateDateEdit.StyleController = this.dataLayoutControl1;
            this.DueDateDateEdit.TabIndex = 8;
            // 
            // ItemForDueDate
            // 
            this.ItemForDueDate.Control = this.DueDateDateEdit;
            this.ItemForDueDate.Location = new System.Drawing.Point(0, 72);
            this.ItemForDueDate.Name = "ItemForDueDate";
            this.ItemForDueDate.Size = new System.Drawing.Size(548, 24);
            this.ItemForDueDate.Text = "Due Date";
            this.ItemForDueDate.TextSize = new System.Drawing.Size(68, 13);
            // 
            // MemberTextEdit
            // 
            this.MemberTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.borrowedhistoryBindingSource, "Member", true));
            this.MemberTextEdit.Location = new System.Drawing.Point(83, 180);
            this.MemberTextEdit.Name = "MemberTextEdit";
            this.MemberTextEdit.Size = new System.Drawing.Size(473, 20);
            this.MemberTextEdit.StyleController = this.dataLayoutControl1;
            this.MemberTextEdit.TabIndex = 11;
            // 
            // UserTextEdit
            // 
            this.UserTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.borrowedhistoryBindingSource, "User", true));
            this.UserTextEdit.Location = new System.Drawing.Point(83, 204);
            this.UserTextEdit.Name = "UserTextEdit";
            this.UserTextEdit.Size = new System.Drawing.Size(473, 20);
            this.UserTextEdit.StyleController = this.dataLayoutControl1;
            this.UserTextEdit.TabIndex = 12;
            // 
            // ItemForUsername
            // 
            this.ItemForUsername.Control = this.UsernameTextEdit;
            this.ItemForUsername.Location = new System.Drawing.Point(0, 120);
            this.ItemForUsername.Name = "ItemForUsername";
            this.ItemForUsername.Size = new System.Drawing.Size(548, 186);
            this.ItemForUsername.Text = "Username";
            this.ItemForUsername.TextSize = new System.Drawing.Size(68, 13);
            // 
            // StatusTextEdit
            // 
            this.StatusTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.borrowedhistoryBindingSource, "Status", true));
            this.StatusTextEdit.EditValue = "";
            this.StatusTextEdit.Location = new System.Drawing.Point(83, 108);
            this.StatusTextEdit.Name = "StatusTextEdit";
            this.StatusTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.StatusTextEdit.Properties.Items.AddRange(new object[] {
            "Borrowed",
            "Returned"});
            this.StatusTextEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.StatusTextEdit.Size = new System.Drawing.Size(473, 20);
            this.StatusTextEdit.StyleController = this.dataLayoutControl1;
            this.StatusTextEdit.TabIndex = 9;
            // 
            // UsernameTextEdit
            // 
            this.UsernameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.borrowedhistoryBindingSource, "Username", true));
            this.UsernameTextEdit.Location = new System.Drawing.Point(83, 132);
            this.UsernameTextEdit.Name = "UsernameTextEdit";
            this.UsernameTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.UsernameTextEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Username", "Username", 58, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.UsernameTextEdit.Properties.DataSource = this.userBindingSource;
            this.UsernameTextEdit.Properties.DisplayMember = "Username";
            this.UsernameTextEdit.Properties.NullText = "";
            this.UsernameTextEdit.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.UsernameTextEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.UsernameTextEdit.Properties.ValueMember = "Username";
            this.UsernameTextEdit.Size = new System.Drawing.Size(473, 20);
            this.UsernameTextEdit.StyleController = this.dataLayoutControl1;
            this.UsernameTextEdit.TabIndex = 7;
            // 
            // borrowedhistoryBindingSource
            // 
            this.borrowedhistoryBindingSource.DataSource = typeof(Library_dApp.Borrowedhistory);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(Library_dApp.User);
            // 
            // LendForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 502);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "LendForm";
            this.Text = "LendForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MemberNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemberIdTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookISBNTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMemberName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMemberId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBookISBN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMember)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DueDateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DueDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDueDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemberTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsernameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowedhistoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraEditors.TextEdit MemberNameTextEdit;
        private System.Windows.Forms.BindingSource borrowedhistoryBindingSource;
        private DevExpress.XtraEditors.TextEdit MemberIdTextEdit;
        private DevExpress.XtraEditors.TextEdit BookISBNTextEdit;
        private DevExpress.XtraEditors.TextEdit BookTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForMemberName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForMemberId;
        private DevExpress.XtraLayout.LayoutControlItem ItemForBookISBN;
        private DevExpress.XtraLayout.LayoutControlItem ItemForStatus;
        private DevExpress.XtraLayout.LayoutControlItem ItemForBook;
        private DevExpress.XtraLayout.LayoutControlItem ItemForMember;
        private DevExpress.XtraLayout.LayoutControlItem ItemForUser;
        private DevExpress.XtraEditors.SimpleButton SaveButton;
        private DevExpress.XtraEditors.SimpleButton CancelButton;
        private DevExpress.XtraEditors.DateEdit DueDateDateEdit;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDueDate;
        private DevExpress.XtraEditors.TextEdit MemberTextEdit;
        private DevExpress.XtraEditors.TextEdit UserTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem ItemForUsername;
        private DevExpress.XtraEditors.ComboBoxEdit StatusTextEdit;
        private DevExpress.XtraEditors.LookUpEdit UsernameTextEdit;
        private System.Windows.Forms.BindingSource userBindingSource;
    }
}