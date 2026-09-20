using System;
using System.Collections.Generic;
using System.Text;

namespace cslt.session06
{
    internal class ex06
    {
        static void Bai1TinhTong2SoNguyen()
        {

            Console.Write("Nhap a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Nhap b: ");
            int b = int.Parse(Console.ReadLine());

            int tong = a + b;

            Console.WriteLine("Tong = " + tong);
        }
        static void Bai2KiemTraChanLe()
        {
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                Console.WriteLine(n + " la so chan");
            }
            else
            {
                Console.WriteLine(n + " la so le");
            }
        }
        static void Bai3TimMax3so()
        {
            Console.Write("Nhap a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Nhap b: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Nhap c: ");
            int c = int.Parse(Console.ReadLine());

            int max = a;

            if (b > max)
            {
                max = b;
            }

            if (c > max)
            {
                max = c;
            }

            Console.WriteLine("So lon nhat = " + max);
        }
        static void Bai4TinhGiaiThua()
        {
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());

            if (n < 0)
            {
                Console.WriteLine("n phai >= 0");
                return;
            }

            long result = 1;

            for (int i = 1; i <= n; i++)
            {
                result = result * i;
            }

            Console.WriteLine(n + "! = " + result);
        }
        static void Bai5DaoNguocChuoi()
        {
            Console.Write("Nhap chuoi: ");
            string input = Console.ReadLine();

            char[] char_array = input.ToCharArray();

            Array.Reverse(char_array);

            string result = new string(char_array);

            Console.WriteLine("Chuoi dao nguoc = " + result);
        }
        static void Bai6KiemTraNguyenTo()
        {
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());

            bool isPrime = true;

            if (n < 2)
            {
                isPrime = false;
            }
            else
            {
                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }

            if (isPrime)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
        static void Bai7InFibonacci()
        {
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());

            int a = 0;
            int b = 1;

            for (int i = 0; i < n; i++)
            {
                Console.Write(a + " ");

                int temp = a + b;
                a = b;
                b = temp;
            }

            Console.WriteLine();
        }
        static void Bai8DemNguyenAm()
        {
            Console.Write("Nhap chuoi: ");
            string s = Console.ReadLine();

            int count = 0;

            for (int i = 0; i < s.Length; i++)
            {
                char c = char.ToLower(s[i]);

                if (c == 'a' ||
                    c == 'e' ||
                    c == 'i' ||
                    c == 'o' ||
                    c == 'u')
                {
                    count++;
                }
            }

            Console.WriteLine("So luong nguyen am = " + count);
        }
        static void Bai9TinhLuyThua()
        {

            Console.Write("Nhap x: ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("Nhap y: ");
            int y = int.Parse(Console.ReadLine());

            double result = 1;

            if (y >= 0)
            {
                for (int i = 0; i < y; i++)
                {
                    result = result * x;
                }
            }
            else
            {
                for (int i = 0; i < -y; i++)
                {
                    result = result * x;
                }

                result = 1 / result;
            }

            Console.WriteLine("Ket qua = " + result);
        }
        static void Bai10TinhTrungBinh()
        {
            Console.Write("Nhap so luong phan tu: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap arr[" + i + "]: ");
                arr[i] = int.Parse(Console.ReadLine());

                sum = sum + arr[i];
            }

            double average = (double)sum / n;

            Console.WriteLine("Trung binh = " + average);
        }
        static void Bai11KiemTraDoiXung()
        {
            Console.Write("Nhap chuoi: ");
            string s = Console.ReadLine();

            string reverse = "";

            for (int i = s.Length - 1; i >= 0; i--)
            {
                reverse += s[i];
            }

            if (s == reverse)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
        static void Bai12CelsiusToFahrenheit()
        {
            Console.Write("Nhap do C: ");
            double c = double.Parse(Console.ReadLine());

            double f = c * 9 / 5 + 32;

            Console.WriteLine("Do F = " + f);
        }
        static void Bai13TimMin()
        {
            Console.Write("Nhap so luong phan tu: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap arr[" + i + "]: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            int min = arr[0];

            for (int i = 1; i < n; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }

            Console.WriteLine("Gia tri nho nhat = " + min);
        }
        static void Bai14TongCacChuSo()
        {
            Console.Write("Nhap so nguyen: ");
            int n = int.Parse(Console.ReadLine());

            n = Math.Abs(n);

            int sum = 0;

            while (n > 0)
            {
                sum += n % 10;
                n /= 10;
            }

            Console.WriteLine("Tong cac chu so = " + sum);
        }
        static void Bai15SapXepMangTangDan()
        {
            Console.Write("Nhap so luong phan tu: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap arr[" + i + "]: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n - 1; i++)//sap xep tang dan
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            Console.Write("Mang tang dan: ");

            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();
        }
        static void Bai16XoaKiTuTrungLap()
        {
            Console.Write("Nhap chuoi: ");
            string s = Console.ReadLine();

            string result = "";

            for (int i = 0; i < s.Length; i++)
            {
                bool trung = false;

                for (int j = 0; j < result.Length; j++)
                {
                    if (s[i] == result[j])
                    {
                        trung = true;
                        break;
                    }
                }

                if (!trung)
                {
                    result += s[i];
                }
            }

            Console.WriteLine("Chuoi sau khi xoa trung lap = " + result);
        }
        static void Bai17UocChungLonNhat()
        {
            Console.Write("Nhap a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Nhap b: ");
            int b = int.Parse(Console.ReadLine());

            a = Math.Abs(a);
            b = Math.Abs(b);

            // Thuat toan Euclid
            while (b != 0)
            {
                int temp = a % b;
                a = b;
                b = temp;
            }

            Console.WriteLine("UCLN = " + a);
        }
        static void Bai18DecimalToBinary()
        {
            Console.Write("Nhap so thap phan: ");
            int n = int.Parse(Console.ReadLine());

            if (n == 0)
            {
                Console.WriteLine("Nhi phan = 0");
                return;
            }

            string binary = "";

            while (n > 0)
            {
                int du = n % 2;

                binary = du + binary;

                n /= 2;
            }

            Console.WriteLine("Nhi phan = " + binary);
        }
        static void Bai19KiemTraNamNhuan()
        {
            Console.Write("Nhap nam: ");
            int year = int.Parse(Console.ReadLine());

            bool leapYear = false;

            if (year % 400 == 0)
            {
                leapYear = true;
            }
            else if (year % 100 == 0)
            {
                leapYear = false;
            }
            else if (year % 4 == 0)
            {
                leapYear = true;
            }

            Console.WriteLine(leapYear);
        }
        static void Bai20DemSoTu()
        {
            Console.Write("Nhap cau: ");
            string sentence = Console.ReadLine();

            string[] words = sentence.Split(
                new char[] { ' ', '\t' },
                StringSplitOptions.RemoveEmptyEntries
            );

            Console.WriteLine("So tu = " + words.Length);
        }

        static void Main7(string[] args)
        {
            Bai1TinhTong2SoNguyen();
            Bai2KiemTraChanLe();
            Bai3TimMax3so();
            Bai4TinhGiaiThua();
            Bai5DaoNguocChuoi();
            Bai6KiemTraNguyenTo();
            Bai7InFibonacci();
            Bai8()DemNguyenAm;
            Bai9()TinhLuyThua;
            Bai10()TinhTrungBinh;
            Bai11KiemTraDoiXung();
            Bai12CelsiusToFahrenheit();
            Bai13TimMin();
            Bai14TongCacChuSo();
            Bai15SapXepMangTangDan();
            Bai16XoaKiTuTrungLap();
            Bai17UocChungLonNhat();
            Bai18DecimalToBinary();
            Bai19KiemTraNamNhuan();
            Bai20DemSoTu();

        }

    }
}
