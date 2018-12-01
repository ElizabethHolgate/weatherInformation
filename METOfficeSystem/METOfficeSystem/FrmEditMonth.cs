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
    public partial class FrmEditMonth : Form
    {
        FrmEditMonth tempEditMonth = null;

        private static Location locEdit = Data.locations[FrmMain.currentLoc];
        private static Year[] yearArray = locEdit.GetAllYears();
        private static Year yearEdit = yearArray[FrmMain.currentYear];
        private static MonthyObservations[] monthArray = yearEdit.GetYrObserv();
        private static MonthyObservations editMonth = monthArray[FrmMain.currentMonth];

        public FrmEditMonth()
        {
            InitializeComponent();
            tempEditMonth = this;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ReturnToMain();
        }

        private void ReturnToMain()
        {
            FrmMain.KeepFrmMain.Show();
            tempEditMonth.Hide();
        }

        private void FillAllBoxes()
        {
            txtMonthID.Text = editMonth.GetMonthID();
            txtMaxTemp.Text = editMonth.GetMaxTemp().ToString();
            txtMinTemp.Text = editMonth.GetMinTemp().ToString();
            txtAirFrost.Text = editMonth.GetFrostDays().ToString();
            txtMmRain.Text = editMonth.GetMmRainfall().ToString();
            txtHoursSun.Text = editMonth.GetSunHours().ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            FillAllBoxes();
        }

        private void FrmEditMonth_Load(object sender, EventArgs e)
        {
            FillAllBoxes();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            editMonth.SetMonthID(txtMonthID.Text);
            editMonth.SetMaxTemp(txtMaxTemp.Text);
            editMonth.SetMinTemp(txtMinTemp.Text);
            editMonth.SetFrostDays(txtAirFrost.Text);
            editMonth.SetMmRainfall(txtMmRain.Text);
            editMonth.SetSunHours(txtHoursSun.Text);
            
            ReturnToMain();
        }
    }
}
