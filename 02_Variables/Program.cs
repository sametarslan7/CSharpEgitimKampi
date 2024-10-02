using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region DoubleVariables

            //double number;
            //number = 4.85;
            //Console.WriteLine(number);

            //Console.WriteLine("***** Fiyat Listesi *****\n");

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 16.99;
            //orangePrice = 24.75;
            //strawberryPrice =36.99;
            //potatoPrice =11.99;
            //tomatoPrice = 18.99;

            //Console.WriteLine("--- Apple : " + applePrice + " $ ");
            //Console.WriteLine("--- Orange : " + orangePrice + " $ ");
            //Console.WriteLine("--- Strawberry : " + strawberryPrice + " $ ");
            //Console.WriteLine("--- Potato : " + potatoPrice + " $ ");
            //Console.WriteLine("--- Tomato : " + tomatoPrice + " $ ");

            //Console.WriteLine("\n\n");
            //Console.WriteLine("***** Alışveriş Fişi *****\n");

            //double appleAmount,orangeAmount,strawberryAmount,potatoAmount,tomatoAmount;

            //appleAmount = 1.456;
            //orangeAmount = 2.578;
            //strawberryAmount = 4.523;
            //potatoAmount = 6.254;
            //tomatoAmount = 2.147;

            //double appleTotalPrice = applePrice * appleAmount;
            //double orangeTotalPrice = orangePrice * orangeAmount;
            //double strawberryTotalPrice = strawberryPrice * strawberryAmount;
            //double potatoTotalPrice = potatoPrice * potatoAmount;
            //double tomatoTotalPrice = tomatoPrice * tomatoAmount;

            //Console.WriteLine("Total Apple Price : " + appleTotalPrice + " $ ");
            //Console.WriteLine("Total Orange Price : " + orangeTotalPrice + " $ ");
            //Console.WriteLine("Total Strawberry Price : " + strawberryTotalPrice + " $ ");
            //Console.WriteLine("Total Potato Price : " + potatoTotalPrice + " $ ");
            //Console.WriteLine("Total Tomato Price : " + tomatoTotalPrice + " $ ");
            //Console.WriteLine();
            //double total=appleTotalPrice+orangeTotalPrice+strawberryTotalPrice+potatoTotalPrice+tomatoTotalPrice;
            //Console.WriteLine("Total : " + total + " $ ");

            #endregion

            #region CharVariables
            //char symbol = 'a';
            //Console.WriteLine(symbol);
            #endregion

            #region DataEntriesFromKeyboard - String Variables
            //Console.WriteLine("--- Hava Yolları Yolcu Bilgisi ---\n");

            //string passengerName, passengerSurname,passengerFrom,passengerTo, passengerAge, passengerIdentıtyNumber;

            //Console.Write("Passenger Name : ");
            //passengerName = Console.ReadLine();
            //Console.Write("Passenger Surname : ");
            //passengerSurname = Console.ReadLine();
            //Console.Write("Passenger Age : ");
            //passengerAge = Console.ReadLine();
            //Console.Write("Passenger Identıty No : ");
            //passengerIdentıtyNumber = Console.ReadLine();
            //Console.Write("Passenger From : ");
            //passengerFrom= Console.ReadLine();
            //Console.Write("Passenger To : ");
            //passengerTo= Console.ReadLine();

            //Console.WriteLine("\n ----------------------------");
            //Console.WriteLine(passengerIdentıtyNumber +" Passenger \n" + "Name :  " + passengerName + "\nSurname : " + passengerSurname + "\nAge : " + passengerAge + "\nFlight -> from " + passengerFrom + " to " + passengerTo);

            #endregion

            #region DataEntriesFromKeyboard - Int Varıables

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 4500;
            //tvPrice = 8000;

            //int shoesCount, computerCount, chairCount, tvCount;
            //Console.Write("Shoes Count : ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Computer Count : ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Chair Count : ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("TV Count : ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice  =shoesPrice*shoesCount+computerPrice*computerCount+chairCount*chairPrice+tvCount*tvPrice;

            //Console.WriteLine("\n----- Total Price : " + totalPrice);

            #endregion

            #region DataEntriesFromKeyboard - Double Variables

            //double exam1, exam2, exam3, result;

            //Console.Write("Exam 1 : ");
            //exam1=double.Parse(Console.ReadLine());
            //Console.Write("Exam 2 : ");
            //exam2 = double.Parse(Console.ReadLine());
            //Console.Write("Exam 3 : ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Your Grade Average : " + result);

            #endregion

            #region DataEntriesFromKeyboard - Char Variables

            //char gender;
            //Console.Write(" Please select your gender (male - m / female - f) : ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Your gender : " + gender);
            #endregion

            Console.Read();
        }
    }
}
