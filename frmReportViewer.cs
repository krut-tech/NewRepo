using mobile_store.Helpers;
using System;
using System.Windows.Forms;

namespace mobile_store.View
{
    public partial class frmReportViewer : Form
    {
        public frmReportViewer(int invoiceId = 1)
        {
            InitializeComponent();
            Load += (s, e) =>
            {
                // ✅ Use the new 2-parameter version
                ReportHelper.LoadInvoiceReport(invoiceId, null);

                // Optional: close the form automatically after saving the PDF
                this.Close();
            };
        }
    }
}
