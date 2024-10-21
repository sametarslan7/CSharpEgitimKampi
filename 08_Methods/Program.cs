using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Methods

            // not return back methods
            //
            //void CustomerList()
            //{
            //    Console.WriteLine("Huge Jackson");
            //    Console.WriteLine("Melany Malone");
            //    Console.WriteLine("Ashley Bryant");
            //    Console.WriteLine("Julia Robertson");
            //}
            //CustomerList();

            //void Sum()
            //{
            //    int x = 8;
            //    int y = 16;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}
            //Sum();
            #endregion

            #region Not return back with string parameters

            //void Customer(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}
            //Customer("Hamdi Tanpınar");

            //void CustomerCard(string name,string surName)
            //{
            //    Console.WriteLine("Customer : " + name + " " + surName);
            //}
            //CustomerCard("Garry","Young");
            //CustomerCard("Angelia","Walker");

            #endregion

            #region Not return back with string parameters

            //void Sum(int num1,int num2 , int num3)
            //{
            //    int result = num1+ num2 + num3;
            //    Console.WriteLine("SUm : " + result);
            //}
            //Sum(5,8,96);
            #endregion

            #region return back methods

            //String CustomerName()
            //{
            //    return "Mohamed Kudus";
            //}
            //CustomerName();

            //String CustomerCard()
            //{
            //    string name = "Isac";
            //    string surName = "Tarkowski";

            //    return name + " " + surName;
            //}
            //Console.WriteLine(CustomerCard());

            #endregion

            #region return back methods with String parameters

            //String CountryCard(string countryName,string countryCapital , string countryFlagColor)
            //{
            //    string cardInfo = "Country : " + countryName + "\nCountry Capital :  " + countryCapital + "\nCountry Flag Color : " + countryFlagColor;
            //    return cardInfo;    
            //}

            //string name, capital, flagColor;

            //Console.Write("Enter the Country Name : ");
            //name=Console.ReadLine();

            //Console.Write("Enter the Capital City of Country : ");
            //capital=Console.ReadLine();

            //Console.Write("Enter the Country FLag's Color : ");
            //flagColor=Console.ReadLine();


            //Console.WriteLine(CountryCard(name, capital, flagColor));

            #endregion

            #region return back methods with Int parameters

            //int Sum(int number1,int number2)
            //{
            //    return number1 + number2;
            //}
            //Console.WriteLine(Sum(8,6));

            //string ExamResult(string name , int exam1,int exam2,int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;
            //    if (result >= 50) 
            //    {
            //        return name + "Congrats , you passed the exam";
            //    }else
            //    {
            //        return name + "Unfortunately , you couldn't pass the exam";
            //    }
            //}

            //Console.WriteLine(ExamResult("Ledia Mantrova",80,40,60));
            #endregion




            Console.Read();
        }
    }
}
