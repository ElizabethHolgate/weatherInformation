namespace METOfficeSystem
{
    partial class FrmMain
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
            this.lstLocation = new System.Windows.Forms.ListBox();
            this.lstYear = new System.Windows.Forms.ListBox();
            this.lstMonths = new System.Windows.Forms.ListBox();
            this.lstMonthInfo = new System.Windows.Forms.ListBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnViewLocation = new System.Windows.Forms.Button();
            this.btnEditLocation = new System.Windows.Forms.Button();
            this.btnEditYear = new System.Windows.Forms.Button();
            this.btnAddLocation = new System.Windows.Forms.Button();
            this.btnAddYear = new System.Windows.Forms.Button();
            this.btnEditMonth = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSeachLoc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstLocation
            // 
            this.lstLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstLocation.FormattingEnabled = true;
            this.lstLocation.ItemHeight = 25;
            this.lstLocation.Location = new System.Drawing.Point(321, 97);
            this.lstLocation.Name = "lstLocation";
            this.lstLocation.Size = new System.Drawing.Size(202, 429);
            this.lstLocation.TabIndex = 0;
            this.lstLocation.SelectedIndexChanged += new System.EventHandler(this.lstLocation_SelectedIndexChanged);
            // 
            // lstYear
            // 
            this.lstYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstYear.FormattingEnabled = true;
            this.lstYear.ItemHeight = 25;
            this.lstYear.Location = new System.Drawing.Point(550, 97);
            this.lstYear.Name = "lstYear";
            this.lstYear.Size = new System.Drawing.Size(444, 429);
            this.lstYear.TabIndex = 1;
            this.lstYear.SelectedIndexChanged += new System.EventHandler(this.lstYear_SelectedIndexChanged);
            // 
            // lstMonths
            // 
            this.lstMonths.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMonths.FormattingEnabled = true;
            this.lstMonths.ItemHeight = 25;
            this.lstMonths.Location = new System.Drawing.Point(1021, 97);
            this.lstMonths.Name = "lstMonths";
            this.lstMonths.Size = new System.Drawing.Size(148, 429);
            this.lstMonths.TabIndex = 2;
            this.lstMonths.SelectedIndexChanged += new System.EventHandler(this.lstMonths_SelectedIndexChanged);
            // 
            // lstMonthInfo
            // 
            this.lstMonthInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMonthInfo.FormattingEnabled = true;
            this.lstMonthInfo.ItemHeight = 25;
            this.lstMonthInfo.Location = new System.Drawing.Point(1194, 97);
            this.lstMonthInfo.Name = "lstMonthInfo";
            this.lstMonthInfo.Size = new System.Drawing.Size(292, 254);
            this.lstMonthInfo.TabIndex = 3;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(61, 441);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(135, 30);
            this.txtSearch.TabIndex = 4;
            // 
            // btnViewLocation
            // 
            this.btnViewLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewLocation.Location = new System.Drawing.Point(61, 97);
            this.btnViewLocation.Name = "btnViewLocation";
            this.btnViewLocation.Size = new System.Drawing.Size(197, 36);
            this.btnViewLocation.TabIndex = 5;
            this.btnViewLocation.Text = "View Location";
            this.btnViewLocation.UseVisualStyleBackColor = true;
            this.btnViewLocation.Click += new System.EventHandler(this.btnViewLocation_Click);
            // 
            // btnEditLocation
            // 
            this.btnEditLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditLocation.Location = new System.Drawing.Point(61, 139);
            this.btnEditLocation.Name = "btnEditLocation";
            this.btnEditLocation.Size = new System.Drawing.Size(197, 36);
            this.btnEditLocation.TabIndex = 6;
            this.btnEditLocation.Text = "Edit Location";
            this.btnEditLocation.UseVisualStyleBackColor = true;
            this.btnEditLocation.Click += new System.EventHandler(this.btnEditLocation_Click);
            // 
            // btnEditYear
            // 
            this.btnEditYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditYear.Location = new System.Drawing.Point(61, 244);
            this.btnEditYear.Name = "btnEditYear";
            this.btnEditYear.Size = new System.Drawing.Size(197, 36);
            this.btnEditYear.TabIndex = 7;
            this.btnEditYear.Text = "Edit Year";
            this.btnEditYear.UseVisualStyleBackColor = true;
            // 
            // btnAddLocation
            // 
            this.btnAddLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddLocation.Location = new System.Drawing.Point(61, 181);
            this.btnAddLocation.Name = "btnAddLocation";
            this.btnAddLocation.Size = new System.Drawing.Size(197, 36);
            this.btnAddLocation.TabIndex = 8;
            this.btnAddLocation.Text = "Add Location";
            this.btnAddLocation.UseVisualStyleBackColor = true;
            // 
            // btnAddYear
            // 
            this.btnAddYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddYear.Location = new System.Drawing.Point(61, 286);
            this.btnAddYear.Name = "btnAddYear";
            this.btnAddYear.Size = new System.Drawing.Size(197, 36);
            this.btnAddYear.TabIndex = 9;
            this.btnAddYear.Text = "Add Year";
            this.btnAddYear.UseVisualStyleBackColor = true;
            // 
            // btnEditMonth
            // 
            this.btnEditMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditMonth.Location = new System.Drawing.Point(61, 352);
            this.btnEditMonth.Name = "btnEditMonth";
            this.btnEditMonth.Size = new System.Drawing.Size(197, 36);
            this.btnEditMonth.TabIndex = 10;
            this.btnEditMonth.Text = "Edit Month";
            this.btnEditMonth.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(209, 438);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(49, 36);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Go";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // lblSeachLoc
            // 
            this.lblSeachLoc.AutoSize = true;
            this.lblSeachLoc.Location = new System.Drawing.Point(61, 418);
            this.lblSeachLoc.Name = "lblSeachLoc";
            this.lblSeachLoc.Size = new System.Drawing.Size(122, 17);
            this.lblSeachLoc.TabIndex = 13;
            this.lblSeachLoc.Text = "Search Locations:";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 554);
            this.Controls.Add(this.lblSeachLoc);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnEditMonth);
            this.Controls.Add(this.btnAddYear);
            this.Controls.Add(this.btnAddLocation);
            this.Controls.Add(this.btnEditYear);
            this.Controls.Add(this.btnEditLocation);
            this.Controls.Add(this.btnViewLocation);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lstMonthInfo);
            this.Controls.Add(this.lstMonths);
            this.Controls.Add(this.lstYear);
            this.Controls.Add(this.lstLocation);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstLocation;
        private System.Windows.Forms.ListBox lstYear;
        private System.Windows.Forms.ListBox lstMonths;
        private System.Windows.Forms.ListBox lstMonthInfo;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnViewLocation;
        private System.Windows.Forms.Button btnEditLocation;
        private System.Windows.Forms.Button btnEditYear;
        private System.Windows.Forms.Button btnAddLocation;
        private System.Windows.Forms.Button btnAddYear;
        private System.Windows.Forms.Button btnEditMonth;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSeachLoc;
    }
}

