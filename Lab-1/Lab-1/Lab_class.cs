using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    static public class Lab_class
    {
        static public double Lab_1_1(double a, double b)
        {
            double result = default;

            result = 0.5 * a * (b * b - 0.25 * a * a);

            return result;
        }

        static public int Lab_1_2(int[] x)
        {
            int i = default, sum = default, average = default;

            for (i = 0; i < x.Length; i++)
                sum += x[i];

            average = sum / x.Length;

            return average;
        }

        static public double Lab_1_3_formula(double x)
        {
            double result = 0;

            result = (Math.Exp(x) - Math.Exp(-x)) / 2;

            return result;
        }

        static public double Lab_1_3_series(double x)
        {
            double result, xp, fn;
            result = xp = fn = default;
            int n, N = 12;

            result = x;
            xp = x;
            fn = 1;

            for (n = 1; n <= N; n++)
            {
                xp *= x * x;
                fn *= 2 * n * (2 * n + 1);

                result += xp / fn;
            }

            return result;
        }

        static public void Lab_1_4(List<char> clist, ref List<char> cdigs, ref List<char> cchars)
        {
            int i;

            for (i = 0; i < clist.Count; i++)
                if (Char.IsDigit(clist[i]))
                    cdigs.Add(clist[i]);
                else
                    cchars.Add(clist[i]);
        }
    }
}
