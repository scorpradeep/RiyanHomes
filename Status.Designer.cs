namespace RiyanHomes
{
    partial class Status
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
            this.Tenent = new System.Windows.Forms.Label();
            this.gridLookup = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // Tenent
            // 
            this.Tenent.AutoSize = true;
            this.Tenent.Location = new System.Drawing.Point(63, 34);
            this.Tenent.Name = "Tenent";
            this.Tenent.Size = new System.Drawing.Size(41, 13);
            this.Tenent.TabIndex = 6;
            this.Tenent.Text = "Tenent";
            // 
            // gridLookup
            // 
            this.gridLookup.Location = new System.Drawing.Point(156, 27);
            this.gridLookup.Name = "gridLookup";
            this.gridLookup.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookup.Properties.PopupView = this.gridLookUpEdit1View;
            this.gridLookup.Size = new System.Drawing.Size(254, 20);
            this.gridLookup.TabIndex = 5;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // Status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Tenent);
            this.Controls.Add(this.gridLookup);
            this.Name = "Status";
            this.Text = "Status";
            ((System.ComponentModel.ISupportInitialize)(this.gridLookup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Tenent;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookup;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
    }
}