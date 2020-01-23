namespace Library_dApp
{
    partial class ListBooksForm
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colBookName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBookISBN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAuthor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEdition = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYear_published = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReserve_ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(685, 534);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBookName,
            this.colBookISBN,
            this.colAuthor,
            this.colEdition,
            this.colYear_published,
            this.colReserve_});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // colBookName
            // 
            this.colBookName.FieldName = "BookName";
            this.colBookName.Name = "colBookName";
            this.colBookName.Visible = true;
            this.colBookName.VisibleIndex = 0;
            // 
            // colBookISBN
            // 
            this.colBookISBN.FieldName = "BookISBN";
            this.colBookISBN.Name = "colBookISBN";
            this.colBookISBN.Visible = true;
            this.colBookISBN.VisibleIndex = 1;
            // 
            // colAuthor
            // 
            this.colAuthor.FieldName = "Author";
            this.colAuthor.Name = "colAuthor";
            this.colAuthor.Visible = true;
            this.colAuthor.VisibleIndex = 2;
            // 
            // colEdition
            // 
            this.colEdition.FieldName = "Edition";
            this.colEdition.Name = "colEdition";
            this.colEdition.Visible = true;
            this.colEdition.VisibleIndex = 3;
            // 
            // colYear_published
            // 
            this.colYear_published.FieldName = "Year_published";
            this.colYear_published.Name = "colYear_published";
            this.colYear_published.Visible = true;
            this.colYear_published.VisibleIndex = 4;
            // 
            // colReserve_
            // 
            this.colReserve_.FieldName = "Reserve_";
            this.colReserve_.Name = "colReserve_";
            this.colReserve_.Visible = true;
            this.colReserve_.VisibleIndex = 5;
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataSource = typeof(Library_dApp.Book);
            // 
            // ListBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 534);
            this.Controls.Add(this.gridControl1);
            this.Name = "ListBooksForm";
            this.Text = "ListBooksForm";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colBookName;
        private DevExpress.XtraGrid.Columns.GridColumn colBookISBN;
        private DevExpress.XtraGrid.Columns.GridColumn colAuthor;
        private DevExpress.XtraGrid.Columns.GridColumn colEdition;
        private DevExpress.XtraGrid.Columns.GridColumn colYear_published;
        private DevExpress.XtraGrid.Columns.GridColumn colReserve_;
    }
}