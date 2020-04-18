namespace Library_dApp
{
    partial class NewMemberForm
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
            this.MemberIdTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.MemberNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ProgramTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.LevelTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.HostelTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForMemberId = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForMemberName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForProgram = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForLevel = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForHostel = new DevExpress.XtraLayout.LayoutControlItem();
            this.SavesimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.CancelsimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MemberIdTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemberNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProgramTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LevelTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HostelTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMemberId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMemberName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForProgram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForHostel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.MemberIdTextEdit);
            this.dataLayoutControl1.Controls.Add(this.MemberNameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.ProgramTextEdit);
            this.dataLayoutControl1.Controls.Add(this.LevelTextEdit);
            this.dataLayoutControl1.Controls.Add(this.HostelTextEdit);
            this.dataLayoutControl1.DataSource = this.memberBindingSource;
            this.dataLayoutControl1.Location = new System.Drawing.Point(39, 32);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(485, 180);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // MemberIdTextEdit
            // 
            this.MemberIdTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.memberBindingSource, "MemberId", true));
            this.MemberIdTextEdit.Location = new System.Drawing.Point(83, 12);
            this.MemberIdTextEdit.Name = "MemberIdTextEdit";
            this.MemberIdTextEdit.Size = new System.Drawing.Size(390, 20);
            this.MemberIdTextEdit.StyleController = this.dataLayoutControl1;
            this.MemberIdTextEdit.TabIndex = 4;
            // 
            // MemberNameTextEdit
            // 
            this.MemberNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.memberBindingSource, "MemberName", true));
            this.MemberNameTextEdit.Location = new System.Drawing.Point(83, 36);
            this.MemberNameTextEdit.Name = "MemberNameTextEdit";
            this.MemberNameTextEdit.Size = new System.Drawing.Size(390, 20);
            this.MemberNameTextEdit.StyleController = this.dataLayoutControl1;
            this.MemberNameTextEdit.TabIndex = 5;
            // 
            // ProgramTextEdit
            // 
            this.ProgramTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.memberBindingSource, "Program", true));
            this.ProgramTextEdit.Location = new System.Drawing.Point(83, 60);
            this.ProgramTextEdit.Name = "ProgramTextEdit";
            this.ProgramTextEdit.Size = new System.Drawing.Size(390, 20);
            this.ProgramTextEdit.StyleController = this.dataLayoutControl1;
            this.ProgramTextEdit.TabIndex = 6;
            // 
            // LevelTextEdit
            // 
            this.LevelTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.memberBindingSource, "Level", true));
            this.LevelTextEdit.Location = new System.Drawing.Point(83, 84);
            this.LevelTextEdit.Name = "LevelTextEdit";
            this.LevelTextEdit.Size = new System.Drawing.Size(390, 20);
            this.LevelTextEdit.StyleController = this.dataLayoutControl1;
            this.LevelTextEdit.TabIndex = 7;
            // 
            // HostelTextEdit
            // 
            this.HostelTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.memberBindingSource, "Hostel", true));
            this.HostelTextEdit.Location = new System.Drawing.Point(83, 108);
            this.HostelTextEdit.Name = "HostelTextEdit";
            this.HostelTextEdit.Size = new System.Drawing.Size(390, 20);
            this.HostelTextEdit.StyleController = this.dataLayoutControl1;
            this.HostelTextEdit.TabIndex = 8;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(485, 180);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForMemberId,
            this.ItemForMemberName,
            this.ItemForProgram,
            this.ItemForLevel,
            this.ItemForHostel});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(465, 160);
            // 
            // ItemForMemberId
            // 
            this.ItemForMemberId.Control = this.MemberIdTextEdit;
            this.ItemForMemberId.Location = new System.Drawing.Point(0, 0);
            this.ItemForMemberId.Name = "ItemForMemberId";
            this.ItemForMemberId.Size = new System.Drawing.Size(465, 24);
            this.ItemForMemberId.Text = "Member Id";
            this.ItemForMemberId.TextSize = new System.Drawing.Size(68, 13);
            // 
            // ItemForMemberName
            // 
            this.ItemForMemberName.Control = this.MemberNameTextEdit;
            this.ItemForMemberName.Location = new System.Drawing.Point(0, 24);
            this.ItemForMemberName.Name = "ItemForMemberName";
            this.ItemForMemberName.Size = new System.Drawing.Size(465, 24);
            this.ItemForMemberName.Text = "Member Name";
            this.ItemForMemberName.TextSize = new System.Drawing.Size(68, 13);
            // 
            // ItemForProgram
            // 
            this.ItemForProgram.Control = this.ProgramTextEdit;
            this.ItemForProgram.Location = new System.Drawing.Point(0, 48);
            this.ItemForProgram.Name = "ItemForProgram";
            this.ItemForProgram.Size = new System.Drawing.Size(465, 24);
            this.ItemForProgram.Text = "Program";
            this.ItemForProgram.TextSize = new System.Drawing.Size(68, 13);
            // 
            // ItemForLevel
            // 
            this.ItemForLevel.Control = this.LevelTextEdit;
            this.ItemForLevel.Location = new System.Drawing.Point(0, 72);
            this.ItemForLevel.Name = "ItemForLevel";
            this.ItemForLevel.Size = new System.Drawing.Size(465, 24);
            this.ItemForLevel.Text = "Level";
            this.ItemForLevel.TextSize = new System.Drawing.Size(68, 13);
            // 
            // ItemForHostel
            // 
            this.ItemForHostel.Control = this.HostelTextEdit;
            this.ItemForHostel.Location = new System.Drawing.Point(0, 96);
            this.ItemForHostel.Name = "ItemForHostel";
            this.ItemForHostel.Size = new System.Drawing.Size(465, 64);
            this.ItemForHostel.Text = "Hostel";
            this.ItemForHostel.TextSize = new System.Drawing.Size(68, 13);
            // 
            // SavesimpleButton
            // 
            this.SavesimpleButton.Location = new System.Drawing.Point(152, 264);
            this.SavesimpleButton.Name = "SavesimpleButton";
            this.SavesimpleButton.Size = new System.Drawing.Size(75, 23);
            this.SavesimpleButton.TabIndex = 1;
            this.SavesimpleButton.Text = "Save";
            this.SavesimpleButton.Click += new System.EventHandler(this.SavesimpleButton_Click);
            // 
            // CancelsimpleButton
            // 
            this.CancelsimpleButton.Location = new System.Drawing.Point(348, 264);
            this.CancelsimpleButton.Name = "CancelsimpleButton";
            this.CancelsimpleButton.Size = new System.Drawing.Size(75, 23);
            this.CancelsimpleButton.TabIndex = 1;
            this.CancelsimpleButton.Text = "Cancel";
            this.CancelsimpleButton.Click += new System.EventHandler(this.CancelsimpleButton_Click);
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataSource = typeof(Library_dApp.Member);
            // 
            // NewMemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 516);
            this.Controls.Add(this.CancelsimpleButton);
            this.Controls.Add(this.SavesimpleButton);
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "NewMemberForm";
            this.Text = "NewMemberForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MemberIdTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemberNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProgramTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LevelTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HostelTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMemberId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMemberName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForProgram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForHostel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraEditors.TextEdit MemberIdTextEdit;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private DevExpress.XtraEditors.TextEdit MemberNameTextEdit;
        private DevExpress.XtraEditors.TextEdit ProgramTextEdit;
        private DevExpress.XtraEditors.TextEdit LevelTextEdit;
        private DevExpress.XtraEditors.TextEdit HostelTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForMemberId;
        private DevExpress.XtraLayout.LayoutControlItem ItemForMemberName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForProgram;
        private DevExpress.XtraLayout.LayoutControlItem ItemForLevel;
        private DevExpress.XtraLayout.LayoutControlItem ItemForHostel;
        private DevExpress.XtraEditors.SimpleButton SavesimpleButton;
        private DevExpress.XtraEditors.SimpleButton CancelsimpleButton;
    }
}