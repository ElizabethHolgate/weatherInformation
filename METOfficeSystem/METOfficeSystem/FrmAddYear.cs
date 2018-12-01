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
    public partial class FrmAddYear : Form
    {
        private FrmAddYear tempAddYear = null;

        public FrmAddYear()
        {
            InitializeComponent();
            tempAddYear = this;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FrmMain.KeepFrmMain.Show();
            tempAddYear.Hide();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtYearID.Text = "";
            txtYearDescrip.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int yearLength;

            Location location = Data.locations[FrmMain.currentLoc];
            Year[] yearsArr = location.GetAllYears();

            Year yearNew = new Year(txtYearID.Text, txtYearDescrip.Text);

            yearLength = yearsArr.Length;
            Array.Resize(ref yearsArr, yearLength + 1);
            yearsArr[yearLength] = yearNew;
        }
    }
}
