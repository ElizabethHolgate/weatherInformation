using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace METOfficeSystem
{
    class Location
    {
        private string locationName, strtNameNum, county, postCode;
        private double latitude, longitude;
        private Year[] allYears;
        
        public Location()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:METOfficeSystem.Location"/> class.
        /// </summary>
        /// <param name="theLocationName">The location name.</param>
        /// <param name="theStrtNameNum">The street name and number.</param>
        /// <param name="theCounty">The county.</param>
        /// <param name="thePostCode">The post code.</param>
        /// <param name="theLatitude">The latitude.</param>
        /// <param name="theLongitude">The longitude.</param>
        public Location(string theLocationName, string theStrtNameNum, string theCounty, string thePostCode, string theLatitude, string theLongitude)
        {
            locationName = theLocationName;
            strtNameNum = theStrtNameNum;
            county = theCounty;
            postCode = thePostCode;
            latitude = Convert.ToDouble(theLatitude);
            longitude = Convert.ToDouble(theLongitude);
            allYears = null;
        }

        //GETTERS
        /// <summary>
        /// Gets the name of the location.
        /// </summary>
        /// <returns>The location name.</returns>
        public string GetLocationName()
        {
            if (!String.IsNullOrEmpty(locationName))
            {
                return locationName;
            }
            else 
            {
                return "ERROR";
            }
        }

        ///// <summary>
        ///// Gets the street number.
        ///// </summary>
        ///// <returns>The strt number.</returns>
        //public int GetStrtNum()
        //{
        //    return strtNum;
        //}

        /// <summary>
        /// Gets the street number and the name of the street.
        /// </summary>
        /// <returns>The strt name.</returns>
        public string GetStrtName()
        {
            if (!String.IsNullOrEmpty(strtNameNum))
            {
                return strtNameNum;
            }
            else
            {
                return "ERROR";
            }
        }

        /// <summary>
        /// Gets the county.
        /// </summary>
        /// <returns>The county.</returns>
        public string GetCounty()
        {
            if (!String.IsNullOrEmpty(county))
            {
                return county;
            }
            else
            {
                return "ERROR";
            }
        }

        /// <summary>
        /// Gets the post code.
        /// </summary>
        /// <returns>The post code.</returns>
        public string GetPostCode()
        {
            if (!String.IsNullOrEmpty(postCode))
            {
                return postCode;
            }
            else
            {
                return "ERROR";
            }
        }

        /// <summary>
        /// Gets the latitude.
        /// </summary>
        /// <returns>The latitude.</returns>
        public double GetLatitude()
        {
            return latitude;
        }

        /// <summary>
        /// Gets the longitude.
        /// </summary>
        /// <returns>The longitude.</returns>
        public double GetLongitude()
        {
            return longitude;
        }

        /// <summary>
        /// Gets all the year observations for the location.
        /// </summary>
        /// <returns>The all years.</returns>
        public Year[] GetAllYears()
        {
            return allYears;
        }

        //SETTERS

        /// <summary>
        /// Sets the name of the location.
        /// </summary>
        /// <param name="inLocationName">In location name.</param>
        public void SetLocationName(string inLocationName)
        {
            try
            {
                locationName = inLocationName;
            }
            catch (FormatException e)
            {
                System.Windows.Forms.MessageBox.Show("ERROR: " + e.Message + " Please input a vaild location name");
            }
        }

        ///// <summary>
        ///// Sets the street number.
        ///// </summary>
        ///// <param name="inStrtNum">In strt number.</param>
        //public void SetStrtNum(string inStrtNum)
        //{
        //    try
        //    {
        //        strtNum = Convert.ToInt32(inStrtNum);
        //    }
        //    catch (FormatException e)
        //    {
        //        System.Windows.Forms.MessageBox.Show("ERROR: " + e.Message + " Please input a vaild street number");
        //    }
        //}

        /// <summary>
        /// Sets the name of the street.
        /// </summary>
        /// <param name="inStrtName">In strt name.</param>
        public void SetStrtName(string inStrtNameNum)
        {
            try
            {
                strtNameNum = inStrtNameNum;
            }
            catch (FormatException e)
            {
                System.Windows.Forms.MessageBox.Show("ERROR: " + e.Message + " Please input a vaild street name");
            }
        }

        /// <summary>
        /// Sets the county.
        /// </summary>
        /// <param name="inCounty">In county.</param>
        public void SetCounty(string inCounty)
        {
            try
            {
                county = inCounty;
            }
            catch (FormatException e)
            {
                System.Windows.Forms.MessageBox.Show("ERROR: " + e.Message + " Please input a vaild county");
            }
        }

        /// <summary>
        /// Sets the post code.
        /// </summary>
        /// <param name="inPostCode">In post code.</param>
        public void SetPostCode(string inPostCode)
        {
            try
            {
                postCode = inPostCode;
            }
            catch (FormatException e)
            {
                System.Windows.Forms.MessageBox.Show("ERROR: " + e.Message + " Please input a vaild post code");
            }
        }

        /// <summary>
        /// Sets the latitude.
        /// </summary>
        /// <param name="inLatitude">In latitude.</param>
        public void SetLatitude(string inLatitude)
        {
            try
            {
                latitude = Convert.ToDouble(inLatitude);
            }
            catch (FormatException e)
            {
                System.Windows.Forms.MessageBox.Show("ERROR: " + e.Message + " Please input a vaild latitude");
            }
        }

        /// <summary>
        /// Sets the longitude. 
        /// </summary>
        /// <param name="inLongitude">In longitude.</param>
        public void SetLongitude(string inLongitude)
        {
            try
            {
                longitude = Convert.ToDouble(inLongitude);
            }
            catch (FormatException e)
            {
                System.Windows.Forms.MessageBox.Show("ERROR: " + e.Message + " Please input a vaild longitude");
            }
        }

        /// <summary>
        /// Sets all the year observations for that location.
        /// </summary>
        /// <param name="inAllYears">In all years.</param>
        public void SetAllYears(Year[] inAllYears)
        {
            try
            {
                allYears = inAllYears;
            }
            catch (FormatException e)
            {
                System.Windows.Forms.MessageBox.Show("ERROR: " + e.Message + " Please input a vaild array");
            }
        }
    }
}
