using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  Basic Array Types

            //string[] colors = new string[4];

            //colors[0] = "Red";
            //colors[1] = "Yello";
            //colors[2] = "Blue";
            //colors[3] = "Black";

            //Console.WriteLine(colors[2]);

            //int[] even_numbers = new int[7];
            //even_numbers[0] = 2;
            //even_numbers[1] = 4;
            //even_numbers[2] = 6;
            //even_numbers[5] = 16;

            //Console.WriteLine(even_numbers[3]);

            //string[] cities = { "Athen", "Prag", "Istanbul", "London" };
            //Console.WriteLine(cities[2]);

            #endregion

            #region List of all items of arrays with for loops

            //string[] colors = { "yellow", "white", "black" , "blue","purple","orange"};

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine((i+1) + ". Color : " +  colors[i]);   
            //}

            //int[] numbers = { 8, 164, 25, 33, 1962, 47, 7255, 12, 1, 36, 5896, 24, 63, 78, 51, 92 };

            //Console.WriteLine("------------ Divided by 3 (not float values)-------------");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i]%3 == 0) 
            //    { 
            //        Console.WriteLine(numbers[i]); ;
            //    }
            //}


            //int[] numbers = { 2, 74, 54, 556, 85, 123, 684, 57, 19, 85, 23, 66, 428, 33, 30, 20, 55, 68, 97 };
            //int max_number = 0;

            //Console.WriteLine("------------ NUMBERS ------------");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //    if (numbers[i] > max_number)
            //    {
            //        max_number = numbers[i];
            //    }
            //}
            //Console.WriteLine("MAX NUMBER on ARRAY : " +max_number );


            #endregion

            #region Array's Methods

            //--LENGTH--
            //string[] students = { "Jack", "Cris", "Ahmet", "Al Musa", "Andy", "Jenny", "Taylor", "Alex", "Jolie", "Julia" };

            //Console.WriteLine(students.Length);

            //--SORT--
            //int[] numbers = { 45, 16, 885, 74, 92, 3, 258, 12563 };
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //--REVERSE--
            //int[] numbers = { 45, 16, 885, 74, 92, 3, 258, 12563 };
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //--INDEXOF--
            //string[] customers = { "Mary", "Rob", "Ihenacho", "William", "Maria", "Adams" };
            //int index = Array.IndexOf(customers, "Maria");

            //Console.WriteLine(index);

            //--MAX,MIN--
            //int[] numbers = { 2, 57, 84, 96, 3325, 68, 10, 29 };
            //Console.WriteLine("MAX NUMBER : " + numbers.Max());
            //Console.WriteLine("MIN NUMBER : " + numbers.Min());


            #endregion

            #region Take a Value for Array from User 

            //string[] fruits = new string[5];

            //for (int i = 0; i < fruits.Length; i++)
            //{
            //    Console.Write($"Please enter your {i+1}. fruit :  ");
            //    fruits[i]=Console.ReadLine();   
            //}
            //Console.WriteLine("\n----------------------- YOUR FRUITS --------------------------\n");
            //for (int i = 0; i < fruits.Length; i++)
            //{
            //    Console.WriteLine(fruits[i]);
            //}

            //int[] numbers = new int[5];
            //int sum = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write($"Give us your {i+1}. number : ");
            //    numbers[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine("----------------\n");
            //Console.WriteLine("SUM OF YOUR NUMBERS ARRAY : " + sum);

            int[] numbers = new int[10];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"NUMBER {i+1} : ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\n----------- EVEN NUMBERS ------------\n");
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] %2 ==0)
                {
                    Console.WriteLine(numbers[i]);
                }
            }

            Console.WriteLine("\n----------- ODD NUMBERS ------------\n");
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    Console.WriteLine(numbers[i]);
                }
            }


            #endregion


            Console.Read();
        }
    }
}
