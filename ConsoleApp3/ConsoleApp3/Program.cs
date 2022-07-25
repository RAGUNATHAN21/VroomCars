using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp1
{
    class Class2
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("1. Display");
                Console.WriteLine("2. Add Employee");
                Console.WriteLine("3. Modify Employee");
                Console.WriteLine("4. Delete Employee");
                Console.WriteLine("5. Exit");
                Console.Write("\nEnter Your Choice :");
                int ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        ShowAll();
                        break;
                    case 2:
                        AddRecord();
                        break;
                    case 3:
                        UpdateRecord();
                        break;
                    case 4:
                        DeleteRecord();
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("Invalid Choide");
                        break;
                }
            } while (true);
        }

        private static void AddRecord()
        {
            SqlConnection sqlConnection = new SqlConnection(" Data Source = RAGU; Integrated Security = true ; initial catalog=crikettdb");
            
            string Name;
            int pl_id;
            string Roll;
            Console.Write("Enter the id:");
            pl_id =Convert.ToInt32(Console.ReadLine());
            
            Name = Console.ReadLine();
            Console.Write("Enter the Name:");
            Console.Write("Enter Roll:");
            Roll = Console.ReadLine();

            string query = "insert into player values(pl_id" + Name + "'," + Roll + ")";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            Console.WriteLine("Record Added");



        }
        private static void ShowAll()
        {
            SqlConnection sqlConnection = new SqlConnection();
            SqlCommand sqlCommand = new SqlCommand();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

            sqlConnection.ConnectionString = " Data Source = RAGU; Integrated Security = true ; Initial Catalog =crikettdb";
            sqlCommand.CommandText = "select * from player";
            sqlCommand.Connection = sqlConnection;
            sqlDataAdapter.SelectCommand = sqlCommand;

            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                Console.WriteLine(dataTable.Rows[i][0] + "\t" + dataTable.Rows[i][1]+"\t" + dataTable.Rows[i][2]);
            }



            Console.ReadKey();


        }
        private static void UpdateRecord()
        {

        }
        private static void DeleteRecord()
        {

        }
    }
}