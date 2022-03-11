using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Lab_1
{
    static public class Lab_1_class
    {
        static public bool DataInput<T>(string message, out T result)
        {
            int x = Console.CursorLeft;
            int y = Console.CursorTop;
            Console.Write(message);

            ConsoleKeyInfo keyInfo;
            StringBuilder sb = new StringBuilder();

            do
            {
                keyInfo = Console.ReadKey();

                switch (keyInfo.Key)
                {
                    case ConsoleKey.OemMinus:
                        if (sb.Length == 0)
                            sb.Append(keyInfo.KeyChar);
                        break;

                    case ConsoleKey.Backspace:
                        if (sb.Length > 0)
                            sb.Remove(sb.Length - 1, 1);
                        break;

                    case ConsoleKey.OemPeriod:
                    case ConsoleKey.Decimal:
                    case ConsoleKey.OemComma:
                        sb.Append(keyInfo.KeyChar);
                        break;

                    case ConsoleKey.Escape:
                        sb.Clear();
                        break;

                    default:
                        if (Char.IsDigit(keyInfo.KeyChar))
                            sb.Append(keyInfo.KeyChar);
                        break;
                }

                Console.CursorLeft = x;
                Console.CursorTop = y;
                Console.Write("{0}{1}", message, sb.ToString());
            }
            while (keyInfo.Key != ConsoleKey.Enter && keyInfo.Key != ConsoleKey.Escape );

            Console.WriteLine();
            result = default(T);
            if (sb.Length == 0)
                return false;
            result = (T)Convert.ChangeType(sb.ToString(), typeof(T), CultureInfo.CurrentCulture);
            return true;
        }

        static public void Lab_1_1()
        {
            double a = default, b = default, result = default;

            Console.Clear();
            DataInput<double>("Enter number A: ", out a);
            DataInput<double>("Enter number B: ", out b);

            Console.WriteLine($"A = {a}");
            Console.WriteLine($"B = {b}");

            result = Math.Pow(a, 2);
            result = 0.25 * result;
            result = Math.Pow(b, 2) - result;
            result = a * result;
            result = 0.5 * result;

            Console.WriteLine($"Result = {result.ToString()}\n");
        }

        static public void Lab_1_2()
        {
            int[] x = new int[5];
            int i = default, sum = default, average = default;

            Console.Clear();

            for (i = 0; i < 5; i++)
            {
                DataInput<int>($"Enter number {i + 1}: ", out x[i]);
                sum += x[i];
            }

            average = sum / 5;

            if (average > x[0])
                Console.WriteLine($"Arithmetic mean: {average}\n");
            else
                Console.WriteLine("Arithmetic mean is not smaller than the first number\n");
        }

        static public void Lab_1_3()
        {
            double xn, xk, x, h, xp, fn, result1, result2;
            xn = xk = x = h = xp = fn = default;
            int n, N = 12;

            Console.Clear();

            DataInput<double>("Enter xn: ", out xn);
            DataInput<double>("Enter xk: ", out xk);

            h = (xk - xn) / 10;

            for (x = xn; x <= xk; x += h)
            {
                result1 = 0;

                result1 = (Math.Pow(Math.E, x) - Math.Pow(Math.E, -x)) / 2;

                result2 = x;
                xp = x;
                fn = 1;

                for (n = 1; n <= N; n++)
                {
                    xp *= x * x;
                    fn *= 2 * n * (2 * n + 1);

                    result2 += xp / fn;
                }

                Console.WriteLine($"x = {x,-5}\t Y(x) = {result1,-20}\t S(x) = {result2,-20}");
            }

            Console.WriteLine();
        }

        static public void Lab_1_4()
        {
            string str;
            int i = default;
            List<char> clist = new List<char>();

            Console.Clear();

            Console.Write("Enter string: ");
            str = Console.ReadLine();

            foreach (char c in str)
                clist.Add(c);

            Console.WriteLine("\nDigits:");

            for (i = 0; i < clist.Count; i++)
                if (Char.IsDigit(clist[i]))
                    Console.Write(clist[i]);

            Console.WriteLine("\nOther symbols:");
            for (i = 0; i < clist.Count; i++)
                if (!Char.IsDigit(clist[i]))
                    Console.Write(clist[i]);

            Console.WriteLine("\n");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            ConsoleKeyInfo key;
            Boolean exit = false;

            while (! exit)
            {
                x = Console.CursorLeft;
                y = Console.CursorTop;
                Console.Write("Actions:\n1 - Lab 1.1\n2 - Lab 1.2\n3 - Lab 1.3\n4 - Lab 1.4\n0 - Exit\nChoose action: ");
                key = Console.ReadKey();
                switch (key.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        Lab_1_class.Lab_1_1();
                        break;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        Lab_1_class.Lab_1_2();
                        break;

                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        Lab_1_class.Lab_1_3();
                        break;

                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        Lab_1_class.Lab_1_4();
                        break;

                    case ConsoleKey.D0:
                    case ConsoleKey.NumPad0:
                        Console.WriteLine("\nExiting");
                        exit = true;
                        break;

                    default:
                        Console.CursorLeft = x;
                        Console.CursorTop = y;
                        Console.Write(" ");
                        Console.CursorLeft = x;
                        Console.CursorTop = y;
                        break;
                }
            }
        }
    }
}
