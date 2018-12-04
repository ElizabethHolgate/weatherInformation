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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstLocation
            // 
            this.lstLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstLocation.FormattingEnabled = true;
            this.lstLocation.ItemHeight = 20;
            this.lstLocation.Location = new System.Drawing.Point(213, 77);
            this.lstLocation.Margin = new System.Windows.Forms.Padding(2);
            this.lstLocation.Name = "lstLocation";
            this.lstLocation.Size = new System.Drawing.Size(152, 344);
            this.lstLocation.TabIndex = 10;
            this.lstLocation.SelectedIndexChanged += new System.EventHandler(this.lstLocation_SelectedIndexChanged);
            // 
            // lstYear
            // 
            this.lstYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstYear.FormattingEnabled = true;
            this.lstYear.ItemHeight = 20;
            this.lstYear.Location = new System.Drawing.Point(384, 77);
            this.lstYear.Margin = new System.Windows.Forms.Padding(2);
            this.lstYear.Name = "lstYear";
            this.lstYear.Size = new System.Drawing.Size(334, 344);
            this.lstYear.TabIndex = 11;
            this.lstYear.SelectedIndexChanged += new System.EventHandler(this.lstYear_SelectedIndexChanged);
            // 
            // lstMonths
            // 
            this.lstMonths.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMonths.FormattingEnabled = true;
            this.lstMonths.ItemHeight = 20;
            this.lstMonths.Location = new System.Drawing.Point(738, 77);
            this.lstMonths.Margin = new System.Windows.Forms.Padding(2);
            this.lstMonths.Name = "lstMonths";
            this.lstMonths.Size = new System.Drawing.Size(112, 344);
            this.lstMonths.TabIndex = 12;
            this.lstMonths.SelectedIndexChanged += new System.EventHandler(this.lstMonths_SelectedIndexChanged);
            // 
            // lstMonthInfo
            // 
            this.lstMonthInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMonthInfo.FormattingEnabled = true;
            this.lstMonthInfo.ItemHeight = 20;
            this.lstMonthInfo.Location = new System.Drawing.Point(868, 77);
            this.lstMonthInfo.Margin = new System.Windows.Forms.Padding(2);
            this.lstMonthInfo.Name = "lstMonthInfo";
            this.lstMonthInfo.Size = new System.Drawing.Size(220, 204);
            this.lstMonthInfo.TabIndex = 13;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(32, 395);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(102, 26);
            this.txtSearch.TabIndex = 8;
            // 
            // btnViewLocation
            // 
            this.btnViewLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewLocation.Location = new System.Drawing.Point(32, 131);
            this.btnViewLocation.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewLocation.Name = "btnViewLocation";
            this.btnViewLocation.Size = new System.Drawing.Size(148, 29);
            this.btnViewLocation.TabIndex = 2;
            this.btnViewLocation.Text = "View Location";
            this.btnViewLocation.UseVisualStyleBackColor = true;
            this.btnViewLocation.Click += new System.EventHandler(this.btnViewLocation_Click);
            // 
            // btnEditLocation
            // 
            this.btnEditLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditLocation.Location = new System.Drawing.Point(32, 165);
            this.btnEditLocation.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditLocation.Name = "btnEditLocation";
            this.btnEditLocation.Size = new System.Drawing.Size(148, 29);
            this.btnEditLocation.TabIndex = 3;
            this.btnEditLocation.Text = "Edit Location";
            this.btnEditLocation.UseVisualStyleBackColor = true;
            this.btnEditLocation.Click += new System.EventHandler(this.btnEditLocation_Click);
            // 
            // btnEditYear
            // 
            this.btnEditYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditYear.Location = new System.Drawing.Point(32, 252);
            this.btnEditYear.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditYear.Name = "btnEditYear";
            this.btnEditYear.Size = new System.Drawing.Size(148, 29);
            this.btnEditYear.TabIndex = 5;
            this.btnEditYear.Text = "Edit Year";
            this.btnEditYear.UseVisualStyleBackColor = true;
            this.btnEditYear.Click += new System.EventHandler(this.btnEditYear_Click);
            // 
            // btnAddLocation
            // 
            this.btnAddLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddLocation.Location = new System.Drawing.Point(32, 199);
            this.btnAddLocation.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddLocation.Name = "btnAddLocation";
            this.btnAddLocation.Size = new System.Drawing.Size(148, 29);
            this.btnAddLocation.TabIndex = 4;
            this.btnAddLocation.Text = "Add Location";
            this.btnAddLocation.UseVisualStyleBackColor = true;
            this.btnAddLocation.Click += new System.EventHandler(this.btnAddLocation_Click);
            // 
            // btnAddYear
            // 
            this.btnAddYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddYear.Location = new System.Drawing.Point(32, 286);
            this.btnAddYear.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddYear.Name = "btnAddYear";
            this.btnAddYear.Size = new System.Drawing.Size(148, 29);
            this.btnAddYear.TabIndex = 6;
            this.btnAddYear.Text = "Add Year";
            this.btnAddYear.UseVisualStyleBackColor = true;
            this.btnAddYear.Click += new System.EventHandler(this.btnAddYear_Click);
            // 
            // btnEditMonth
            // 
            this.btnEditMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditMonth.Location = new System.Drawing.Point(32, 332);
            this.btnEditMonth.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditMonth.Name = "btnEditMonth";
            this.btnEditMonth.Size = new System.Drawing.Size(148, 29);
            this.btnEditMonth.TabIndex = 7;
            this.btnEditMonth.Text = "Edit Month";
            this.btnEditMonth.UseVisualStyleBackColor = true;
            this.btnEditMonth.Click += new System.EventHandler(this.btnEditMonth_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(143, 393);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(37, 29);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Go";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblSeachLoc
            // 
            this.lblSeachLoc.AutoSize = true;
            this.lblSeachLoc.Location = new System.Drawing.Point(32, 377);
            this.lblSeachLoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSeachLoc.Name = "lblSeachLoc";
            this.lblSeachLoc.Size = new System.Drawing.Size(44, 13);
            this.lblSeachLoc.TabIndex = 13;
            this.lblSeachLoc.Text = "Search:";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(32, 77);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(148, 29);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh Report";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 450);
            this.Controls.Add(this.btnRefresh);
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
            this.Name = "FrmMain";
            this.Text = "Weather Information";
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
        private System.Windows.Forms.Button btnRefresh;
    }
}

