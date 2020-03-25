using System;

namespace Numfrom0to100
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, choose some number:");
            Console.Write("number = ");
            double num = double.Parse(Console.ReadLine());
            if  (num < 0 || num > 100) {
                Console.WriteLine("The chosen number is out of range[0,100]");
            } else if (num >= 0 && num <= 14) {
                Console.WriteLine("The chosen number is in range[0,14]");
            } else if (num >=15 && num <= 35) {
                Console.WriteLine("The chosen number is in range[15,35]");
            } else if (num >= 36 && num <= 50) {
                Console.WriteLine("The chosen number is in range[36,50]");
            } else {
                Console.WriteLine("The chosen number is in range[50,100]");
            }
            Console.ReadKey();

        }
    }
}
