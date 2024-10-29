using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Database_CRUD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Menu Order Operatıons Panel *****\n\n");

            SqlConnection conn = new SqlConnection("Data Source=DESTROYERM\\SQLEXPRESS;initial Catalog = EgitimKampiDb;integrated security=true");

            #region Adding Category
            //Console.Write("Enter the category name that you want to add : ");
            //string categoryName=Console.ReadLine();

            //conn.Open();

            //SqlCommand cmd = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)",conn);
            //cmd.Parameters.AddWithValue("@p1", categoryName);
            //cmd.ExecuteNonQuery();
            //conn.Close();

            //Console.WriteLine("Successfull Adding Operation ...");
            #endregion

            #region Adding Product
            //Console.Write("Enter the Product Name :  ");
            //string productName = Console.ReadLine();

            //Console.Write("Enter the Product Price : ");
            //double productPrice = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter the Product Status (true or false) : ");
            //bool productStatus = Convert.ToBoolean(Console.ReadLine());

            //conn.Open();

            //SqlCommand cmd = new SqlCommand("insert into TblProducts (ProductName,ProductPrice,ProductStatus) values (@p1,@p2,@p3)", conn);

            //cmd.Parameters.AddWithValue("@p1", productName);
            //cmd.Parameters.AddWithValue("@p2", productPrice.ToString());
            //cmd.Parameters.AddWithValue("@p3", productStatus.ToString());
            //cmd.ExecuteNonQuery();
            //conn.Close();

            //Console.WriteLine("Adding new products to Database is succesful ");
            #endregion

            #region Make List Operation

            //conn.Open();

            //SqlCommand cmd = new SqlCommand("select * from TblProducts",conn);
            //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();

            //adapter.Fill(dt);

            //foreach (DataRow dr in dt.Rows) 
            //{
            //    foreach (var item in dr.ItemArray) 
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();    
            //}



            conn.Close();

            #endregion

            #region Deleting Product with ID

            //conn.Open();

            //SqlCommand cmd = new SqlCommand("select * from TblProducts", conn);
            //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();

            //adapter.Fill(dt);

            //foreach (DataRow dr in dt.Rows)
            //{
            //    foreach (var item in dr.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}

            //Console.Write("\n\nEnter the ID of that you want to delete  : ");
            //int id=Convert.ToInt32(Console.ReadLine());

            //SqlCommand cmd2 = new SqlCommand("delete from TblProducts where ProductId = @p1",conn);
            //cmd2.Parameters.AddWithValue("@p1",id.ToString());
            //cmd2.ExecuteNonQuery(); 


            //conn.Close();
            //Console.WriteLine("Deleting process is successfull");

            #endregion

            #region Update Product 

            conn.Open();
            Console.Write("Enter the ıd of product that you want to update : ");
            int productID=int.Parse(Console.ReadLine());

            SqlCommand cmd = new SqlCommand("select * from TblProducts where ProductId = @p1",conn);
            cmd.Parameters.AddWithValue("@p1",productID.ToString());

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            foreach (DataRow row in dt.Rows) 
            {
                foreach (var item in row.ItemArray) 
                {
                    Console.Write(item.ToString() + " ");
                }
            }
            Console.WriteLine("\n\n");    

            Console.Write("Enter Product Name : ");
            string productName=Console.ReadLine();
            Console.Write("Enter Product Price : ");
            double productPrice = double.Parse(Console.ReadLine());
            Console.Write("Enter Product Status (true or false) : ");
            bool productStatus = bool.Parse(Console.ReadLine());

            SqlCommand cmdUpdate=new SqlCommand("Update TblProducts set ProductName=@productname , ProductPrice=@productprice , ProductStatus=@productstatus where ProductId=@productid",conn);
            cmdUpdate.Parameters.AddWithValue("@productid", productID.ToString());
            cmdUpdate.Parameters.AddWithValue("@productname",productName);
            cmdUpdate.Parameters.AddWithValue("@productprice",productPrice.ToString());
            cmdUpdate.Parameters.AddWithValue("@productstatus", productStatus.ToString()) ;
                
            cmdUpdate.ExecuteNonQuery();    

            conn.Close();

            Console.WriteLine("Updateing process is successful ");
            
            #endregion


            Console.Read();
        }
    }
}
