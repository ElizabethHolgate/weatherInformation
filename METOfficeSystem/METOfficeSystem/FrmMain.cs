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
        public static string selectedFile;
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
            lblMeanOutput.Text = "";
        }

        public string SelectFile()
        {
            openFileDialog.ShowDialog();
            selectedFile = openFileDialog.FileName;

            return selectedFile;
        }

        /// <summary>
        /// Sets up weather info (data read in).
        /// </summary>
        private void SetUpWeatherInfo()
        {
            string userFile, locName, locStrtNameNum, locCounty, locPostcode, locLatitude, locLongitude, yearDescription, yearID, monthID, maxTemp, minTemp, airFrostDays, mmRainfall, sunHours;
            int numLocations, numLocationYears, locArrSize;

            //Hard coded stream reader for testing purposes
            StreamReader getData = new StreamReader(@"inputEXTENDED.txt");
            selectedFile = "inputEXTENDED.txt";

            //userFile = SelectFile();
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
                    newYear.SetMonthObserv(monthsInYear);

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

        //write data to file
        private void SaveDataToFile()
        {
            int yrLength;
            Location addLoc = new Location();
            Year[] yrArr = null;
            Year addYr = new Year();
            MonthyObservations[] monthArr = null;
            MonthyObservations addMonth = new MonthyObservations();

            StreamWriter sw = new StreamWriter(selectedFile, false, Encoding.ASCII);

            sw.WriteLine(Data.locations.Length);

            for (int l = 0; l < Data.locations.Length; l++)
            {
                addLoc = Data.locations[l];
                yrArr = addLoc.GetAllYears();

                if (yrArr == null)
                {
                    yrLength = 0;
                }
                else
                {
                    yrLength = yrArr.Length;
                }

                sw.WriteLine(addLoc.GetLocationName());
                sw.WriteLine(addLoc.GetStrtName());
                sw.WriteLine(addLoc.GetCounty());
                sw.WriteLine(addLoc.GetPostCode());
                sw.WriteLine(addLoc.GetLatitude());
                sw.WriteLine(addLoc.GetLongitude());
                sw.WriteLine(yrLength);

                for (int y = 0; y < yrLength; y++)
                {
                    addYr = yrArr[y];
                    monthArr = addYr.GetMonthObserv();
                    
                    sw.WriteLine(addYr.GetYrDescrip());

                    for (int m = 0; m < monthArr.Length; m++)
                    {
                        addMonth = monthArr[m];

                        sw.WriteLine(addYr.GetYear());
                        sw.WriteLine(addMonth.GetMonthID());
                        sw.WriteLine(addMonth.GetMaxTemp());
                        sw.WriteLine(addMonth.GetMinTemp());
                        sw.WriteLine(addMonth.GetFrostDays());
                        sw.WriteLine(addMonth.GetMmRainfall());
                        sw.WriteLine(addMonth.GetSunHours());
                    }
                }
            }

            sw.Close();
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
            currentLoc = -1;
            currentLoc = lstLocation.SelectedIndex;

            if (currentLoc < 0)
            {
                lstLocationInfo.Items.Add("No Location selected");
            }
            else if (currentLoc < Data.locations.Length)
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
            else
            {
                try
                {
                    lstLocationInfo.Items.Add(Data.locations[currentLoc].GetLocationName());
                }
                catch (Exception e)
                {
                    System.Windows.Forms.MessageBox.Show("ERROR: " + e.Message + " Please refresh the form and try again");
                    
                }
            }
        }

        /// <summary>
        /// Shows the years.
        /// </summary>
        private void ShowYears()
        {
            try
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
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("ERROR: " + e.Message + " Please refresh the form and try again");
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
                try
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
                catch (Exception e)
                {
                    System.Windows.Forms.MessageBox.Show("ERROR: " + e.Message + " Please ensure you have selected a year.");
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
            try
            {
                Location locToEdit = Data.locations[locEdit];

                locToEdit.SetLocationName(txtEditLocationName.Text);
                locToEdit.SetStrtName(txtEditStreetNameNum.Text);
                locToEdit.SetCounty(txtEditCounty.Text);
                locToEdit.SetPostCode(txtEditPostcode.Text);
                locToEdit.SetLatitude(txtEditLatitude.Text);
                locToEdit.SetLongitude(txtEditLongitude.Text);

                Data.locations[locEdit] = locToEdit;

                SaveDataToFile();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("ERROR: " + e.Message + " Please ensure all fields have been filled out correctly.");
            }
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SetCurrentYear();
            Search();
        }

        private void Search()
        {
            string userSearch;
            bool resultFound = false;

            userSearch = txtSearch.Text.ToLower();

            
                if (rdbSearchLocation.Checked)
                {
                    resultFound = SearchLocation(userSearch);
                }
                else if(rdbSearchYear.Checked)
                {
                    resultFound = SearchYear(userSearch);
                }
                else if(rdbSearchMonth.Checked)
                {
                    resultFound = SearchMonth(userSearch);
                }
                else
                {
                    lblSearchResult.Text = "Please select a catagory to search.";
                }
        }

        private bool SearchLocation(string userInput)
        {
            //variables
            string locName, nextMatch;
            int numLocs, locCount, locLength, currentPosition, amountLeft, findLength;
            bool found = false;

            //initialise variables
            numLocs = Data.locations.Length;
            locCount = 0;
            findLength = userInput.Length;

            while ((locCount < numLocs - 1) && (found == false))
            {
                locName = Data.locations[locCount].GetLocationName();
                locLength = locName.Length;
                currentPosition = 0;
                amountLeft = currentPosition - findLength - 1;

                if (findLength <= locLength)
                {
                    while ((amountLeft < locLength) && (found == false))
                    {
                        nextMatch = locName.Substring(currentPosition, findLength).ToLower();

                        if (nextMatch != userInput)
                        {
                            currentPosition++;
                            amountLeft = currentPosition + findLength;
                        }
                        else
                        {
                            lstLocation.SelectedIndex = locCount;
                            lblSearchResult.Text = string.Format("\"{0}\" is number {1} in the\n location list.", locName, locCount + 1);
                            found = true;
                            return found;
                        }
                    }
                }

                locCount++;
            }

            return found;
        }

        private bool SearchYear(string userInput)
        {
            string yearID, nextMatch;
            int numYears, yearCount, yearLength, currentPosition, amountLeft, findLength;
            bool found = false;
            Year[] yrArr = Data.locations[currentLoc].GetAllYears();

            numYears = yrArr.Length;
            yearCount = 0;
            findLength = userInput.Length;

            while ((yearCount < numYears - 1) && (found == false))
            {
                yearID = yrArr[yearCount].GetYear();
                yearLength = yearID.Length;
                currentPosition = 0;
                amountLeft = currentPosition - findLength - 1;

                if (findLength <= yearLength)
                {
                    while ((amountLeft < yearLength) && (found == false))
                    {
                        nextMatch = yearID.Substring(currentPosition, findLength).ToLower();

                        if (nextMatch != userInput)
                        {
                            currentPosition++;
                            amountLeft = currentPosition + findLength;
                        }
                        else
                        {
                            lstYear.SelectedIndex = yearCount;
                            lblSearchResult.Text = string.Format("\"{0}\" is number {1} in the\n year list.", yearID, yearCount + 1);
                            found = true;
                            return found;
                        }
                    }
                }

                yearCount++;
            }

            return found;
        }

        private bool SearchMonth(string userInput)
        {
            string monthID;
            bool found = false;

            if (currentLoc > 0 & currentYear > 0)
            {
                Year[] yrArr = Data.locations[currentLoc].GetAllYears();
                MonthyObservations[] monthArr = yrArr[currentYear].GetMonthObserv();
                MonthyObservations month = new MonthyObservations();

                for (int i = 0; i < monthArr.Length; i++)
                {
                    month = monthArr[i];
                    monthID = month.GetMonthID().ToLower();

                    if (userInput == monthID)
                    {
                        lblSearchResult.Text = string.Format("\"{0}\" is number {1} in the\n month data grid.", monthID, i + 1);
                        found = true;
                        return found;
                    }
                }
            }
            else
            {
                lblSearchResult.Text = "Please select location and year\n to search for month within";
            }
            
            return found;
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
                lstLocation.SelectedIndex = currentLoc;
                lstYear.Items.Clear();
                ShowYears();

                if (currentYear >= 0)
                {
                    lstYear.SelectedIndex = currentYear;
                    ShowMonths();
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshLists();
            System.Windows.Forms.MessageBox.Show("Form Refreshed!");
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
            SaveDataToFile();
        }

        /// <summary>
        /// Saves the edited month.
        /// </summary>
        private void SaveMonthEdit()
        {
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

            yearArray[currentYear].SetMonthObserv(monthArray);
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
            try
            {
                Year[] yearArray = Data.locations[locEdit].GetAllYears();
                Year editYear = yearArray[yearEdit];

                editYear.SetYrDescrip(txtYearDescrip.Text);

                yearArray[yearEdit] = editYear;
                Data.locations[locEdit].SetAllYears(yearArray);

                ClearEditYear();
                RefreshLists();

                SaveDataToFile();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("ERROR: " + e.Message + " Please ensure all fields have been filled out correctly.");
            }
            
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
            bool addLocInput;

            addLocInput = TestAddLocationInput();

            if (addLocInput == true)
            {
                Location newLoc = new Location(txtAddLocationName.Text, txtAddStrtNameNum.Text, txtAddCounty.Text, txtAddPostcode.Text, txtAddLatitude.Text, txtAddLongitude.Text);

                locArrLength = Data.locations.Length;
                Array.Resize(ref Data.locations, locArrLength + 1);
                Data.locations[locArrLength] = newLoc;

                SaveDataToFile();
            }
            else if (addLocInput == false)
            {
                System.Windows.Forms.MessageBox.Show("Please ensure all the values are entered correctly before clicking 'Add Location'.");
            }
            
        }

        private bool TestAddLocationInput()
        {
            bool textBoxesFull = false, name = true, street = true, county = true, postcode = true, lat = true, longitude = true;
            double latTry, longTry;

            if (String.IsNullOrEmpty(txtAddLocationName.Text))
            {
                name = false;
            }
            if (String.IsNullOrEmpty(txtAddStrtNameNum.Text))
            {
                street = false;
            }
            if (String.IsNullOrEmpty(txtAddCounty.Text))
            {
                county = false;
            }
            if (String.IsNullOrEmpty(txtAddPostcode.Text))
            {
                postcode = false;
            }
            if (String.IsNullOrEmpty(txtAddLatitude.Text))
            {
                lat = false;
            }
            else
            {
                if (double.TryParse(txtAddLatitude.Text, out latTry))
                {
                    lat = true;
                }
                else
                {
                    lat = false;
                }
            }
            if (String.IsNullOrEmpty(txtAddLongitude.Text))
            {
                if (double.TryParse(txtAddLongitude.Text, out longTry))
                {
                    longitude = true;
                }
                else
                {
                    longitude = false;
                }
            }

            if (name == false || street == false || county == false || postcode == false || lat == false || longitude == false)
            {
                textBoxesFull = false;
            }
            else
            {
                textBoxesFull = true;
            }

            return textBoxesFull;
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

        private bool TestAddYearInputs()
        {
            bool textBoxesFull = true;

            if (String.IsNullOrEmpty(txtAddYearID.Text))
            {
                textBoxesFull = false;
            }

            return textBoxesFull;
        }

        /// <summary>
        /// Adds the new year.
        /// </summary>
        private void AddYear()
        {
            int yearArrLength;
            Year[] yearArr = Data.locations[locEdit].GetAllYears();
            MonthyObservations[] monthArr = new MonthyObservations[12];
            

            Year newYear = new Year(txtAddYearID.Text, txtAddYearDescrip.Text);

            if (yearArr == null)
            {
                yearArrLength = 0;
            }
            else
            {
                yearArrLength = yearArr.Length;
            }

            for (int i = 0; i < monthArr.Length; i++)
            {
                MonthyObservations month = new MonthyObservations((i + 1).ToString(), "000", "000", "1000", "1000", "1000");

                monthArr[i] = month;
            }

            newYear.SetMonthObserv(monthArr);
            
            Array.Resize(ref yearArr, yearArrLength + 1);
            yearArr[yearArrLength] = newYear;

            Data.locations[locEdit].SetAllYears(yearArr);

            SaveDataToFile();
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

        private string CalculateMean(double[] numArr)
        {
            string answer;
            double numAnswer, sum = 0;

            foreach (double d in numArr)
            {
                sum =+ d;
            }

            numAnswer = sum / 12;
            answer = String.Format("{0:0.00}", numAnswer);

            return answer;
        }

        private double[] MinArray()
        {
            double num;
            Year[] yrArr = Data.locations[currentLoc].GetAllYears();
            MonthyObservations[] allMonths = yrArr[currentYear].GetMonthObserv();

            double[] minArr = new double[allMonths.Length];

            for (int i = 0; i < allMonths.Length; i++)
            {
                num = allMonths[i].GetMinTemp();
                minArr[i] = num;
            }

            return minArr;
        }

        private double[] MaxArray()
        {
            double num;
            Year[] yrArr = Data.locations[currentLoc].GetAllYears();
            MonthyObservations[] allMonths = yrArr[currentYear].GetMonthObserv();

            double[] maxArr = new double[allMonths.Length];

            for (int i = 0; i < allMonths.Length; i++)
            {
                num = allMonths[i].GetMaxTemp();
                maxArr[i] = num;
            }

            return maxArr;
        }

        private double[] AirFrostArray()
        {
            double num;
            Year[] yrArr = Data.locations[currentLoc].GetAllYears();
            MonthyObservations[] allMonths = yrArr[currentYear].GetMonthObserv();

            double[] airFrostArr = new double[allMonths.Length];

            for (int i = 0; i < allMonths.Length; i++)
            {
                num = allMonths[i].GetFrostDays();
                airFrostArr[i] = num;
            }

            return airFrostArr;
        }

        private double[] RainArray()
        {
            double num;
            Year[] yrArr = Data.locations[currentLoc].GetAllYears();
            MonthyObservations[] allMonths = yrArr[currentYear].GetMonthObserv();

            double[] rainArr = new double[allMonths.Length];

            for (int i = 0; i < allMonths.Length; i++)
            {
                num = allMonths[i].GetMmRainfall();
                rainArr[i] = num;
            }

            return rainArr;
        }

        private double[] SunArray()
        {
            double num;
            Year[] yrArr = Data.locations[currentLoc].GetAllYears();
            MonthyObservations[] allMonths = yrArr[currentYear].GetMonthObserv();

            double[]sunArr = new double[allMonths.Length];

            for (int i = 0; i < allMonths.Length; i++)
            {
                num = allMonths[i].GetSunHours();
                sunArr[i] = num;
            }

            return sunArr;
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            bool categoryChecked = false;
            string meanResult;
            double[] categoryArray = new double[12];

            SetCurrentYear();

            if (currentYear < 0 | currentLoc < 0)
            {
                System.Windows.Forms.MessageBox.Show("Please select the Location and Year proir to 'Edit Year'.");
            }
            else
            {
                if (rdbMaxTemp.Checked)
                {
                    categoryArray = MaxArray();
                    categoryChecked = true;
                }
                else if (rdbMinTemp.Checked)
                {
                    categoryArray = MinArray();
                    categoryChecked = true;
                }
                else if (rdbAirFrost.Checked)
                {
                    categoryArray = AirFrostArray();
                    categoryChecked = true;
                }
                else if (rdbRain.Checked)
                {
                    categoryArray = RainArray();
                    categoryChecked = true;
                }
                else if(rdbSunshine.Checked)
                {
                    categoryArray = SunArray();
                    categoryChecked = true;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Please select the cateogory you want to calculate statistics for.");
                }
            }

            if (categoryChecked == true)
            {
                meanResult = CalculateMean(categoryArray);
                lblMeanOutput.Text = meanResult;
            }
            
        }
    }
}
