using System;
using System.Security.Cryptography.X509Certificates;

namespace RoomCalculator
{
    class Program
    {
        //App prompts user to enter height and width.
        //Display area, perimeter and room size.
        //Room size classification (Requirements for small 1-250, med 251-649, large >= 650)
        //Prompt to continue, or end.

        static void Main(string[] args)
        {
            Build();           
        }
    
     public static void Build()
        {
            bool keepMeasuring = true;
            string continueAnswer;
            string answerToLower;

            while (keepMeasuring)
            {
                Console.WriteLine("Please enter the length of the room.");
                string sideLength = Console.ReadLine();
                double sLength = double.Parse(sideLength);

                Console.WriteLine("Please enter the width of the room.");
                string sideWidth = Console.ReadLine();
                double sWidth = double.Parse(sideWidth);

                Console.WriteLine("Please enter the height of the room.");
                string sideHeight = Console.ReadLine();
                double sHeight = double.Parse(sideHeight);

                double area = GetArea(sLength, sWidth);
                double perimeter = GetPerimeter(sLength, sWidth);
                double volume = GetVolume(area, sHeight);
                string roomSize = GetRoomSize(area);

                DisplayAnswers(area, perimeter, volume, roomSize);

                bool keepGoing = true;

                while (keepGoing)
                {
                    Console.WriteLine("Would you like to continue measuring rectangles? (Y/N)");

                    continueAnswer = Console.ReadLine();
                    answerToLower = continueAnswer.ToLower();

                    if (answerToLower == "yes" || answerToLower == "y")
                    {
                        keepGoing = false;
                        keepMeasuring = true;
                    }
                    else if (answerToLower == "no" || answerToLower == "n")
                    {
                        keepGoing = false;
                        keepMeasuring = false;
                    }
                    else
                    {
                        keepGoing = true;
                    }

                }

            }
        }

        public static string GetString(string input)
        {
            return input = Console.ReadLine();
        }

        public static double GetParseDouble(string input, double num1)
        {
           num1 = double.Parse(input);
           return num1;
        }
        
        public static double GetPerimeter(double num1, double num2)
        {
            double perimeter = 2 * (num1 + num2);
            return perimeter;
        }

        public static double GetArea(double num1, double num2)
        {
            double area = num1 * num2;
            return area;
        }

        public static double GetVolume(double num1, double num2)
        {
            double volume = num1 * num2;
            return volume;
        }

        public static string GetRoomSize(double num1)
        {
            string roomSize;

            if (num1 >= 650)
            {
                return roomSize = "Large Room";
            }
            else if (num1 >= 251 && num1 < 650)
            {
                return roomSize = "Medium Room";
            }
            else if (num1 > 0)
            {
                return roomSize = "Small Room";
            }
            else
            {
                return roomSize = "non-existent space";
            }
        }

        public static void DisplayAnswers(double num1, double num2, double num3, string size)
        {
            Console.WriteLine("");
            Console.WriteLine($"Area: {num1} feet.");
            Console.WriteLine($"Perimeter: {num2} feet.");
            Console.WriteLine($"Volume: {num3} feet.");
            Console.WriteLine($"Room size: {size}");
            Console.WriteLine("");

         }
        }

    }


