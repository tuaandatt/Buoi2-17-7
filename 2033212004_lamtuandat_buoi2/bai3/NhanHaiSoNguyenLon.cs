using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
//lamtuandat
//2033212004
//buoi2
namespace bai3
{
    internal class NhanHaiSoNguyenLon
    {
        static void Main()
        {
            Console.Write("Nhap so nguyen lon thu nhat: ");
            BigInteger X = BigInteger.Parse(Console.ReadLine());

            Console.Write("Nhap so nguyen lon thu hai: ");
            BigInteger Y = BigInteger.Parse(Console.ReadLine());

            BigInteger result = KaratsubaMultiply(X, Y);
            Console.WriteLine($"\nKet qua nhan: {result}");
        }

        static BigInteger KaratsubaMultiply(BigInteger X, BigInteger Y)
        {
            if (X < 10 || Y < 10)
            {
                return X * Y;
            }

            int n = Math.Max(X.ToString().Length, Y.ToString().Length);
            int half = (n / 2) + (n % 2);

            BigInteger A = X / BigInteger.Pow(10, half);
            BigInteger B = X % BigInteger.Pow(10, half);
            BigInteger C = Y / BigInteger.Pow(10, half);
            BigInteger D = Y % BigInteger.Pow(10, half);

            BigInteger m1 = KaratsubaMultiply(A, C);
            BigInteger m2 = KaratsubaMultiply(B, D);
            BigInteger m3 = KaratsubaMultiply(A + B, C + D) - m1 - m2;

            return m1 * BigInteger.Pow(10, 2 * half) + m3 * BigInteger.Pow(10, half) + m2;
        }
    }

}
