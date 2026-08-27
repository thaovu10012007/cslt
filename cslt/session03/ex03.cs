using System;
using System.Collections.Generic;
using System.Text;

namespace cslt.session03
{
    internal class ex_2
    {
        static void Bai_1slide ()
        {
       
                Console.Write("Inpur celsius: ");
                if (double.TryParse(Console.ReadLine(), out double celsius))
                {
                    double kelvin = celsius + 273;
                    double fahrenheit = celsius * 18 / 10 + 32;
                    Console.WriteLine($"kelvin = {kelvin}");
                    Console.WriteLine($"fahrenheit = {fahrenheit}");
                }
                else
                {
                    Console.WriteLine("Incorrect, please try again");
                }
            }
    static void Bai_2slide ()
        {
            Console.Write("Input radius: ");
            if (double.TryParse(Console.ReadLine(), out double radius))
            {
                double surface = 4 * Math.PI * Math.Pow(radius, 2);
                double volume = (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);

                Console.WriteLine($"Surface: {surface}");
                Console.WriteLine($"Volume: {volume}");
            }
            else
            {
                Console.WriteLine("Incorrect, please try again");
            }
        }
        static void Bai_3slide ()
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
            static void Main(string[] args)
            {
            Bai_1slide();
            Bai_2slide();
            Bai_3slide();
            }
        }
    }






