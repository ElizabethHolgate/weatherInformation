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

        public FrmEditLocation()
        {
            InitializeComponent();

            TempEditLocation = this;
        }

        private void FrmEditLocation_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FrmMain.KeepFrmMain.Show();
            TempEditLocation.Hide();
        }
    }
}
