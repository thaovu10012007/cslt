using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace cslt.session04
{
    internal class ex04
    {
        static void Bai_1 ()
        {
            Console.Write("Input a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Input b: ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine($"{a} + {b} = {a + b}");
            Console.WriteLine($"{a} - {b} = {a - b}");
            Console.WriteLine($"{a} x {b} = {a * b}");
            Console.WriteLine($"{a} / {b} = {a / b}");
            Console.WriteLine($"{a} mod {b} = {a % b}");
        }
        static void Bai_2 ()
        {
            for (int y = -5; y <= 5; y++) 
            {
                int x = y * y + 2 * y + 1;
                Console.WriteLine($"y = {y}, x = {x}");
            }

        static void Bai_3 ()
            {
                Console.Write("Input distance (km): ");
                double distance = double.Parse(Console.ReadLine());

                Console.Write("Input hours: ");
                double hours = double.Parse(Console.ReadLine());

                Console.Write("Input minutes: ");
                double minutes = double.Parse(Console.ReadLine());

                Console.Write("Seconds: ");
                double seconds = double.Parse(Console.ReadLine());
                double total = hours + minutes / 60.0 + seconds / 3600.0;
                double speedkmh = distance / total;
                double miles = distance / 1609.9;
                double speedmilesh = miles / total;
                Console.WriteLine($"speed in kilometers per hour: {speedkmh} (km / h)");
                Console.WriteLine($"speed in miles per hour: {speedmilesh} (miles / h)");
            }
        static void Bai_4 ()
            {
                Console.Write("Input radius: ");
                if (double.TryParse(Console.ReadLine(), out double radius))
                {
                    double surface = 4 * Math.PI * Math.Pow(radius, 2);
                    double volume = (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);

                    Console.WriteLine($"Surface: {surface:F2}");
                    Console.WriteLine($"Volume: {volume:F2}");
                }
                else
                {
                    Console.WriteLine("Incorrect, please try again");
                }
            }
        static void Bai_5 ()
            {
                Console.Write("Enter a character: ");
                char c = char.Parse(Console.ReadLine());

                if ("aeiouAEIOU".Contains(c))
                {
                    Console.WriteLine("Vowel");
                }
                else if (char.IsDigit(c))
                {
                    Console.WriteLine("Digit");
                }
                else
                {
                    Console.WriteLine("Other symbol");
                }
            }
            static void giaiPT ()
            {
                Console.Write("nhập hệ số a: "); int a = int.Parse(Console.ReadLine());
                Console.Write("nhập hệ số a: "); int b = int.Parse(Console.ReadLine());
                Console.Write("nhập hệ số a: "); int c = int.Parse(Console.ReadLine());
            }
            static void Main(string[] args)
            {
                Bai_1();
                Bai_2();
                Bai_3();
                Bai_4();
                Bai_5();
            }
        }
    }
}
