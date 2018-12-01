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
    public partial class FrmEditYear : Form
    {
        private FrmEditYear tempEditYear = null;

        private static Location locEdit = Data.locations[FrmMain.currentLoc];
        private static Year[] yearArray = locEdit.GetAllYears();
        private Year editYear = yearArray[FrmMain.currentYear];

        public FrmEditYear()
        {
            InitializeComponent();
            tempEditYear = this;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FrmMain.KeepFrmMain.Show();
            tempEditYear.Hide();
        }

        private void FillTextBoxes()
        {
            lblYearID.Text = editYear.GetYear();
            txtYearDescrip.Text = editYear.GetYrDescrip();
        }

        private void FrmEditYear_Load(object sender, EventArgs e)
        {
            FillTextBoxes();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            FillTextBoxes();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            editYear.SetYrDescrip(txtYearDescrip.Text);
        }
    }
}
