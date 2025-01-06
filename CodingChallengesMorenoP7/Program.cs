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

                var number16 = Console.ReadLine();
                int numberToUse16 = int.Parse(number16);

                Console.WriteLine("The sum of the interior angles of your polygon is: " + SumPolygon(numberToUse16));
            }

            else if (choiceInt == 14)
            {
                Console.WriteLine("We are going to concatenate a passed string with string Edabit.\n Please type something in.");
                string words2 = Console.ReadLine();
                Console.WriteLine(nameString(words2));
            }

            else if (choiceInt == 15)
            {
                Console.WriteLine("We are going to see if two boolean values are giving true and false.\n Please give me true or false.");
                var words3 = Console.ReadLine();
                bool wordsToUse3 = bool.Parse(words3);
                Console.WriteLine("Got it. Please give me true or false again.");
                var words4 = Console.ReadLine();
                bool wordsToUse4 = bool.Parse(words4);
                if ((wordsToUse3 == true) && (wordsToUse4 == false))
                {
                    Console.WriteLine("It's false.");
                }
                else if ((wordsToUse3 == true) && (wordsToUse4 == true))
                {
                    Console.WriteLine("It's true.");
                }
                else if ((wordsToUse3 == false) && (wordsToUse4 == true))
                {
                    Console.WriteLine("It's false.");
                }
                else if ((wordsToUse3 == false) && (wordsToUse4 == false))
                {
                    Console.WriteLine("It's false.");
                }
            }

            else if (choiceInt == 16)
            {
                Console.WriteLine("We are going to see how many points were scored based on 3-pointers & 2-pointers.\n Please input a value for 3-pointers.");

                var number17 = Console.ReadLine();
                int numberToUse17 = int.Parse(number17);

                Console.WriteLine("Got it. Give me a value for 2-pointers.");

                var number18 = Console.ReadLine();
                int numberToUse18 = int.Parse(number18);

                Console.WriteLine("The total points scored in the game were: " + Points(numberToUse17, numberToUse18));
            }

            else if (choiceInt == 17)
            {
                Console.WriteLine("We are going to find the perimeter of a rectangle.\n Please input a value for length.");

                var number19 = Console.ReadLine();
                int numberToUse19 = int.Parse(number19);

                Console.WriteLine("Got it. Give me a value for width.");

                var number20 = Console.ReadLine();
                int numberToUse20 = int.Parse(number20);

                Console.WriteLine("The perimeter of the rectangle is: " + Perimeter(numberToUse19, numberToUse20));
            }

            else if (choiceInt == 18)
            {
                Console.WriteLine("We are going to make a greeting\n Please type in a name.");
                string words4 = Console.ReadLine();
                Console.WriteLine(HelloName(words4));
            }

            else if (choiceInt == 19)
            {
                Console.WriteLine("We are going to find the total number of legs among a farmer's animals.\n Please input the number of chickens the farmer has.");

                var number21 = Console.ReadLine();
                int numberToUse21 = int.Parse(number21);

                Console.WriteLine("Got it. Give me a value for the number of cows.");

                var number22 = Console.ReadLine();
                int numberToUse22 = int.Parse(number22);

                Console.WriteLine("Got it. Give me a value for the number of pigs.");

                var number23 = Console.ReadLine();
                int numberToUse23 = int.Parse(number23);

                Console.WriteLine("The total number of legs among a farmer's animals are: " + Animals(numberToUse21, numberToUse22, numberToUse23));
            }

            else if (choiceInt == 20)
            {
                Console.WriteLine("We are going to find the number of points a football team has obtained through wins, draws, and losses.\n Please input the number of wins the team has obtained.");

                var number24 = Console.ReadLine();
                int numberToUse24 = int.Parse(number24);

                Console.WriteLine("Got it. Give me the number of draws.");

                var number25 = Console.ReadLine();
                int numberToUse25 = int.Parse(number25);

                Console.WriteLine("Got it. Give me the number of losses.");

                var number26 = Console.ReadLine();
                int numberToUse26 = int.Parse(number26);

                Console.WriteLine("The total number of points the football team has obtained through wins, draws, and losses are " + FootballPoints(numberToUse24, numberToUse25, numberToUse26));
            }

            else if (choiceInt == 21)
            {
                Console.WriteLine("We are going to input a number and get its corresponding month. Give me a number between 1 and 12.");

                Months();
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
        return words2 + " Edabit";
    }

    public static bool And(bool words3, bool words4)
    {
        return words3;
        return words4;
    }

    public static int Points(int numberToUse17, int numberToUse18)
    {
        return (numberToUse17 * 3) + (numberToUse18 * 2);
    }

    public static int Perimeter(int numberToUse19, int numberToUse20)
    {
        return (numberToUse19 * 2) + (numberToUse20 * 2);
    }

    public static string HelloName(string words4)
    {
        return "Hello " + words4;
    }

    public static int Animals(int numberToUse21, int numberToUse22, int numberToUse23)
    {
        return (numberToUse21 * 2) + (numberToUse22 * 4) + (numberToUse23 * 4);
    }

    public static int FootballPoints(int numberToUse24, int numberToUse25, int numberToUse26)
    {
        return (numberToUse24 * 3) + (numberToUse25 * 1) + (numberToUse26 * 0);
    }

    public static void Months()
    {
        redo:
        var input21 = Console.ReadLine();
        int number21 = int.Parse(input21);
        if (number21 < 1)
        {
            Console.WriteLine("Invalid number. Try again.");
            goto redo;
        }
        if (number21 > 12)
        {
            Console.WriteLine("Invalid number. Try again.");
            goto redo;
        }
        else
        {
            switch (number21)
            {
                case 1:
                    Console.WriteLine("January");
                    break;
                case 2:
                    Console.WriteLine("February");
                    break;
                case 3:
                    Console.WriteLine("March");
                    break;
                case 4:
                    Console.WriteLine("April");
                    break;
                case 5:
                    Console.WriteLine("May");
                    break;
                case 6:
                    Console.WriteLine("June");
                    break;
                case 7:
                    Console.WriteLine("July");
                    break;
                case 8:
                    Console.WriteLine("August");
                    break;
                case 9:
                    Console.WriteLine("September");
                    break;
                case 10:
                    Console.WriteLine("October");
                    break;
                case 11:
                    Console.WriteLine("November");
                    break;
                case 12:
                    Console.WriteLine("December");
                    break;


            }
        }
    }
}
