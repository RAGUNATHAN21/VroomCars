using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.OleDb;
using System.Data;
using System.Configuration;

using System.Data.SqlClient;

namespace wednesday
{
    class Program
    {
        static void Main(string[] args)
        {
            //OleDbConnection oleDbConnection = new OleDbConnection("Provider=SQLOLEDB.1; user id=sa; password=a; Initial Catalog=NextTurnDB");
            //OleDbCommand oleDbCommand = new OleDbCommand("select * from Employee", oleDbConnection);
            //OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(oleDbCommand);

            SqlConnection sqlConnection = new SqlConnection("Data Source=RAGU; Integrated Security=true ; Initial Catalog=crikettdb");
            SqlCommand sqlCommand = new SqlCommand("select * from player", sqlConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

            /*SqlConnection sqlConnection = new SqlConnection();
            SqlCommand sqlCommand = new SqlCommand();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
*/
            //sqlConnection.ConnectionString = "Data Source=sathesh-laptop; user id=sa; password=a; Initial Catalog=NextTurnDB";
           /* sqlConnection.ConnectionString = ConfigurationSettings.AppSettings["connectionString"];
            sqlCommand.CommandText = "select * from Employee";
            sqlCommand.Connection = sqlConnection;
            sqlDataAdapter.SelectCommand = sqlCommand;*/

            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                Console.WriteLine(dataTable.Rows[i][0] + "\t" + dataTable.Rows[i][1] +"\t"+dataTable.Rows[i][1]);
            }



            Console.ReadKey();


        }
    }
}
