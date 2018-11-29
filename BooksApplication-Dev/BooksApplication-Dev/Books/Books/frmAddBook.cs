using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Books
{
    public partial class frmAddBook : Form
    {
        //create variable for this form
        public static frmAddBook tempAddBook;

        public frmAddBook()
        {
            InitializeComponent();
            //set variable to this form
            tempAddBook = this;
        }

        private void btnSaveBook_Click(object sender, EventArgs e)
        {
            //variables for inputs
            string userIsbn, userTitle, userAuthor, userYear, userNumCopies;
            int bkStSize;

            //assign text box data into user variables
            userIsbn = txtIsbn.Text;
            userTitle = txtTitle.Text;
            userAuthor = txtAuthor.Text;
            userYear = txtYear.Text;
            userNumCopies = txtNumCopies.Text;

            bkStSize = Data.bookstore.Length;
            Array.Resize(ref Data.bookstore, bkStSize + 1);
            Data.bookstore[bkStSize] = new Book(userIsbn, userTitle, userAuthor, userYear, userNumCopies);

            ReturnToMain();
        }

        private void btnCancelAddBook_Click(object sender, EventArgs e)
        {
            ReturnToMain();
        }

        private void ReturnToMain()
        {
            //create variable for mainBookStore form
            frmMainBookstore mainBookstore = new frmMainBookstore();
            //show that form
            mainBookstore.Show();
            //hide this form
            tempAddBook.Hide();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtIsbn.Text = "";
            txtTitle.Text = "";
            txtAuthor.Text = "";
            txtYear.Text = "";
            txtNumCopies.Text = "";
        }
    }
}
