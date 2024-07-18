using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//lamtuandat
//2033212004
//buoi2
namespace bai1
{
    internal class MergeSort
    {
        const int MAX = 3;

        static void Main()
        {
            int[] a = new int[MAX];
            int n;

            do
            {
                Console.Write("Nhap phan tu cua mang: ");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0 || n > MAX);

            nhapMang(a, ref n);
            Console.WriteLine("Mang chua duoc sap xep:");
            xuatMang(a, n);

            mergeSort(a, 0, n - 1);

            Console.WriteLine("\nMang sau khi duoc sap xep:");
            xuatMang(a, n);
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

        static void merge(int[] a, int l, int m, int r)
        {
            int[] b = new int[r - l + 1];
            int i = l, j = m + 1, k = 0;

            while (i <= m && j <= r)
            {
                if (a[i] <= a[j])
                    b[k++] = a[i++];
                else
                    b[k++] = a[j++];
            }

            while (i <= m)
                b[k++] = a[i++];

            while (j <= r)
                b[k++] = a[j++];

            for (i = l, k = 0; i <= r; i++, k++)
                a[i] = b[k];
        }

        static void mergeSort(int[] a, int l, int r)
        {
            if (l >= r)
                return;

            int mid = (l + r) / 2;
            mergeSort(a, l, mid);
            mergeSort(a, mid + 1, r);
            merge(a, l, mid, r);
        }
    }
}
