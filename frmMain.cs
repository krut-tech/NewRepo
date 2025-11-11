using mobile_store.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using mobile_store.Helpers;

namespace mobile_store
{
    public partial class frmMain : Sample
    {
        public frmMain()
        {
            InitializeComponent();
        }

        // to access the frmMain values 
        static frmMain _obj;

        private void frmMain_Load(object sender, EventArgs e)
        {
            _obj = this;
        }

        public static frmMain Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new frmMain();
                }
                return _obj;
            }
        }

        private void AddControls(Form f)
        {
            Centerpanel.Controls.Clear();
            f.TopLevel = false;
            //  f.AutoScroll = true;
            Centerpanel.Controls.Add(f);
            // f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            f.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            AddControls(new frmDashboardView());
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            AddControls(new frmProductView());

        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            AddControls(new frmPOS());

        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            AddControls(new frmSettingView());

        }

        private void btnPrintInvoice_Click(object sender, EventArgs e)
        {
            int invoiceId = 1; // change this to the real mainID from tblMain
            var frm = new View.frmReportViewer(invoiceId);
            frm.ShowDialog();
        }

    }
}
