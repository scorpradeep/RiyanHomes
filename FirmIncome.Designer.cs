namespace RiyanHomes
{
    partial class FirmIncome
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
            this.Receivables = new System.Windows.Forms.CheckBox();
            this.NetGross = new DevExpress.XtraEditors.ToggleSwitch();
            this.Pradeep = new System.Windows.Forms.CheckBox();
            this.Father = new System.Windows.Forms.CheckBox();
            this.Prathusha = new System.Windows.Forms.CheckBox();
            this.ExportToExcel = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.DashBoardGrid = new DevExpress.XtraGrid.GridControl();
            this.DashBoardView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.FromDate = new DevExpress.XtraEditors.DateEdit();
            this.ToDate = new DevExpress.XtraEditors.DateEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NetGross.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DashBoardGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DashBoardView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FromDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToDate.Properties)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.ToDate);
            this.splitContainer1.Panel1.Controls.Add(this.FromDate);
            this.splitContainer1.Panel1.Controls.Add(this.Receivables);
            this.splitContainer1.Panel1.Controls.Add(this.NetGross);
            this.splitContainer1.Panel1.Controls.Add(this.Pradeep);
            this.splitContainer1.Panel1.Controls.Add(this.Father);
            this.splitContainer1.Panel1.Controls.Add(this.Prathusha);
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
            // Receivables
            // 
            this.Receivables.AutoSize = true;
            this.Receivables.Location = new System.Drawing.Point(545, 39);
            this.Receivables.Name = "Receivables";
            this.Receivables.Size = new System.Drawing.Size(85, 17);
            this.Receivables.TabIndex = 8;
            this.Receivables.Text = "Receivables";
            this.Receivables.UseVisualStyleBackColor = true;
            // 
            // NetGross
            // 
            this.NetGross.Location = new System.Drawing.Point(388, 35);
            this.NetGross.Name = "NetGross";
            this.NetGross.Properties.OffText = "GROSS";
            this.NetGross.Properties.OnText = "NET";
            this.NetGross.Size = new System.Drawing.Size(150, 24);
            this.NetGross.TabIndex = 7;
            // 
            // Pradeep
            // 
            this.Pradeep.AutoSize = true;
            this.Pradeep.Location = new System.Drawing.Point(545, 3);
            this.Pradeep.Name = "Pradeep";
            this.Pradeep.Size = new System.Drawing.Size(66, 17);
            this.Pradeep.TabIndex = 5;
            this.Pradeep.Text = "Pradeep";
            this.Pradeep.UseVisualStyleBackColor = true;
            // 
            // Father
            // 
            this.Father.AutoSize = true;
            this.Father.Location = new System.Drawing.Point(468, 3);
            this.Father.Name = "Father";
            this.Father.Size = new System.Drawing.Size(56, 17);
            this.Father.TabIndex = 4;
            this.Father.Text = "Father";
            this.Father.UseVisualStyleBackColor = true;
            // 
            // Prathusha
            // 
            this.Prathusha.AutoSize = true;
            this.Prathusha.Location = new System.Drawing.Point(388, 3);
            this.Prathusha.Name = "Prathusha";
            this.Prathusha.Size = new System.Drawing.Size(74, 17);
            this.Prathusha.TabIndex = 3;
            this.Prathusha.Text = "Prathusha";
            this.Prathusha.UseVisualStyleBackColor = true;
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
            this.Search.Location = new System.Drawing.Point(712, 4);
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
            // FromDate
            // 
            this.FromDate.EditValue = null;
            this.FromDate.Location = new System.Drawing.Point(69, 14);
            this.FromDate.Name = "FromDate";
            this.FromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.FromDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.FromDate.Size = new System.Drawing.Size(100, 20);
            this.FromDate.TabIndex = 9;
            // 
            // ToDate
            // 
            this.ToDate.EditValue = null;
            this.ToDate.Location = new System.Drawing.Point(244, 14);
            this.ToDate.Name = "ToDate";
            this.ToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ToDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ToDate.Size = new System.Drawing.Size(100, 20);
            this.ToDate.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 26);
            this.label1.TabIndex = 11;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(187, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 26);
            this.label2.TabIndex = 12;
            this.label2.Text = "To";
            // 
            // FirmIncome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FirmIncome";
            this.Text = "DashBoard";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NetGross.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DashBoardGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DashBoardView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FromDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToDate.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button Search;
        private DevExpress.XtraGrid.GridControl DashBoardGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView DashBoardView;
        private System.Windows.Forms.Button ExportToExcel;
        private System.Windows.Forms.CheckBox Pradeep;
        private System.Windows.Forms.CheckBox Father;
        private System.Windows.Forms.CheckBox Prathusha;
        private DevExpress.XtraEditors.ToggleSwitch NetGross;
        private System.Windows.Forms.CheckBox Receivables;
        private DevExpress.XtraEditors.DateEdit ToDate;
        private DevExpress.XtraEditors.DateEdit FromDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}