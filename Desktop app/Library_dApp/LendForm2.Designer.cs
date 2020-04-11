namespace Library_dApp
{
    partial class LendForm2
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
            this.borrowedhistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MemberIdTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.BookISBNTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.UsernameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.DueDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.StatusTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForMemberName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForMemberId = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForUsername = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForDueDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForStatus = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForBookISBN = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MemberNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowedhistoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemberIdTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookISBNTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsernameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DueDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DueDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMemberName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMemberId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDueDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBookISBN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.MemberNameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.MemberIdTextEdit);
            this.dataLayoutControl1.Controls.Add(this.BookISBNTextEdit);
            this.dataLayoutControl1.Controls.Add(this.UsernameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.DueDateDateEdit);
            this.dataLayoutControl1.Controls.Add(this.StatusTextEdit);
            this.dataLayoutControl1.DataSource = this.borrowedhistoryBindingSource;
            this.dataLayoutControl1.Location = new System.Drawing.Point(17, 24);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(653, 91, 250, 350);
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(562, 265);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // MemberNameTextEdit
            // 
            this.MemberNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.borrowedhistoryBindingSource, "MemberName", true));
            this.MemberNameTextEdit.Location = new System.Drawing.Point(83, 12);
            this.MemberNameTextEdit.Name = "MemberNameTextEdit";
            this.MemberNameTextEdit.Size = new System.Drawing.Size(196, 20);
            this.MemberNameTextEdit.StyleController = this.dataLayoutControl1;
            this.MemberNameTextEdit.TabIndex = 4;
            // 
            // borrowedhistoryBindingSource
            // 
            this.borrowedhistoryBindingSource.DataSource = typeof(Library_dApp.Borrowedhistory);
            // 
            // MemberIdTextEdit
            // 
            this.MemberIdTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.borrowedhistoryBindingSource, "MemberId", true));
            this.MemberIdTextEdit.Location = new System.Drawing.Point(354, 12);
            this.MemberIdTextEdit.Name = "MemberIdTextEdit";
            this.MemberIdTextEdit.Size = new System.Drawing.Size(196, 20);
            this.MemberIdTextEdit.StyleController = this.dataLayoutControl1;
            this.MemberIdTextEdit.TabIndex = 5;
            // 
            // BookISBNTextEdit
            // 
            this.BookISBNTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.borrowedhistoryBindingSource, "BookISBN", true));
            this.BookISBNTextEdit.Location = new System.Drawing.Point(83, 36);
            this.BookISBNTextEdit.Name = "BookISBNTextEdit";
            this.BookISBNTextEdit.Size = new System.Drawing.Size(196, 20);
            this.BookISBNTextEdit.StyleController = this.dataLayoutControl1;
            this.BookISBNTextEdit.TabIndex = 6;
            // 
            // UsernameTextEdit
            // 
            this.UsernameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.borrowedhistoryBindingSource, "Username", true));
            this.UsernameTextEdit.Location = new System.Drawing.Point(354, 36);
            this.UsernameTextEdit.Name = "UsernameTextEdit";
            this.UsernameTextEdit.Size = new System.Drawing.Size(196, 20);
            this.UsernameTextEdit.StyleController = this.dataLayoutControl1;
            this.UsernameTextEdit.TabIndex = 7;
            // 
            // DueDateDateEdit
            // 
            this.DueDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.borrowedhistoryBindingSource, "DueDate", true));
            this.DueDateDateEdit.EditValue = null;
            this.DueDateDateEdit.Location = new System.Drawing.Point(83, 84);
            this.DueDateDateEdit.Name = "DueDateDateEdit";
            this.DueDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DueDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DueDateDateEdit.Size = new System.Drawing.Size(467, 20);
            this.DueDateDateEdit.StyleController = this.dataLayoutControl1;
            this.DueDateDateEdit.TabIndex = 8;
            // 
            // StatusTextEdit
            // 
            this.StatusTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.borrowedhistoryBindingSource, "Status", true));
            this.StatusTextEdit.Location = new System.Drawing.Point(83, 60);
            this.StatusTextEdit.Name = "StatusTextEdit";
            this.StatusTextEdit.Size = new System.Drawing.Size(467, 20);
            this.StatusTextEdit.StyleController = this.dataLayoutControl1;
            this.StatusTextEdit.TabIndex = 9;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(562, 265);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForMemberName,
            this.ItemForMemberId,
            this.ItemForUsername,
            this.ItemForDueDate,
            this.ItemForStatus,
            this.ItemForBookISBN});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(542, 245);
            // 
            // ItemForMemberName
            // 
            this.ItemForMemberName.Control = this.MemberNameTextEdit;
            this.ItemForMemberName.Location = new System.Drawing.Point(0, 0);
            this.ItemForMemberName.Name = "ItemForMemberName";
            this.ItemForMemberName.Size = new System.Drawing.Size(271, 24);
            this.ItemForMemberName.Text = "Member Name";
            this.ItemForMemberName.TextSize = new System.Drawing.Size(68, 13);
            // 
            // ItemForMemberId
            // 
            this.ItemForMemberId.Control = this.MemberIdTextEdit;
            this.ItemForMemberId.Location = new System.Drawing.Point(271, 0);
            this.ItemForMemberId.Name = "ItemForMemberId";
            this.ItemForMemberId.Size = new System.Drawing.Size(271, 24);
            this.ItemForMemberId.Text = "Member Id";
            this.ItemForMemberId.TextSize = new System.Drawing.Size(68, 13);
            // 
            // ItemForUsername
            // 
            this.ItemForUsername.Control = this.UsernameTextEdit;
            this.ItemForUsername.Location = new System.Drawing.Point(271, 24);
            this.ItemForUsername.Name = "ItemForUsername";
            this.ItemForUsername.Size = new System.Drawing.Size(271, 24);
            this.ItemForUsername.Text = "Username";
            this.ItemForUsername.TextSize = new System.Drawing.Size(68, 13);
            // 
            // ItemForDueDate
            // 
            this.ItemForDueDate.Control = this.DueDateDateEdit;
            this.ItemForDueDate.Location = new System.Drawing.Point(0, 72);
            this.ItemForDueDate.Name = "ItemForDueDate";
            this.ItemForDueDate.Size = new System.Drawing.Size(542, 173);
            this.ItemForDueDate.Text = "Due Date";
            this.ItemForDueDate.TextSize = new System.Drawing.Size(68, 13);
            // 
            // ItemForStatus
            // 
            this.ItemForStatus.Control = this.StatusTextEdit;
            this.ItemForStatus.Location = new System.Drawing.Point(0, 48);
            this.ItemForStatus.Name = "ItemForStatus";
            this.ItemForStatus.Size = new System.Drawing.Size(542, 24);
            this.ItemForStatus.Text = "Status";
            this.ItemForStatus.TextSize = new System.Drawing.Size(68, 13);
            // 
            // ItemForBookISBN
            // 
            this.ItemForBookISBN.Control = this.BookISBNTextEdit;
            this.ItemForBookISBN.Location = new System.Drawing.Point(0, 24);
            this.ItemForBookISBN.Name = "ItemForBookISBN";
            this.ItemForBookISBN.Size = new System.Drawing.Size(271, 24);
            this.ItemForBookISBN.Text = "Book ISBN";
            this.ItemForBookISBN.TextSize = new System.Drawing.Size(68, 13);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(147, 296);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Save";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(299, 295);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "Cancel";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataSource = typeof(Library_dApp.Book);
            // 
            // LendForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 438);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "LendForm2";
            this.Text = "LendForm2";
            
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MemberNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowedhistoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemberIdTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookISBNTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsernameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DueDateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DueDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMemberName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMemberId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDueDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBookISBN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraEditors.TextEdit MemberNameTextEdit;
        private System.Windows.Forms.BindingSource borrowedhistoryBindingSource;
        private DevExpress.XtraEditors.TextEdit MemberIdTextEdit;
        private DevExpress.XtraEditors.TextEdit BookISBNTextEdit;
        private DevExpress.XtraEditors.TextEdit UsernameTextEdit;
        private DevExpress.XtraEditors.DateEdit DueDateDateEdit;
        private DevExpress.XtraEditors.TextEdit StatusTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForMemberName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForMemberId;
        private DevExpress.XtraLayout.LayoutControlItem ItemForBookISBN;
        private DevExpress.XtraLayout.LayoutControlItem ItemForUsername;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDueDate;
        private DevExpress.XtraLayout.LayoutControlItem ItemForStatus;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}