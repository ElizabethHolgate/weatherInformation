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
            setUpWeatherInfo();
            showLocations();
        }

        private void setUpWeatherInfo()
        {
            string locName, locStrtNameNum, locCounty, locPostcode, locLatitude, locLongitude, yearDescription, yearID, monthID, maxTemp, minTemp, airFrostDays, mmRainfall, sunHours;
            int numLocations, numLocationYears, locArrSize;

            StreamReader getData = new StreamReader(@"inputEXTENDED.txt");

            //read number of locations in data file
            numLocations = Convert.ToInt32(getData.ReadLine());

            while (!getData.EndOfStream)
            {
                //shall a put a for loop number locations <-----

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

            foreach (Year y in yearsInLoc)
            {
                lstYear.Items.Add(y.GetYear() + ": " + y.GetYrDescrip());
            }
        }

        private void showMonths()
        {
            Year[] yearsInLoc = Data.locations[currentLoc].GetAllYears();
            MonthyObservations[] monthsInYear = yearsInLoc[currentYear].GetYrObserv();

            lstMonths.Items.Clear();

            foreach (MonthyObservations m in monthsInYear)
            {
                lstMonths.Items.Add(m.GetMonthID());
            }
        }

        private void showMonthsInfo()
        {
            Year[] yearsInLoc = Data.locations[currentLoc].GetAllYears();
            MonthyObservations[] monthsInYear = yearsInLoc[currentYear].GetYrObserv();

            MonthyObservations m = monthsInYear[currentMonth];

            lstMonthInfo.Items.Clear();

            lstMonthInfo.Items.Add("Month ID: " + m.GetMonthID());
            lstMonthInfo.Items.Add("Maximum Temperature: " + m.GetMaxTemp());
            lstMonthInfo.Items.Add("Minimum Temperature: " + m.GetMinTemp());
            lstMonthInfo.Items.Add("Air Frost Days: " + m.GetFrostDays());
            lstMonthInfo.Items.Add("Rainfall in mm: " + m.GetMmRainfall());
            lstMonthInfo.Items.Add("Hours of Sunshine: " + m.GetSunHours());
        }

        private void lstYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentYear = lstYear.SelectedIndex;
            lstMonths.Items.Clear();
            lstMonthInfo.Items.Clear();
            showMonths();
        }

        private void lstLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentLoc = lstLocation.SelectedIndex;
            lstYear.Items.Clear();
            lstMonths.Items.Clear();
            lstMonthInfo.Items.Clear();
            showYears();
        }

        private void lstMonths_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentMonth = lstMonths.SelectedIndex;
            lstMonthInfo.Items.Clear();
            showMonthsInfo();
        }

        private void btnViewLocation_Click(object sender, EventArgs e)
        {
            //select current location
            currentLoc = lstLocation.SelectedIndex;

            if (currentLoc < 0)
            {
                System.Windows.Forms.MessageBox.Show("Please select the location prior to 'View Location'.");
            }
            else
            {
                Location locInfo = Data.locations[currentLoc];

                clearLstBoxes();

                lstYear.Items.Add(locInfo.GetLocationName());
                lstYear.Items.Add("");
                lstYear.Items.Add("Address:");
                lstYear.Items.Add(locInfo.GetStrtName());
                lstYear.Items.Add(locInfo.GetCounty());
                lstYear.Items.Add(locInfo.GetPostCode());
                lstYear.Items.Add("");
                lstYear.Items.Add("Coordinates:");
                lstYear.Items.Add(locInfo.GetLongitude());
                lstYear.Items.Add(locInfo.GetLatitude());
            }

            
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
            lstMonthInfo.Items.Clear();
            lstMonths.Items.Clear();
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

        private void btnEditMonth_Click(object sender, EventArgs e)
        {
            currentLoc = lstLocation.SelectedIndex;
            currentYear = lstYear.SelectedIndex;
            currentMonth = lstMonths.SelectedIndex;

            if (currentYear < 0 | currentLoc < 0 | currentMonth < 0)
            {
                System.Windows.Forms.MessageBox.Show("Please select a location, a year and a month proir to 'Edit Month'.");
            }
            else
            {
                FrmEditMonth frmEditMonth = new FrmEditMonth();

                frmEditMonth.Show();
                KeepFrmMain.Hide();

                lstMonthInfo.Items.Clear();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string userSearch;

            

            userSearch = txtSearch.Text;


        }
    }
}
