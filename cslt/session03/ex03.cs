using System;
using System.Collections.Generic;
using System.Text;

namespace cslt.session03
{
    internal class ex_2
    {
        static void Bai_1() 
            static void Main(string[] args)
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
        }
    }

