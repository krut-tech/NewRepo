using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using mobile_store.Model;

namespace mobile_store
{
    class MainClass
    {
        // ✅ Connection String
        public static string con_String =
            "Data Source=LAPTOP-QBUK3ICL\\SQLEXPRESS;Initial Catalog=DBMobile;Integrated Security=True;TrustServerCertificate=True;";

        public static Microsoft.Data.SqlClient.SqlConnection con =
            new Microsoft.Data.SqlClient.SqlConnection(con_String);

        // ✅ User validation
        public static bool IsValidUser(string user, string pass)
        {
            bool isValid = false;
            string qry = $"SELECT * FROM tblUser WHERE uUsername = '{user}' AND uPass = '{pass}'";

            using (var cmd = new Microsoft.Data.SqlClient.SqlCommand(qry, con))
            using (var da = new Microsoft.Data.SqlClient.SqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                    isValid = true;
            }

            return isValid;
        }

        // ✅ Insert, Update, Delete operations
        public static int SQl(string qry, Hashtable ht)
        {
            int res = 0;
            try
            {
                using (var cmd = new Microsoft.Data.SqlClient.SqlCommand(qry, con))
                {
                    cmd.CommandType = CommandType.Text;
                    foreach (DictionaryEntry de in ht)
                        cmd.Parameters.AddWithValue(de.Key.ToString(), de.Value);

                    if (con.State == ConnectionState.Closed)
                        con.Open();

                    res = cmd.ExecuteNonQuery();

                    if (con.State == ConnectionState.Open)
                        con.Close();
                }
            }
            catch (Exception ex)
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
                MessageBox.Show(ex.Message);
            }
            return res;
        }

        // ✅ Fetch data
        public static DataTable GetData(string qry)
        {
            using (var cmd = new Microsoft.Data.SqlClient.SqlCommand(qry, con))
            using (var da = new Microsoft.Data.SqlClient.SqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // ✅ Load data into DataGridView
        public static void LoadData(string qry, DataGridView gv)
        {
            gv.DataSource = GetData(qry);
            int count = 0;
            foreach (DataGridViewRow row in gv.Rows)
            {
                count++;
                row.Cells[0].Value = count;
            }
        }

        private static void gv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridView gv = (DataGridView)sender;
            int count = 0;
            foreach (DataGridViewRow row in gv.Rows)
            {
                count++;
                row.Cells[0].Value = count;
            }
        }

        // ✅ Clear form controls
        public static void ClearControls(Form f)
        {
            foreach (Control c in f.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
                else if (c is ComboBox cb)
                {
                    cb.SelectedIndex = -1;
                    cb.Text = string.Empty;
                }
                else if (c is CheckBox chk)
                    chk.Checked = false;
            }
        }

        // ✅ Blur background
        public static void BlurBackground(Form model)
        {
            Form background = new Form();
            using (model)
            {
                background.StartPosition = FormStartPosition.Manual;
                background.FormBorderStyle = FormBorderStyle.None;
                background.Opacity = 0.5d;
                background.BackColor = Color.Black;
                background.Size = frmMain.Instance.Size;
                background.Location = frmMain.Instance.Location;
                background.ShowInTaskbar = false;
                background.Show();

                model.Owner = background;
                model.ShowDialog(background);
                background.Dispose();
            }
        }

        // ✅ ComboBox fill
        public static void CBFill(string qry, ComboBox cb)
        {
            using (var cmd = new Microsoft.Data.SqlClient.SqlCommand(qry, con))
            using (var da = new Microsoft.Data.SqlClient.SqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                cb.DisplayMember = "Name";
                cb.ValueMember = "Id";
                cb.DataSource = dt;
                cb.SelectedIndex = -1;
            }
        }

        // ✅ Form-specific clear functions
        internal static void ClearAll(frmBrandAdd frm) => ClearControls(frm);
        internal static void ClearAll(frmProductAdd frm) => ClearControls(frm);
        internal static void ClearAll(fmUserAdd frm) => ClearControls(frm);
        internal static void ClearAll(frmColorAdd frm) => ClearControls(frm);
    }
}
