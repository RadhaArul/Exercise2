using System;
using System.Text.RegularExpressions; // for string manipulation
// Radha Manickam Exercise 2
// C# övning2 - Flöde via loopar och strängmanipulation
// I have validated extra assignment also.
namespace Exercise2
{ 
    class Program
    {
        static void Main(string[] args)
        {
            bool displaymenu = true;
            while (displaymenu)
            {
                displaymenu = Menu();
            }
        }
        private static bool Menu()
        {
            Console.Clear();
            Console.WriteLine("Main Menu");
            Console.WriteLine("---------");
            Console.WriteLine("Enter the options ");
            Console.WriteLine("1. Buy Bio Ticket ");
            Console.WriteLine("2. Repeate the Input 10 times");
            Console.WriteLine("3. Printing the 3rd word in an Input");
            Console.WriteLine("0. Exit ");
            string result = Console.ReadLine();
            switch(result)
            {
                case "0":
                    {
                        return false;
                    }
                case "1":
                    {
                        BuyBioTicket(); // calling the userdefined function for optionMenu 1:
                        return true;
                    }
                case "2":
                    {
                        Repeat10times(); // calling the userdefined funcion for optionMenu 2:
                        return true;
                    }
                case "3":
                    {
                        Printing3rdword(); // calling the userdefined function for optionMenu 3:
                        return true;
                    }
                default:
                    {
                        Console.WriteLine("Invalid Input! Press Enter Key to Try again!");
                        Console.ReadLine();
                        return true;
                    }
            }
            
        }

        private static void BuyBioTicket() // User defined function to buy a Film Ticket
        {
            Console.Clear();
            Console.WriteLine("Please enter how many members ");
            int Members = int.Parse(Console.ReadLine());

            if(Members == 1) // For Single Ticket
            {
                Console.WriteLine("Please enter your Age ");
                int Age = int.Parse(Console.ReadLine());
                Console.Clear();
                if (Age > 5 && Age <= 20)
                {
                    Console.WriteLine("Number of Ticket is : 1 ");
                    Console.WriteLine(" Youth Price : 80kr");
                }
                else if (Age > 65 && Age < 100)
                {
                    Console.WriteLine("Number of Ticket is : 1 ");
                    Console.WriteLine("Pensioner Price is : 90kr");
                }
                else if (Age > 20 && Age <= 65)
                {
                    Console.WriteLine("Number of Ticket is : 1 ");
                    Console.WriteLine("Standard Price is : 120kr");
                }
                else if (Age > 0 && Age <= 5)
                {
                    Console.WriteLine("Number of Ticket is : 1 ");
                    Console.WriteLine("Child under 5 is Free");
                }
                else if (Age > 100)
                {
                    Console.WriteLine("Number of Ticket is : 1 ");
                    Console.WriteLine("Pensioner over 100 is Free");
                }
            }
            else // For Group Ticket
            {
                int[] age = new int[Members];
                int TotalPrice = 0;
                Console.WriteLine($"Please Enter the Age for {Members} Members");
                for (int i=0;i<Members;i++)
                {
                    age[i] = int.Parse(Console.ReadLine());
                    if (age[i] > 5 && age[i] < 20)
                        TotalPrice += 80;
                    else if (age[i] > 65 && age[i] < 100)
                        TotalPrice += 90;
                    else if (age[i]>=20 && age[i]<=65)
                        TotalPrice += 120;
                }
                Console.Clear();
                Console.WriteLine($"Total number of Persons : {Members}");
                Console.WriteLine($"Total Price for the Group : {TotalPrice}");
            }
            Console.WriteLine("\n Press Enter Key to go back to Main Menu");
            Console.ReadLine();
        }

        private static void Printing3rdword() // Printing 3rd word from the user input text with the help of string manipulation
        {
            Console.Clear();
            Console.WriteLine("Enter any Text with atleast 3 words ");
            var texT = Console.ReadLine();
            texT = texT.Trim(); // Remove leading and trailing white spaces
            
            string trim = Regex.Replace(texT, @"\s+", " "); // Remove multiple white spaces
            string[] Words = trim.Split(' ');

            //Validating User Input
            int WordCount = int.Parse(Words.Length.ToString()); 

            if (WordCount < 3)
                Console.WriteLine("Invalid!!!!  Enter atleast 3 word text");
            else
                Console.WriteLine($"The 3rd Word is : ({Words[2]})");
            Console.WriteLine("Press Enter Key to go back to Main Menu");
            Console.ReadLine();
        }

        private static void Repeat10times() // Printing the user input 10 times with the help of for loop
        {
            Console.Clear();
            Console.WriteLine("Enter any Text");
            string Text = Console.ReadLine();
            for(int i=1;i<=10;i++)
            {
                Console.Write($"{i}. {Text} ");
            }
            Console.WriteLine("\n Press Enter Key to go back to Main Menu");
            Console.ReadLine();
        }
    }
}

