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
            this.btnLocEdit = new System.Windows.Forms.Button();
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
            this.txtEditLongitude = new System.Windows.Forms.TextBox();
            this.lblLong = new System.Windows.Forms.Label();
            this.txtEditLatitude = new System.Windows.Forms.TextBox();
            this.lblLat = new System.Windows.Forms.Label();
            this.txtEditPostcode = new System.Windows.Forms.TextBox();
            this.lblPostcode = new System.Windows.Forms.Label();
            this.txtEditCounty = new System.Windows.Forms.TextBox();
            this.lblCounty = new System.Windows.Forms.Label();
            this.lblStrtNameNum = new System.Windows.Forms.Label();
            this.lblLocationName = new System.Windows.Forms.Label();
            this.txtEditStreetNameNum = new System.Windows.Forms.TextBox();
            this.txtEditLocationName = new System.Windows.Forms.TextBox();
            this.grpEditLocation = new System.Windows.Forms.GroupBox();
            this.btnLocCancelEdit = new System.Windows.Forms.Button();
            this.btnLocResetEdit = new System.Windows.Forms.Button();
            this.btnLocSaveEdit = new System.Windows.Forms.Button();
            this.lblYearID = new System.Windows.Forms.Label();
            this.lblYearDescript = new System.Windows.Forms.Label();
            this.txtYearDescrip = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.grpEditYear = new System.Windows.Forms.GroupBox();
            this.btnYearCancel = new System.Windows.Forms.Button();
            this.btnYearReset = new System.Windows.Forms.Button();
            this.btnYearEdit = new System.Windows.Forms.Button();
            this.btnYearSave = new System.Windows.Forms.Button();
            this.grpAddLocation = new System.Windows.Forms.GroupBox();
            this.btnLocCancelAdd = new System.Windows.Forms.Button();
            this.txtAddLocationName = new System.Windows.Forms.TextBox();
            this.lblLocNameAdd = new System.Windows.Forms.Label();
            this.lblLongAdd = new System.Windows.Forms.Label();
            this.txtAddLongitude = new System.Windows.Forms.TextBox();
            this.lblLatAdd = new System.Windows.Forms.Label();
            this.lblPostcodeAdd = new System.Windows.Forms.Label();
            this.lblStrtNameNumAdd = new System.Windows.Forms.Label();
            this.lblCountyAdd = new System.Windows.Forms.Label();
            this.txtAddLatitude = new System.Windows.Forms.TextBox();
            this.txtAddStrtNameNum = new System.Windows.Forms.TextBox();
            this.txtAddCounty = new System.Windows.Forms.TextBox();
            this.btnLocAdd = new System.Windows.Forms.Button();
            this.txtAddPostcode = new System.Windows.Forms.TextBox();
            this.lblAddYearDescrip = new System.Windows.Forms.Label();
            this.txtAddYearDescrip = new System.Windows.Forms.TextBox();
            this.lblAddYearID = new System.Windows.Forms.Label();
            this.grpAddYear = new System.Windows.Forms.GroupBox();
            this.btnYearAdd = new System.Windows.Forms.Button();
            this.btnYearCancelAdd = new System.Windows.Forms.Button();
            this.txtAddYearID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMonthInfo)).BeginInit();
            this.grpEditLocation.SuspendLayout();
            this.grpEditYear.SuspendLayout();
            this.grpAddLocation.SuspendLayout();
            this.grpAddYear.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstLocation
            // 
            this.lstLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstLocation.FormattingEnabled = true;
            this.lstLocation.ItemHeight = 20;
            this.lstLocation.Location = new System.Drawing.Point(317, 34);
            this.lstLocation.Margin = new System.Windows.Forms.Padding(2);
            this.lstLocation.Name = "lstLocation";
            this.lstLocation.Size = new System.Drawing.Size(321, 204);
            this.lstLocation.TabIndex = 10;
            this.lstLocation.SelectedIndexChanged += new System.EventHandler(this.lstLocation_SelectedIndexChanged);
            // 
            // lstYear
            // 
            this.lstYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstYear.FormattingEnabled = true;
            this.lstYear.ItemHeight = 20;
            this.lstYear.Location = new System.Drawing.Point(10, 243);
            this.lstYear.Margin = new System.Windows.Forms.Padding(2);
            this.lstYear.Name = "lstYear";
            this.lstYear.Size = new System.Drawing.Size(302, 404);
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
            // btnLocEdit
            // 
            this.btnLocEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocEdit.Location = new System.Drawing.Point(5, 220);
            this.btnLocEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnLocEdit.Name = "btnLocEdit";
            this.btnLocEdit.Size = new System.Drawing.Size(122, 36);
            this.btnLocEdit.TabIndex = 3;
            this.btnLocEdit.Text = "Edit Location";
            this.btnLocEdit.UseVisualStyleBackColor = true;
            this.btnLocEdit.Click += new System.EventHandler(this.btnEditLocation_Click);
            // 
            // btnAddYear
            // 
            this.btnAddYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddYear.Location = new System.Drawing.Point(577, 589);
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
            this.btnRefresh.Location = new System.Drawing.Point(339, 584);
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
            this.dtgMonthInfo.Location = new System.Drawing.Point(317, 243);
            this.dtgMonthInfo.Name = "dtgMonthInfo";
            this.dtgMonthInfo.Size = new System.Drawing.Size(646, 300);
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
            this.btnSaveMonth.Location = new System.Drawing.Point(45, 184);
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
            this.lstLocationInfo.Location = new System.Drawing.Point(642, 34);
            this.lstLocationInfo.Margin = new System.Windows.Forms.Padding(2);
            this.lstLocationInfo.Name = "lstLocationInfo";
            this.lstLocationInfo.Size = new System.Drawing.Size(321, 204);
            this.lstLocationInfo.TabIndex = 17;
            // 
            // txtEditLongitude
            // 
            this.txtEditLongitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditLongitude.Location = new System.Drawing.Point(205, 174);
            this.txtEditLongitude.Margin = new System.Windows.Forms.Padding(2);
            this.txtEditLongitude.Name = "txtEditLongitude";
            this.txtEditLongitude.Size = new System.Drawing.Size(121, 26);
            this.txtEditLongitude.TabIndex = 29;
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
            // txtEditLatitude
            // 
            this.txtEditLatitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditLatitude.Location = new System.Drawing.Point(205, 144);
            this.txtEditLatitude.Margin = new System.Windows.Forms.Padding(2);
            this.txtEditLatitude.Name = "txtEditLatitude";
            this.txtEditLatitude.Size = new System.Drawing.Size(121, 26);
            this.txtEditLatitude.TabIndex = 27;
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
            // txtEditPostcode
            // 
            this.txtEditPostcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditPostcode.Location = new System.Drawing.Point(205, 114);
            this.txtEditPostcode.Margin = new System.Windows.Forms.Padding(2);
            this.txtEditPostcode.Name = "txtEditPostcode";
            this.txtEditPostcode.Size = new System.Drawing.Size(121, 26);
            this.txtEditPostcode.TabIndex = 25;
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
            // txtEditCounty
            // 
            this.txtEditCounty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditCounty.Location = new System.Drawing.Point(205, 84);
            this.txtEditCounty.Margin = new System.Windows.Forms.Padding(2);
            this.txtEditCounty.Name = "txtEditCounty";
            this.txtEditCounty.Size = new System.Drawing.Size(190, 26);
            this.txtEditCounty.TabIndex = 23;
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
            // txtEditStreetNameNum
            // 
            this.txtEditStreetNameNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditStreetNameNum.Location = new System.Drawing.Point(205, 54);
            this.txtEditStreetNameNum.Margin = new System.Windows.Forms.Padding(2);
            this.txtEditStreetNameNum.Name = "txtEditStreetNameNum";
            this.txtEditStreetNameNum.Size = new System.Drawing.Size(303, 26);
            this.txtEditStreetNameNum.TabIndex = 19;
            // 
            // txtEditLocationName
            // 
            this.txtEditLocationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditLocationName.Location = new System.Drawing.Point(205, 24);
            this.txtEditLocationName.Margin = new System.Windows.Forms.Padding(2);
            this.txtEditLocationName.Name = "txtEditLocationName";
            this.txtEditLocationName.Size = new System.Drawing.Size(248, 26);
            this.txtEditLocationName.TabIndex = 18;
            // 
            // grpEditLocation
            // 
            this.grpEditLocation.Controls.Add(this.btnLocCancelEdit);
            this.grpEditLocation.Controls.Add(this.btnLocResetEdit);
            this.grpEditLocation.Controls.Add(this.txtEditLocationName);
            this.grpEditLocation.Controls.Add(this.lblLocationName);
            this.grpEditLocation.Controls.Add(this.lblLong);
            this.grpEditLocation.Controls.Add(this.txtEditLongitude);
            this.grpEditLocation.Controls.Add(this.lblLat);
            this.grpEditLocation.Controls.Add(this.btnLocSaveEdit);
            this.grpEditLocation.Controls.Add(this.lblPostcode);
            this.grpEditLocation.Controls.Add(this.lblStrtNameNum);
            this.grpEditLocation.Controls.Add(this.lblCounty);
            this.grpEditLocation.Controls.Add(this.txtEditLatitude);
            this.grpEditLocation.Controls.Add(this.txtEditStreetNameNum);
            this.grpEditLocation.Controls.Add(this.txtEditCounty);
            this.grpEditLocation.Controls.Add(this.btnLocEdit);
            this.grpEditLocation.Controls.Add(this.txtEditPostcode);
            this.grpEditLocation.Location = new System.Drawing.Point(968, 34);
            this.grpEditLocation.Name = "grpEditLocation";
            this.grpEditLocation.Size = new System.Drawing.Size(515, 261);
            this.grpEditLocation.TabIndex = 30;
            this.grpEditLocation.TabStop = false;
            this.grpEditLocation.Text = "Edit Location";
            // 
            // btnLocCancelEdit
            // 
            this.btnLocCancelEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocCancelEdit.Location = new System.Drawing.Point(386, 220);
            this.btnLocCancelEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnLocCancelEdit.Name = "btnLocCancelEdit";
            this.btnLocCancelEdit.Size = new System.Drawing.Size(122, 36);
            this.btnLocCancelEdit.TabIndex = 43;
            this.btnLocCancelEdit.Text = "Cancel";
            this.btnLocCancelEdit.UseVisualStyleBackColor = true;
            this.btnLocCancelEdit.Click += new System.EventHandler(this.btnLocCancel_Click);
            // 
            // btnLocResetEdit
            // 
            this.btnLocResetEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocResetEdit.Location = new System.Drawing.Point(257, 220);
            this.btnLocResetEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnLocResetEdit.Name = "btnLocResetEdit";
            this.btnLocResetEdit.Size = new System.Drawing.Size(125, 36);
            this.btnLocResetEdit.TabIndex = 32;
            this.btnLocResetEdit.Text = "Reset Location";
            this.btnLocResetEdit.UseVisualStyleBackColor = true;
            this.btnLocResetEdit.Click += new System.EventHandler(this.btnLocReset_Click);
            // 
            // btnLocSaveEdit
            // 
            this.btnLocSaveEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocSaveEdit.Location = new System.Drawing.Point(131, 220);
            this.btnLocSaveEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnLocSaveEdit.Name = "btnLocSaveEdit";
            this.btnLocSaveEdit.Size = new System.Drawing.Size(122, 36);
            this.btnLocSaveEdit.TabIndex = 31;
            this.btnLocSaveEdit.Text = "Save Location";
            this.btnLocSaveEdit.UseVisualStyleBackColor = true;
            this.btnLocSaveEdit.Click += new System.EventHandler(this.btnSaveLocation_Click);
            // 
            // lblYearID
            // 
            this.lblYearID.AutoSize = true;
            this.lblYearID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYearID.Location = new System.Drawing.Point(142, 16);
            this.lblYearID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblYearID.Name = "lblYearID";
            this.lblYearID.Size = new System.Drawing.Size(75, 20);
            this.lblYearID.TabIndex = 41;
            this.lblYearID.Text = "lblYearID";
            // 
            // lblYearDescript
            // 
            this.lblYearDescript.AutoSize = true;
            this.lblYearDescript.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYearDescript.Location = new System.Drawing.Point(7, 43);
            this.lblYearDescript.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblYearDescript.Name = "lblYearDescript";
            this.lblYearDescript.Size = new System.Drawing.Size(131, 20);
            this.lblYearDescript.TabIndex = 40;
            this.lblYearDescript.Text = "Year Description:";
            // 
            // txtYearDescrip
            // 
            this.txtYearDescrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYearDescrip.Location = new System.Drawing.Point(142, 40);
            this.txtYearDescrip.Margin = new System.Windows.Forms.Padding(2);
            this.txtYearDescrip.Name = "txtYearDescrip";
            this.txtYearDescrip.Size = new System.Drawing.Size(366, 26);
            this.txtYearDescrip.TabIndex = 39;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(70, 18);
            this.lblYear.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(68, 20);
            this.lblYear.TabIndex = 38;
            this.lblYear.Text = "Year ID:";
            // 
            // grpEditYear
            // 
            this.grpEditYear.Controls.Add(this.btnYearCancel);
            this.grpEditYear.Controls.Add(this.btnYearReset);
            this.grpEditYear.Controls.Add(this.btnYearEdit);
            this.grpEditYear.Controls.Add(this.btnYearSave);
            this.grpEditYear.Controls.Add(this.lblYearID);
            this.grpEditYear.Controls.Add(this.lblYearDescript);
            this.grpEditYear.Controls.Add(this.txtYearDescrip);
            this.grpEditYear.Controls.Add(this.lblYear);
            this.grpEditYear.Location = new System.Drawing.Point(968, 311);
            this.grpEditYear.Name = "grpEditYear";
            this.grpEditYear.Size = new System.Drawing.Size(515, 128);
            this.grpEditYear.TabIndex = 42;
            this.grpEditYear.TabStop = false;
            this.grpEditYear.Text = "Edit Year";
            // 
            // btnYearCancel
            // 
            this.btnYearCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYearCancel.Location = new System.Drawing.Point(386, 87);
            this.btnYearCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnYearCancel.Name = "btnYearCancel";
            this.btnYearCancel.Size = new System.Drawing.Size(122, 36);
            this.btnYearCancel.TabIndex = 44;
            this.btnYearCancel.Text = "Cancel";
            this.btnYearCancel.UseVisualStyleBackColor = true;
            this.btnYearCancel.Click += new System.EventHandler(this.btnYearCancel_Click);
            // 
            // btnYearReset
            // 
            this.btnYearReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYearReset.Location = new System.Drawing.Point(260, 87);
            this.btnYearReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnYearReset.Name = "btnYearReset";
            this.btnYearReset.Size = new System.Drawing.Size(122, 36);
            this.btnYearReset.TabIndex = 44;
            this.btnYearReset.Text = "Reset Year";
            this.btnYearReset.UseVisualStyleBackColor = true;
            this.btnYearReset.Click += new System.EventHandler(this.btnYearReset_Click);
            // 
            // btnYearEdit
            // 
            this.btnYearEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYearEdit.Location = new System.Drawing.Point(8, 87);
            this.btnYearEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnYearEdit.Name = "btnYearEdit";
            this.btnYearEdit.Size = new System.Drawing.Size(122, 36);
            this.btnYearEdit.TabIndex = 32;
            this.btnYearEdit.Text = "Edit Year";
            this.btnYearEdit.UseVisualStyleBackColor = true;
            this.btnYearEdit.Click += new System.EventHandler(this.btnYearEdit_Click);
            // 
            // btnYearSave
            // 
            this.btnYearSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYearSave.Location = new System.Drawing.Point(134, 87);
            this.btnYearSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnYearSave.Name = "btnYearSave";
            this.btnYearSave.Size = new System.Drawing.Size(122, 36);
            this.btnYearSave.TabIndex = 43;
            this.btnYearSave.Text = "Save Year";
            this.btnYearSave.UseVisualStyleBackColor = true;
            this.btnYearSave.Click += new System.EventHandler(this.btnYearSave_Click);
            // 
            // grpAddLocation
            // 
            this.grpAddLocation.Controls.Add(this.btnLocCancelAdd);
            this.grpAddLocation.Controls.Add(this.txtAddLocationName);
            this.grpAddLocation.Controls.Add(this.lblLocNameAdd);
            this.grpAddLocation.Controls.Add(this.lblLongAdd);
            this.grpAddLocation.Controls.Add(this.txtAddLongitude);
            this.grpAddLocation.Controls.Add(this.lblLatAdd);
            this.grpAddLocation.Controls.Add(this.lblPostcodeAdd);
            this.grpAddLocation.Controls.Add(this.lblStrtNameNumAdd);
            this.grpAddLocation.Controls.Add(this.lblCountyAdd);
            this.grpAddLocation.Controls.Add(this.txtAddLatitude);
            this.grpAddLocation.Controls.Add(this.txtAddStrtNameNum);
            this.grpAddLocation.Controls.Add(this.txtAddCounty);
            this.grpAddLocation.Controls.Add(this.txtAddPostcode);
            this.grpAddLocation.Controls.Add(this.btnLocAdd);
            this.grpAddLocation.Location = new System.Drawing.Point(969, 445);
            this.grpAddLocation.Name = "grpAddLocation";
            this.grpAddLocation.Size = new System.Drawing.Size(514, 259);
            this.grpAddLocation.TabIndex = 43;
            this.grpAddLocation.TabStop = false;
            this.grpAddLocation.Text = "Add Location";
            // 
            // btnLocCancelAdd
            // 
            this.btnLocCancelAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocCancelAdd.Location = new System.Drawing.Point(385, 218);
            this.btnLocCancelAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnLocCancelAdd.Name = "btnLocCancelAdd";
            this.btnLocCancelAdd.Size = new System.Drawing.Size(122, 36);
            this.btnLocCancelAdd.TabIndex = 59;
            this.btnLocCancelAdd.Text = "Cancel";
            this.btnLocCancelAdd.UseVisualStyleBackColor = true;
            this.btnLocCancelAdd.Click += new System.EventHandler(this.btnLocCancelAdd_Click);
            // 
            // txtAddLocationName
            // 
            this.txtAddLocationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddLocationName.Location = new System.Drawing.Point(204, 22);
            this.txtAddLocationName.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddLocationName.Name = "txtAddLocationName";
            this.txtAddLocationName.Size = new System.Drawing.Size(248, 26);
            this.txtAddLocationName.TabIndex = 45;
            // 
            // lblLocNameAdd
            // 
            this.lblLocNameAdd.AutoSize = true;
            this.lblLocNameAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocNameAdd.Location = new System.Drawing.Point(80, 28);
            this.lblLocNameAdd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLocNameAdd.Name = "lblLocNameAdd";
            this.lblLocNameAdd.Size = new System.Drawing.Size(120, 20);
            this.lblLocNameAdd.TabIndex = 47;
            this.lblLocNameAdd.Text = "Location Name:";
            // 
            // lblLongAdd
            // 
            this.lblLongAdd.AutoSize = true;
            this.lblLongAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLongAdd.Location = new System.Drawing.Point(116, 178);
            this.lblLongAdd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLongAdd.Name = "lblLongAdd";
            this.lblLongAdd.Size = new System.Drawing.Size(84, 20);
            this.lblLongAdd.TabIndex = 55;
            this.lblLongAdd.Text = "Longitude:";
            // 
            // txtAddLongitude
            // 
            this.txtAddLongitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddLongitude.Location = new System.Drawing.Point(204, 172);
            this.txtAddLongitude.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddLongitude.Name = "txtAddLongitude";
            this.txtAddLongitude.Size = new System.Drawing.Size(121, 26);
            this.txtAddLongitude.TabIndex = 56;
            // 
            // lblLatAdd
            // 
            this.lblLatAdd.AutoSize = true;
            this.lblLatAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLatAdd.Location = new System.Drawing.Point(129, 148);
            this.lblLatAdd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLatAdd.Name = "lblLatAdd";
            this.lblLatAdd.Size = new System.Drawing.Size(71, 20);
            this.lblLatAdd.TabIndex = 53;
            this.lblLatAdd.Text = "Latitude:";
            // 
            // lblPostcodeAdd
            // 
            this.lblPostcodeAdd.AutoSize = true;
            this.lblPostcodeAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostcodeAdd.Location = new System.Drawing.Point(116, 118);
            this.lblPostcodeAdd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPostcodeAdd.Name = "lblPostcodeAdd";
            this.lblPostcodeAdd.Size = new System.Drawing.Size(84, 20);
            this.lblPostcodeAdd.TabIndex = 51;
            this.lblPostcodeAdd.Text = "Post code:";
            // 
            // lblStrtNameNumAdd
            // 
            this.lblStrtNameNumAdd.AutoSize = true;
            this.lblStrtNameNumAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStrtNameNumAdd.Location = new System.Drawing.Point(6, 58);
            this.lblStrtNameNumAdd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStrtNameNumAdd.Name = "lblStrtNameNumAdd";
            this.lblStrtNameNumAdd.Size = new System.Drawing.Size(194, 20);
            this.lblStrtNameNumAdd.TabIndex = 48;
            this.lblStrtNameNumAdd.Text = "Street Number and Name:";
            // 
            // lblCountyAdd
            // 
            this.lblCountyAdd.AutoSize = true;
            this.lblCountyAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountyAdd.Location = new System.Drawing.Point(137, 88);
            this.lblCountyAdd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCountyAdd.Name = "lblCountyAdd";
            this.lblCountyAdd.Size = new System.Drawing.Size(63, 20);
            this.lblCountyAdd.TabIndex = 49;
            this.lblCountyAdd.Text = "County:";
            // 
            // txtAddLatitude
            // 
            this.txtAddLatitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddLatitude.Location = new System.Drawing.Point(204, 142);
            this.txtAddLatitude.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddLatitude.Name = "txtAddLatitude";
            this.txtAddLatitude.Size = new System.Drawing.Size(121, 26);
            this.txtAddLatitude.TabIndex = 54;
            // 
            // txtAddStrtNameNum
            // 
            this.txtAddStrtNameNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddStrtNameNum.Location = new System.Drawing.Point(204, 52);
            this.txtAddStrtNameNum.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddStrtNameNum.Name = "txtAddStrtNameNum";
            this.txtAddStrtNameNum.Size = new System.Drawing.Size(303, 26);
            this.txtAddStrtNameNum.TabIndex = 46;
            // 
            // txtAddCounty
            // 
            this.txtAddCounty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddCounty.Location = new System.Drawing.Point(204, 82);
            this.txtAddCounty.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddCounty.Name = "txtAddCounty";
            this.txtAddCounty.Size = new System.Drawing.Size(190, 26);
            this.txtAddCounty.TabIndex = 50;
            // 
            // btnLocAdd
            // 
            this.btnLocAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocAdd.Location = new System.Drawing.Point(259, 218);
            this.btnLocAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnLocAdd.Name = "btnLocAdd";
            this.btnLocAdd.Size = new System.Drawing.Size(122, 36);
            this.btnLocAdd.TabIndex = 44;
            this.btnLocAdd.Text = "Add Location";
            this.btnLocAdd.UseVisualStyleBackColor = true;
            this.btnLocAdd.Click += new System.EventHandler(this.btnLocAdd_Click);
            // 
            // txtAddPostcode
            // 
            this.txtAddPostcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddPostcode.Location = new System.Drawing.Point(204, 112);
            this.txtAddPostcode.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddPostcode.Name = "txtAddPostcode";
            this.txtAddPostcode.Size = new System.Drawing.Size(121, 26);
            this.txtAddPostcode.TabIndex = 52;
            // 
            // lblAddYearDescrip
            // 
            this.lblAddYearDescrip.AutoSize = true;
            this.lblAddYearDescrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddYearDescrip.Location = new System.Drawing.Point(7, 51);
            this.lblAddYearDescrip.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddYearDescrip.Name = "lblAddYearDescrip";
            this.lblAddYearDescrip.Size = new System.Drawing.Size(131, 20);
            this.lblAddYearDescrip.TabIndex = 46;
            this.lblAddYearDescrip.Text = "Year Description:";
            // 
            // txtAddYearDescrip
            // 
            this.txtAddYearDescrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddYearDescrip.Location = new System.Drawing.Point(142, 48);
            this.txtAddYearDescrip.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddYearDescrip.Name = "txtAddYearDescrip";
            this.txtAddYearDescrip.Size = new System.Drawing.Size(366, 26);
            this.txtAddYearDescrip.TabIndex = 45;
            // 
            // lblAddYearID
            // 
            this.lblAddYearID.AutoSize = true;
            this.lblAddYearID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddYearID.Location = new System.Drawing.Point(70, 26);
            this.lblAddYearID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddYearID.Name = "lblAddYearID";
            this.lblAddYearID.Size = new System.Drawing.Size(68, 20);
            this.lblAddYearID.TabIndex = 44;
            this.lblAddYearID.Text = "Year ID:";
            // 
            // grpAddYear
            // 
            this.grpAddYear.Controls.Add(this.txtAddYearID);
            this.grpAddYear.Controls.Add(this.btnYearCancelAdd);
            this.grpAddYear.Controls.Add(this.btnYearAdd);
            this.grpAddYear.Controls.Add(this.lblAddYearID);
            this.grpAddYear.Controls.Add(this.txtAddYearDescrip);
            this.grpAddYear.Controls.Add(this.lblAddYearDescrip);
            this.grpAddYear.Location = new System.Drawing.Point(968, 710);
            this.grpAddYear.Name = "grpAddYear";
            this.grpAddYear.Size = new System.Drawing.Size(515, 132);
            this.grpAddYear.TabIndex = 48;
            this.grpAddYear.TabStop = false;
            this.grpAddYear.Text = "Add Year";
            // 
            // btnYearAdd
            // 
            this.btnYearAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYearAdd.Location = new System.Drawing.Point(262, 91);
            this.btnYearAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnYearAdd.Name = "btnYearAdd";
            this.btnYearAdd.Size = new System.Drawing.Size(122, 36);
            this.btnYearAdd.TabIndex = 49;
            this.btnYearAdd.Text = "Add Year";
            this.btnYearAdd.UseVisualStyleBackColor = true;
            this.btnYearAdd.Click += new System.EventHandler(this.btnYearAdd_Click);
            // 
            // btnYearCancelAdd
            // 
            this.btnYearCancelAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYearCancelAdd.Location = new System.Drawing.Point(388, 91);
            this.btnYearCancelAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnYearCancelAdd.Name = "btnYearCancelAdd";
            this.btnYearCancelAdd.Size = new System.Drawing.Size(122, 36);
            this.btnYearCancelAdd.TabIndex = 60;
            this.btnYearCancelAdd.Text = "Cancel";
            this.btnYearCancelAdd.UseVisualStyleBackColor = true;
            // 
            // txtAddYearID
            // 
            this.txtAddYearID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddYearID.Location = new System.Drawing.Point(142, 18);
            this.txtAddYearID.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddYearID.Name = "txtAddYearID";
            this.txtAddYearID.Size = new System.Drawing.Size(114, 26);
            this.txtAddYearID.TabIndex = 61;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1493, 913);
            this.Controls.Add(this.grpAddYear);
            this.Controls.Add(this.grpAddLocation);
            this.Controls.Add(this.grpEditYear);
            this.Controls.Add(this.lstLocationInfo);
            this.Controls.Add(this.btnSaveMonth);
            this.Controls.Add(this.dtgMonthInfo);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblSeachLoc);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnEditMonth);
            this.Controls.Add(this.btnAddYear);
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
            this.grpEditYear.ResumeLayout(false);
            this.grpEditYear.PerformLayout();
            this.grpAddLocation.ResumeLayout(false);
            this.grpAddLocation.PerformLayout();
            this.grpAddYear.ResumeLayout(false);
            this.grpAddYear.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstLocation;
        private System.Windows.Forms.ListBox lstYear;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnLocEdit;
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
        private System.Windows.Forms.TextBox txtEditLongitude;
        private System.Windows.Forms.Label lblLong;
        private System.Windows.Forms.TextBox txtEditLatitude;
        private System.Windows.Forms.Label lblLat;
        private System.Windows.Forms.TextBox txtEditPostcode;
        private System.Windows.Forms.Label lblPostcode;
        private System.Windows.Forms.TextBox txtEditCounty;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.Label lblStrtNameNum;
        private System.Windows.Forms.Label lblLocationName;
        private System.Windows.Forms.TextBox txtEditStreetNameNum;
        private System.Windows.Forms.TextBox txtEditLocationName;
        private System.Windows.Forms.GroupBox grpEditLocation;
        private System.Windows.Forms.Button btnLocSaveEdit;
        private System.Windows.Forms.Label lblYearID;
        private System.Windows.Forms.Label lblYearDescript;
        private System.Windows.Forms.TextBox txtYearDescrip;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.GroupBox grpEditYear;
        private System.Windows.Forms.Button btnYearEdit;
        private System.Windows.Forms.Button btnYearSave;
        private System.Windows.Forms.Button btnLocResetEdit;
        private System.Windows.Forms.Button btnLocCancelEdit;
        private System.Windows.Forms.Button btnYearCancel;
        private System.Windows.Forms.Button btnYearReset;
        private System.Windows.Forms.GroupBox grpAddLocation;
        private System.Windows.Forms.Button btnLocCancelAdd;
        private System.Windows.Forms.TextBox txtAddLocationName;
        private System.Windows.Forms.Label lblLocNameAdd;
        private System.Windows.Forms.Label lblLongAdd;
        private System.Windows.Forms.TextBox txtAddLongitude;
        private System.Windows.Forms.Label lblLatAdd;
        private System.Windows.Forms.Label lblPostcodeAdd;
        private System.Windows.Forms.Label lblStrtNameNumAdd;
        private System.Windows.Forms.Label lblCountyAdd;
        private System.Windows.Forms.TextBox txtAddLatitude;
        private System.Windows.Forms.TextBox txtAddStrtNameNum;
        private System.Windows.Forms.TextBox txtAddCounty;
        private System.Windows.Forms.Button btnLocAdd;
        private System.Windows.Forms.TextBox txtAddPostcode;
        private System.Windows.Forms.Label lblAddYearDescrip;
        private System.Windows.Forms.TextBox txtAddYearDescrip;
        private System.Windows.Forms.Label lblAddYearID;
        private System.Windows.Forms.GroupBox grpAddYear;
        private System.Windows.Forms.TextBox txtAddYearID;
        private System.Windows.Forms.Button btnYearCancelAdd;
        private System.Windows.Forms.Button btnYearAdd;
    }
}

