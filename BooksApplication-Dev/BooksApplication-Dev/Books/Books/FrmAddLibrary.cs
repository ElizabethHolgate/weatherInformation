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
    public partial class FrmAddLibrary : Form
    {
        public static FrmAddLibrary tempAddNewLibrary = null;

        public FrmAddLibrary()
        {
            InitializeComponent();
            tempAddNewLibrary = this;
        }

        private void ReturnToMain()
        {
            frmMainBookstore mainBookstore = new frmMainBookstore();
            mainBookstore.Show();
            tempAddNewLibrary.Hide();
        }

        private void btnReturnMainFrm_Click(object sender, EventArgs e)
        {
            ReturnToMain();
        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
            txtLibraryName.Text = "";
            txtEmail.Text = "";
            txtNumTitles.Text = "";
            txtLibStNum.Text = "";
            txtLibStreet.Text = "";
            txtLibCity.Text = "";
            txtLibCounty.Text = "";
            txtLibPostcode.Text = "";
        }

        private void btnSaveLibrary_Click(object sender, EventArgs e)
        {
            //variables
            String userName, userEmail, userStNum, userStreet, userCity, userCounty, userPostcode;
            int userNumTitles, libArrSize;

            userName = txtLibraryName.Text;
            userEmail = txtEmail.Text;
            userNumTitles = Convert.ToInt32(txtNumTitles.Text);

            userStNum = txtLibStNum.Text;
            userStreet = txtLibStreet.Text;
            userCity = txtLibCity.Text;
            userCounty = txtLibCounty.Text;
            userPostcode = txtLibPostcode.Text;

            libArrSize = Data.libraries.Length;
            Array.Resize(ref Data.libraries, libArrSize + 1);
            Data.libraries[libArrSize] = new Library(userName, userStNum, userStreet, userCity, userCounty, userPostcode, userEmail, userNumTitles);

            ReturnToMain();
        }
    }
}
