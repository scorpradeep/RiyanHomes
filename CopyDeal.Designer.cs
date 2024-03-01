namespace RiyanHomes
{
    partial class CopyDeal
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
            this.Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EffectiveFrom = new DevExpress.XtraEditors.DateEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Rent = new System.Windows.Forms.NumericUpDown();
            this.Type = new DevExpress.XtraEditors.ComboBoxEdit();
            this.Submit = new System.Windows.Forms.Button();
            this.TenentId = new DevExpress.XtraEditors.TextEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.EffectiveTo = new DevExpress.XtraEditors.DateEdit();
            this.Phone = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Email = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RenualDate = new DevExpress.XtraEditors.DateEdit();
            this.RenualRate = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Location = new DevExpress.XtraEditors.ComboBoxEdit();
            this.Address = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PropertyId = new DevExpress.XtraEditors.ComboBoxEdit();
            this.DealType = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EffectiveFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EffectiveFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Type.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TenentId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EffectiveTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EffectiveTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RenualDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RenualDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Location.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PropertyId.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Type";
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(228, 144);
            this.Name.Multiline = true;
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(224, 23);
            this.Name.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // EffectiveFrom
            // 
            this.EffectiveFrom.EditValue = null;
            this.EffectiveFrom.Location = new System.Drawing.Point(228, 208);
            this.EffectiveFrom.Name = "EffectiveFrom";
            this.EffectiveFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.EffectiveFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.EffectiveFrom.Size = new System.Drawing.Size(100, 20);
            this.EffectiveFrom.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Phone";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Rent";
            // 
            // Rent
            // 
            this.Rent.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Rent.Location = new System.Drawing.Point(228, 339);
            this.Rent.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.Rent.Name = "Rent";
            this.Rent.Size = new System.Drawing.Size(157, 20);
            this.Rent.TabIndex = 15;
            // 
            // Type
            // 
            this.Type.Location = new System.Drawing.Point(228, 31);
            this.Type.Name = "Type";
            this.Type.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Type.Size = new System.Drawing.Size(148, 20);
            this.Type.TabIndex = 18;
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Submit.Location = new System.Drawing.Point(228, 514);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(193, 39);
            this.Submit.TabIndex = 19;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // TenentId
            // 
            this.TenentId.Location = new System.Drawing.Point(228, 5);
            this.TenentId.Name = "TenentId";
            this.TenentId.Properties.ReadOnly = true;
            this.TenentId.Size = new System.Drawing.Size(92, 20);
            this.TenentId.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 23);
            this.label7.TabIndex = 22;
            this.label7.Text = "Location";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(35, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 23);
            this.label8.TabIndex = 24;
            this.label8.Text = "Effective From";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(347, 211);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 23);
            this.label9.TabIndex = 26;
            this.label9.Text = "Effective To";
            // 
            // EffectiveTo
            // 
            this.EffectiveTo.EditValue = null;
            this.EffectiveTo.Location = new System.Drawing.Point(470, 210);
            this.EffectiveTo.Name = "EffectiveTo";
            this.EffectiveTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.EffectiveTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.EffectiveTo.Size = new System.Drawing.Size(100, 20);
            this.EffectiveTo.TabIndex = 25;
            // 
            // Phone
            // 
            this.Phone.Location = new System.Drawing.Point(228, 277);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(148, 20);
            this.Phone.TabIndex = 27;
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(228, 300);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(148, 20);
            this.Email.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(35, 295);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 23);
            this.label10.TabIndex = 28;
            this.label10.Text = "Email";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(35, 178);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 23);
            this.label11.TabIndex = 31;
            this.label11.Text = "Tenent ID";
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(228, 178);
            this.Description.Multiline = true;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Size = new System.Drawing.Size(224, 23);
            this.Description.TabIndex = 30;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(35, 94);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 23);
            this.label12.TabIndex = 32;
            this.label12.Text = "Address";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 385);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 23);
            this.label5.TabIndex = 35;
            this.label5.Text = "Renual Date";
            // 
            // RenualDate
            // 
            this.RenualDate.EditValue = null;
            this.RenualDate.Location = new System.Drawing.Point(228, 384);
            this.RenualDate.Name = "RenualDate";
            this.RenualDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.RenualDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.RenualDate.Size = new System.Drawing.Size(100, 20);
            this.RenualDate.TabIndex = 34;
            // 
            // RenualRate
            // 
            this.RenualRate.Location = new System.Drawing.Point(228, 435);
            this.RenualRate.Name = "RenualRate";
            this.RenualRate.Size = new System.Drawing.Size(148, 20);
            this.RenualRate.TabIndex = 37;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(35, 430);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 23);
            this.label13.TabIndex = 36;
            this.label13.Text = "Renual Rate";
            // 
            // Location
            // 
            this.Location.Location = new System.Drawing.Point(228, 60);
            this.Location.Name = "Location";
            this.Location.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Location.Size = new System.Drawing.Size(148, 20);
            this.Location.TabIndex = 38;
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(228, 94);
            this.Address.Multiline = true;
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(224, 44);
            this.Address.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 23);
            this.label6.TabIndex = 43;
            this.label6.Text = "Property ID";
            // 
            // PropertyId
            // 
            this.PropertyId.Location = new System.Drawing.Point(228, 248);
            this.PropertyId.Name = "PropertyId";
            this.PropertyId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.PropertyId.Size = new System.Drawing.Size(148, 20);
            this.PropertyId.TabIndex = 42;
            // 
            // DealType
            // 
            this.DealType.Location = new System.Drawing.Point(228, 466);
            this.DealType.Multiline = true;
            this.DealType.Name = "DealType";
            this.DealType.Size = new System.Drawing.Size(373, 42);
            this.DealType.TabIndex = 45;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(33, 467);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(116, 23);
            this.label14.TabIndex = 44;
            this.label14.Text = "Deal Type";
            // 
            // CopyDeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 565);
            this.Controls.Add(this.DealType);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PropertyId);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.Location);
            this.Controls.Add(this.RenualRate);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RenualDate);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.EffectiveTo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TenentId);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.Rent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EffectiveFrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.label1);
            ((System.ComponentModel.ISupportInitialize)(this.EffectiveFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EffectiveFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Type.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TenentId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EffectiveTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EffectiveTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RenualDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RenualDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Location.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PropertyId.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.DateEdit EffectiveFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown Rent;
        private DevExpress.XtraEditors.ComboBoxEdit Type;
        private System.Windows.Forms.Button Submit;
        private DevExpress.XtraEditors.TextEdit TenentId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.DateEdit EffectiveTo;
        private System.Windows.Forms.TextBox Phone;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Description;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.DateEdit RenualDate;
        private System.Windows.Forms.TextBox RenualRate;
        private System.Windows.Forms.Label label13;
        private DevExpress.XtraEditors.ComboBoxEdit Location;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.ComboBoxEdit PropertyId;
        private System.Windows.Forms.TextBox DealType;
        private System.Windows.Forms.Label label14;
    }
}