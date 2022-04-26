using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7
{
    public class BClass
    {
        public int a;
        public double b;
        public string s;

        public BClass()
        {
            a = 15;
            b = 2.3;
            s = "The string";
        }

        public BClass(int a, double b, string s)
        {
            this.a = a;
            this.b = b;
            this.s = s;
        }

        public static bool operator true(BClass op)
        {
            if (op.a != 0 || op.b != 0 || !String.IsNullOrEmpty(op.s))
                return true;
            else
                return false;
        }

        public static bool operator false(BClass op)
        {
            if (op.a == 0 && op.b == 0 && String.IsNullOrEmpty(op.s))
                return true;
            else
                return false;
        }
        
        public static bool operator &(BClass op1, BClass op2)
        {
            if ((op1.a != 0 || op1.b != 0 || !String.IsNullOrEmpty(op1.s)) &&
                (op2.a != 0 || op2.b != 0 || !String.IsNullOrEmpty(op2.s)))
                return true;
            else
                return false;
        }
        /*
        public static BClass operator &(BClass op1, BClass op2)
        {
            if ((op1.a != 0 || op1.b != 0 || !String.IsNullOrEmpty(op1.s)) &&
                (op2.a != 0 || op2.b != 0 || !String.IsNullOrEmpty(op2.s)))
                return op1;
            else
                return op2;
        }
        */
        /*
        public static bool operator &(BClass op1, BClass op2)
        {
            if (op1 & op2)
                return true;
            else
                return false;
        }
        */

        public static BClass operator +(BClass op, string str)
        {
            return new BClass(op.a, op.b, op.s + str);
        }

        public static BClass operator *(BClass op, double d)
        {
            return new BClass(op.a, op.b * d, op.s);
        }

        public static BClass operator -(BClass op, int i)
        {
            return new BClass(op.a - i, op.b, op.s);
        }

        public override string ToString()
        {
            return $"a = {a}, b = {b}, s = \"{s}\"";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            BClass a = new BClass(0, 0, String.Empty);
            BClass b = new BClass(1, 0, String.Empty);
            BClass c = new BClass();

            Console.WriteLine($"Object A: {a.ToString()}");
            Console.WriteLine($"Object B: {b.ToString()}");
            Console.WriteLine($"Object C: {c.ToString()}");

            Console.WriteLine();

            if (a)
                Console.WriteLine("A is true");
            else
                Console.WriteLine("A is false");

            if (b)
                Console.WriteLine("B is true");
            else
                Console.WriteLine("B is false");

            if (c)
                Console.WriteLine("C is true");
            else
                Console.WriteLine("C is false");

            Console.WriteLine();

            Console.WriteLine($"A & B is {a & b}");
            Console.WriteLine($"B & C is {b & c}");

            // Console.WriteLine($"B && C is {b && c}");

            Console.WriteLine();

            Console.WriteLine($"C + \" is extended\":\r\n{(c + " is extended").ToString()}");

            Console.WriteLine();

            Console.WriteLine($"C * 3.1:\r\n{(c * 3.1).ToString()}");

            Console.WriteLine();

            Console.WriteLine($"C - 5:\r\n{(c - 5).ToString()}");

        }
    }
}
