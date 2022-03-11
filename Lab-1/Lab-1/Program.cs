using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
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
                        Lab_1_1_f();
                        break;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        Lab_1_2_f();
                        break;
                        
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        Lab_1_3_f();
                        break;

                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        Lab_1_4_f();
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

        static public void Lab_1_1_f()
        {
            double a = default, b = default, result = default;

            Console.Clear();
            DataExchange.DataInput<double>("Enter number A: ", out a);
            DataExchange.DataInput<double>("Enter number B: ", out b);

            result = Lab_class.Lab_1_1(a, b);

            Console.WriteLine($"Result = {result.ToString()}\n");
        }

        static public void Lab_1_2_f()
        {
            int[] x = new int[5];
            int i = default, average = default;

            Console.Clear();

            for (i = 0; i < 5; i++)
                DataExchange.DataInput<int>($"Enter number {i + 1}: ", out x[i]);

            average = Lab_class.Lab_1_2(x);

            if (average > x[0])
                Console.WriteLine($"Arithmetic mean: {average}\n");
            else
                Console.WriteLine("Arithmetic mean is not smaller than the first number\n");
        }

        static public void Lab_1_3_f()
        {
            double xn, xk, x, h, resultFormula, resultSeries;
            xn = xk = x = h = resultFormula = resultSeries = default;

            Console.Clear();

            DataExchange.DataInput<double>("Enter xn: ", out xn);
            DataExchange.DataInput<double>("Enter xk: ", out xk);

            h = (xk - xn) / 10;

            for (x = xn; x <= xk; x += h)
            {
                resultFormula = Lab_class.Lab_1_3_formula(x);
                resultSeries = Lab_class.Lab_1_3_series(x);

                Console.WriteLine($"x = {x,-5}\t Y(x) = {resultFormula,-20}\t S(x) = {resultSeries,-20}");
            }

            Console.WriteLine();
        }

        static public void Lab_1_4_f()
        {
            string str;
            List<char> clist = new List<char>();
            List<char> cdigits = new List<char>();
            List<char> ccharacters = new List<char>();

            Console.Clear();

            Console.Write("Enter string: ");
            str = Console.ReadLine();

            foreach (char c in str)
                clist.Add(c);

            Lab_class.Lab_1_4(clist, ref cdigits, ref ccharacters);

            Console.Write($"\nDigits: ");
            foreach (char c in cdigits)
                Console.Write(c);

            Console.Write("\nOther symbols: ");
            foreach (char c in ccharacters)
                Console.Write(c);

            Console.WriteLine("\n");
        }
    }
}
