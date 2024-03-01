namespace RiyanHomes
{
    partial class DashBoard
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
            this.NetGross = new DevExpress.XtraEditors.ToggleSwitch();
            this.Pradeep = new System.Windows.Forms.CheckBox();
            this.Father = new System.Windows.Forms.CheckBox();
            this.Prathusha = new System.Windows.Forms.CheckBox();
            this.YearMonth = new System.Windows.Forms.ComboBox();
            this.ExportToExcel = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.DashBoardGrid = new DevExpress.XtraGrid.GridControl();
            this.DashBoardView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Receivables = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NetGross.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DashBoardGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DashBoardView)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.Receivables);
            this.splitContainer1.Panel1.Controls.Add(this.NetGross);
            this.splitContainer1.Panel1.Controls.Add(this.Pradeep);
            this.splitContainer1.Panel1.Controls.Add(this.Father);
            this.splitContainer1.Panel1.Controls.Add(this.Prathusha);
            this.splitContainer1.Panel1.Controls.Add(this.YearMonth);
            this.splitContainer1.Panel1.Controls.Add(this.ExportToExcel);
            this.splitContainer1.Panel1.Controls.Add(this.Search);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.DashBoardGrid);
            this.splitContainer1.Size = new System.Drawing.Size(1081, 450);
            this.splitContainer1.SplitterDistance = 69;
            this.splitContainer1.TabIndex = 0;
            // 
            // NetGross
            // 
            this.NetGross.Location = new System.Drawing.Point(227, 43);
            this.NetGross.Name = "NetGross";
            this.NetGross.Properties.OffText = "GROSS";
            this.NetGross.Properties.OnText = "NET";
            this.NetGross.Size = new System.Drawing.Size(150, 24);
            this.NetGross.TabIndex = 7;
            // 
            // Pradeep
            // 
            this.Pradeep.AutoSize = true;
            this.Pradeep.Location = new System.Drawing.Point(384, 11);
            this.Pradeep.Name = "Pradeep";
            this.Pradeep.Size = new System.Drawing.Size(66, 17);
            this.Pradeep.TabIndex = 5;
            this.Pradeep.Text = "Pradeep";
            this.Pradeep.UseVisualStyleBackColor = true;
            // 
            // Father
            // 
            this.Father.AutoSize = true;
            this.Father.Location = new System.Drawing.Point(307, 11);
            this.Father.Name = "Father";
            this.Father.Size = new System.Drawing.Size(56, 17);
            this.Father.TabIndex = 4;
            this.Father.Text = "Father";
            this.Father.UseVisualStyleBackColor = true;
            // 
            // Prathusha
            // 
            this.Prathusha.AutoSize = true;
            this.Prathusha.Location = new System.Drawing.Point(227, 11);
            this.Prathusha.Name = "Prathusha";
            this.Prathusha.Size = new System.Drawing.Size(74, 17);
            this.Prathusha.TabIndex = 3;
            this.Prathusha.Text = "Prathusha";
            this.Prathusha.UseVisualStyleBackColor = true;
            // 
            // YearMonth
            // 
            this.YearMonth.FormattingEnabled = true;
            this.YearMonth.Location = new System.Drawing.Point(36, 14);
            this.YearMonth.Name = "YearMonth";
            this.YearMonth.Size = new System.Drawing.Size(157, 21);
            this.YearMonth.TabIndex = 2;
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
            this.Search.Location = new System.Drawing.Point(551, 12);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(139, 23);
            this.Search.TabIndex = 0;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // DashBoardGrid
            // 
            this.DashBoardGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DashBoardGrid.Location = new System.Drawing.Point(0, 0);
            this.DashBoardGrid.MainView = this.DashBoardView;
            this.DashBoardGrid.Name = "DashBoardGrid";
            this.DashBoardGrid.Size = new System.Drawing.Size(1081, 377);
            this.DashBoardGrid.TabIndex = 0;
            this.DashBoardGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.DashBoardView});
            // 
            // DashBoardView
            // 
            this.DashBoardView.GridControl = this.DashBoardGrid;
            this.DashBoardView.Name = "DashBoardView";
            this.DashBoardView.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.DashBoardView_RowStyle);
            this.DashBoardView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.DashBoardView_CustomColumnDisplayText);
            // 
            // Receivables
            // 
            this.Receivables.AutoSize = true;
            this.Receivables.Location = new System.Drawing.Point(384, 47);
            this.Receivables.Name = "Receivables";
            this.Receivables.Size = new System.Drawing.Size(85, 17);
            this.Receivables.TabIndex = 8;
            this.Receivables.Text = "Receivables";
            this.Receivables.UseVisualStyleBackColor = true;
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "DashBoard";
            this.Text = "DashBoard";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NetGross.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DashBoardGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DashBoardView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button Search;
        private DevExpress.XtraGrid.GridControl DashBoardGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView DashBoardView;
        private System.Windows.Forms.Button ExportToExcel;
        private System.Windows.Forms.ComboBox YearMonth;
        private System.Windows.Forms.CheckBox Pradeep;
        private System.Windows.Forms.CheckBox Father;
        private System.Windows.Forms.CheckBox Prathusha;
        private DevExpress.XtraEditors.ToggleSwitch NetGross;
        private System.Windows.Forms.CheckBox Receivables;
    }
}