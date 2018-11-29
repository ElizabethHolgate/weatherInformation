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
    public partial class FrmEditLibrary : Form
    {
        public static FrmEditLibrary tempEditLibrary; 
        private Library editLibrary = Data.libraries[frmMainBookstore.currentLibrary];

        public FrmEditLibrary()
        {
            InitializeComponent();
            tempEditLibrary = this;
        }

        private void ReturnToMain()
        {
            frmMainBookstore.frmKeepBookstore.Show();
            tempEditLibrary.Hide();
        }

        private void btnReturnMainFrm_Click(object sender, EventArgs e)
        {
            ReturnToMain();
        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
            fillTextBox();
        }

        private void fillTextBox()
        {
            txtLibraryName.Text = editLibrary.GetName();
            txtEmail.Text = editLibrary.GetEmail();
            txtNumTitles.Text = Convert.ToString(editLibrary.GetNumTitles());
            txtLibStNum.Text = editLibrary.GetStreetNum();
            txtLibStreet.Text = editLibrary.GetStreetName();
            txtLibCity.Text = editLibrary.GetCity();
            txtLibCounty.Text = editLibrary.GetCounty();
            txtLibPostcode.Text = editLibrary.GetPostCode();
        }

        private void FrmEditLibrary_Load(object sender, EventArgs e)
        {
            fillTextBox();
        }

        private void btnSaveEditedLibrary_Click(object sender, EventArgs e)
        {
            editLibrary.SetName(txtLibraryName.Text);
            editLibrary.SetEmail(txtEmail.Text);
            editLibrary.SetNumTitles(txtNumTitles.Text);
            editLibrary.SetStreetNum(txtLibStNum.Text);
            editLibrary.SetStreet(txtLibStreet.Text);
            editLibrary.SetCity(txtLibCity.Text);
            editLibrary.SetCounty(txtLibCounty.Text);
            editLibrary.SetPostCode(txtLibPostcode.Text);
        }
    }
}
