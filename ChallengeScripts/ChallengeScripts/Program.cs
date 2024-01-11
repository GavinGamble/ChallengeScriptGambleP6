using System.Diagnostics;
using System;

class Challenges
{
    static void Main()
    {
        Console.WriteLine("(1) return a + b");
        Console.WriteLine("(2) return minutes * 60;");
        Console.WriteLine("(3) return num + 1");
        Console.WriteLine("(4) return voltage * current");
        Console.WriteLine("(5) return years * 365");
        Console.WriteLine("(6) TriArea");
        Console.WriteLine("(7) return num <= 0");
        Console.WriteLine("(8) LessThan100");
        Console.WriteLine("(9) IsEqual");
        Console.WriteLine("(10) GiveMeSomething");
        Console.WriteLine("(11) Reverse");
        Console.WriteLine("(12) HowManySeconds");
        Console.WriteLine("(13) SumPolygon");
        Console.WriteLine("(14) NameString");
        Console.WriteLine("(15) Return And");
        Console.WriteLine("(16) Basketball Points");
        Console.WriteLine("(17) FindPerimeter");
        Console.WriteLine("(18) HelloName");
        Console.WriteLine("(19) Animals");
        Console.WriteLine("(20) FootballPoints");
        Console.WriteLine("(21) MonthName");
        Console.WriteLine("(22) FindMinMax");
        Console.WriteLine("(23) GetAbsSum");
        Console.WriteLine("(24) CalculateExponent");
        Console.WriteLine("(25) MultiplyByLength");
        Console.WriteLine("(26) HammingDistance");
        while (true)
        {
            Console.WriteLine("Hello, my name is Gavin and I have some programs for you to run.");
            Console.WriteLine("Enter challenge number (1-26) or press 8 to reset:");

            string input = Console.ReadLine();

            if (input == "8")
            {
                Console.Clear();
                continue;
            }

            switch (input)
            {
                case "1":
                    Challenge1();
                    break;
                case "2":
                    Challenge2();
                    break;
                case "3":
                    Challenge3();
                    break;
                case "4":
                    Challenge4();
                    break;
                case "5":
                    Challenge5();
                    break;
                case "6":
                    Challenge6();
                    break;
                case "7":
                    Challenge7();
                    break;
                case "8":
                    Challenge8();
                    break;
                case "9":
                    Challenge9();
                    break;
                case "10":
                    Challenge10();
                    break;
                case "11":
                    Challenge11();
                    break;
                case "12":
                    Challenge12();
                    break;
                case "13":
                    Challenge13();
                    break;
                case "14":
                    Challenge14();
                    break;
                case "15":
                    Challenge15();
                    break;
                case "16":
                    Challenge16();
                    break;
                case "17":
                    Challenge17();
                    break;
                case "18":
                    Challenge18();
                    break;
                case "19":
                    Challenge19();
                    break;
                case "20":
                    Challenge20();
                    break;
                case "21":
                    Challenge21();
                    break;
                case "22":
                    Challenge22();
                    break;
                case "23":
                    Challenge23();
                    break;
                case "24":
                    Challenge24();
                    break;
                case "25":
                    Challenge25();
                    break;
                case "26":
                    Challenge26();
                    break;
                default:
                    Console.WriteLine("Invalid input. Please enter a valid challenge number.");
                    break;
            }
        }
    }

    // Challenge 1
    static void Challenge1()
    {
        Console.WriteLine(Sum(1, 5));
    }

    static int Sum(int a, int b)
    {
        return a + b;
    }

    // Challenge 2
    static void Challenge2()
    {
        Console.WriteLine(Convert(5));
    }

    static int Convert(int minutes)
    {
        return minutes * 60;
    }

    // Challenge 3
    static void Challenge3()
    {
        Console.WriteLine(PlusOne(3));
    }

    static int PlusOne(int num)
    {
        return num + 1;
    }

    // Challenge 4
    static void Challenge4()
    {
        Console.WriteLine(CircuitPower(230, 10));
    }

    static int CircuitPower(int voltage, int current)
    {
        return voltage * current;
    }
    // Challenge 5
    static void Challenge5()
    {
        Console.WriteLine(CalcAge(65));
    }

