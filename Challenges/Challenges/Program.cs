using System.Globalization;
using System;
using System.Globalization;

class Challenges
{
    public static void Main()
    {  
        //challenge 24
        Console.WriteLine("The base number 6 multiplied by the exponent 4 has a product of " + calculateExponent(6, 4));
        //challenge 25
        int[] lengths = { 0, 11, -9, 12, 5 };
        Console.WriteLine("The array 0, 11, -9, 12, 5 multiplied by the length gives the new array " + MultiplyBylength(lengths));
        //challenge 26
        Console.WriteLine("The hamming distance for the line abcdefgg and abcdefgh is " + HammingDistance("abcdefgg", "abcdefgh"));
    }
    public static int calculateExponent(int b, int e)
    {
        return (int)Math.Pow(b, e);
    }

    public static int MultiplyBylength(int[] l)
    {
        int a = l[0] * l.Length;
        int b = l[1] * l.Length;
        int c = l[2] * l.Length;
        int d = l[3] * l.Length;
        int e = l[4] * l.Length;
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
        Console.WriteLine(d);
        return e;
    }

    public static int HammingDistance(string first, string second)
    {
        int count = 0;

        if (first.Length > second.Length || first.Length < second.Length) { throw new ArgumentException(); }
        else if (first.Length == 0 || second.Length == 0) { count = 0; }
        else if (first == second) { count = 0; }
        else
        {
            for (int i = 0; i < first.Length; i++)
            {
                if (first[i] != second[i])
                {
                    count++;
                }
            }
        }
        return count;
    }
}
