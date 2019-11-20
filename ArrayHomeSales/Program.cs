using System;
using static System.Console;

namespace ArrayHomeSales
{
    class Program
    {
        static void Main(string[] args)
        {
                char letter;
                string inputString;
                double sale, grandTotal;

                string[] names = { "Danielle", "Edward", "Francis" };
                char[] initials = { 'd', 'e', 'f' };
                double[] totals = new double[3];

                //get the user input and set it to lowercase
                Write("Enter a salesperson initial >> ");
                inputString = ReadLine();
                inputString = inputString.ToLower();
                letter = Convert.ToChar(inputString);

                int post = 0;
                while (letter != 'Z' && letter != 'z')
                {
                    Write("Enter amount of sale >> ");
                    inputString = ReadLine();
                    sale = Convert.ToDouble(inputString);

                    post = Array.BinarySearch(initials, letter);
                    if (post >= 0)
                        totals[post] += sale;
                    else
                        WriteLine("Sorry - invalid salesperson.");

                    Write("Enter next salesperson intital Z to quit >> ");
                    inputString = ReadLine();
                    inputString = inputString.ToLower();
                    letter = Convert.ToChar(inputString);
                }
                
                //prints out the employees names with their totals
            for(int x = 0; x < totals.Length; ++x)
            {
                WriteLine("{0} sold    {1,10}", names[x], totals[x].ToString("C"));
            }
            
            //gets the grandtotal
                grandTotal = 0;
                for (int x = 0; x < totals.Length; ++x)
                {
                    grandTotal += totals[x];
                }
                WriteLine("Total sales were {0,10}", grandTotal.ToString("C"));

            //finds the person with the most sales
                int mostSales = 0;
                for (int x = 1; x < totals.Length; ++x)
                {
                    if (totals[x] > totals[mostSales])
                    {
                        mostSales = x;
                    }
                }

                WriteLine("{0} sold the most", names[mostSales]);

            }
        }
    }


