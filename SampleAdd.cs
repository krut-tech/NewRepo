using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mobile_store
{
    public partial class SampleAdd : Sample
    {
        public SampleAdd()
        {
            InitializeComponent();
        }

        public int editID = 0; // this is use when we want to edit the data so we can pass the id of that data
        public virtual void btnClose_Click(object sender, EventArgs e)
        {
            this .Close();
        }

        public virtual void btnSave_Click(object sender, EventArgs e)
        {
               
        }
    }
}
