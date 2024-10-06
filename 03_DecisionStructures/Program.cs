using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_DecisionStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region IF
            //Console.Write("Please Enter the Password : ");
            //string password;
            //password = Console.ReadLine();
            //if (password=="1234")
            //{
            //    Console.WriteLine("Password is Correct.");
            //}
            //else
            //{
            //    Console.WriteLine("Password is not Correct");
            //}
            #endregion

            #region IF EXAMPLE

            //double grade1, grade2, average;

            //Console.Write("Enter your first exam's grade : ");
            //grade1=double.Parse(Console.ReadLine());
            //Console.Write("Enter your second exam's grade : ");
            //grade2 = double.Parse(Console.ReadLine());

            //average = (grade1 + grade2) / 2;
            //Console.WriteLine("----------------------");
            //Console.WriteLine("AVERAGE : " + average);

            //if (average<=50)
            //{
            //    Console.WriteLine("Bad avg");
            //}
            //else if(average>=50 & average<=70)
            //{
            //    Console.WriteLine("Not good Not bad avg");
            //}
            //else if (average >= 70 & average <= 90)
            //{
            //    Console.WriteLine("Good avg");
            //}
            //else if (average >= 90)
            //{
            //    Console.WriteLine("Excellent avg");
            //}
            //else
            //{
            //    Console.WriteLine("wrong grades");
            //}
            #endregion

            #region MOD OPERATIONS

            //int number;
            //Console.Write("Enter the first number :  ");
            //number=int.Parse(Console.ReadLine());

            //int mod_number;
            //Console.Write("Enter teh mod-number : ");
            //mod_number= int.Parse(Console.ReadLine());

            //int result;
            //result=number%mod_number;

            //Console.WriteLine(" ***  mod " +mod_number + " of " + number + " is " + result );

            #endregion

            #region MOD OPERATIONS with IF-ELSE

            //int num, result;

            //Console.Write("NUM : ");
            //num=int.Parse(Console.ReadLine());

            //result = num % 2;

            //if (result == 1)
            //{
            //    Console.WriteLine("The number you entered , is odd");
            //}
            //else if (result == 0)
            //{
            //    Console.WriteLine("The number you entered , is even");
            //}
            //else
            //{
            //    Console.WriteLine("wrong operation with wrong number , please try again");
            //}

            #endregion

            #region IF-ELSE EXAMPLE with CHAR VARIABLES

            //char team_letter;

            //Console.Write("Enter just first letter of your team's name  : ");
            //team_letter=char.Parse(Console.ReadLine());

            //if (team_letter=='f' | team_letter=='F')
            //{
            //    Console.WriteLine("FENERBAHÇE");
            //}
            //else if (team_letter == 'g' | team_letter == 'G')
            //{
            //    Console.WriteLine("GALATASARAY");
            //}
            //else if (team_letter == 'b' | team_letter == 'B')
            //{
            //    Console.WriteLine("BEŞİKTAŞ");
            //}
            //else if (team_letter == 't' | team_letter == 'T')
            //{
            //    Console.WriteLine("TRABZONSPOR");
            //}
            //else
            //{
            //    Console.WriteLine("entered letter was wrong ...");
            //}


            #endregion

            #region DOING MENU with IF-ELSE

            //Console.WriteLine("------- MENU -------\n");

            //int select;

            //Console.WriteLine("1-Starter Meals\n2-Intermediate Heats\n3-Main Course\n4-Desserts\n5-Drinks\n\n");
            //Console.Write("Please select an option ... ");
            //select=int.Parse(Console.ReadLine());

            //if (select == 1)
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------ Starter Meals ------\n\n");

            //    Console.WriteLine("1-Chicken Soup\n2-Lentil Soup\n3-Noodle Soup\n\n");
            //}
            //else if(select==2)
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------ Intermedıate Heats ------\n\n");

            //    Console.WriteLine("1-Fried Potatoes\n2-Stuffed Grape Leaves\n3-Turkish Ravioli\n\n");
            //}
            //else if (select == 3)
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------ Main Course ------\n\n");

            //    Console.WriteLine("1-Chicken and Rice\n2-Bean Dish\n3-Salmon\n\n");
            //}
            //else if (select == 4)
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------ Desserts ------\n\n");

            //    Console.WriteLine("1-Baklava\n2-Rice Pudding\n3-Supangle\n\n");
            //}
            //else if (select == 5)
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------ Drinks ------\n\n");

            //    Console.WriteLine("1-Water\n2-Coke\n3-Ayran\n\n");
            //}

            #endregion

            #region SWITCH - CASE

            //int month_number;
            //Console.Write("Enter your birthdate month number  : ");
            //month_number=int.Parse(Console.ReadLine());

            //switch (month_number)
            //{
            //    case 1: Console.Write("January"); break;
            //    case 2: Console.Write("February"); break;
            //    case 3: Console.Write("March"); break;
            //    case 4: Console.Write("April"); break;
            //    case 5: Console.Write("May"); break;
            //    case 6: Console.Write("June"); break;
            //    case 7: Console.Write("July"); break;
            //    case 8: Console.Write("August"); break;
            //    case 9: Console.Write("September"); break;
            //    case 10: Console.Write("October"); break;
            //    case 11: Console.Write("November"); break;
            //    case 12: Console.Write("December"); break;

            //    default: Console.WriteLine("Wrong Number"); break;
            //}


            #endregion

            #region CALCULATE MACHINE with SWITCH-CASE

            Console.WriteLine("------ CALCULATE MACHINE ------\n\n");

            int number1, number2, result;
            char symbol;

            Console.Write("NUMBER 1 : ");
            number1=int.Parse(Console.ReadLine());
            Console.Write("NUMBER 2 : ");
            number2 = int.Parse(Console.ReadLine());

            Console.Write("OPERATION'S SYMBOL (+,-,*,/) : ");
            symbol = char.Parse(Console.ReadLine());

            Console.WriteLine("--------------\n\n");

            switch (symbol)
            {
                case '+':
                    result=number1 + number2;
                    Console.Write("Result : " + result);
                    break;
                case '-':
                    result = number1 - number2;
                    Console.Write("Result : " + result);
                    break;
                case '*':
                    result = number1 * number2;
                    Console.Write("Result : " + result);
                    break;
                case '/':
                    result = number1 / number2;
                    Console.Write("Result : " + result);
                    break;
                default:
                    Console.Write("wrong operation...");
                    break;
            }


            #endregion


            Console.Read();
        }
    }
}
