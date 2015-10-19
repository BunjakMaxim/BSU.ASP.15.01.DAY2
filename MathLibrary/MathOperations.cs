using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;

namespace MathLibrary
{
    public static class MathOperations
    {
        public static double SqrtNewtanMetod(double value, int n, double precision = 0.00001)
        {
            double x, x1 = 1;
            if (value == 0) return 0;
            if (value < 0) throw new ArgumentException("Negative value!");

            do
            {
                x = x1;
                x1 = 1.0 / n * ((n - 1) * x + value / Math.Pow(x, n - 1));
            } while (Math.Abs(x - x1) > precision);
           
            return x;
        }
        
        public static string Format10to16(this int value)
        {
            return String.Format("{0:X}", value);
        }

        public static int EuclidAlgorithm(int a, int b, out long time)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start(); 
            a = Math.Abs(a);
            b = Math.Abs(b);

            if(a < b)
            {
                int r = a;
                a = b; b = r;
            }

            while (b != 0)
            {
                int q = a % b;
                a = b; b = q;
            }

            watch.Stop();
            time = watch.ElapsedTicks;
            return a;
        }
        public static int EuclidAlgorithm(int a, int b, int c, out long time)
        {
            long time1;
            int d = EuclidAlgorithm(a, b, out time1);
            
            d = EuclidAlgorithm(d, c, out time);
            time += time1;

            return d;
        }
        public static int EuclidAlgorithm( out long time, params int[] a)
        {
            int r = a[0];
            long time1; time = 0;

            for (int i = 1; i < a.Length; i++)
            {
                r = EuclidAlgorithm(a[i], r, out time1);
                time += time1;
            }

            return r;
        }

        public static int BinaryGCDAlgorithm(int a, int b, out long time)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();

            if (a < 0) a = Math.Abs(a);
            if (b < 0) b = Math.Abs(b);

            int nod = 1;

            while(a > 1 && b > 1)
            {
                if (a % 2 == 0 && b % 2 == 0)
                {
                    nod <<= 1;
                    a >>= 1;
                    b >>= 1;
                }
                else if (a % 2 == 0)
                    a >>= 1;
                else if (b % 2 == 0)
                    b >>= 1;
                else
                {
                    if (a > b)
                        a = (a - b) >> 1;
                    else
                        b = (b - a) >> 1;
                }
            }

            if (a > 1 && b != 1) nod *= a;
            if (b > 1 && a != 1) nod *= b;

            watch.Stop();
            time = watch.ElapsedTicks;
         
            return nod;
        }
        public static int BinaryGCDAlgorithm(int a, int b, int c, out long time)
        {
            long time1;
            int d = BinaryGCDAlgorithm(a, b, out time1);

            d = BinaryGCDAlgorithm(d, c, out time);
            time += time1;

            return d;
        }
        public static int BinaryGCDAlgorithm(out long time, params int[] a)
        {
            int r = a[0];
            long time1; time = 0;

            for (int i = 1; i < a.Length; i++)
            {
                r = EuclidAlgorithm(a[i], r, out time1);
                time += time1;
            }

            return r;
        }
    }
}
