using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Exam70483_13
{
    static class AuthenticationObjectDataAccess
    {
        public static bool VerifyLogin(string userName, string password)
        {
            AuthenticationObject authExisting = Get(userName);

            string loginHashedPassword = AuthenticationObject.GetHashedPassword(password, authExisting.Salt);

            var dummy = loginHashedPassword.GetHashCode();
            var dummy2 = authExisting.Password.GetHashCode();
            return loginHashedPassword.GetHashCode() == authExisting.Password.GetHashCode();
        }

        public static int Save(AuthenticationObject auth)
        {
            var result = 0;
            var connectionString = GetConnectionString();
            try
            {
                using (var con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string cmdTxt = String.Format("Insert into Authentication values ('{0}', '{1}', '{2}')", auth.UserName, auth.Password, auth.Salt);
                    SqlCommand cmd = new SqlCommand(cmdTxt, con);
                    result = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public static AuthenticationObject Get(string userName)
        {
            AuthenticationObject auth = null;
            var connectionString = GetConnectionString();
            using (var con = new SqlConnection(connectionString))
            {
                con.Open();
                string cmdTxt = String.Format("Select * from Authentication where userName = '{0}'", userName);
                SqlCommand cmd = new SqlCommand(cmdTxt, con);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        var password = reader["Password"].ToString();
                        var salt = Guid.Parse(reader["Salt"].ToString());

                        auth = new AuthenticationObject(userName, password, salt);
                    }
                }
            }

            return auth;
        }

        private static string GetConnectionString()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder
            {
                DataSource = @"localhost\MSSQLSERVER01",
                InitialCatalog = "School",
                IntegratedSecurity = true
            };
            return builder.ToString();
        }
    }
}