    static int CalcAge(int years)
    {
        return years * 365;
    }

    // Challenge 6
    static void Challenge6()
    {
        Console.Write("Enter the base of the triangle: ");
        double baseValue;

        while (!double.TryParse(Console.ReadLine(), out baseValue) || baseValue <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a valid positive number for the base.");
            Console.Write("Enter the base of the triangle: ");
        }

        Console.Write("Enter the height of the triangle: ");
        double height;

        while (!double.TryParse(Console.ReadLine(), out height) || height <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a valid positive number for the height.");
            Console.Write("Enter the height of the triangle: ");
        }

        Console.WriteLine($"The area of the triangle is: {TriArea(baseValue, height)}");
    }

    static double TriArea(double baseValue, double height)
    {
        return (baseValue * height) / 2;
    }
    // Challenge 7
    static void Challenge7()
    {
        Console.WriteLine(LessThanOrEqualToZero(5));
    }

    static bool LessThanOrEqualToZero(int num)
    {
        return num <= 0;
    }

    // Challenge 8
    static void Challenge8()
    {
        Console.WriteLine(LessThan100(22, 15));
    }

    static bool LessThan100(int a, int b)
    {
        return (a + b) < 100;
    }

    // Challenge 9
    static void Challenge9()
    {
        Console.WriteLine(IsEqual(5, 6));
        Console.WriteLine(IsEqual(1, 1));
    }

    static bool IsEqual(int x, int y)
    {
        return x == y;
    }

    // Challenge 10
    static void Challenge10()
    {
        Console.WriteLine(GiveMeSomething("is better than nothing"));
        Console.WriteLine(GiveMeSomething("John Seed"));
        Console.WriteLine(GiveMeSomething("something"));
    }

    static string GiveMeSomething(string input)
    {
        return "something " + input;
    }

    // Challenge 11
    static void Challenge11()
    {
        Console.WriteLine(Reverse(true));
        Console.WriteLine(Reverse(false));
    }

    static bool Reverse(bool value)
    {
        return !value;
    }

    // Challenge 12
    static void Challenge12()
    {
        Console.WriteLine(HowManySeconds(2));
    }

    static int HowManySeconds(int hours)
    {
        return hours * 60 * 60;
    }

    // Challenge 13
    static void Challenge13()
    {
        Console.WriteLine(SumPolygon(3));
        Console.WriteLine(SumPolygon(4));
        Console.WriteLine(SumPolygon(6));
    }

    static int SumPolygon(int n)
    {
        return (n - 2) * 180;
    }

    // Challenge 14
    static void Challenge14()
    {
        Console.WriteLine(NameString("Mubashir"));
        Console.WriteLine(NameString("Matt"));
        Console.WriteLine(NameString("C#"));
    }

    static string NameString(string name)
    {
        return name + "Edabit";
    }

    // Challenge 15
    static void Challenge15()
    {
        Console.WriteLine(And(true, false));
        Console.WriteLine(And(true, true));
        Console.WriteLine(And(false, true));
        Console.WriteLine(And(false, false));
    }

    static bool And(bool a, bool b)
    {
        return a && b;
    }

    // Challenge 16
    static void Challenge16()
    {
        Console.WriteLine(Points(1, 1));
        Console.WriteLine(Points(7, 5));
    }

    static int Points(int twoPointers, int threePointers)
    {
        return (twoPointers * 2) + (threePointers * 3);
    }

    // Challenge 17
    static void Challenge17()
    {
        Console.WriteLine(FindPerimeter(6, 7));
        Console.WriteLine(FindPerimeter(20, 10));
    }

    static int FindPerimeter(int length, int width)
    {
        return 2 * (length + width);
    }

