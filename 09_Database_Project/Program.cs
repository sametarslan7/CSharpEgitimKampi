using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Database_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Product-Category Info System with Database on C# *****\n\n");
            Console.WriteLine("--------------\n");

            string table_number;

            Console.WriteLine("1-Categories");
            Console.WriteLine("2-Products");
            Console.WriteLine("3-Orders");
            Console.WriteLine("4-Quit");
            Console.WriteLine("Select that table you want to see or Quit : ");
            table_number = Console.ReadLine();
            Console.WriteLine("--------------\n");

            SqlConnection connect = new SqlConnection("Data Source=DESTROYERM\\SQLEXPRESS;initial Catalog = EgitimKampiDb;integrated security=true");
            
            SqlCommand cmd = new SqlCommand("Select * from TblCategory",connect);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dt=new DataTable();
            adapter.Fill(dt);
            connect.Close();

            foreach (DataRow row in dt.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.WriteLine(item.ToString());
                }
                Console.WriteLine();
            }


            Console.Read();
        }
    }
}
