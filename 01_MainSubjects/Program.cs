﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region WritingCommands
            //Console.WriteLine("Hello World");

            //Console.WriteLine("***** Categories *****");
            //Console.WriteLine();
            //Console.WriteLine("1 - Soups");
            //Console.WriteLine("2 - Intermediate Heats");
            //Console.WriteLine("3 - Main Courses");
            //Console.WriteLine("4 - Desserts");
            //Console.WriteLine("5 - Drinks");

            //Console.Read();
            #endregion

            #region StringVariables


            //String passengerName;
            //String passengerSurname;
            //String passengerPhone, passengerEmail, passengerDistrict, passengerCity;

            //passengerName = "Samet";
            //passengerSurname = "Arslan";
            //passengerPhone = "+90 522 412 11 11";
            //passengerEmail = "sametarslan@gmail.com";
            //passengerDistrict = "Kadıköy";
            //passengerCity = "İstanbul"; 

            //Console.WriteLine("*** Rezervation Card *** \n");
            //Console.WriteLine("--------------------------------");
            //Console.WriteLine("passenger : " + passengerName + " " + passengerSurname + "\nPhone : " + passengerPhone + "\nE-Mail : " + passengerEmail + "\nAdress : " + passengerDistrict + "/" + passengerCity);
            //Console.WriteLine("--------------------------------");
            //Console.Read();
            #endregion

            #region IntVarıables

            //int number = 29;
            //Console.WriteLine(number);

            int burgerPrice = 300;
            int waterPrice = 20;
            int cokePrice = 45;
            int pizzaPrice = 250;
            int lemonadePrice = 30;


            Console.WriteLine(" ***** Menu ***** \n");
            Console.WriteLine(" Hamburger : " + burgerPrice + " $ ");
            Console.WriteLine(" Water : " + waterPrice + " $ ");
            Console.WriteLine(" Coke : " + cokePrice + " $ ");
            Console.WriteLine(" Pizza : " + pizzaPrice + " $ ");
            Console.WriteLine(" Lemonade : " + lemonadePrice + " $ ");

            Console.WriteLine();

            int burgerCount = 3;
            int waterCount = 2;
            int cokeCount = 1;
            int pizzaCount = 2;
            int lemonadeCount = 2;

            int totalPrice = 0;
            totalPrice = burgerCount*burgerPrice + waterCount*waterPrice + cokeCount*cokePrice + pizzaCount*pizzaPrice + lemonadePrice*lemonadeCount;

            Console.WriteLine("-----------------------------");
            Console.WriteLine("Total Price : " + totalPrice);
            Console.Read();
            
            
            #endregion

        }

    }
}

