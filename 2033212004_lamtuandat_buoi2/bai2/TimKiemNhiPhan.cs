using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//lamtuandat
//2033212004
//buoi2
namespace bai2
{
    internal class TimKiemNhiPhan
    {
        const int MAX = 100;

        static void Main()
        {
            int[] a = new int[MAX];
            int n, x;

            do
            {
                Console.Write("Nhap phan tu cua mang: ");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0 || n > MAX);

            nhapMang(a, ref n);
            xuatMang(a, n);

            Console.Write("\nNhap x can tim: ");
            x = int.Parse(Console.ReadLine());

            int kq = binarySearch(a, n, x);

            if (kq == -1)
                Console.WriteLine($"Khong tim thay {x} trong mang");
            else
                Console.WriteLine($"Tim thay {x} tai vi tri thu {kq}");
        }

        static void nhapMang(int[] a, ref int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap phan tu a[{i}]: ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }

        static void xuatMang(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"\t{a[i]}");
            }
            Console.WriteLine();
        }

        static int binarySearch(int[] a, int n, int key)
        {
            int left = 0;
            int right = n - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;

                if (a[mid] == key)
                    return mid;

                if (key < a[mid])
                    right = mid - 1;
                else
                    left = mid + 1;
            }

            return -1;
        }
    }
}