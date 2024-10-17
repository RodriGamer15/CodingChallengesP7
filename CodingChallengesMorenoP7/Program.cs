using System;


class Challenges
{


    public static void Main(string[] args)
    {

        //Welcome the user to my program
        Console.WriteLine("Welcome to my coding challenge program. I will be making a variety of functions for you to use. \n Please pick one.");

        Console.WriteLine("We are going to use the number adder today called sum. Please give me two numbers.");

        var number1 = Console.ReadLine();
        int numberToUse1 = int.Parse(number1);

        Console.WriteLine("Got it, give me your 2nd number.\n");

        var number2 = Console.ReadLine();
        int numberToUse2 = int.Parse(number2);

        Console.WriteLine("The sum of the number: " + number1 + " and the number: " + number2 + " is equal to: " + Sum(numberToUse1, numberToUse2));
        Sum(numberToUse1, numberToUse2);

        Console.WriteLine("I am going to convert minutes to seconds.\nPlease input a number to convert.");

        var number3 = Console.ReadLine();
        int numberToUse3 = int.Parse(number3);

        Console.WriteLine("If I convert: " + number3 + "minutes to seconds. I get" + Convert(numberToUse3) + "Seconds");

        Console.WriteLine("I am going to add +1 to a number.\nPlease input a number to add 1 to.");

        var number4 = Console.ReadLine();
        int numberToUse4 = int.Parse(number4);
        numberToUse4 = PlusOne(numberToUse4);
        Console.WriteLine($"You're new number is {numberToUse4}");

        Console.WriteLine("I am going to get the calculated power of voltage and current.\n Please input a voltage");

        var number5 = Console.ReadLine();
        int numberToUse5 = int.Parse(number5);

        Console.WriteLine("Got it, give me your current.\n");

        var number6 = Console.ReadLine();
        int numberToUse6 = int.Parse(number6);
        Console.WriteLine("You're circuit power is: " + Power(numberToUse5, numberToUse6));

        Console.WriteLine("I am going to convert years into days.\nPlease input a number to convert. ");

        var number7 = Console.ReadLine();
        int numberToUse7 = int.Parse(number7);

        Console.WriteLine("If I convert: " + number7 + "years to days. I get" + CalcAge(numberToUse7) + "Days");

        Console.WriteLine("I am going to find the area of a triangle.\nPlease input a base");

        var number8 = Console.ReadLine();
        int numberToUse8 = int.Parse(number8);

        Console.WriteLine("Got it, give me your height.\n");

        var number9 = Console.ReadLine();
        int numberToUse9 = int.Parse(number9);

        Console.WriteLine("Your area is: " + CalcTriArea(numberToUse8, numberToUse9));

        Console.WriteLine("We are going to see if a number is less than or equal to zero.\nPlease input a number");

        var number10 = Console.ReadLine();
        int numberToUse10 = int.Parse(number10);

        Console.WriteLine("Your number is less than or equal to 0." + LessThanOrEqualToZero(numberToUse10));
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
        return (number8 * number9) / 2;
    }

    public static bool LessThanOrEqualToZero(int numberToUse10)
    {
        return numberToUse10 <= 0;
    }
}