    // Challenge 18
    static void Challenge18()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.WriteLine("Hello " + name + "!");
    }

    // Challenge 19
    static void Challenge19()
    {
        Console.WriteLine(Animals(2, 3, 5));
        Console.WriteLine(Animals(1, 2, 3));
    }

    static int Animals(int chickens, int cows, int pigs)
    {
        return (chickens *

2) + (cows * 4) + (pigs * 4);
    }

    // Challenge 20
    static void Challenge20()
    {
        Console.WriteLine(FootballPoints(3, 4, 2));
        Console.WriteLine(FootballPoints(5, 0, 2));
    }

    static int FootballPoints(int wins, int draws, int losses)
    {
        return (wins * 3) + draws;
    }

    // Challenge 21
    static void Challenge21()
    {
        Console.WriteLine("Number\tMonth Name");
        Console.WriteLine("1\tJanuary");
        Console.WriteLine("2\tFebruary");
        Console.WriteLine("3\tMarch");
        Console.WriteLine("4\tApril");
        Console.WriteLine("5\tMay");
        Console.WriteLine("6\tJune");
        Console.WriteLine("7\tJuly");
        Console.WriteLine("8\tAugust");
        Console.WriteLine("9\tSeptember");
        Console.WriteLine("10\tOctober");
        Console.WriteLine("11\tNovember");
        Console.WriteLine("12\tDecember");

        Console.Write("Enter the month number: ");
        int monthNumber;

        while (!int.TryParse(Console.ReadLine(), out monthNumber) || monthNumber < 1 || monthNumber > 12)
        {
            Console.WriteLine("Invalid input. Please enter a valid month number (1-12).");
            Console.Write("Enter the month number: ");
        }

        Console.WriteLine("You chose " + monthNumber);
    }
    // Challenge 22
    static void Challenge22()
    {
        Console.WriteLine(FindMinMax(new int[] { 1, 2, 3, 4, 5 }));
        Console.WriteLine(FindMinMax(new int[] { 2334454, 5 }));
    }

    static int[] FindMinMax(int[] numbers)
    {
        int min = numbers[0];
        int max = numbers[0];

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] < min)
                min = numbers[i];
            if (numbers[i] > max)
                max = numbers[i];
        }

        return new int[] { min, max };
    }

    // Challenge 23
    static void Challenge23()
    {
        Console.WriteLine(GetAbsSum(new int[] { 2, -1, 4, 8, 10 }));
        Console.WriteLine(GetAbsSum(new int[] { -3, -4, -10, -2, -3 }));
    }

    static int GetAbsSum(int[] numbers)
    {
        int sum = 0;

        foreach (int num in numbers)
        {
            sum += Math.Abs(num);
        }

        return sum;
    }

    // Challenge 24
    static void Challenge24()
    {
        Console.Write("Enter the base number: ");
        double baseNum;

        while (!double.TryParse(Console.ReadLine(), out baseNum))
        {
            Console.WriteLine("Invalid input. Please enter a valid number for the base.");
            Console.Write("Enter the base number: ");
        }

        Console.Write("Enter the exponent number: ");
        double exponent;

        while (!double.TryParse(Console.ReadLine(), out exponent))
        {
            Console.WriteLine("Invalid input. Please enter a valid number for the exponent.");
            Console.Write("Enter the exponent number: ");
        }

        Console.WriteLine($"The result of {baseNum}^{exponent} is: {CalculateExponent(baseNum, exponent)}");
    }

    static double CalculateExponent(double baseNum, double exponent)
    {
        return Math.Pow(baseNum, exponent);
    }
    // Challenge 25
    static void Challenge25()
    {
        Console.WriteLine(MultiplyByLength(new int[] { 2, 3, 1, 0 }));
        Console.WriteLine(MultiplyByLength(new int[] { 4, 1, 1 }));
    }

    static int[] MultiplyByLength(int[] numbers)
    {
        int multiplier = numbers.Length;

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] *= multiplier;
        }

        return numbers;
    }

    // Challenge 26
    static void Challenge26()
    {
        Console.WriteLine(HammingDistance("abcde", "bcdef"));
        Console.WriteLine(HammingDistance("abcde", "abcde"));
        Console.WriteLine(HammingDistance("strong", "strung"));
    }

    static int HammingDistance(string str1, string str2)
    {
        int distance = 0;

        for (int i = 0; i < Math.Min(str1.Length, str2.Length); i++)
        {
            if (str1[i] != str2[i])
                distance++;
        }

        return distance;
    }
}






