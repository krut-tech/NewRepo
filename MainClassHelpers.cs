using Microsoft.Data.SqlClient;

namespace mobile_store
{
    internal static class MainClassHelpers
    {
        public static bool IsValidUser(string user, string pass)
        {
            bool isValid = false;

            string qry = @"SELECT COUNT(*) FROM UserDetails WHERE Email = @user AND Password = @pass";
            string connectionString = @"Server=LAPTOP-QBUK3ICL\SQLEXPRESS;Database=MobileStoreDB;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;";

            using (Microsoft.Data.SqlClient.SqlConnection con = new Microsoft.Data.SqlClient.SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(qry, con))
                {
                    cmd.Parameters.AddWithValue("@user", user);
                    cmd.Parameters.AddWithValue("@pass", pass);

                    con.Open();
                    int count = (int)cmd.ExecuteScalar();

                    isValid = (count > 0);
                }
            }

            return isValid;
        }
    }
}
