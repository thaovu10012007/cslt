using System;
using System.Collections.Generic;
using System.Text;

namespace cslt.session02
{
    internal class ex01
    {
        public static void Main(string[] args)
        {

            //1.To add/ Sum two numbers
            Console.Write("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"the answer is: {num1 + num2}");

            //2.To swap values of two variables
            Console.Write("Enter a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = a;
            a = b;
            b = c;
            Console.WriteLine($"After swapping:a={a} , b={b}/n");

            //3.To multiply two floating point numbers 
            Console.Write("Enter a floating number: ");
            float f1 = Convert.ToSingle(Console.ReadLine());
            Console.Write("Enter a second floating number: ");
            float f2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine($"the answer is: {f1 + f2}\n");

            //4.To convert feet to meter
            Console.WriteLine("Enter distance in feet: ");
            double feet = Convert.ToDouble(Console.ReadLine());
            double meters = feet * 0.3048;
            Console.WriteLine($"{feet} feet = {meters} meters\n");

            //5.Convert Celsius to Fahrenheit and Vice Versa
            Console.Write("Enter temperature in Celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());
            double fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine($"{celsius}°C = {fahrenheit} F ");

            //6.to find the Size of data types
            Console.WriteLine($"Size of double data type is {sizeof(double)}");
            Console.WriteLine($"Size of int data type is {sizeof(int)}");

            //7. to Print ASCII Value (tip: read character, print number of this char)
            Console.Write("Enter a character:");
            int ch = Console.Read();
            Console.WriteLine($"ASCII code of {(char)c} is {ch}");

            //8. to Calculate Area of Circle
            double r = 5.1;
            double ac = r * r * Math.PI;
            Console.WriteLine($"Area of circle: {ac}");

            //9. to Calculate Area of Square
            double d = 4.5;
            double cs = d * d;
            Console.WriteLine($"Area of square: {cs}");

            //10. to convert days to years, weeks and days
            int days = 2765;
            int years = days / 365;
            int weeks = (days - years * 365) / 7;
            int dayleft = (days - years * 365 - weeks * 7);
            Console.WriteLine($"days: {days}");
            Console.WriteLine($"{days} days = {years} years, {weeks} weeks, {dayleft} days");


        }
    }
}
