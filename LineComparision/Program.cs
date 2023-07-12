using System;
namespace LineComparision
{
    class Program
    {
        static void Main(string[] args)
        {
            Operation line1 = new Operation(1, 2, 3, 4);
            double line1length = line1.CalculateLength(); 
            Operation line2 = new Operation(1, 2, 3, 4);
            double line2length = line2.CalculateLength();

            if (line1length.Equals(line2length))
                Console.WriteLine("Lines are equal");
            else
                Console.WriteLine("lines are not equal");

            if (line1length.CompareTo(line2length) == 0)
                Console.WriteLine("Lines are equal");
            if (line1length.CompareTo(line2length) <0)
                Console.WriteLine("Line1 < line 2");
            if (line1length.CompareTo(line2length) > 0)
                Console.WriteLine("Line1 > line 2");


        }
    }
}