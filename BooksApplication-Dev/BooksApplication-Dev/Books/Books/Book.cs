using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    class Book
    {
        //variables
        private string isbn, title, author, year;
        private int numCopies;

        //generic constructor
        public Book()
        {
        }

        //constructor
        public Book(string theIsbn, string theTitle, string theAuthor, string theYear, string theNumCopies)
        {
            isbn = theIsbn;
            title = theTitle;
            author = theAuthor;
            year = theYear;
            //numCopies is done differently becasue they involve numbers
            SetNumCopies(theNumCopies);
        }

        //GETTERS
        public string GetIsbn()
        {
            return isbn;
        }

        public string GetTitle()
        {
            return title;
        }

        public string GetAuthor()
        {
            return author;
        }

        public string GetYear()
        {
            return year;
        }

        public int GetNumCopies()
        {
            return numCopies;
        }

        //SETTERS
        public void SetIsbn(string inIsbn)
        {
            try
            {
                isbn = inIsbn;
            }
            catch (FormatException e)
            {
                System.Windows.Forms.MessageBox.Show("ERROR:" + e.Message + " Please input valid ISBN");
                
            }
        }

        public void SetTitle(string inTitle)
        {
            try
            {
                title = inTitle;
            }
            catch (FormatException e)
            {
                System.Windows.Forms.MessageBox.Show("ERROR:" + e.Message + " Please input valid title");
                
            }
        }

        public void SetAuthor(string inAuthor)
        {
            try
            {
                author = inAuthor;
            }
            catch (FormatException e)
            {
                System.Windows.Forms.MessageBox.Show("ERROR:" + e.Message + " Please input valid author");
                
            }
        }

        public void SetYear(string inYear)
        {
            try
            {
                year = inYear;
            }
            catch (FormatException e)
            {
                System.Windows.Forms.MessageBox.Show("ERROR:" + e.Message + " Please input valid year");
            }
        }

        public void SetNumCopies(string inNumCopies)
        {
            try
            {
                numCopies = Convert.ToInt32(inNumCopies);
            }
            catch (FormatException e)
            {
                System.Windows.Forms.MessageBox.Show("ERROR:" + e.Message + " Please input valid number of copies");
                
            }
        }
    }
}
