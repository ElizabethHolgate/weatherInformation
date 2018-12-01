using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace METOfficeSystem
{
    public partial class FrmEditLocation : Form
    {
        public static FrmEditLocation TempEditLocation = null;

        private Location editLoc = Data.locations[FrmMain.currentLoc];

        public FrmEditLocation()
        {
            InitializeComponent();

            TempEditLocation = this;
        }

        private void FrmEditLocation_Load(object sender, EventArgs e)
        {
            FillTextBoxes();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ReturnToMain();
        }

        private void FillTextBoxes()
        {
            txtLocationName.Text = editLoc.GetLocationName();
            txtStreetNameNum.Text = editLoc.GetStrtName();
            txtCounty.Text = editLoc.GetCounty();
            txtPostcode.Text = editLoc.GetPostCode();
            txtLatitude.Text = editLoc.GetLatitude().ToString();
            txtLongitude.Text = editLoc.GetLongitude().ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            FillTextBoxes();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            editLoc.SetLocationName(txtLocationName.Text);
            editLoc.SetStrtName(txtStreetNameNum.Text);
            editLoc.SetCounty(txtCounty.Text);
            editLoc.SetPostCode(txtPostcode.Text);
            editLoc.SetLatitude(txtLatitude.Text);
            editLoc.SetLongitude(txtLongitude.Text);

            ReturnToMain();
        }

        private void ReturnToMain()
        {
            FrmMain.KeepFrmMain.Show();
            TempEditLocation.Hide();
        }
    }
}
