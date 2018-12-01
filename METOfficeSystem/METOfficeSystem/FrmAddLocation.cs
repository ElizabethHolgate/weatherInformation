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
    public partial class FrmAddLocation : Form
    {
        private FrmAddLocation tempAddLocation = null;

        public FrmAddLocation()
        {
            InitializeComponent();
            tempAddLocation = this;
        }

        private void FrmAddLocation_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FrmMain.KeepFrmMain.Show();
            tempAddLocation.Hide();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtLocationName.Text = "";
            txtStreetNameNum.Text = "";
            txtCounty.Text = "";
            txtPostcode.Text = "";
            txtLatitude.Text = "";
            txtLongitude.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int locArrLength;

            Location locNew = new Location(txtLocationName.Text, txtStreetNameNum.Text, txtCounty.Text, txtPostcode.Text, txtLatitude.Text, txtLongitude.Text);
            
            locArrLength = Data.locations.Length;

            Array.Resize(ref Data.locations, locArrLength + 1);
            Data.locations[locArrLength] = locNew;
        }
    }
}
