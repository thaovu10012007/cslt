using System;
using System.Collections.Generic;
using System.Text;

namespace cslt.session06
{
    internal class ex06
    {
        static int Max(int a, int b, int c)
        {
            int max = a;
            if (b > max)
            {
                max = b;
            }
            if (c > max)
            {
                max = c;
            }
            return max;
            int result = Max(a, b, c);
        }
        static long Factorial(int n)
        {
            long result = 1;
            for (int i = 1; i <= n; i++)
            {
                result = result * i;
            }
            return result;
        }
        /// <summary>
        /// hàm kiểm tra 1 số có phải số nguyên tố     
        /// </summary>
        /// <param name="number">là số cần kiểm tra</param>
        /// <returns>true nếu là số cần kiểm tra là số nguyên tố</returns>
        static bool IsPrime(int number)
        {
            if (number < 2)
            {
                return false;
            }

            for (int i = 2; i <= number/2; i++)
            {
                if (number % i == 0)// tồn tại 1 ước số khác 1 và chính nó 
                {
                    return false;
                }
            }
            return true;
        }
        public static Main(string[] args)
        {

        }

    }
}
