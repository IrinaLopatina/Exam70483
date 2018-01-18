using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Exam70483_12
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder
            {
                DataSource = @"localhost\MSSQLSERVER01",
                InitialCatalog = "School",
                IntegratedSecurity = true
            };

            string connectionString = builder.ToString();
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            //string cmdTxt1 = "Insert into Student values(1, 'Valeria Vileid')";
            //string cmdTxt1 = "Insert into Student values(2, 'Viktor Vileid')";
            //string cmdTxt1 = "Insert into Student values(3, 'Marina Vileid')";

            string cmdTxt1 = "select * from student";
            /* Connected layer operations
            SqlCommand cmd1 = new SqlCommand(cmdTxt1, con);

            SqlDataReader reader  = cmd1.ExecuteReader();

            int studentId;
            string studentName;

            if(reader.HasRows)
            {
                while (reader.Read())
                {
                    studentId = int.Parse(reader["StudentId"].ToString());
                    studentName = reader["StudentName"].ToString();

                    Console.WriteLine("ID is: {0}, name is: {1}", studentId, studentName);
                }
            }
            reader.Close();
            con.Close();
            */
            /*Disconnected layer operationa*/

            SqlDataAdapter adapter = new SqlDataAdapter(cmdTxt1, con);
            DataTable tbl = new DataTable();
            adapter.Fill(tbl);//Now the data  is in Datatable (memory)
            con.Close();

            foreach (DataRow row in tbl.Rows)
            {
                Console.WriteLine("ID is: {0}, name is: {1}", row[0], row[1]);
                Console.WriteLine("****************************************");
            }

            DataRow newRow = tbl.NewRow(); //New record to add in DataBase
            newRow["studentId"] = 4;
            newRow["studentName"] = "Irina Lopatina";
            tbl.Rows.Add(newRow);
            foreach (DataRow row in tbl.Rows)
            {
                Console.WriteLine("ID is: {0}, name is: {1}", row[0], row[1]);
                Console.WriteLine("****************************************");
            }

            //Now new row has to add in Database(pass newRow Parameters to this insert query)
            string newCommand = @"Insert into Student(StudentId,StudentName) Values(@StudentId, @StudentName)";
            SqlCommand insertCommand = new SqlCommand(newCommand, con);

            //Create the parameters
            insertCommand.Parameters.Add(new SqlParameter("@StudentId", SqlDbType.Int, Int32.MaxValue, "StudentId"));
            insertCommand.Parameters.Add(new SqlParameter("@StudentName", SqlDbType.VarChar, 50, "StudentName"));
            con.Open();
            adapter.InsertCommand = insertCommand;
            adapter.Update(tbl);

            con.Close();
        }
    }
}
