using System;
using System.Security.Cryptography.X509Certificates;

namespace RoomCalculator
{
    class Program
    {
        //App prompts user to enter height and width.
        //Display area, perimeter and room size.
        //Room size classification (Requirements for small 1-250, med 251-649, large >= 650)
        //Room Volume
        //Prompt to continue, or end.

        static void Main(string[] args)
        {
            Build();
            //Kicks off the build method to begin the program.
        }
    
     public static void Build()
        {
            //Build list of important things we will need to use the program.
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

            //While loop to keep the code going until the user is finished.
            while (keepMeasuring)
            {
                //Ask method that pulls a question using a string to customize the query.
                AskQuestion(w1);
                sideLength = GetString(sideLength);

                //Parse method to turn the string into a double.
                sLength = GetParseDouble(sideLength, sLength);
                //Would probably add number validation instead of this in a real world situation.

                AskQuestion(w2);
                sideWidth = GetString(sideWidth);
                sWidth = GetParseDouble(sideWidth, sWidth);

                AskQuestion(w3);
                sideHeight = GetString(sideHeight);
                sHeight = GetParseDouble(sideHeight, sHeight);

                //Methods for the maths.
                double area = GetArea(sLength, sWidth);
                double perimeter = GetPerimeter(sLength, sWidth);
                double volume = GetVolume(area, sHeight);
                string roomSize = GetRoomSize(area);

                //Display method.
                DisplayAnswers(area, perimeter, volume, roomSize);

                //Continue measuring rooms ask.
                bool keepGoing = true;

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


