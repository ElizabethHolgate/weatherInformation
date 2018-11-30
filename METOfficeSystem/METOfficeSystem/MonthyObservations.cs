using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace METOfficeSystem
{
    class MonthyObservations
    {
        private string monthID;
        private int maxTemp, minTemp, frostDays, mmRainfall, sunHours;

        public MonthyObservations()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:METOfficeSystem.MonthyObservations"/> class.
        /// </summary>
        /// <param name="theMonthID">The month identifier.</param>
        /// <param name="theMaxTemp">The max temp.</param>
        /// <param name="theMinTemp">The minimum temp.</param>
        /// <param name="theFrostDays">The frost days.</param>
        /// <param name="theMmRainfall">The mm rainfall.</param>
        /// <param name="theSunHours">The sun hours.</param>
        public MonthyObservations(string theMonthID, string theMaxTemp, string theMinTemp, string theFrostDays, string theMmRainfall, string theSunHours)
        {
            monthID = theMonthID;
            maxTemp = Convert.ToInt32(theMaxTemp);
            minTemp = Convert.ToInt32(theMinTemp);
            frostDays = Convert.ToInt32(theFrostDays);
            mmRainfall = Convert.ToInt32(theMmRainfall);
            sunHours = Convert.ToInt32(theSunHours);
        }

        //GETTERS

        /// <summary>
        /// Gets the month identifier.
        /// </summary>
        /// <returns>The month identifier.</returns>
        public string GetMonthID()
        {
            if (!String.IsNullOrEmpty(monthID))
            {
                return monthID;
            }
            else
            {
                return "ERROR";
            }

        }

        /// <summary>
        /// Gets the maximum temperature.
        /// </summary>
        /// <returns>The max temp.</returns>
        public int GetMaxTemp()
        {
            if (maxTemp != default(int))
            {
                return maxTemp;
            }
            else
            {
                return 1000;
            }
        }

        /// <summary>
        /// Gets the minimum temperature.
        /// </summary>
        /// <returns>The minimum temp.</returns>
        public int GetMinTemp()
        {
            if (minTemp != default(int))
            {
                return minTemp;
            }
            else
            {
                return -1000;
            }
        }

        /// <summary>
        /// Gets the number of airfrost days.
        /// </summary>
        /// <returns>The frost days.</returns>
        public int GetFrostDays()
        {
            if (frostDays != default(int))
            {
                return frostDays;
            }
            else
            {
                return 1000;
            }
        }

        /// <summary>
        /// Gets the millimeters of rainfall.
        /// </summary>
        /// <returns>The mm rainfall.</returns>
        public int GetMmRainfall()
        {
            if (mmRainfall != default(int))
            {
                return mmRainfall;
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// Gets the number of sunshine hours.
        /// </summary>
        /// <returns>The sun hours.</returns>
        public int GetSunHours()
        {
            return sunHours;
        }

        //SETTERS

        /// <summary>
        /// Sets the month identifier.
        /// </summary>
        /// <param name="inMonthID">In month identifier.</param>
        public void SetMonthID(string inMonthID)
        {
            try
            {
                monthID = inMonthID;
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("ERROR: " + e.Message + " Please input valid month ID");
            }
        }

        /// <summary>
        /// Sets the maximum temperature.
        /// </summary>
        /// <param name="inMaxTemp">In max temp.</param>
        public void SetMaxTemp(string inMaxTemp)
        {
            try
            {
                maxTemp = Convert.ToInt32(inMaxTemp);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("ERROR: " + e.Message + " Please input vaild maximum temperature");
            }
        }

        /// <summary>
        /// Sets the minimum temperature.
        /// </summary>
        /// <param name="inMinTemp">In minimum temp.</param>
        public void SetMinTemp(string inMinTemp)
        {
            try
            {
                minTemp = Convert.ToInt32(inMinTemp);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("ERROR: " + e.Message + " Please input vaild minimum temperature");
            }
        }

        /// <summary>
        /// Sets the number of airfrost days.
        /// </summary>
        /// <param name="inFrostDays">In frost days.</param>
        public void SetFrostDays(string inFrostDays)
        {
            try
            {
                frostDays = Convert.ToInt32(inFrostDays);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("ERROR: " + e.Message + " Please input valid number of air frost days");
            }
        }

        /// <summary>
        /// Sets the millimeters of rainfall.
        /// </summary>
        /// <param name="inMmRainfall">In mm rainfall.</param>
        public void SetMmRainfall(string inMmRainfall)
        {
            try
            {
                mmRainfall = Convert.ToInt32(inMmRainfall);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("ERROR: " + e.Message + " Please input vaild millimeters of rainfall");
            }
        }

        /// <summary>
        /// Sets the number of sunshine hours.
        /// </summary>
        /// <param name="inSunHours">In sun hours.</param>
        public void SetSunHours(string inSunHours)
        {
            try
            {
                sunHours = Convert.ToInt32(inSunHours);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("ERROR: " + e.Message + " Please input vaild number of sunshine hours");
            }
        }
    }
}
