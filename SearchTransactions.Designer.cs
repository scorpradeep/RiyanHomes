namespace RiyanHomes
{
    partial class SearchTransactions
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.SearchText = new System.Windows.Forms.TextBox();
            this.ExportToExcel = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.TransactionGrid = new DevExpress.XtraGrid.GridControl();
            this.TranGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Modify = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TranGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Modify);
            this.splitContainer1.Panel1.Controls.Add(this.SearchText);
            this.splitContainer1.Panel1.Controls.Add(this.ExportToExcel);
            this.splitContainer1.Panel1.Controls.Add(this.Search);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.TransactionGrid);
            this.splitContainer1.Size = new System.Drawing.Size(1081, 450);
            this.splitContainer1.SplitterDistance = 69;
            this.splitContainer1.TabIndex = 0;
            // 
            // SearchText
            // 
            this.SearchText.Location = new System.Drawing.Point(12, 12);
            this.SearchText.Multiline = true;
            this.SearchText.Name = "SearchText";
            this.SearchText.Size = new System.Drawing.Size(465, 35);
            this.SearchText.TabIndex = 40;
            // 
            // ExportToExcel
            // 
            this.ExportToExcel.Location = new System.Drawing.Point(976, 22);
            this.ExportToExcel.Name = "ExportToExcel";
            this.ExportToExcel.Size = new System.Drawing.Size(102, 44);
            this.ExportToExcel.TabIndex = 1;
            this.ExportToExcel.Text = "Export To Excel";
            this.ExportToExcel.UseVisualStyleBackColor = true;
            this.ExportToExcel.Click += new System.EventHandler(this.ExportToExcel_Click);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(494, 10);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(139, 23);
            this.Search.TabIndex = 0;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // TransactionGrid
            // 
            this.TransactionGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TransactionGrid.Location = new System.Drawing.Point(0, 0);
            this.TransactionGrid.MainView = this.TranGridView;
            this.TransactionGrid.Name = "TransactionGrid";
            this.TransactionGrid.Size = new System.Drawing.Size(1081, 377);
            this.TransactionGrid.TabIndex = 0;
            this.TransactionGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.TranGridView});
            // 
            // TranGridView
            // 
            this.TranGridView.GridControl = this.TransactionGrid;
            this.TranGridView.Name = "TranGridView";
            this.TranGridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.TranGridView_CustomColumnDisplayText);
            // 
            // Modify
            // 
            this.Modify.Location = new System.Drawing.Point(705, 10);
            this.Modify.Name = "Modify";
            this.Modify.Size = new System.Drawing.Size(93, 41);
            this.Modify.TabIndex = 41;
            this.Modify.Text = "Update";
            this.Modify.UseVisualStyleBackColor = true;
            this.Modify.Click += new System.EventHandler(this.Modify_Click);
            // 
            // SearchTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "SearchTransactions";
            this.Text = "SearchTransactions";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TransactionGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TranGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button Search;
        private DevExpress.XtraGrid.GridControl TransactionGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView TranGridView;
        private System.Windows.Forms.Button ExportToExcel;
        private System.Windows.Forms.TextBox SearchText;
        private System.Windows.Forms.Button Modify;
    }
}