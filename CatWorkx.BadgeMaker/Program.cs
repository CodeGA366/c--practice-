using System;
using System.Formats.Asn1;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace CatWorkx.BadgeMaker
{
    class Program
    {
        //variable for area operation
        private static float area;

        static void Main(string[] args)
        {
            //basic C# string operations 
            Console.WriteLine("Hello, World!");
            Console.WriteLine("This is a test for the CatWorkx Badge Maker.");
            string greeting = "Hello ";
            greeting = greeting + "World!";
            Console.WriteLine("Greeting: " + greeting);

            //math operations
            float side = 5.0f;
            area = side * side;
            Console.WriteLine("Area of square with side " + side + " is: " + area);
            Console.WriteLine("area is a float: " + area.GetType());

            //boolean operations
            bool isCold = true;
            Console.WriteLine(isCold ? "drink" : "add ice");
            Console.WriteLine(!isCold ? "drink" : "add ice");

            //Data type conversion
            string stringNum = "2";
            int intNum = Convert.ToInt32(stringNum);
            Console.WriteLine(stringNum);
            Console.WriteLine("String to int: " + intNum);
            Console.WriteLine(intNum + 1);
            Console.WriteLine(intNum.GetType());
            Console.WriteLine(stringNum.GetType());

            //Dictionaries
            Dictionary<string, int> myScoreBoard = new Dictionary<string, int>();
            myScoreBoard.Add("first inning", 10);
            myScoreBoard.Add("second inning", 20);
            myScoreBoard.Add("third inning", 30);
            myScoreBoard.Add("fourth inning", 40);
            myScoreBoard.Add("fifth inning", 50);
            myScoreBoard.Add("sixth inning", 60);
            myScoreBoard.Add("seventh inning", 70);
            myScoreBoard.Add("eighth inning", 80);
            myScoreBoard.Add("ninth inning", 90);
            myScoreBoard.Add("tenth inning", 100);

            Dictionary<string, int> myScoreBoard2 = new Dictionary<string, int>(){
                {"first inning", 10},
                {"second inning", 20},
                {"third inning", 30},
                {"fourth inning", 40},
                {"fifth inning", 50},
                {"sixth inning", 60},
                {"seventh inning", 70},
                {"eighth inning", 80},
                {"ninth inning", 90},
                {"tenth inning", 100}
            };

            Console.WriteLine("_________________");
            Console.WriteLine("  Scoreboard 1");
            Console.WriteLine("_________________");
            foreach (KeyValuePair<string, int> kvp in myScoreBoard)
            {
                Console.WriteLine(kvp.Key + ": " + kvp.Value);
            }

            Console.WriteLine("_________________");
            Console.WriteLine("  Scoreboard 2");
            Console.WriteLine("_________________");
            foreach (KeyValuePair<string, int> kvp in myScoreBoard2)
            {
                Console.WriteLine(kvp.Key + ": " + kvp.Value);
            }

            int totalScore1 = myScoreBoard["first inning"] + myScoreBoard["second inning"] + myScoreBoard["third inning"] + myScoreBoard["fourth inning"] + myScoreBoard["fifth inning"] + myScoreBoard["sixth inning"] + myScoreBoard["seventh inning"] + myScoreBoard["eighth inning"] + myScoreBoard["ninth inning"] + myScoreBoard["tenth inning"];
            int totalScore2 = myScoreBoard2["first inning"] + myScoreBoard2["second inning"] + myScoreBoard2["third inning"] + myScoreBoard2["fourth inning"] + myScoreBoard2["fifth inning"] + myScoreBoard2["sixth inning"] + myScoreBoard2["seventh inning"] + myScoreBoard2["eighth inning"] + myScoreBoard2["ninth inning"] + myScoreBoard2["tenth inning"];
            Console.WriteLine("_________________");
            Console.WriteLine("Total Score 1: " + totalScore1);
            Console.WriteLine("Total Score 2: " + totalScore2);

            //arrays
            string[] favFoods = new string[3]{ "pizza", "sushi", "tacos" };
            string firstFood = favFoods[0];
            string secondFood = favFoods[1];
            string thirdFood = favFoods[2];
            Console.WriteLine("_________________");
            Console.WriteLine("  Favorite Foods");
            Console.WriteLine("_________________");
            Console.WriteLine("I like {0} and {1} and {2}", firstFood, secondFood, thirdFood);


            //lists
            List<string> employees = new List<string>() { "John", "Jane", "Bob", "Alice" };
            employees.Add("Charlie");
            employees.Add("Greg");

            Console.WriteLine("_________________");
            Console.WriteLine("  Employees");
            Console.WriteLine("_________________");
            foreach (string employee in employees)
            {
                Console.WriteLine(employee);
            }
            Console.WriteLine(employees);
            Console.WriteLine(employees.Count);

            //loops
            for (int i = 1; i < employees.Count; i++)
            {
                Console.WriteLine(employees[i]);
            } 
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}