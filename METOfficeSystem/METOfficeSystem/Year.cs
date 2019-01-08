using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace METOfficeSystem
{
    class Year
    {
        private string yrDescrip;
        private string year; //change to a date/time
        private MonthyObservations[] monthObserv;

        public Year()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:METOfficeSystem.Year"/> class.
        /// </summary>
        /// <param name="theYear">The year.</param>
        /// <param name="theYrDescript">The yr descript.</param>
        public Year(string theYear, string theYrDescript)
        {
            year = theYear;
            yrDescrip = theYrDescript;
            monthObserv = null;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:METOfficeSystem.Year"/> class.
        /// </summary>
        /// <param name="theYrDescript"></param>
        public Year(string theYrDescript)
        {
            yrDescrip = theYrDescript;
        }

        //GETTERS
        /// <summary>
        /// Gets the year ID.
        /// </summary>
        /// <returns>The year.</returns>
        public string GetYear()
        {
            return year;
        }

        //don't if/else this because it's optional so it doens't matter if it's null
        /// <summary>
        /// Gets the year description.
        /// </summary>
        /// <returns>The yr descrip.</returns>
        public string GetYrDescrip()
        {
            return yrDescrip;
        }

        /// <summary>
        /// Gets the array of monthy observations for the year.
        /// </summary>
        /// <returns>The yr observ.</returns>
        public MonthyObservations[] GetMonthObserv()
        {
            return monthObserv;
        }

        //SETTERS

        /// <summary>
        /// Sets the year ID.
        /// </summary>
        /// <param name="inYear">In year.</param>
        public void SetYear(string inYear)
        {
            try
            {
                year = inYear;
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("ERROR: " + e.Message + " Please input a vaild year");
            }
        }

        /// <summary>
        /// Sets the year description.
        /// </summary>
        /// <param name="inYrDescrip">In yr descrip.</param>
        public void SetYrDescrip(string inYrDescrip)
        {
            try
            {
                yrDescrip = inYrDescrip;
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("ERROR: " + e.Message + " Please input a vaild year description");
            }
        }

        /// <summary>
        /// Sets the array of monthy observations for the year.
        /// </summary>
        /// <param name="inYrObserv">In yr observ.</param>
        public void SetMonthObserv(MonthyObservations[] inYrObserv)
        {
            try
            {
                monthObserv = inYrObserv;
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("ERROR: " + e.Message + " Please input valid array data");
            }
        }
    }
}
