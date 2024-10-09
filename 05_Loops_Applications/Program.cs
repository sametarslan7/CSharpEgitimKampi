using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Loops_Applications
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region create 10 stars one aboove the other

            //for (int i = 1; i <=10; i++)
            //{
            //    Console.WriteLine("*");   
            //}

            #endregion

            #region create 10 stars side by side

            //for (int i = 1; i <=10; i++)
            //{
            //    Console.Write("*");
            //}


            #endregion

            #region create 10 stars oen above the other every row has 10 stars

            //for (int i = 1; i <=10; i++)
            //{
            //    for (int j = 1; j <=10; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Right Triangle with Stars

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            #endregion

            #region Reverse Right Triangle with Stars

            //for (int i = 5; i >= 1; i--)
            //{
            //    for (int j = i; j >= 1; j--)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            #endregion

            #region Right Triangle and Revers Right Triangle together

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 4; i >= 1; i--)
            //{
            //    for (int j = i; j >= 1; j--)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region  Pyramid

            //int n = 5;
            //for (int i = 1; i <=n; i++)
            //{
            //    for (int j = n-i; j >0 ; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int k = 1; k <= 2*i-1 ; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region  ReversePyramid

            //int n = 5;
            //for (int i = n; i >= 1; i--)
            //{
            //    for (int j = n - i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion



            Console.Read();
        }
    }
}
