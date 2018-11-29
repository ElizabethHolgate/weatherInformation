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

namespace Books
{
    public partial class frmMainBookstore : Form
    {
        //create var for this form
        public static frmMainBookstore frmKeepBookstore = null;

        //vars for current book and library
        public static int currentBook = -1;
        public static int currentLibrary = 0;

        public frmMainBookstore()
        {
            InitializeComponent();
            //set var as this form;
            frmKeepBookstore = this;

            lstBooks.Items.Clear();
        }

        private void frmMainBookstore_Load(object sender, EventArgs e)
        {
            //call methods to set up and show books
            //setUpBookStore();
            setUpLibraries();            
            showListLibraries();
            showListBooks();
        }

        private void btnStockReport_Click(object sender, EventArgs e)
        {
            //call show books method
            lstBooks.Items.Clear();
            //showListBooks();
            showListLibraries();
        }

        //private void setUpBookStore()
        //{
        //    //variables
        //    string author, title, year, isbn, copies;
        //    int bkStSize;

        //    StreamReader getData = new StreamReader(@"books.txt");

        //    while (!getData.EndOfStream)
        //    {
        //        //read line of data from file
        //        author = getData.ReadLine();
        //        title = getData.ReadLine();
        //        year = getData.ReadLine();
        //        copies = getData.ReadLine();
        //        isbn = getData.ReadLine();

        //        Book nextBook = new Book(isbn, title, author, year, copies);

        //        if (Data.bookstore == null)
        //        {
        //            bkStSize = 0;
        //        }
        //        else
        //        {
        //            bkStSize = Data.bookstore.Length;
        //        }

        //        //resize array and add book to it
        //        Array.Resize(ref Data.bookstore, bkStSize + 1);
        //        Data.bookstore[bkStSize] = nextBook;
        //    }

        //}

        private void setUpLibraries()
        {
            string bkAuthor, bkTitle, bkYear, bkNumCopies, bkIsbn, libName, libNum, libStreet, libCity, libCounty, libPostcode, libEmail;
            int libNumTitles, libArrSize; 

            StreamReader getLibraries = new StreamReader(@"lib.txt");
            

            while (! getLibraries.EndOfStream)
            {
                //read in data about libraries
                libName = getLibraries.ReadLine();
                libNum = getLibraries.ReadLine();
                libStreet = getLibraries.ReadLine();
                libCity = getLibraries.ReadLine();
                libCounty = getLibraries.ReadLine();
                libPostcode = getLibraries.ReadLine();
                libEmail = getLibraries.ReadLine();
                libNumTitles = Convert.ToInt32(getLibraries.ReadLine());

                //create library object
                Library newLibrary = new Library(libName, libNum, libStreet, libCity, libCounty, libPostcode, libEmail, libNumTitles);

                Book[] bookCollection = new Book[libNumTitles];

                for (int i = 0; i < libNumTitles; i++)
                {
                    bkAuthor = getLibraries.ReadLine();
                    bkTitle = getLibraries.ReadLine();
                    bkYear = getLibraries.ReadLine();
                    bkNumCopies = getLibraries.ReadLine();
                    bkIsbn = getLibraries.ReadLine();

                    Book nextBook = new Book(bkIsbn, bkTitle, bkAuthor, bkYear, bkNumCopies);

                    bookCollection[i] = nextBook;
                }

                newLibrary.SetBooksLibrary(bookCollection);

                if (Data.libraries == null)
                {
                    libArrSize = 0;
                }
                else
                {
                    libArrSize = Data.libraries.Length;
                }

                //resize library array
                Array.Resize(ref Data.libraries, libArrSize + 1);
                Data.libraries[libArrSize] = newLibrary;
            }
            getLibraries.Close();
        }

        private void showListBooks()
        {            
            //show books in lstBooks
            lstBooks.Items.Clear();

            Book[] currentBookArray = Data.libraries[currentLibrary].getAllBooks();

            if (currentBookArray == null)
                lstBooks.Items.Add("no book");
            else
            {
                foreach (Book b in currentBookArray)
                {
                    lstBooks.Items.Add(b.GetTitle() + " by " + b.GetAuthor() + ". ISBN: " + b.GetIsbn() + ". Year: " + Convert.ToString(b.GetYear()));
                }
            }
        }

        private void showListLibraries()
        {
            lstLibs.Items.Clear();

            foreach (Library l in Data.libraries)
            {
                lstLibs.Items.Add(l.GetName());
                
            }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            //var for add book form
            frmAddBook tempAddNewBook = new frmAddBook();
            //show add book form
            tempAddNewBook.Show();
            //hide this form
            frmKeepBookstore.Hide();
        }

        private void btnEditBook_Click(object sender, EventArgs e)
        {
            FrmEditBook tempEditBook = new FrmEditBook();
            currentBook = lstBooks.SelectedIndex;
            currentLibrary = lstLibs.SelectedIndex;
            if ((currentBook < 0) || (currentLibrary < 0))
            {
                System.Windows.Forms.MessageBox.Show("ERROR! Please select the library and the book to edit proir to clicking 'Edit Book'.");
            }
            else
            {
                tempEditBook.Show();
                frmKeepBookstore.Hide();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAddLibrary_Click(object sender, EventArgs e)
        {
            FrmAddLibrary tempAddLibrary = new FrmAddLibrary();
            tempAddLibrary.Show();
            frmKeepBookstore.Hide();
        }

        private void btnEditLibrary_Click(object sender, EventArgs e)
        {
            FrmEditLibrary tempEditLibrary = new FrmEditLibrary();
            currentLibrary = lstLibs.SelectedIndex;
            if (currentLibrary < 0)
            {
                System.Windows.Forms.MessageBox.Show("ERROR! Please select library to edit proir to clicking 'Edit Library'.");

            }
            else
            {
                tempEditLibrary.Show();
                frmKeepBookstore.Hide();
            }
        }

        private void lstLibs_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentLibrary = lstLibs.SelectedIndex;
            showListBooks();
        }
    }
}
