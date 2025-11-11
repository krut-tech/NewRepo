using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;



namespace mobile_store
{
    public partial class frmLogin : Sample
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // user validation wiil be use when add some user later 

           if(MainClass.IsValidUser (txtUser.Text, txtPass.Text) == false)
            {
               MessageBox.Show("invelid user name or passwor");
                return;
            }   


            frmMain main = new frmMain();
            main.Show();
            this.Hide();
        }
    }
}
