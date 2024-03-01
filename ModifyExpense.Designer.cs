namespace RiyanHomes
{
    partial class ModifyExpense
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
            this.label1 = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TransactionDate = new DevExpress.XtraEditors.DateEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NoteDesc = new System.Windows.Forms.TextBox();
            this.Notes = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.MonthYear = new DevExpress.XtraEditors.ComboBoxEdit();
            this.MarkTenent = new DevExpress.XtraEditors.ComboBoxEdit();
            this.Submit = new System.Windows.Forms.Button();
            this.TransactionId = new DevExpress.XtraEditors.TextEdit();
            this.Amount = new DevExpress.XtraEditors.SpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonthYear.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MarkTenent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Amount.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Expense Date";
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(228, 57);
            this.Description.Multiline = true;
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(413, 112);
            this.Description.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Remarks";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TransactionDate
            // 
            this.TransactionDate.EditValue = null;
            this.TransactionDate.Location = new System.Drawing.Point(228, 31);
            this.TransactionDate.Name = "TransactionDate";
            this.TransactionDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TransactionDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TransactionDate.Size = new System.Drawing.Size(100, 20);
            this.TransactionDate.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Amount";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tenent";
            // 
            // NoteDesc
            // 
            this.NoteDesc.Location = new System.Drawing.Point(228, 252);
            this.NoteDesc.Multiline = true;
            this.NoteDesc.Name = "NoteDesc";
            this.NoteDesc.Size = new System.Drawing.Size(402, 63);
            this.NoteDesc.TabIndex = 11;
            // 
            // Notes
            // 
            this.Notes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Notes.Location = new System.Drawing.Point(35, 269);
            this.Notes.Name = "Notes";
            this.Notes.Size = new System.Drawing.Size(77, 23);
            this.Notes.TabIndex = 12;
            this.Notes.Text = "Notes";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "Month";
            // 
            // MonthYear
            // 
            this.MonthYear.Location = new System.Drawing.Point(228, 339);
            this.MonthYear.Name = "MonthYear";
            this.MonthYear.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.MonthYear.Size = new System.Drawing.Size(118, 20);
            this.MonthYear.TabIndex = 16;
            // 
            // MarkTenent
            // 
            this.MarkTenent.Location = new System.Drawing.Point(228, 226);
            this.MarkTenent.Name = "MarkTenent";
            this.MarkTenent.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.MarkTenent.Size = new System.Drawing.Size(157, 20);
            this.MarkTenent.TabIndex = 17;
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Submit.Location = new System.Drawing.Point(209, 398);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(193, 39);
            this.Submit.TabIndex = 19;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // TransactionId
            // 
            this.TransactionId.Location = new System.Drawing.Point(228, 5);
            this.TransactionId.Name = "TransactionId";
            this.TransactionId.Properties.ReadOnly = true;
            this.TransactionId.Size = new System.Drawing.Size(92, 20);
            this.TransactionId.TabIndex = 20;
            // 
            // Amount
            // 
            this.Amount.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.Amount.Location = new System.Drawing.Point(228, 193);
            this.Amount.Name = "Amount";
            this.Amount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Amount.Properties.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Amount.Size = new System.Drawing.Size(157, 20);
            this.Amount.TabIndex = 22;
            // 
            // ModifyExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 462);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.TransactionId);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.MarkTenent);
            this.Controls.Add(this.MonthYear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Notes);
            this.Controls.Add(this.NoteDesc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TransactionDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.label1);
            this.Name = "ModifyExpense";
            this.Text = "Modify";
            ((System.ComponentModel.ISupportInitialize)(this.TransactionDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonthYear.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MarkTenent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Amount.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Description;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.DateEdit TransactionDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NoteDesc;
        private System.Windows.Forms.Label Notes;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.ComboBoxEdit MonthYear;
        private DevExpress.XtraEditors.ComboBoxEdit MarkTenent;
        private System.Windows.Forms.Button Submit;
        private DevExpress.XtraEditors.TextEdit TransactionId;
        private DevExpress.XtraEditors.SpinEdit Amount;
    }
}