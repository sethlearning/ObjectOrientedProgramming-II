using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7._2
{

    public class Vector3
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public double Length { get => Math.Sqrt(A * A + B * B + C * C); }

        //double Length = Math.Sqrt(a * a + b * b + c * c);

        public Vector3(double a, double b, double c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }

        public Vector3(Vector3 v)
        {
            this.A = v.A;
            this.B = v.B;
            this.C = v.C;
        }

        public static Vector3 operator +(Vector3 v1, Vector3 v2)
        {
            return new Vector3(v1.A + v2.A, v1.B + v2.B, v1.C + v2.C);
        }

        public static Vector3 operator -(Vector3 v1, Vector3 v2)
        {
            return new Vector3(v1.A - v2.A, v1.B - v2.B, v1.C - v2.C);
        }

        public static double operator *(Vector3 v1, Vector3 v2)
        {
            return v1.A * v2.A + v1.B * v2.B + v1.C * v2.C;
        }

        public static Vector3 operator *(Vector3 v, int d)
        {
            return new Vector3(v.A * d, v.B * d, v.C * d);
        }

        public static Vector3 operator /(Vector3 v, int d)
        {
            return new Vector3(v.A / d, v.B / d, v.C / d);
        }

        public double Angle(Vector3 v)
        {
            double sk = this * v;
            double ml = this.Length * v.Length;

            double rad = Math.Acos(sk / ml);

            return rad * (180 / Math.PI);
        }

        public override string ToString()
        {
            return $"A = {A}, B = {B}, C = {C}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Vector3 v1 = new Vector3(2, 4, 8);

            Vector3 v2 = new Vector3(v1);
            v2.A = 5;
            v2.B = 10;
            v2.C = 15;

            /*
            Vector3 v1 = new Vector3(2, 0, 0);
            Vector3 v2 = new Vector3(11, 0, 0);
            */

            Console.WriteLine($"v1: {v1.ToString()}");
            Console.WriteLine($"v2: {v2.ToString()}");

            Console.WriteLine();
            Console.WriteLine($"v1.Length: {v1.Length:N3}");
            Console.WriteLine($"v2.Length: {v2.Length:N3}");

            Console.WriteLine();
            Console.WriteLine($"Angle: {v1.Angle(v2):N3} degrees");

            Console.WriteLine();
            Console.WriteLine($"v1 + v2: {(v1 + v2).ToString()}");
            Console.WriteLine($"v1 - v2: {(v1 - v2).ToString()}");
            Console.WriteLine($"v1 * v2: {(v1 * v2).ToString()}");

            Console.WriteLine();
            Console.WriteLine($"v1 * 2: {(v1 * 2).ToString()}");
            Console.WriteLine($"v2 / 5: {(v2 / 5).ToString()}");

        }
    }
}
