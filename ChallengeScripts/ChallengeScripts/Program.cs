using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

class Program
{
    public static void Main()
    {
        Console.WriteLine("24 hours is " + howManySeconds(24) + " seconds.");
        Console.WriteLine("A polygon with 12 sides has " + sumPolygon(12) + " degree internal angle");
        Console.WriteLine("The name is " + nameString("Dronk "));
        Console.WriteLine(And(true, false));
        Console.WriteLine("There were " + points(3, 13) + " points scored during the game");


        static int howManySeconds(int s)
        {
            return s * 3600;
        }

        static int sumPolygon(int p)
        {
            return (p - 2) * 180;
        }

        static string nameString(string first)
        {
            string last = ("Edabit");
            return first + last;
        }

        static bool And(bool a, bool b)
        {
            if (a && b == true) return true;
            else return false;
        }

        Console.WriteLine("There were " + points(3, 13) + " points scored during the game");
        Console.WriteLine("With a width of 12 and a length of 23 then the perimeter is " + findPerimeter(12, 23));
        Console.WriteLine(helloName("Gavin"));
        Console.WriteLine("If there are 5 chickens, 12 cows, and 9 pigs, then there are " + animals(5, 12, 9) + " total legs");
        Console.WriteLine("The football team had 11 wins, 2 draws, and 3 losses, so the team has points" + footballPoints(11, 2, 3));
        Console.WriteLine("This month is " + monthName(12));



        static int points(int o, int t)
        {
            o = o * 2; t = t * 3;
            return o + t;
        }

        static int findPerimeter(int w, int l)
        {
            int p = (2 * w) + (2 + l);
            return p;
        }

        static string helloName(string name)
        {
            return "Hello " + name + "!";
        }

        static int animals(int chicken, int cow, int pig)
        {
            return (chicken * 2) + (cow * 4) + (pig * 4);
        }

        static int footballPoints(int w, int d, int l)
        {
            return (w * 3) + d + (l * 0);
        }

        static string monthName(int m)
        {
            return CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(m);
        }


    }
}


