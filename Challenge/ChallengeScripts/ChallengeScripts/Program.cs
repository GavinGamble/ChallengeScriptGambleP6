using System;

class Challenges
{
    static void Main()
    {
        Console.WriteLine("The sum of 1 and 5 is:" + Sum(1, 5));
        Console.WriteLine("There are " + Converter(5) + "seconds in 5 minutes");
        Console.WriteLine("The number is: " + PlusOne(23));
        Console.WriteLine("The power is: " + Power(230, 10));
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
}




