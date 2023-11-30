using System;
  
 class Program
{
    static void Main()
    {
        Console.WriteLine("The sum of 1 and 5 is:" + Sum(1, 5));
        Console.WriteLine("There are " + Converter(5) + "seconds in 5 minutes");
        Console.WriteLine("The number is: " + PlusOne(23));
        Console.WriteLine("The power is: " + Power(230, 10));
        Console.WriteLine("15 years old is the same as " + Age(15) + "days old");
        Console.WriteLine("When the base off the base is 4 and the height is 6 then the area is " + Triangle(4, 6));
        int inputNumber = 5;
        bool result = LessThanOrEqualToZero(inputNumber);

        if (result)
        {
            Console.WriteLine($"{inputNumber} <=0 : true");
        }
        else
        {
            Console.WriteLine($"{inputNumber} <= 0: false");
        }
        Console.WriteLine("22 plus 13 is less than 100, this state,ment is " + LessThan100(22, 13));
        Console.WriteLine("8342534 is equal to 8342534, this statement is " + EqualTo(8342534, 8342534));
        Console.WriteLine(GiveMeSomething("Is Wrong."));
        Console.WriteLine("False is " + Reverse(false));
        Console.WriteLine("24 hours is also " + howManySeconds(24) + "seconds");
        Console.WriteLine("A polygon with 12 sides has " + sumPolygon(12) + " degree internal angle");
        Console.WriteLine("The name is " + nameString("John"));
        Console.WriteLine(And(true, false));
        Console.WriteLine("There were " + points(3, 13) + " points scored during the game");

    }

    public static int Converter(int minute)
    {
        int sec = minute * 60;
        return sec;
    }

    public static int Sum(int a, int b)
    {
        int c = a + b;
        return c;
    }

    public static int PlusOne(int number)
    {
        int n = number + 1;
        return n;
    }

    public static int Power(int v, int c)
    {
        int p = v * c;
        return p;
    }
    public static int Age(int year)
    {
        int days;
        days = year * 365;
        return days;
    }
    public static int Triangle(int b, int h)
    {
        int a = (b * h) / 2;
        return a;
    }
    static bool LessThanOrEqualToZero(int number)
    {
        return number <= 0;
    }
    public static bool LessThan100(int a, int b)
    {
        int c = a + b;
        if (c < 100)
        {
            return true;
        }
        return false;   
    }
    public static bool EqualTo(int a, int b)
    {
        if (a == b) return true;
        return false;
    }
    public static string GiveMeSomething(string s)
    {
        string something = ("Something ");
        s = (something + s);
        return s;
    }
    public static bool Reverse(bool b)
    {
        return b;
    }
    public static int howManySeconds(int s)
    {
        return s * 3600;
    }

    public static int sumPolygon(int p)
    {
        return (p - 2) * 180;
    }

    public static string nameString(string first)
    {
        string last = ("Edabit");
        return first + last;
    }

    public static bool And(bool a, bool b)
    {
        if (a && b == true) return true;
        else return false;
    }

    public static int points(int o, int t)
    {
        o = o * 2; t = t * 3;
        return o + t;
    }



}



