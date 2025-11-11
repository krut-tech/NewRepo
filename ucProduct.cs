using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mobile_store.View;
using System.IO;


namespace mobile_store
{
    public partial class ucProduct : UserControl
    {
        public EventHandler? onSe1ect = null;
        public ucProduct()
        {
            InitializeComponent();
        }

        //Properties of usercontrol

        [Browsable(true)]
        [Category("Custom Properties")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int id { get; set; }

        [Browsable(true)]
        [Category("Custom Properties")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string PCost { get; set; }

        [Browsable(true)]
        [Category("Custom Properties")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string PName
        {
            get { return txtName.Text; }
            set { txtName.Text = value; }
        }

        [Browsable(true)]
        [Category("Custom Properties")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Single pRating
        {
            get { return txtRating.Value; }
            set { txtRating.Value = value; }
        }

        [Browsable(true)]
        [Category("Custom Properties")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string pPrice
        {
            get { return txtPrice.Text; }
            set { txtPrice.Text = value; }
        }

        [Browsable(true)]
        [Category("Custom Properties")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Image pImage
        {
            get { return txtPic.Image; }
            set { txtPic.Image = value; }
        }
        /*   public int id { get; set; }

           public string PCost { get; set; }

           public string PName
           {
               get { return txtName.Text; }
               set { txtName.Text = value; }
           }

           public string pRating
           {
               get { return txtRating.Text; }
               set { txtRating.Text = value; }
           }

           public Image pImage
           {
               get { return txtPic.Image; }
               set { txtPic.Image = value; }
           }*/

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtPic_Click(object sender, EventArgs e)
        {
            onSe1ect?.Invoke(this, e);
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            //open detail form design latter
            MainClass.BlurBackground(new frmDetails() { id = id } );

        }

        private void ucProduct_MouseEnter(object sender, EventArgs e)
        {
            // change color on hover

            this.BackColor = Color.LightCyan;
        }

        private void ucProduct_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.WhiteSmoke;

        }
    }
}
