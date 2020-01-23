namespace Library_dApp
{
    partial class NewBookForm
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
            this.CancelsimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.SavesimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.BookNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForBookName = new DevExpress.XtraLayout.LayoutControlItem();
            this.BookISBNTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForBookISBN = new DevExpress.XtraLayout.LayoutControlItem();
            this.AuthorTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForAuthor = new DevExpress.XtraLayout.LayoutControlItem();
            this.EditionTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForEdition = new DevExpress.XtraLayout.LayoutControlItem();
            this.Year_publishedDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.ItemForYear_published = new DevExpress.XtraLayout.LayoutControlItem();
            this.Reserve_CheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.ItemForReserve_ = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBookName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookISBNTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBookISBN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AuthorTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAuthor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditionTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEdition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Year_publishedDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Year_publishedDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForYear_published)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reserve_CheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForReserve_)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelsimpleButton
            // 
            this.CancelsimpleButton.Location = new System.Drawing.Point(335, 313);
            this.CancelsimpleButton.Name = "CancelsimpleButton";
            this.CancelsimpleButton.Size = new System.Drawing.Size(75, 23);
            this.CancelsimpleButton.TabIndex = 1;
            this.CancelsimpleButton.Text = "Cancel";
            this.CancelsimpleButton.Click += new System.EventHandler(this.CancelsimpleButton_Click);
            // 
            // SavesimpleButton
            // 
            this.SavesimpleButton.Location = new System.Drawing.Point(186, 313);
            this.SavesimpleButton.Name = "SavesimpleButton";
            this.SavesimpleButton.Size = new System.Drawing.Size(75, 23);
            this.SavesimpleButton.TabIndex = 1;
            this.SavesimpleButton.Text = "Save";
            this.SavesimpleButton.Click += new System.EventHandler(this.SavesimpleButton_Click);
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.BookNameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.BookISBNTextEdit);
            this.dataLayoutControl1.Controls.Add(this.AuthorTextEdit);
            this.dataLayoutControl1.Controls.Add(this.EditionTextEdit);
            this.dataLayoutControl1.Controls.Add(this.Year_publishedDateEdit);
            this.dataLayoutControl1.Controls.Add(this.Reserve_CheckEdit);
            this.dataLayoutControl1.DataSource = this.bookBindingSource;
            this.dataLayoutControl1.Location = new System.Drawing.Point(12, 16);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(475, 256);
            this.dataLayoutControl1.TabIndex = 2;
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
            this.layoutControlGroup1.Size = new System.Drawing.Size(475, 256);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataSource = typeof(Library_dApp.Book);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForBookName,
            this.ItemForBookISBN,
            this.ItemForAuthor,
            this.ItemForEdition,
            this.ItemForYear_published,
            this.ItemForReserve_});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(455, 236);
            // 
            // BookNameTextEdit
            // 
            this.BookNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bookBindingSource, "BookName", true));
            this.BookNameTextEdit.Location = new System.Drawing.Point(89, 12);
            this.BookNameTextEdit.Name = "BookNameTextEdit";
            this.BookNameTextEdit.Size = new System.Drawing.Size(374, 20);
            this.BookNameTextEdit.StyleController = this.dataLayoutControl1;
            this.BookNameTextEdit.TabIndex = 4;
            // 
            // ItemForBookName
            // 
            this.ItemForBookName.Control = this.BookNameTextEdit;
            this.ItemForBookName.Location = new System.Drawing.Point(0, 0);
            this.ItemForBookName.Name = "ItemForBookName";
            this.ItemForBookName.Size = new System.Drawing.Size(455, 24);
            this.ItemForBookName.Text = "Book Name";
            this.ItemForBookName.TextSize = new System.Drawing.Size(73, 13);
            // 
            // BookISBNTextEdit
            // 
            this.BookISBNTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bookBindingSource, "BookISBN", true));
            this.BookISBNTextEdit.Location = new System.Drawing.Point(89, 36);
            this.BookISBNTextEdit.Name = "BookISBNTextEdit";
            this.BookISBNTextEdit.Size = new System.Drawing.Size(374, 20);
            this.BookISBNTextEdit.StyleController = this.dataLayoutControl1;
            this.BookISBNTextEdit.TabIndex = 5;
            // 
            // ItemForBookISBN
            // 
            this.ItemForBookISBN.Control = this.BookISBNTextEdit;
            this.ItemForBookISBN.Location = new System.Drawing.Point(0, 24);
            this.ItemForBookISBN.Name = "ItemForBookISBN";
            this.ItemForBookISBN.Size = new System.Drawing.Size(455, 24);
            this.ItemForBookISBN.Text = "Book ISBN";
            this.ItemForBookISBN.TextSize = new System.Drawing.Size(73, 13);
            // 
            // AuthorTextEdit
            // 
            this.AuthorTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bookBindingSource, "Author", true));
            this.AuthorTextEdit.Location = new System.Drawing.Point(89, 60);
            this.AuthorTextEdit.Name = "AuthorTextEdit";
            this.AuthorTextEdit.Size = new System.Drawing.Size(374, 20);
            this.AuthorTextEdit.StyleController = this.dataLayoutControl1;
            this.AuthorTextEdit.TabIndex = 6;
            // 
            // ItemForAuthor
            // 
            this.ItemForAuthor.Control = this.AuthorTextEdit;
            this.ItemForAuthor.Location = new System.Drawing.Point(0, 48);
            this.ItemForAuthor.Name = "ItemForAuthor";
            this.ItemForAuthor.Size = new System.Drawing.Size(455, 24);
            this.ItemForAuthor.Text = "Author";
            this.ItemForAuthor.TextSize = new System.Drawing.Size(73, 13);
            // 
            // EditionTextEdit
            // 
            this.EditionTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bookBindingSource, "Edition", true));
            this.EditionTextEdit.Location = new System.Drawing.Point(89, 84);
            this.EditionTextEdit.Name = "EditionTextEdit";
            this.EditionTextEdit.Size = new System.Drawing.Size(374, 20);
            this.EditionTextEdit.StyleController = this.dataLayoutControl1;
            this.EditionTextEdit.TabIndex = 7;
            // 
            // ItemForEdition
            // 
            this.ItemForEdition.Control = this.EditionTextEdit;
            this.ItemForEdition.Location = new System.Drawing.Point(0, 72);
            this.ItemForEdition.Name = "ItemForEdition";
            this.ItemForEdition.Size = new System.Drawing.Size(455, 24);
            this.ItemForEdition.Text = "Edition";
            this.ItemForEdition.TextSize = new System.Drawing.Size(73, 13);
            // 
            // Year_publishedDateEdit
            // 
            this.Year_publishedDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bookBindingSource, "Year_published", true));
            this.Year_publishedDateEdit.EditValue = null;
            this.Year_publishedDateEdit.Location = new System.Drawing.Point(89, 108);
            this.Year_publishedDateEdit.Name = "Year_publishedDateEdit";
            this.Year_publishedDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Year_publishedDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Year_publishedDateEdit.Size = new System.Drawing.Size(374, 20);
            this.Year_publishedDateEdit.StyleController = this.dataLayoutControl1;
            this.Year_publishedDateEdit.TabIndex = 8;
            // 
            // ItemForYear_published
            // 
            this.ItemForYear_published.Control = this.Year_publishedDateEdit;
            this.ItemForYear_published.Location = new System.Drawing.Point(0, 96);
            this.ItemForYear_published.Name = "ItemForYear_published";
            this.ItemForYear_published.Size = new System.Drawing.Size(455, 24);
            this.ItemForYear_published.Text = "Year_published";
            this.ItemForYear_published.TextSize = new System.Drawing.Size(73, 13);
            // 
            // Reserve_CheckEdit
            // 
            this.Reserve_CheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bookBindingSource, "Reserve_", true));
            this.Reserve_CheckEdit.Location = new System.Drawing.Point(89, 132);
            this.Reserve_CheckEdit.Name = "Reserve_CheckEdit";
            this.Reserve_CheckEdit.Properties.Caption = "Reserve_";
            this.Reserve_CheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Reserve_CheckEdit.Size = new System.Drawing.Size(374, 19);
            this.Reserve_CheckEdit.StyleController = this.dataLayoutControl1;
            this.Reserve_CheckEdit.TabIndex = 9;
            // 
            // ItemForReserve_
            // 
            this.ItemForReserve_.Control = this.Reserve_CheckEdit;
            this.ItemForReserve_.Location = new System.Drawing.Point(0, 120);
            this.ItemForReserve_.Name = "ItemForReserve_";
            this.ItemForReserve_.Size = new System.Drawing.Size(455, 116);
            this.ItemForReserve_.Text = "Reserve_";
            this.ItemForReserve_.TextSize = new System.Drawing.Size(73, 13);
            // 
            // NewBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 446);
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.SavesimpleButton);
            this.Controls.Add(this.CancelsimpleButton);
            this.Name = "NewBookForm";
            this.Text = "NewBookForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBookName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookISBNTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBookISBN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AuthorTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAuthor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditionTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEdition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Year_publishedDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Year_publishedDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForYear_published)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reserve_CheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForReserve_)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton CancelsimpleButton;
        private DevExpress.XtraEditors.SimpleButton SavesimpleButton;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraEditors.TextEdit BookNameTextEdit;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private DevExpress.XtraEditors.TextEdit BookISBNTextEdit;
        private DevExpress.XtraEditors.TextEdit AuthorTextEdit;
        private DevExpress.XtraEditors.TextEdit EditionTextEdit;
        private DevExpress.XtraEditors.DateEdit Year_publishedDateEdit;
        private DevExpress.XtraEditors.CheckEdit Reserve_CheckEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForBookName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForBookISBN;
        private DevExpress.XtraLayout.LayoutControlItem ItemForAuthor;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEdition;
        private DevExpress.XtraLayout.LayoutControlItem ItemForYear_published;
        private DevExpress.XtraLayout.LayoutControlItem ItemForReserve_;
    }
}