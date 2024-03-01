namespace RiyanHomes
{
    partial class TransactionsByTenent
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
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.YearMonth = new DevExpress.XtraEditors.ComboBoxEdit();
            this.ExportToExcel = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.TransactionGrid = new DevExpress.XtraGrid.GridControl();
            this.TranGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YearMonth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TranGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.YearMonth);
            this.splitContainer2.Panel1.Controls.Add(this.ExportToExcel);
            this.splitContainer2.Panel1.Controls.Add(this.Search);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.TransactionGrid);
            this.splitContainer2.Size = new System.Drawing.Size(1081, 450);
            this.splitContainer2.SplitterDistance = 69;
            this.splitContainer2.TabIndex = 0;
            // 
            // YearMonth
            // 
            this.YearMonth.Location = new System.Drawing.Point(35, 19);
            this.YearMonth.Name = "YearMonth";
            this.YearMonth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.YearMonth.Size = new System.Drawing.Size(148, 20);
            this.YearMonth.TabIndex = 19;
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
            this.Search.Location = new System.Drawing.Point(295, 12);
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
            // TransactionsByTenent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 450);
            this.Controls.Add(this.splitContainer2);
            this.Name = "TransactionsByTenent";
            this.Text = "TransactionsByTenent";
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.YearMonth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TranGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button Search;
        private DevExpress.XtraGrid.GridControl TransactionGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView TranGridView;
        private System.Windows.Forms.Button ExportToExcel;
        private DevExpress.XtraEditors.ComboBoxEdit YearMonth;
    }
}