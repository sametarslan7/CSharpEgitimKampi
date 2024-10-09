using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region For Loops

            //int i;
            //for (i = 1; i <= 5 ; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 0; i <= 30; i+=3)
            //{
            //    Console.WriteLine(i);
            //}



            #endregion

            #region For Loops with Decisions Structures

            //for (int i = 0; i <=100; i++)
            //{
            //    if (i%5==0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int sum = 0;

            //for (int i = 1; i <=  10; i++)
            //{
            //    sum += i; 
            //}
            //Console.WriteLine(sum);

            //int evenNumberSum = 0;
            //for (int i = 1; i <= 20; i++)
            //{
            //    if (i%2 == 0 )
            //    {
            //        evenNumberSum += i;
            //        Console.WriteLine(i);    
            //    }
            //}
            //Console.WriteLine("-----------");
            //Console.WriteLine( evenNumberSum );

            //int numberOfSevenMultiples = 0;
            //for (int i = 1; i < 177; i++)
            //{
            //    if (i%7==0)
            //    {
            //        numberOfSevenMultiples++;
            //        Console.WriteLine(i);
            //    }
            //}

            //Console.WriteLine("--------------");    
            //Console.WriteLine(numberOfSevenMultiples);

            #endregion

            #region Bacterias Example with For Loops

            //int time;
            //int numberOfBacterium = 1;

            //for ( time = 1; time <=24; time++) 
            //{
            //    numberOfBacterium = numberOfBacterium * 2;

            //    Console.WriteLine(time + " . Hour -> " + numberOfBacterium + " Bacteria");

            //}
            //Console.WriteLine("-----------");
            //Console.WriteLine("24.Hou - Total Bacteria : " + numberOfBacterium);

            #endregion

            #region While Loops

            //int i=1;
            //while (i<=10) 
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            #endregion

            #region While Loops with Decision Structures

            //int i = 1;
            //while (i<=10)
            //{
            //    if (i%3==0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //int numberStart, numberEnd;
            //int sum = 0;
            //Console.Write("Enter the start number : ");
            //numberStart = int.Parse(Console.ReadLine());

            //Console.Write("Enter the end number : ");
            //numberEnd = int.Parse(Console.ReadLine());

            //while (numberStart <= numberEnd) 
            //{
            //    sum += numberStart;
            //    Console.WriteLine(numberStart);
            //    numberStart++;
            //}
            //Console.WriteLine(" Sum : "+sum);

            #endregion

            #region Example Exam Question
            // Sum of entered 3 digits number's digits (341 : 3+4+1 = 8)

            //int number;
            //int ones, tens, hundereds;
            //int sum=0;
            //Console.Write("NUMBER : ");
            //number  =int.Parse(Console.ReadLine());

            //ones = number % 10;
            //tens = (number % 100) / 10;
            //hundereds = number / 100;


            //sum=ones+tens+hundereds;
            //Console.WriteLine(sum);

            #endregion


            Console.Read();

        }
    }
}
