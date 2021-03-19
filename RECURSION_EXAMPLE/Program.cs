using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RECURSION_EXAMPLE
{
    class Program
    {
        static void HanoiTower(char a, char b, char c, int n)
        {
            if (n == 1)
            { 
                Console.WriteLine($"Move Disk from Pole {a} to Pole {b}");
                Console.ReadKey();
            }
            else
            {
                HanoiTower(a, c, b, n - 1);
                Console.WriteLine($"Move Disk from Pole {a} to Pole {b}");
                Console.ReadKey();
                HanoiTower(c, b, a, n - 1);
            }
        }
        static long Pow (int x, int y)
        {
            if (y == 0)
                return 1;
           return Pow(x, y - 1) * x;
        }
        static int Series(int a1, int d, int n)
        {
            if(n==1)
            {
                return a1;
            }
            return Series(a1, d, n - 1) + d;
        }
        static int Mystery1 (int num)
        {
            if (num < 10)
                return num;
            return Mystery1(num / 100) * 100 + (num / 10) % 10 + num % 10 * 10;
        }
        static int SumSeries (int n)
        {
            if (n == 1)
                return 1;
            if (n % 2 == 0)
                return n / 2 + SumSeries(n - 1);
            return n + SumSeries(n - 1);
        }
        static void PrintToN (int n)
        {
               if(n==1)
            {
                Console.Write("{0,-3}", n);
            }
            else
            {
                Console.Write("{0,-3}", n);
                PrintToN(n - 1);
                Console.Write("{0,-3}", n);
            }
        }
        static void PrintReverse (int x)
        {
            if (x < 10)
                Console.Write(x);
            else
            {
                Console.Write(x % 10);
                PrintReverse(x / 10);
               // Console.Write(x % 10);
            }
        }
        static int Find (int [] ar, int length, int x)
        {
            if (length == 0)
                return -1;
            if (ar[length - 1] == x)
                return length - 1;
            return Find(ar, length - 1, x);
        }
        static bool IsSorted (int [] ar, int length)
        {
            if (length == 1)
            {
                return true;
            } 
            if (ar[length-2] > ar[length-1] )
            {
                return false;
            }
            return IsSorted(ar, length - 1);
        }
        static int Count (int [] ar, int length, int x)
        {
            if (length == 0)
                return 0;
            int add = 0;
            if (ar[length - 1] == x)
                add++;
            return add + Count(ar, length - 1, x);
        }
        static bool Symetric (int [] ar)
        {
            return Symetric(ar, 0, ar.Length - 1);
        }

         static bool Symetric(int[] ar, int v1, int v2)
        {
            if (v2 - v1 < 1)
                return true;
            if (ar[v1] != ar[v2])
                return false;
            return Symetric(ar, v1 + 1, v2 - 1);
        }
        static void ReverseArray (int [] ar)
        {
             ReverseArray(ar, 0, ar.Length - 1);

        }
       static void ReverseArray(int[] ar, int v1, int v2)
        {
            if (v2 - v1 < 1) return;
            int tmp = ar[v1];
            ar[v1] = ar[v2];
            ar[v2] = tmp;
            ReverseArray(ar, v1 + 1, v2 - 1);           
        }
        static void Print (int [] ar)
        {
            for (int i = 0; i < ar.Length - 1; i++)
                Console.Write($"{ar[i]}, ");
            Console.WriteLine(ar[ar.Length - 1]);
        }
        static int Find (int [] ar, int start, int end)
        {

        }

        static void Main(string[] args)
        {
            // HanoiTower('a', 'b', 'c', 4);
            //Console.WriteLine(Mystery1 (123456));
            //PrintToN(10);
            //PrintReverse(48327);
            int[] ar = { 3, 7, 23, 9, 15, 6 };
            Print(ar);
            ReverseArray(ar);
            Print(ar);
            
            //Console.WriteLine($"Place the value {x} in the array is {Find(ar, ar.Length, x)}");
            Console.ReadKey();
        }
    }
}
