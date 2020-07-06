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
            string sideLength = "";
            string sideWidth = "";
            string sideHeight = "";
            double sLength = 0;
            double sWidth = 0;
            double sHeight = 0;
            string w1 = "length";
            string w2 = "width";
            string w3 = "height";

            while (keepMeasuring)
            {
                AskQuestion(w1);
                sideLength = GetString(sideLength);
                sLength = GetParseDouble(sideLength, sLength);

                AskQuestion(w2);
                sideWidth = GetString(sideLength);
                sWidth = GetParseDouble(sideWidth, sWidth);

                AskQuestion(w3);
                sideHeight = GetString(sideLength);
                sHeight = GetParseDouble(sideHeight, sHeight);

                double area = GetArea(sLength, sWidth);
                double perimeter = GetPerimeter(sLength, sWidth);
                double volume = GetVolume(area, sHeight);
                string roomSize = GetRoomSize(area);

                DisplayAnswers(area, perimeter, volume, roomSize);

                bool keepGoing = true;

                //Note to self: Work on GetBool methods.
                while (keepGoing)
                {
                    Console.WriteLine("Would you like to continue measuring rooms? (Y/N)");

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

        public static void AskQuestion(string input)
        {
            Console.WriteLine($"Please enter the {input} of the room.");
        }
        public static string GetString(string input)
        {
            string output;
            return output = Console.ReadLine();
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


