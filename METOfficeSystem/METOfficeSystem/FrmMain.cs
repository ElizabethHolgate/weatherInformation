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
        //var for this form
        public static FrmMain KeepFrmMain = null;

        //public vars for which location, year and month is selected
        public static int currentLoc = -1;
        public static int currentYear = -1;
        public static int currentMonth = -1;

        public FrmMain()
        {
            InitializeComponent();
            KeepFrmMain = this;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            SetUpWeatherInfo();
            showLocations();
        }

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

        private void showLocations()
        {
            foreach (Location l in Data.locations)
            {
                lstLocation.Items.Add(l.GetLocationName());
            }
        }

        private void showYears()
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

        private void showMonths()
        {
            Year[] yearsInLoc = Data.locations[currentLoc].GetAllYears();
            
            if (yearsInLoc == null)
            {
                dtgMonthInfo.Rows[0].Cells[0].Value = "No month info";
            }
            else
            {
                MonthyObservations[] monthsInYear = yearsInLoc[currentYear].GetMonthObserv();
                
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
            currentLoc = lstLocation.SelectedIndex;
            currentYear = lstYear.SelectedIndex;
            showMonths();
        }

        private void lstLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentLoc = lstLocation.SelectedIndex;
            lstLocationInfo.Items.Clear();
            lstYear.Items.Clear();
            ShowLocationInfo();
            showYears();
        }

        private void lstMonths_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentLoc = lstLocation.SelectedIndex;
            currentYear = lstYear.SelectedIndex;
        }
        
        private void ShowLocationInfo()
        {
            currentLoc = lstLocation.SelectedIndex;

            Location locInfo = Data.locations[currentLoc];

            clearLstBoxes();

            lstLocationInfo.Items.Add(locInfo.GetLocationName());
            lstLocationInfo.Items.Add("");
            lstLocationInfo.Items.Add("Address:");
            lstLocationInfo.Items.Add(locInfo.GetStrtName());
            lstLocationInfo.Items.Add(locInfo.GetCounty());
            lstLocationInfo.Items.Add(locInfo.GetPostCode());
            lstLocationInfo.Items.Add("");
            lstLocationInfo.Items.Add("Coordinates:");
            lstLocationInfo.Items.Add(locInfo.GetLongitude());
            lstLocationInfo.Items.Add(locInfo.GetLatitude());
        }

        private void btnEditLocation_Click(object sender, EventArgs e)
        {
            currentLoc = lstLocation.SelectedIndex;

            if (currentLoc < 0)
            {
                System.Windows.Forms.MessageBox.Show("Please select a location prior to 'Edit Location'.");
            }
            else
            {
                FrmEditLocation frmEditLocation = new FrmEditLocation();

                frmEditLocation.Show();
                KeepFrmMain.Hide();

                clearLstBoxes();
            }
        }

        private void clearLstBoxes()
        {
            lstYear.Items.Clear();
        }

        private void btnAddLocation_Click(object sender, EventArgs e)
        {
            FrmAddLocation frmAddLocation = new FrmAddLocation();

            frmAddLocation.Show();
            KeepFrmMain.Hide();

            clearLstBoxes();
        }

        private void btnEditYear_Click(object sender, EventArgs e)
        {
            currentLoc = lstLocation.SelectedIndex;
            currentYear = lstYear.SelectedIndex;

            if (currentYear < 0 | currentLoc < 0)
            {
                System.Windows.Forms.MessageBox.Show("Please select a location and a year proir to 'Edit Year'.");
            }
            else if (currentYear > -1 & currentLoc > -1)
            {
                FrmEditYear frmEditYear = new FrmEditYear();

                frmEditYear.Show();
                KeepFrmMain.Hide();

                clearLstBoxes();
            }
        }

        private void btnAddYear_Click(object sender, EventArgs e)
        {
            currentLoc = lstLocation.SelectedIndex;

            if (currentLoc < 0)
            {
                System.Windows.Forms.MessageBox.Show("Please select a location to store the year in.");
            }
            else if (currentLoc > -1)
            {
                FrmAddYear frmAddYear = new FrmAddYear();

                frmAddYear.Show();
                KeepFrmMain.Hide();

                clearLstBoxes();
            }
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            currentLoc = lstLocation.SelectedIndex;
            currentYear = lstYear.SelectedIndex;

            lstLocation.Items.Clear();
            showLocations();

            if (currentLoc > 0)
            {
                lstYear.Items.Clear();
                showYears();

                if (currentYear > 0)
                {
                    showMonths();

                    if (currentMonth > 0)
                    {
                        
                    }
                }
            }
        }

        private void btnSaveMonth_Click(object sender, EventArgs e)
        {
            currentLoc = lstLocation.SelectedIndex;
            currentYear = lstYear.SelectedIndex;

            Year[] yearArray = Data.locations[currentLoc].GetAllYears();
            MonthyObservations[] monthArray = yearArray[currentYear].GetMonthObserv();

            for (int i = 0; i < monthArray.Length; i++)
            {
                monthArray[i].SetMonthID(dtgMonthInfo.Rows[i].Cells[0].Value.ToString());
                monthArray[i].SetMaxTemp(dtgMonthInfo.Rows[i].Cells[1].Value.ToString());
                monthArray[i].SetMinTemp(dtgMonthInfo.Rows[i].Cells[2].Value.ToString());
                monthArray[i].SetFrostDays(dtgMonthInfo.Rows[i].Cells[3].Value.ToString());
                monthArray[i].SetMmRainfall(dtgMonthInfo.Rows[i].Cells[4].Value.ToString());
                monthArray[i].SetSunHours(dtgMonthInfo.Rows[i].Cells[5].Value.ToString());
            }
            
        }
    }
}
