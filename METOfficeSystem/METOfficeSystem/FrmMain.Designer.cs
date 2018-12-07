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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnEditLocation = new System.Windows.Forms.Button();
            this.btnEditYear = new System.Windows.Forms.Button();
            this.btnAddLocation = new System.Windows.Forms.Button();
            this.btnAddYear = new System.Windows.Forms.Button();
            this.btnEditMonth = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSeachLoc = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.dtgMonthInfo = new System.Windows.Forms.DataGridView();
            this.colMonthID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaxTemp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMinTemp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAirFrost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRainfall = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSunshine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSaveMonth = new System.Windows.Forms.Button();
            this.lstLocationInfo = new System.Windows.Forms.ListBox();
            this.txtLongitude = new System.Windows.Forms.TextBox();
            this.lblLong = new System.Windows.Forms.Label();
            this.txtLatitude = new System.Windows.Forms.TextBox();
            this.lblLat = new System.Windows.Forms.Label();
            this.txtPostcode = new System.Windows.Forms.TextBox();
            this.lblPostcode = new System.Windows.Forms.Label();
            this.txtCounty = new System.Windows.Forms.TextBox();
            this.lblCounty = new System.Windows.Forms.Label();
            this.lblStrtNameNum = new System.Windows.Forms.Label();
            this.lblLocationName = new System.Windows.Forms.Label();
            this.txtStreetNameNum = new System.Windows.Forms.TextBox();
            this.txtLocationName = new System.Windows.Forms.TextBox();
            this.grpEditLocation = new System.Windows.Forms.GroupBox();
            this.btnSaveLocation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMonthInfo)).BeginInit();
            this.grpEditLocation.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstLocation
            // 
            this.lstLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstLocation.FormattingEnabled = true;
            this.lstLocation.ItemHeight = 20;
            this.lstLocation.Location = new System.Drawing.Point(11, 162);
            this.lstLocation.Margin = new System.Windows.Forms.Padding(2);
            this.lstLocation.Name = "lstLocation";
            this.lstLocation.Size = new System.Drawing.Size(302, 204);
            this.lstLocation.TabIndex = 10;
            this.lstLocation.SelectedIndexChanged += new System.EventHandler(this.lstLocation_SelectedIndexChanged);
            // 
            // lstYear
            // 
            this.lstYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstYear.FormattingEnabled = true;
            this.lstYear.ItemHeight = 20;
            this.lstYear.Location = new System.Drawing.Point(11, 370);
            this.lstYear.Margin = new System.Windows.Forms.Padding(2);
            this.lstYear.Name = "lstYear";
            this.lstYear.Size = new System.Drawing.Size(302, 324);
            this.lstYear.TabIndex = 11;
            this.lstYear.SelectedIndexChanged += new System.EventHandler(this.lstYear_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(63, 77);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(102, 26);
            this.txtSearch.TabIndex = 8;
            // 
            // btnEditLocation
            // 
            this.btnEditLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditLocation.Location = new System.Drawing.Point(589, 505);
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
            this.btnEditYear.Location = new System.Drawing.Point(589, 592);
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
            this.btnAddLocation.Location = new System.Drawing.Point(589, 539);
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
            this.btnAddYear.Location = new System.Drawing.Point(589, 626);
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
            this.btnEditMonth.Location = new System.Drawing.Point(0, 0);
            this.btnEditMonth.Name = "btnEditMonth";
            this.btnEditMonth.Size = new System.Drawing.Size(75, 23);
            this.btnEditMonth.TabIndex = 16;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(174, 75);
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
            this.lblSeachLoc.Location = new System.Drawing.Point(63, 59);
            this.lblSeachLoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSeachLoc.Name = "lblSeachLoc";
            this.lblSeachLoc.Size = new System.Drawing.Size(44, 13);
            this.lblSeachLoc.TabIndex = 13;
            this.lblSeachLoc.Text = "Search:";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(556, 66);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(148, 29);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh Report";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // dtgMonthInfo
            // 
            this.dtgMonthInfo.AllowUserToAddRows = false;
            this.dtgMonthInfo.AllowUserToDeleteRows = false;
            this.dtgMonthInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMonthInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMonthID,
            this.colMaxTemp,
            this.colMinTemp,
            this.colAirFrost,
            this.colRainfall,
            this.colSunshine});
            this.dtgMonthInfo.Location = new System.Drawing.Point(318, 162);
            this.dtgMonthInfo.Name = "dtgMonthInfo";
            this.dtgMonthInfo.Size = new System.Drawing.Size(644, 300);
            this.dtgMonthInfo.TabIndex = 14;
            // 
            // colMonthID
            // 
            this.colMonthID.HeaderText = "Month ID";
            this.colMonthID.Name = "colMonthID";
            // 
            // colMaxTemp
            // 
            this.colMaxTemp.HeaderText = "Maximum Temperature";
            this.colMaxTemp.Name = "colMaxTemp";
            // 
            // colMinTemp
            // 
            this.colMinTemp.HeaderText = "Minimum Temperature";
            this.colMinTemp.Name = "colMinTemp";
            // 
            // colAirFrost
            // 
            this.colAirFrost.HeaderText = "Air Frost Days";
            this.colAirFrost.Name = "colAirFrost";
            // 
            // colRainfall
            // 
            this.colRainfall.HeaderText = "Rainfall (mm)";
            this.colRainfall.Name = "colRainfall";
            // 
            // colSunshine
            // 
            this.colSunshine.HeaderText = "Sunshine (hours)";
            this.colSunshine.Name = "colSunshine";
            // 
            // btnSaveMonth
            // 
            this.btnSaveMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveMonth.Location = new System.Drawing.Point(318, 66);
            this.btnSaveMonth.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveMonth.Name = "btnSaveMonth";
            this.btnSaveMonth.Size = new System.Drawing.Size(148, 29);
            this.btnSaveMonth.TabIndex = 15;
            this.btnSaveMonth.Text = "Save All Months";
            this.btnSaveMonth.UseVisualStyleBackColor = true;
            this.btnSaveMonth.Click += new System.EventHandler(this.btnSaveMonth_Click);
            // 
            // lstLocationInfo
            // 
            this.lstLocationInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstLocationInfo.FormattingEnabled = true;
            this.lstLocationInfo.ItemHeight = 20;
            this.lstLocationInfo.Location = new System.Drawing.Point(11, 698);
            this.lstLocationInfo.Margin = new System.Windows.Forms.Padding(2);
            this.lstLocationInfo.Name = "lstLocationInfo";
            this.lstLocationInfo.Size = new System.Drawing.Size(302, 204);
            this.lstLocationInfo.TabIndex = 17;
            // 
            // txtLongitude
            // 
            this.txtLongitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLongitude.Location = new System.Drawing.Point(205, 174);
            this.txtLongitude.Margin = new System.Windows.Forms.Padding(2);
            this.txtLongitude.Name = "txtLongitude";
            this.txtLongitude.Size = new System.Drawing.Size(121, 26);
            this.txtLongitude.TabIndex = 29;
            // 
            // lblLong
            // 
            this.lblLong.AutoSize = true;
            this.lblLong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLong.Location = new System.Drawing.Point(117, 180);
            this.lblLong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLong.Name = "lblLong";
            this.lblLong.Size = new System.Drawing.Size(84, 20);
            this.lblLong.TabIndex = 28;
            this.lblLong.Text = "Longitude:";
            // 
            // txtLatitude
            // 
            this.txtLatitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLatitude.Location = new System.Drawing.Point(205, 144);
            this.txtLatitude.Margin = new System.Windows.Forms.Padding(2);
            this.txtLatitude.Name = "txtLatitude";
            this.txtLatitude.Size = new System.Drawing.Size(121, 26);
            this.txtLatitude.TabIndex = 27;
            // 
            // lblLat
            // 
            this.lblLat.AutoSize = true;
            this.lblLat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLat.Location = new System.Drawing.Point(130, 150);
            this.lblLat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLat.Name = "lblLat";
            this.lblLat.Size = new System.Drawing.Size(71, 20);
            this.lblLat.TabIndex = 26;
            this.lblLat.Text = "Latitude:";
            // 
            // txtPostcode
            // 
            this.txtPostcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPostcode.Location = new System.Drawing.Point(205, 114);
            this.txtPostcode.Margin = new System.Windows.Forms.Padding(2);
            this.txtPostcode.Name = "txtPostcode";
            this.txtPostcode.Size = new System.Drawing.Size(121, 26);
            this.txtPostcode.TabIndex = 25;
            // 
            // lblPostcode
            // 
            this.lblPostcode.AutoSize = true;
            this.lblPostcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostcode.Location = new System.Drawing.Point(117, 120);
            this.lblPostcode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPostcode.Name = "lblPostcode";
            this.lblPostcode.Size = new System.Drawing.Size(84, 20);
            this.lblPostcode.TabIndex = 24;
            this.lblPostcode.Text = "Post code:";
            // 
            // txtCounty
            // 
            this.txtCounty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCounty.Location = new System.Drawing.Point(205, 84);
            this.txtCounty.Margin = new System.Windows.Forms.Padding(2);
            this.txtCounty.Name = "txtCounty";
            this.txtCounty.Size = new System.Drawing.Size(190, 26);
            this.txtCounty.TabIndex = 23;
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounty.Location = new System.Drawing.Point(138, 90);
            this.lblCounty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(63, 20);
            this.lblCounty.TabIndex = 22;
            this.lblCounty.Text = "County:";
            // 
            // lblStrtNameNum
            // 
            this.lblStrtNameNum.AutoSize = true;
            this.lblStrtNameNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStrtNameNum.Location = new System.Drawing.Point(7, 60);
            this.lblStrtNameNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStrtNameNum.Name = "lblStrtNameNum";
            this.lblStrtNameNum.Size = new System.Drawing.Size(194, 20);
            this.lblStrtNameNum.TabIndex = 21;
            this.lblStrtNameNum.Text = "Street Number and Name:";
            // 
            // lblLocationName
            // 
            this.lblLocationName.AutoSize = true;
            this.lblLocationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocationName.Location = new System.Drawing.Point(81, 30);
            this.lblLocationName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLocationName.Name = "lblLocationName";
            this.lblLocationName.Size = new System.Drawing.Size(120, 20);
            this.lblLocationName.TabIndex = 20;
            this.lblLocationName.Text = "Location Name:";
            // 
            // txtStreetNameNum
            // 
            this.txtStreetNameNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStreetNameNum.Location = new System.Drawing.Point(205, 54);
            this.txtStreetNameNum.Margin = new System.Windows.Forms.Padding(2);
            this.txtStreetNameNum.Name = "txtStreetNameNum";
            this.txtStreetNameNum.Size = new System.Drawing.Size(408, 26);
            this.txtStreetNameNum.TabIndex = 19;
            // 
            // txtLocationName
            // 
            this.txtLocationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocationName.Location = new System.Drawing.Point(205, 24);
            this.txtLocationName.Margin = new System.Windows.Forms.Padding(2);
            this.txtLocationName.Name = "txtLocationName";
            this.txtLocationName.Size = new System.Drawing.Size(285, 26);
            this.txtLocationName.TabIndex = 18;
            // 
            // grpEditLocation
            // 
            this.grpEditLocation.Controls.Add(this.txtLocationName);
            this.grpEditLocation.Controls.Add(this.lblLocationName);
            this.grpEditLocation.Controls.Add(this.lblLong);
            this.grpEditLocation.Controls.Add(this.txtLongitude);
            this.grpEditLocation.Controls.Add(this.lblLat);
            this.grpEditLocation.Controls.Add(this.btnSaveLocation);
            this.grpEditLocation.Controls.Add(this.lblPostcode);
            this.grpEditLocation.Controls.Add(this.lblStrtNameNum);
            this.grpEditLocation.Controls.Add(this.lblCounty);
            this.grpEditLocation.Controls.Add(this.txtLatitude);
            this.grpEditLocation.Controls.Add(this.txtStreetNameNum);
            this.grpEditLocation.Controls.Add(this.txtCounty);
            this.grpEditLocation.Controls.Add(this.txtPostcode);
            this.grpEditLocation.Location = new System.Drawing.Point(968, 34);
            this.grpEditLocation.Name = "grpEditLocation";
            this.grpEditLocation.Size = new System.Drawing.Size(622, 212);
            this.grpEditLocation.TabIndex = 30;
            this.grpEditLocation.TabStop = false;
            this.grpEditLocation.Text = "Edit Location";
            // 
            // btnSaveLocation
            // 
            this.btnSaveLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveLocation.Location = new System.Drawing.Point(495, 164);
            this.btnSaveLocation.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveLocation.Name = "btnSaveLocation";
            this.btnSaveLocation.Size = new System.Drawing.Size(122, 36);
            this.btnSaveLocation.TabIndex = 31;
            this.btnSaveLocation.Text = "Save Location";
            this.btnSaveLocation.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1605, 913);
            this.Controls.Add(this.lstLocationInfo);
            this.Controls.Add(this.btnSaveMonth);
            this.Controls.Add(this.dtgMonthInfo);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblSeachLoc);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnEditMonth);
            this.Controls.Add(this.btnAddYear);
            this.Controls.Add(this.btnAddLocation);
            this.Controls.Add(this.btnEditYear);
            this.Controls.Add(this.btnEditLocation);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lstYear);
            this.Controls.Add(this.lstLocation);
            this.Controls.Add(this.grpEditLocation);
            this.Name = "FrmMain";
            this.Text = "Weather Information";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgMonthInfo)).EndInit();
            this.grpEditLocation.ResumeLayout(false);
            this.grpEditLocation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstLocation;
        private System.Windows.Forms.ListBox lstYear;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnEditLocation;
        private System.Windows.Forms.Button btnEditYear;
        private System.Windows.Forms.Button btnAddLocation;
        private System.Windows.Forms.Button btnAddYear;
        private System.Windows.Forms.Button btnEditMonth;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSeachLoc;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.DataGridView dtgMonthInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMonthID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaxTemp;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMinTemp;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAirFrost;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRainfall;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSunshine;
        private System.Windows.Forms.Button btnSaveMonth;
        private System.Windows.Forms.ListBox lstLocationInfo;
        private System.Windows.Forms.TextBox txtLongitude;
        private System.Windows.Forms.Label lblLong;
        private System.Windows.Forms.TextBox txtLatitude;
        private System.Windows.Forms.Label lblLat;
        private System.Windows.Forms.TextBox txtPostcode;
        private System.Windows.Forms.Label lblPostcode;
        private System.Windows.Forms.TextBox txtCounty;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.Label lblStrtNameNum;
        private System.Windows.Forms.Label lblLocationName;
        private System.Windows.Forms.TextBox txtStreetNameNum;
        private System.Windows.Forms.TextBox txtLocationName;
        private System.Windows.Forms.GroupBox grpEditLocation;
        private System.Windows.Forms.Button btnSaveLocation;
    }
}

