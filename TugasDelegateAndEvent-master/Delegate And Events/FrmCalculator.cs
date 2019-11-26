using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegate_And_Events
{
    public partial class FrmCalculator : Form
    {
        private IList<Calculator> listPerhitungan = new List<Calculator>();
        public FrmCalculator()
        {
            InitializeComponent();
        }

        private void FrmEntry_OnCreate(Calculator cal)
        {
            listPerhitungan.Add(cal);
            lstHasil.Items.Add(cal.Hasil);
        }
        private void BtnHitung_Click(object sender, EventArgs e)
        {
            FrmEntry frmEntryData = new FrmEntry();
            frmEntryData.OnCreate += FrmEntry_OnCreate;
            frmEntryData.ShowDialog();
        }

        private void LstHasil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
