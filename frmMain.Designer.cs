partial class frmMain
{
    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
            this.lstDisplayEntries = new System.Windows.Forms.ListBox();
            this.btnDisplayAllEntries = new System.Windows.Forms.Button();
            this.btnFilterByZipCode = new System.Windows.Forms.Button();
            this.btnFilterByCity = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtCitySearch = new System.Windows.Forms.TextBox();
            this.txtZipCodeSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.radAscending = new System.Windows.Forms.RadioButton();
            this.radDescending = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lstDisplayEntries
            // 
            this.lstDisplayEntries.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDisplayEntries.FormattingEnabled = true;
            this.lstDisplayEntries.ItemHeight = 14;
            this.lstDisplayEntries.Location = new System.Drawing.Point(27, 47);
            this.lstDisplayEntries.Name = "lstDisplayEntries";
            this.lstDisplayEntries.Size = new System.Drawing.Size(425, 228);
            this.lstDisplayEntries.TabIndex = 0;
            // 
            // btnDisplayAllEntries
            // 
            this.btnDisplayAllEntries.Location = new System.Drawing.Point(557, 70);
            this.btnDisplayAllEntries.Name = "btnDisplayAllEntries";
            this.btnDisplayAllEntries.Size = new System.Drawing.Size(107, 23);
            this.btnDisplayAllEntries.TabIndex = 1;
            this.btnDisplayAllEntries.Text = "Display All Entries";
            this.btnDisplayAllEntries.UseVisualStyleBackColor = true;
            this.btnDisplayAllEntries.Click += new System.EventHandler(this.btnDisplayAllEntries_Click);
            // 
            // btnFilterByZipCode
            // 
            this.btnFilterByZipCode.Location = new System.Drawing.Point(557, 147);
            this.btnFilterByZipCode.Name = "btnFilterByZipCode";
            this.btnFilterByZipCode.Size = new System.Drawing.Size(107, 23);
            this.btnFilterByZipCode.TabIndex = 2;
            this.btnFilterByZipCode.Text = "Filter By Zip Code";
            this.btnFilterByZipCode.UseVisualStyleBackColor = true;
            this.btnFilterByZipCode.Click += new System.EventHandler(this.btnFilterByZipCode_Click);
            // 
            // btnFilterByCity
            // 
            this.btnFilterByCity.Location = new System.Drawing.Point(557, 221);
            this.btnFilterByCity.Name = "btnFilterByCity";
            this.btnFilterByCity.Size = new System.Drawing.Size(107, 23);
            this.btnFilterByCity.TabIndex = 3;
            this.btnFilterByCity.Text = "Filter By City";
            this.btnFilterByCity.UseVisualStyleBackColor = true;
            this.btnFilterByCity.Click += new System.EventHandler(this.btnFilterByCity_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(557, 284);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(107, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtCitySearch
            // 
            this.txtCitySearch.Location = new System.Drawing.Point(557, 195);
            this.txtCitySearch.Name = "txtCitySearch";
            this.txtCitySearch.Size = new System.Drawing.Size(107, 20);
            this.txtCitySearch.TabIndex = 5;
            // 
            // txtZipCodeSearch
            // 
            this.txtZipCodeSearch.Location = new System.Drawing.Point(557, 121);
            this.txtZipCodeSearch.Name = "txtZipCodeSearch";
            this.txtZipCodeSearch.Size = new System.Drawing.Size(107, 20);
            this.txtZipCodeSearch.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(475, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Filters";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Zip";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "State";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(128, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "City";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(273, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Latitude";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(373, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Longitude";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(475, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "None";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(475, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Zip Code:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(475, 198);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 15);
            this.label9.TabIndex = 15;
            this.label9.Text = "City:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(27, 304);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 15);
            this.label10.TabIndex = 16;
            this.label10.Text = "Display results:";
            // 
            // radAscending
            // 
            this.radAscending.AutoSize = true;
            this.radAscending.Location = new System.Drawing.Point(138, 302);
            this.radAscending.Name = "radAscending";
            this.radAscending.Size = new System.Drawing.Size(74, 17);
            this.radAscending.TabIndex = 17;
            this.radAscending.TabStop = true;
            this.radAscending.Text = "ascending";
            this.radAscending.UseVisualStyleBackColor = true;
            // 
            // radDescending
            // 
            this.radDescending.AutoSize = true;
            this.radDescending.Location = new System.Drawing.Point(231, 302);
            this.radDescending.Name = "radDescending";
            this.radDescending.Size = new System.Drawing.Size(80, 17);
            this.radDescending.TabIndex = 18;
            this.radDescending.TabStop = true;
            this.radDescending.Text = "descending";
            this.radDescending.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.ClientSize = new System.Drawing.Size(707, 341);
            this.Controls.Add(this.radDescending);
            this.Controls.Add(this.radAscending);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtZipCodeSearch);
            this.Controls.Add(this.txtCitySearch);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnFilterByCity);
            this.Controls.Add(this.btnFilterByZipCode);
            this.Controls.Add(this.btnDisplayAllEntries);
            this.Controls.Add(this.lstDisplayEntries);
            this.Name = "frmMain";
            this.RightToLeftLayout = true;
            this.Text = "Zip Code Filter";
            this.ResumeLayout(false);
            this.PerformLayout();

    }
    #endregion

    private System.Windows.Forms.ListBox lstDisplayEntries;
    private System.Windows.Forms.Button btnDisplayAllEntries;
    private System.Windows.Forms.Button btnFilterByZipCode;
    private System.Windows.Forms.Button btnFilterByCity;
    private System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.TextBox txtCitySearch;
    private System.Windows.Forms.TextBox txtZipCodeSearch;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.RadioButton radAscending;
    private System.Windows.Forms.RadioButton radDescending;
}