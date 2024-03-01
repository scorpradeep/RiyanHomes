namespace RiyanHomes
{
    partial class Deals
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
            this.button1 = new System.Windows.Forms.Button();
            this.DealGridControl = new DevExpress.XtraGrid.GridControl();
            this.DealGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Search = new System.Windows.Forms.Button();
            this.gridLookup = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Tenent = new System.Windows.Forms.Label();
            this.Export = new System.Windows.Forms.Button();
            this.Modify = new System.Windows.Forms.Button();
            this.Copy = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DealGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DealGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(444, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DealGridControl
            // 
            this.DealGridControl.Location = new System.Drawing.Point(0, 92);
            this.DealGridControl.MainView = this.DealGridView;
            this.DealGridControl.Name = "DealGridControl";
            this.DealGridControl.Size = new System.Drawing.Size(1137, 301);
            this.DealGridControl.TabIndex = 1;
            this.DealGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.DealGridView});
            // 
            // DealGridView
            // 
            this.DealGridView.GridControl = this.DealGridControl;
            this.DealGridView.Name = "DealGridView";
            this.DealGridView.OptionsBehavior.Editable = false;
            this.DealGridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.DealGridView_CustomColumnDisplayText);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(594, 12);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(152, 46);
            this.Search.TabIndex = 2;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // gridLookup
            // 
            this.gridLookup.Location = new System.Drawing.Point(252, 26);
            this.gridLookup.Name = "gridLookup";
            this.gridLookup.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookup.Properties.PopupView = this.gridLookUpEdit1View;
            this.gridLookup.Size = new System.Drawing.Size(254, 20);
            this.gridLookup.TabIndex = 3;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // Tenent
            // 
            this.Tenent.AutoSize = true;
            this.Tenent.Location = new System.Drawing.Point(159, 33);
            this.Tenent.Name = "Tenent";
            this.Tenent.Size = new System.Drawing.Size(41, 13);
            this.Tenent.TabIndex = 4;
            this.Tenent.Text = "Tenent";
            // 
            // Export
            // 
            this.Export.Location = new System.Drawing.Point(1016, 415);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(121, 34);
            this.Export.TabIndex = 5;
            this.Export.Text = "Export To Excel";
            this.Export.UseVisualStyleBackColor = true;
            this.Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // Modify
            // 
            this.Modify.Location = new System.Drawing.Point(1033, 63);
            this.Modify.Name = "Modify";
            this.Modify.Size = new System.Drawing.Size(93, 23);
            this.Modify.TabIndex = 6;
            this.Modify.Text = "Modify";
            this.Modify.UseVisualStyleBackColor = true;
            this.Modify.Click += new System.EventHandler(this.Modify_Click);
            // 
            // Copy
            // 
            this.Copy.Location = new System.Drawing.Point(1033, 35);
            this.Copy.Name = "Copy";
            this.Copy.Size = new System.Drawing.Size(93, 23);
            this.Copy.TabIndex = 7;
            this.Copy.Text = "Copy";
            this.Copy.UseVisualStyleBackColor = true;
            this.Copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(1033, 6);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(93, 23);
            this.Add.TabIndex = 8;
            this.Add.Text = "ADD";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Deals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 475);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Copy);
            this.Controls.Add(this.Modify);
            this.Controls.Add(this.Export);
            this.Controls.Add(this.Tenent);
            this.Controls.Add(this.gridLookup);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DealGridControl);
            this.Name = "Deals";
            this.Text = "Deals";
            ((System.ComponentModel.ISupportInitialize)(this.DealGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DealGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private DevExpress.XtraGrid.GridControl DealGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView DealGridView;
        private System.Windows.Forms.Button Search;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookup;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private System.Windows.Forms.Label Tenent;
        private System.Windows.Forms.Button Export;
        private System.Windows.Forms.Button Modify;
        private System.Windows.Forms.Button Copy;
        private System.Windows.Forms.Button Add;
    }
}