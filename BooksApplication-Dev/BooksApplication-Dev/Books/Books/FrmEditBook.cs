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
    public partial class FrmEditBook : Form
    {
        public static FrmEditBook tempEditBook;

        public FrmEditBook()
        {
            tempEditBook = this;
            InitializeComponent();
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
            tempEditBook.Hide();
        }

        private void FrmEditBook_Load(object sender, EventArgs e)
        {
            fillTextBoxesLibrary();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            fillTextBoxesLibrary();
        }

        private void fillTextBoxesBook()
        {
            Book editBook = Data.bookstore[frmMainBookstore.currentBook];

            txtAuthor.Text = editBook.GetAuthor();
            txtTitle.Text = editBook.GetTitle();
            txtIsbn.Text = editBook.GetIsbn();
            txtNumCopies.Text = Convert.ToString(editBook.GetNumCopies());
            txtYear.Text = editBook.GetYear();
        }

        private void fillTextBoxesLibrary()
        {
            Library library = Data.libraries[frmMainBookstore.currentLibrary];
            Book[] editBkArr = library.getAllBooks();
            Book editBook = editBkArr[frmMainBookstore.currentBook];

            txtAuthor.Text = editBook.GetAuthor();
            txtTitle.Text = editBook.GetTitle();
            txtIsbn.Text = editBook.GetIsbn();
            txtNumCopies.Text = Convert.ToString(editBook.GetNumCopies());
            txtYear.Text = editBook.GetYear();
        }

        private void btnSaveBookEdit_Click(object sender, EventArgs e)
        {
            Book editBook = Data.bookstore[frmMainBookstore.currentBook];

            editBook.SetAuthor(txtAuthor.Text);
            editBook.SetTitle(txtTitle.Text);
            editBook.SetIsbn(txtIsbn.Text);
            editBook.SetNumCopies(txtNumCopies.Text);
            editBook.SetYear(txtYear.Text);

            ReturnToMain();
        }
    }
}
