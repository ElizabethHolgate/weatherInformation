using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    class Library
    {
        private string name, streetNum, street, city, county, postCode, email;
        private int numTitles;
        private Book[] allBooksLib;
        
        public Library()
        {
        }

        public Library(string libName, string libStreetNum, string libStreet, string libCity, string libCounty, string libPostCode, string libEmail, int libNumTitles)
        {
            name = libName;
            streetNum = libStreetNum;
            street = libStreet;
            city = libCity;
            county = libCounty;
            postCode = libPostCode;
            email = libEmail;
            numTitles = libNumTitles;
            allBooksLib = null;
        }

        public Library(string libName, string libStreetNum, string libStreet, string libCity, string libCounty, string libPostCode, string libEmail)
        {
            name = libName;
            streetNum = libStreetNum;
            street = libStreet;
            city = libCity;
            county = libCounty;
            postCode = libPostCode;
            email = libEmail;
            numTitles = 0;
            allBooksLib = null;
        }

        //GETTERS
        public string GetName()
        {
            return name;
        }

        public string GetStreetNum()
        {
            return streetNum;
        }

        public string GetStreetName()
        {
            return street;
        }

        public string GetCity()
        {
            return city;
        }

        public string GetCounty()
        {
            return county;
        }

        public string GetPostCode()
        {
            return postCode;
        }

        public string GetEmail()
        {
            return email;
        }

        public int GetNumTitles()
        {
            return numTitles;
        }
        public Book[] getAllBooks()
        {
            return allBooksLib;
        }

        //SETTERS
        public void SetName(string inName)
        {
            try
            {
                name = inName;
            }
            catch (FormatException e)
            {
                System.Windows.Forms.MessageBox.Show("ERROR:" + e.Message + " Please input valid name");
            }
        }

        public void SetStreetNum(string inStreetNum)
        {
            try
            {
                streetNum = inStreetNum;
            }
            catch (FormatException e)
            {
                System.Windows.Forms.MessageBox.Show("ERROR:" + e.Message + " Please input valid street number");
            }
        }

        public void SetStreet(string inStreet)
        {
            try
            {
                street = inStreet;
            }
            catch (FormatException e)
            {
                System.Windows.Forms.MessageBox.Show("ERROR:" + e.Message + " Please input vaild street name");
            }
        }

        public void SetCity(string inCity)
        {
            try
            {
                city = inCity;
            }
            catch (FormatException e)
            {
                System.Windows.Forms.MessageBox.Show("ERROR:" + e.Message + " Please input valid city");
            }
        }

        public void SetCounty(string inCounty)
        {
            try
            {
                county = inCounty;
            }
            catch (FormatException e)
            {
                System.Windows.Forms.MessageBox.Show("ERROR:" + e.Message + " Please input valid county");
            }
        }

        public void SetPostCode(string inPostCode)
        {
            try
            {
                postCode = inPostCode;
            }
            catch (FormatException e)
            {
                System.Windows.Forms.MessageBox.Show("ERROR:" + e.Message + " Please input valid post code");
            }
        }

        public void SetEmail(string inEmail)
        {
            try
            {
                email = inEmail;
            }
            catch (FormatException e)
            {
                System.Windows.Forms.MessageBox.Show("ERROR:" + e.Message + " Please input valid email");
            }
        } //SetNumTitles, SetBooksLibrary

        public void SetNumTitles(string inNumTitles)
        {
            try
            {
                numTitles = Convert.ToInt32(inNumTitles);
            }
            catch (FormatException e)
            {
                System.Windows.Forms.MessageBox.Show("ERROR:" + e.Message + " Please input valid number of titles");
            }
        }

        public void SetBooksLibrary(Book[] inBooksLibrary)
        {
            try
            {
                allBooksLib = inBooksLibrary;
            }
            catch (FormatException e)
            {
                System.Windows.Forms.MessageBox.Show("ERROR:" + e.Message + " Please input valid books in library");
            }
        }
    }
}
