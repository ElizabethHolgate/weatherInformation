using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace METOfficeSystem
{
    public partial class FrmMain : Form
    {
        //public vars for which location, year and month is selected
        /// <summary>
        /// The current location.
        /// </summary>
        public static int currentLoc = -1;
        /// <summary>
        /// The current year.
        /// </summary>
        public static int currentYear = -1;
        /// <summary>
        /// The current month.
        /// </summary>
        public static int currentMonth = -1;
        /// <summary>
        /// The location being edited.
        /// </summary>
        public static int locEdit = -1;
        /// <summary>
        /// The year being edited.
        /// </summary>
        public static int yearEdit = -1;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:METOfficeSystem.FrmMain"/> class.
        /// </summary>
        public FrmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Loads the main form.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">E.</param>
        private void FrmMain_Load(object sender, EventArgs e)
        {
            SetUpWeatherInfo();
            ShowLocations();
            lblYearID.Text = "";
        }

        /// <summary>
        /// Sets up weather info (data read in).
        /// </summary>
        private void SetUpWeatherInfo()
        {
            string userFile, locName, locStrtNameNum, locCounty, locPostcode, locLatitude, locLongitude, yearDescription, yearID, monthID, maxTemp, minTemp, airFrostDays, mmRainfall, sunHours;
            int numLocations, numLocationYears, locArrSize;

            StreamReader getData = new StreamReader(@"inputEXTENDED.txt");
            
            //openFileDialog.ShowDialog();
            //userFile = openFileDialog.FileName;
            //StreamReader getData = new StreamReader(@userFile);

            //read number of locations in data file
            numLocations = Convert.ToInt32(getData.ReadLine());

            while (!getData.EndOfStream)
            {
                //read in location data
                locName = getData.ReadLine();
                locStrtNameNum = getData.ReadLine();
                locCounty = getData.ReadLine();
                locPostcode = getData.ReadLine();
                locLatitude = getData.ReadLine();
                locLongitude = getData.ReadLine();
                numLocationYears = Convert.ToInt32(getData.ReadLine());

                //create location object and year array
                Location newLocation = new Location(locName, locStrtNameNum, locCounty, locPostcode, locLatitude, locLongitude);
                Year[] yearsInLocation = new Year[numLocationYears];

                //year loop
                for (int y = 0; y < numLocationYears; y++)
                {
                    //create array of month observations for that year
                    MonthyObservations[] monthsInYear = new MonthyObservations[12];

                    //get year description
                    yearDescription = getData.ReadLine();
                    Year newYear = new Year(yearDescription);

                    //month loop
                    for (int m = 0; m < 12; m++)
                    {
                        //read in data for month
                        yearID = getData.ReadLine();
                        monthID = getData.ReadLine();
                        maxTemp = getData.ReadLine();
                        minTemp = getData.ReadLine();
                        airFrostDays = getData.ReadLine();
                        mmRainfall = getData.ReadLine();
                        sunHours = getData.ReadLine();

                        //add data to month object
                        MonthyObservations newMonth = new MonthyObservations(monthID, maxTemp, minTemp, airFrostDays, mmRainfall, sunHours);

                        //add new month to array
                        monthsInYear[m] = newMonth;

                        newYear.SetYear(yearID);
                    }
                    //add months to year
                    newYear.SetYrObserv(monthsInYear);

                    //add new year to array of years
                    yearsInLocation[y] = newYear;
                    
                }
                //add year to location
                newLocation.SetAllYears(yearsInLocation);

                if (Data.locations == null)
                {
                    locArrSize = 0;
                }
                else
                {
                    locArrSize = Data.locations.Length;
                }

                //add location to array of locations
                Array.Resize(ref Data.locations, locArrSize + 1);
                Data.locations[locArrSize] = newLocation;
            }
            //close stream reader
            getData.Close();
        }

        /// <summary>
        /// Shows the locations.
        /// </summary>
        private void ShowLocations()
        {
            foreach (Location l in Data.locations)
            {
                lstLocation.Items.Add(l.GetLocationName());
            }
        }

        /// <summary>
        /// Shows the location information.
        /// </summary>
        private void ShowLocationInfo()
        {
            currentLoc = lstLocation.SelectedIndex;

            if (currentLoc < 0)
            {
                lstLocationInfo.Items.Add("No Location selected");
            }
            else
            {
                lstLocationInfo.Items.Add(Data.locations[currentLoc].GetLocationName());
                lstLocationInfo.Items.Add("");
                lstLocationInfo.Items.Add(Data.locations[currentLoc].GetStrtName());
                lstLocationInfo.Items.Add(Data.locations[currentLoc].GetCounty());
                lstLocationInfo.Items.Add(Data.locations[currentLoc].GetPostCode());
                lstLocationInfo.Items.Add("");
                lstLocationInfo.Items.Add("Coordinates:");
                lstLocationInfo.Items.Add(Data.locations[currentLoc].GetLatitude());
                lstLocationInfo.Items.Add(Data.locations[currentLoc].GetLongitude());
            }
        }

        /// <summary>
        /// Shows the years.
        /// </summary>
        private void ShowYears()
        {
            Year[] yearsInLoc = Data.locations[currentLoc].GetAllYears();

            lstYear.Items.Clear();

            if (yearsInLoc == null)
            {
                lstYear.Items.Add("No year data availble.");
            }
            else
            {
                foreach (Year y in yearsInLoc)
                {
                    lstYear.Items.Add(y.GetYear() + ": " + y.GetYrDescrip());
                }
            }
        }

        /// <summary>
        /// Shows the months.
        /// </summary>
        private void ShowMonths()
        {
            Year[] yearsInLoc = Data.locations[currentLoc].GetAllYears();
            
            if (yearsInLoc == null)
            {
                dtgMonthInfo.Rows[0].Cells[0].Value = "No month info";
            }
            else
            {
                MonthyObservations[] monthsInYear = yearsInLoc[currentYear].GetYearObserv();
                
                dtgMonthInfo.Rows.Clear();

                for (int i = 0; i < monthsInYear.Length; i++)
                {
                    MonthyObservations m = monthsInYear[i];

                    dtgMonthInfo.Rows.Add();
                    dtgMonthInfo.Rows[i].Cells[0].Value = m.GetMonthID();
                    dtgMonthInfo.Rows[i].Cells[1].Value = m.GetMaxTemp();
                    dtgMonthInfo.Rows[i].Cells[2].Value = m.GetMinTemp();
                    dtgMonthInfo.Rows[i].Cells[3].Value = m.GetFrostDays();
                    dtgMonthInfo.Rows[i].Cells[4].Value = m.GetMmRainfall();
                    dtgMonthInfo.Rows[i].Cells[5].Value = m.GetSunHours();
                }
            }
        }

        private void lstYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetCurrentYear();
            ShowMonths();
        }

        private void lstLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentLoc = lstLocation.SelectedIndex;
            lstLocationInfo.Items.Clear();
            lstYear.Items.Clear();
            ShowLocationInfo();
            ShowYears();
        }

        private void btnEditLocation_Click(object sender, EventArgs e)
        {
            locEdit = lstLocation.SelectedIndex;

            if (locEdit < 0)
            {
                System.Windows.Forms.MessageBox.Show("Please select a location prior to 'Edit Location'.");
            }
            else
            {
                FillEditLoc(locEdit);
            }
        }

        private void btnLocReset_Click(object sender, EventArgs e)
        {
            FillEditLoc(locEdit);
        }


        private void btnLocCancel_Click(object sender, EventArgs e)
        {
            ClearEditLoc();
        }

        /// <summary>
        /// Clears the edit location.
        /// </summary>
        private void ClearEditLoc()
        {
            txtEditLocationName.Text = "";
            txtEditStreetNameNum.Text = "";
            txtEditCounty.Text = "";
            txtEditPostcode.Text = "";
            txtEditLatitude.Text = "";
            txtEditLongitude.Text = "";
        }

        /// <summary>
        /// Fills the edit location.
        /// </summary>
        /// <param name="loc">Location.</param>
        private void FillEditLoc(int loc)
        {
            Location editLoc = Data.locations[loc];

            txtEditLocationName.Text = editLoc.GetLocationName();
            txtEditStreetNameNum.Text = editLoc.GetStrtName();
            txtEditCounty.Text = editLoc.GetCounty();
            txtEditPostcode.Text = editLoc.GetPostCode();
            txtEditLatitude.Text = editLoc.GetLatitude().ToString();
            txtEditLongitude.Text = editLoc.GetLongitude().ToString();
        }

        private void btnSaveLocation_Click(object sender, EventArgs e)
        {
            SaveEditLocation();
            ClearEditLoc();
            ShowLocations();
            ShowLocationInfo();
        }

        /// <summary>
        /// Saves the edited location.
        /// </summary>
        private void SaveEditLocation()
        {
            Location locToEdit = Data.locations[locEdit];

            locToEdit.SetLocationName(txtEditLocationName.Text);
            locToEdit.SetStrtName(txtEditStreetNameNum.Text);
            locToEdit.SetCounty(txtEditCounty.Text);
            locToEdit.SetPostCode(txtEditPostcode.Text);
            locToEdit.SetLatitude(txtEditLatitude.Text);
            locToEdit.SetLongitude(txtEditLongitude.Text);

            Data.locations[locEdit] = locToEdit;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string userSearch, locName, yrID;
            bool resultFound = false, searching = true;

            Location loc = new Location();
            Year year = new Year();
            
            userSearch = txtSearch.Text.ToUpper();

            while (searching == true)
            {
                for (int l = 0; l < Data.locations.Length; l++)
                {
                    loc = Data.locations[l];
                    locName = loc.GetLocationName().ToUpper();

                    if (userSearch == locName)
                    {
                        lstLocation.SelectedIndex = l;
                        resultFound = true;
                        searching = false;
                    }

                    //Year[] yearArr = loc.GetAllYears();

                    //for (int y = 0; y < yearArr.Length; y++)
                    //{
                    //    year = yearArr[y];
                    //    yrID = year.ToString().ToUpper();

                    //    if (userSearch == yrID)
                    //    {
                    //        lstLocation.SelectedIndex = l;
                    //        lstYear.SelectedIndex = y;
                    //        resultFound = true;
                    //        searching = false;
                    //    }
                    //}
                }

                
            }

            if (resultFound == false)
            {
                System.Windows.Forms.MessageBox.Show("No result found");
            }
            else
            {
                txtSearch.Clear();
            }
        }

        /// <summary>
        /// Refreshs the lists.
        /// </summary>
        private void RefreshLists()
        {
            SetCurrentYear();
            lstLocation.Items.Clear();
            
            ShowLocations();

            if (currentLoc >= 0)
            {
                lstYear.Items.Clear();
                ShowYears();

                if (currentYear >= 0)
                {
                    ShowMonths();
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshLists();
        }

        /// <summary>
        /// Sets the current year.
        /// </summary>
        private void SetCurrentYear()
        {
            currentLoc = lstLocation.SelectedIndex;
            currentYear = lstYear.SelectedIndex;
        }

        private void btnSaveMonth_Click(object sender, EventArgs e)
        {
            SetCurrentYear();
            SaveMonthEdit();
        }

        /// <summary>
        /// Saves the edited month.
        /// </summary>
        private void SaveMonthEdit()
        {
            Year[] yearArray = Data.locations[currentLoc].GetAllYears();
            MonthyObservations[] monthArray = yearArray[currentYear].GetYearObserv();

            for (int i = 0; i < monthArray.Length; i++)
            {
                monthArray[i].SetMonthID(dtgMonthInfo.Rows[i].Cells[0].Value.ToString());
                monthArray[i].SetMaxTemp(dtgMonthInfo.Rows[i].Cells[1].Value.ToString());
                monthArray[i].SetMinTemp(dtgMonthInfo.Rows[i].Cells[2].Value.ToString());
                monthArray[i].SetFrostDays(dtgMonthInfo.Rows[i].Cells[3].Value.ToString());
                monthArray[i].SetMmRainfall(dtgMonthInfo.Rows[i].Cells[4].Value.ToString());
                monthArray[i].SetSunHours(dtgMonthInfo.Rows[i].Cells[5].Value.ToString());
            }

            yearArray[currentYear].SetYrObserv(monthArray);
            Data.locations[currentLoc].SetAllYears(yearArray);
        }

        /// <summary>
        /// Sets the editLoc and editYear values.
        /// </summary>
        private void SetEditYear()
        {
            locEdit = lstLocation.SelectedIndex;
            yearEdit = lstYear.SelectedIndex;
        }

        /// <summary>
        /// Resets the editLoc and editYear values.
        /// </summary>
        private void ResetEditYear()
        {
            locEdit = -1;
            yearEdit = -1;
        }

        private void btnYearEdit_Click(object sender, EventArgs e)
        {
            SetEditYear();

            if (yearEdit < 0 | locEdit < 0)
            {
                System.Windows.Forms.MessageBox.Show("Please select the Location and Year proir to 'Edit Year'.");
            }
            else
            {
                FillEditYear();
            }
        }

        private void btnYearSave_Click(object sender, EventArgs e)
        {
            SaveEditYear();
            ResetEditYear();
            RefreshLists();
        }

        /// <summary>
        /// Saves the edited year.
        /// </summary>
        private void SaveEditYear()
        {
            Year[] yearArray = Data.locations[locEdit].GetAllYears();
            Year editYear = yearArray[yearEdit];

            editYear.SetYrDescrip(txtYearDescrip.Text);

            yearArray[yearEdit] = editYear;
            Data.locations[locEdit].SetAllYears(yearArray);

            ClearEditYear();
            RefreshLists();
        }

        private void btnYearReset_Click(object sender, EventArgs e)
        {
            FillEditYear();
        }

        private void btnYearCancel_Click(object sender, EventArgs e)
        {
            ClearEditYear();
            ResetEditYear();
        }

        /// <summary>
        /// Clears the edit year text fields.
        /// </summary>
        private void ClearEditYear()
        {
            lblYearID.Text = "";
            txtYearDescrip.Text = "";
        }

        /// <summary>
        /// Fills the edit year text fields.
        /// </summary>
        private void FillEditYear()
        {
            Year[] yearArray = Data.locations[locEdit].GetAllYears();
            Year editYear = yearArray[yearEdit];

            lblYearID.Text = editYear.GetYear();
            txtYearDescrip.Text = editYear.GetYrDescrip();
        }

        private void btnLocAdd_Click(object sender, EventArgs e)
        {
            AddLocation();
            ClearAddLocation();
            RefreshLists();
        }

        /// <summary>
        /// Clears the add location text fields.
        /// </summary>
        private void ClearAddLocation()
        {
            txtAddLocationName.Text = "";
            txtAddStrtNameNum.Text = "";
            txtAddCounty.Text = "";
            txtAddPostcode.Text = "";
            txtAddLatitude.Text = "";
            txtAddLongitude.Text = "";
        }

        /// <summary>
        /// Adds the new location.
        /// </summary>
        private void AddLocation()
        {
            int locArrLength;

            Location newLoc = new Location(txtAddLocationName.Text, txtAddStrtNameNum.Text, txtAddCounty.Text, txtAddPostcode.Text, txtAddLatitude.Text, txtAddLongitude.Text);

            locArrLength = Data.locations.Length;
            Array.Resize(ref Data.locations, locArrLength + 1);
            Data.locations[locArrLength] = newLoc;
        }

        private void btnLocCancelAdd_Click(object sender, EventArgs e)
        {
            ClearLocAdd();
        }

        /// <summary>
        /// Clears the location add text fields.
        /// </summary>
        private void ClearLocAdd()
        {
            txtAddLocationName.Text = "";
            txtAddStrtNameNum.Text = "";
            txtAddCounty.Text = "";
            txtAddPostcode.Text = "";
            txtAddLatitude.Text = "";
            txtAddLongitude.Text = "";
        }

        private void btnYearAdd_Click(object sender, EventArgs e)
        {
            SetCurrentYear();
            locEdit = lstLocation.SelectedIndex;

            if (locEdit < 0)
            {
                System.Windows.Forms.MessageBox.Show("Please select location to add year to.");
            }
            else
            {
                AddYear();
                ClearAddYear();
                ResetEditYear();
                RefreshLists();
            }
        }

        /// <summary>
        /// Adds the new year.
        /// </summary>
        private void AddYear()
        {
            int yearArrLength;

            Year[] yearArr = Data.locations[locEdit].GetAllYears();

            Year newYear = new Year(txtAddYearID.Text, txtAddYearDescrip.Text);

            yearArrLength = yearArr.Length;
            Array.Resize(ref yearArr, yearArrLength + 1);
            yearArr[yearArrLength] = newYear;

            Data.locations[locEdit].SetAllYears(yearArr);
        }

        /// <summary>
        /// Clears the add year text fields.
        /// </summary>
        private void ClearAddYear()
        {
            txtAddYearID.Text = "";
            txtAddYearDescrip.Text = "";
        }

        private void btnYearCancelAdd_Click(object sender, EventArgs e)
        {
            ClearAddYear();
            ResetEditYear();
        }
    }
}
