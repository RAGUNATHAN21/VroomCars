using  System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.OleDb;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data;

using System.Configuration;

namespace ConApp2
{
    class Program
    {
        static void Main(string[] args)
        {
           // OleDbConnection oleDbConnection = new OleDbConnection("Provider=SQLOLEDB.1; user id=sa; password=a; Initial Catalog=cricketdb");
          // OleDbCommand oleDbCommand = new OleDbCommand("select * from cricket", oleDbConnection);
            //OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(oleDbCommand);

           // SqlConnection sqlConnection = new SqlConnection("Data Source=RAGU; user id=sa; password=a; Initial Catalog=cricketdb");
           // SqlCommand sqlCommand = new SqlCommand("select * from cricket", sqlConnection);
           // SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

            

           

            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                Console.WriteLine(dataTable.Rows[i][0] + "\t" + dataTable.Rows[i][1] + "\t" + dataTable.Rows[i]["EmpSalary"]);
            }



            Console.ReadKey();


        }
    }
}

