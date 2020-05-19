namespace Library_dApp
{
    partial class lendForm
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
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.MemberIdTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForMemberId = new DevExpress.XtraLayout.LayoutControlItem();
            this.BookISBNTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForBookISBN = new DevExpress.XtraLayout.LayoutControlItem();
            this.UsernameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForUsername = new DevExpress.XtraLayout.LayoutControlItem();
            this.DueDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.ItemForDueDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.StatusTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForStatus = new DevExpress.XtraLayout.LayoutControlItem();
            this.SavesimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.CancelsimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.borrowedhistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemberIdTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMemberId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookISBNTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBookISBN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsernameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DueDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DueDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDueDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowedhistoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.MemberIdTextEdit);
            this.dataLayoutControl1.Controls.Add(this.BookISBNTextEdit);
            this.dataLayoutControl1.Controls.Add(this.UsernameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.DueDateDateEdit);
            this.dataLayoutControl1.Controls.Add(this.StatusTextEdit);
            this.dataLayoutControl1.DataSource = this.borrowedhistoryBindingSource;
            this.dataLayoutControl1.Location = new System.Drawing.Point(110, 23);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(398, 214);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(398, 214);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForMemberId,
            this.ItemForBookISBN,
            this.ItemForUsername,
            this.ItemForDueDate,
            this.ItemForStatus});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(378, 194);
            // 
            // MemberIdTextEdit
            // 
            this.MemberIdTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.borrowedhistoryBindingSource, "MemberId", true));
            this.MemberIdTextEdit.Location = new System.Drawing.Point(67, 12);
            this.MemberIdTextEdit.Name = "MemberIdTextEdit";
            this.MemberIdTextEdit.Size = new System.Drawing.Size(319, 20);
            this.MemberIdTextEdit.StyleController = this.dataLayoutControl1;
            this.MemberIdTextEdit.TabIndex = 4;
            // 
            // ItemForMemberId
            // 
            this.ItemForMemberId.Control = this.MemberIdTextEdit;
            this.ItemForMemberId.Location = new System.Drawing.Point(0, 0);
            this.ItemForMemberId.Name = "ItemForMemberId";
            this.ItemForMemberId.Size = new System.Drawing.Size(378, 24);
            this.ItemForMemberId.Text = "Member Id";
            this.ItemForMemberId.TextSize = new System.Drawing.Size(51, 13);
            // 
            // BookISBNTextEdit
            // 
            this.BookISBNTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.borrowedhistoryBindingSource, "BookISBN", true));
            this.BookISBNTextEdit.Location = new System.Drawing.Point(67, 36);
            this.BookISBNTextEdit.Name = "BookISBNTextEdit";
            this.BookISBNTextEdit.Size = new System.Drawing.Size(319, 20);
            this.BookISBNTextEdit.StyleController = this.dataLayoutControl1;
            this.BookISBNTextEdit.TabIndex = 5;
            // 
            // ItemForBookISBN
            // 
            this.ItemForBookISBN.Control = this.BookISBNTextEdit;
            this.ItemForBookISBN.Location = new System.Drawing.Point(0, 24);
            this.ItemForBookISBN.Name = "ItemForBookISBN";
            this.ItemForBookISBN.Size = new System.Drawing.Size(378, 24);
            this.ItemForBookISBN.Text = "Book ISBN";
            this.ItemForBookISBN.TextSize = new System.Drawing.Size(51, 13);
            // 
            // UsernameTextEdit
            // 
            this.UsernameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.borrowedhistoryBindingSource, "Username", true));
            this.UsernameTextEdit.Location = new System.Drawing.Point(67, 60);
            this.UsernameTextEdit.Name = "UsernameTextEdit";
            this.UsernameTextEdit.Size = new System.Drawing.Size(319, 20);
            this.UsernameTextEdit.StyleController = this.dataLayoutControl1;
            this.UsernameTextEdit.TabIndex = 6;
            // 
            // ItemForUsername
            // 
            this.ItemForUsername.Control = this.UsernameTextEdit;
            this.ItemForUsername.Location = new System.Drawing.Point(0, 48);
            this.ItemForUsername.Name = "ItemForUsername";
            this.ItemForUsername.Size = new System.Drawing.Size(378, 24);
            this.ItemForUsername.Text = "Username";
            this.ItemForUsername.TextSize = new System.Drawing.Size(51, 13);
            // 
            // DueDateDateEdit
            // 
            this.DueDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.borrowedhistoryBindingSource, "DueDate", true));
            this.DueDateDateEdit.EditValue = null;
            this.DueDateDateEdit.Location = new System.Drawing.Point(67, 84);
            this.DueDateDateEdit.Name = "DueDateDateEdit";
            this.DueDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DueDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DueDateDateEdit.Size = new System.Drawing.Size(319, 20);
            this.DueDateDateEdit.StyleController = this.dataLayoutControl1;
            this.DueDateDateEdit.TabIndex = 7;
            // 
            // ItemForDueDate
            // 
            this.ItemForDueDate.Control = this.DueDateDateEdit;
            this.ItemForDueDate.Location = new System.Drawing.Point(0, 72);
            this.ItemForDueDate.Name = "ItemForDueDate";
            this.ItemForDueDate.Size = new System.Drawing.Size(378, 24);
            this.ItemForDueDate.Text = "Due Date";
            this.ItemForDueDate.TextSize = new System.Drawing.Size(51, 13);
            // 
            // StatusTextEdit
            // 
            this.StatusTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.borrowedhistoryBindingSource, "Status", true));
            this.StatusTextEdit.Location = new System.Drawing.Point(67, 108);
            this.StatusTextEdit.Name = "StatusTextEdit";
            this.StatusTextEdit.Size = new System.Drawing.Size(319, 20);
            this.StatusTextEdit.StyleController = this.dataLayoutControl1;
            this.StatusTextEdit.TabIndex = 8;
            // 
            // ItemForStatus
            // 
            this.ItemForStatus.Control = this.StatusTextEdit;
            this.ItemForStatus.Location = new System.Drawing.Point(0, 96);
            this.ItemForStatus.Name = "ItemForStatus";
            this.ItemForStatus.Size = new System.Drawing.Size(378, 98);
            this.ItemForStatus.Text = "Status";
            this.ItemForStatus.TextSize = new System.Drawing.Size(51, 13);
            // 
            // SavesimpleButton
            // 
            this.SavesimpleButton.Location = new System.Drawing.Point(219, 244);
            this.SavesimpleButton.Name = "SavesimpleButton";
            this.SavesimpleButton.Size = new System.Drawing.Size(75, 23);
            this.SavesimpleButton.TabIndex = 1;
            this.SavesimpleButton.Text = "Lend";
            this.SavesimpleButton.Click += new System.EventHandler(this.SavesimpleButton_Click);
            // 
            // CancelsimpleButton
            // 
            this.CancelsimpleButton.Location = new System.Drawing.Point(332, 244);
            this.CancelsimpleButton.Name = "CancelsimpleButton";
            this.CancelsimpleButton.Size = new System.Drawing.Size(75, 23);
            this.CancelsimpleButton.TabIndex = 1;
            this.CancelsimpleButton.Text = "Cancel";
            this.CancelsimpleButton.Click += new System.EventHandler(this.CancelsimpleButton_Click);
            // 
            // borrowedhistoryBindingSource
            // 
            this.borrowedhistoryBindingSource.DataSource = typeof(Library_dApp.Borrowedhistory);
            // 
            // lendForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 350);
            this.Controls.Add(this.CancelsimpleButton);
            this.Controls.Add(this.SavesimpleButton);
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "lendForm";
            this.Text = "lendForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemberIdTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMemberId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookISBNTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBookISBN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsernameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DueDateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DueDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDueDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowedhistoryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraEditors.TextEdit MemberIdTextEdit;
        private System.Windows.Forms.BindingSource borrowedhistoryBindingSource;
        private DevExpress.XtraEditors.TextEdit BookISBNTextEdit;
        private DevExpress.XtraEditors.TextEdit UsernameTextEdit;
        private DevExpress.XtraEditors.DateEdit DueDateDateEdit;
        private DevExpress.XtraEditors.TextEdit StatusTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForMemberId;
        private DevExpress.XtraLayout.LayoutControlItem ItemForBookISBN;
        private DevExpress.XtraLayout.LayoutControlItem ItemForUsername;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDueDate;
        private DevExpress.XtraLayout.LayoutControlItem ItemForStatus;
        private DevExpress.XtraEditors.SimpleButton SavesimpleButton;
        private DevExpress.XtraEditors.SimpleButton CancelsimpleButton;
    }
}