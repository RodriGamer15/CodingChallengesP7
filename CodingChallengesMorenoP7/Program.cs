using System;



class Challenges
{


    public static void Main(string[] args)
    {
        bool work = true;
        //Welcome the user to my program
        Console.WriteLine("Welcome to my coding challenge program. I will be making a variety of functions for you to use. \n Please pick one.");

        var choice = Console.ReadLine();
        int choiceInt = int.Parse(choice);

        while (work)
        {
            if (choiceInt == 1)
            {
                Console.WriteLine("We are going to use the number adder today called sum. Please give me two numbers.");

                var number1 = Console.ReadLine();
                int numberToUse1 = int.Parse(number1);

                Console.WriteLine("Got it, give me your 2nd number.\n");

                var number2 = Console.ReadLine();
                int numberToUse2 = int.Parse(number2);

                Console.WriteLine("The sum of the number: " + number1 + " and the number: " + number2 + " is equal to: " + Sum(numberToUse1, numberToUse2));
                Sum(numberToUse1, numberToUse2);
            }
            else if (choiceInt == 2)
            {
                Console.WriteLine("I am going to convert minutes to seconds.\nPlease input a number to convert.");

                var number3 = Console.ReadLine();
                int numberToUse3 = int.Parse(number3);

                Console.WriteLine("If I convert: " + number3 + "minutes to seconds. I get" + Convert(numberToUse3) + "Seconds");
            }

            else if (choiceInt == 3)
            {
                Console.WriteLine("I am going to add +1 to a number.\nPlease input a number to add 1 to.");

                var number4 = Console.ReadLine();
                int numberToUse4 = int.Parse(number4);
                numberToUse4 = PlusOne(numberToUse4);
                Console.WriteLine($"You're new number is {numberToUse4}");
            }

            else if (choiceInt == 4)
            {
                Console.WriteLine("I am going to get the calculated power of voltage and current.\n Please input a voltage");

                var number5 = Console.ReadLine();
                int numberToUse5 = int.Parse(number5);

                Console.WriteLine("Got it, give me your current.\n");

                var number6 = Console.ReadLine();
                int numberToUse6 = int.Parse(number6);
                Console.WriteLine("You're circuit power is: " + Power(numberToUse5, numberToUse6));
            }

            else if (choiceInt == 5)
            {
                Console.WriteLine("I am going to convert years into days.\nPlease input a number to convert. ");

                var number7 = Console.ReadLine();
                int numberToUse7 = int.Parse(number7);

                Console.WriteLine("If I convert: " + number7 + "years to days. I get" + CalcAge(numberToUse7) + "Days");
            }

            else if (choiceInt == 6)
            {
                Console.WriteLine("I am going to find the area of a triangle.\nPlease input a base");

                var number8 = Console.ReadLine();
                int numberToUse8 = int.Parse(number8);

                Console.WriteLine("Got it, give me your height.\n");

                var number9 = Console.ReadLine();
                int numberToUse9 = int.Parse(number9);

                Console.WriteLine("Your area is: " + CalcTriArea(numberToUse8, numberToUse9));
            }

            else if (choiceInt == 7)
            {
                Console.WriteLine("We are going to see if a number is less than or equal to zero.\nPlease input a number");

                var number10 = Console.ReadLine();
                int numberToUse10 = int.Parse(number10);

                Console.WriteLine("Your number is less than or equal to 0." + LessThanOrEqualToZero(numberToUse10));
            }

            else if (choiceInt == 8)
            {
                Console.WriteLine("We are going to see if the sum of two numbers is less than 100\nPlease input your first number");

                var number11 = Console.ReadLine();
                int numberToUse11 = int.Parse(number11);

                Console.WriteLine("Got it, give me your second number.");

                var number12 = Console.ReadLine();
                int numberToUse12 = int.Parse(number12);

                Console.WriteLine("Your number is less than 100." + LessThanOneHundred(numberToUse11, numberToUse12));
            }

            else if (choiceInt == 9)
            {
                Console.WriteLine("We are going to see if two integers are equal.\nPlease input your first integer.");

                var number13 = Console.ReadLine();
                int numberToUse13 = int.Parse(number13);

                Console.WriteLine("Got it, give me your second integer.");

                var number14 = Console.ReadLine();
                int numberToUse14 = int.Parse(number14);

                Console.WriteLine("Your first integer " + number13 + "and your second integer " + number14 + IsEqualTo(numberToUse13, numberToUse14));
            }

            else if (choiceInt == 10)
            {
                Console.WriteLine();
            }

            else if (choiceInt == 11)
            {
                Console.WriteLine("I am going to reverse true or false boolean statements\n Please input your true or false statements.");

                var words1 = Console.ReadLine();
                bool wordsToUse1 = bool.Parse(words1);
                if (words1 == "true")
                {
                    Console.WriteLine("False!");
                }
                else if (words1 == "false")
                {
                    Console.WriteLine("True!");
                }
            }

            else if (choiceInt == 12)
            {
                Console.WriteLine("I am going to convert hours to seconds. \nPlease input a number to convert.");

                var number15 = Console.ReadLine();
                int numberToUse15 = int.Parse(number15);

                Console.WriteLine("If I convert: " + number15 + "hours to seconds. I get" + Converting(numberToUse15) + "Seconds");
            }

            else if (choiceInt == 13)
            {
                Console.WriteLine("I am going to find the sum of the interior angles of a number-sided polygon. \nPlease input a number.");

                var number16 = Console.ReadLine;
                int numberToUse16 = int.Parse(number16);

                Console.WriteLine("The sum of the interior angles of your polygon is: " + SumPolygon(numberToUse16));
            }

            else if (choiceInt == 14)
            {
                Console.WriteLine("We are going to concatenate a passed string with string Edabit.\n Please type something in.");
                string words2 = Console.ReadLine;
                Console.WriteLine(nameString(words2));
            }
        }

    }

    public static int Sum(int number1, int number2)
    {
        return number1 + number2;
    }

    public static int Convert(int number3)
    {
        return number3 * 60;
    }

    public static int PlusOne(int numberToUse4)
    {
        return numberToUse4 + 1;
    }

    public static int Power(int numberToUse5, int numberToUse6)
    {
        return numberToUse5 * numberToUse6;
    }

    public static int CalcAge(int number7)
    {
        return number7 * 365;
    }

    public static float CalcTriArea(float number8, float number9)
    {
        return ((number8 * number9) / (2));
    }

    public static bool LessThanOrEqualToZero(int numberToUse10)
    {
        return numberToUse10 <= 0;
    }

    public static bool LessThanOneHundred(int numberToUse11, int numberToUse12)
    {
        return (numberToUse11 + numberToUse12) <= 100;
    }

    public static bool IsEqualTo(int numberToUse13, int numberToUse14)
    {
        return numberToUse13 == numberToUse14;
    }

    public static int Converting(int number15)
    {
        return number15 * 60;
    }

    public static int SumPolygon(int numberToUse16)
    {
        return (numberToUse16 - 2) * 180;
    }

    public static bool Reverse(bool words1)
    {
        return words1;
    }

    public static string nameString(string words2)
    {
        return words2 + "Edabit";
    }
}
