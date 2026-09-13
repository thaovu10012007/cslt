using System;
using System.Collections.Generic;
using System.Text;

namespace cslt.session05
{
    internal class bangcuuchuong
    {

        static void printMultiplicationTable()
        {
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($" {i} * {j} = {i * j}");
                }
            }
        }
        public static void Main5(String[] args)
        {
            printMultiplicationTable();
        }
    }
}
