using System;

namespace Lab_8._5
{

    // EventArgs derived classes
    public class VectorExcessEventArgs : EventArgs
    {
        public double VectorValue { get; }

        public VectorExcessEventArgs(double vl)
        {
            VectorValue = vl;
        }
    }

    public class VectorWrongEventArgs : EventArgs
    {
        public string VectorValue { get; }

        public VectorWrongEventArgs(string vl)
        {
            VectorValue = vl;
        }
    }

    // Event handler classes
    public class VectorExcessEventHanlders
    {
        private readonly Vector3 _vector;
        public VectorExcessEventHanlders(Vector3 sender)
        {
            _vector = sender;
            _vector.ExcessValue += OnExcessValue;
        }

        public void OnExcessValue(object sender, VectorExcessEventArgs args)
        {
            Vector3 v = sender as Vector3;
            Console.WriteLine($"{args.VectorValue} is greater than {v.MaxValue}, using {v.MaxValue}.");
        }
    }

    public static class VectorWrongEventHandlers
    {
        /*
        public static void OnWrongValue(object sender, VectorWrongEventArgs args)
        {
            Console.WriteLine($"{args.VectorValue} is not a number, using 0.");
        }
        */
        public static EventHandler<VectorWrongEventArgs> OnWrongValue = (sender, args) =>
        {
            Console.WriteLine($"{args.VectorValue} is not a number, using 0.");
        };
    }

    // Vector3 class
    public class Vector3
    {
        // Delegates
        public delegate void VectorExcessEventHandler(object sender, VectorExcessEventArgs args);
        // public delegate void VectorWrongEventHandler(object sender, VectorWrongEventArgs args);

        // Events
        //public event VectorWrongEventHandler WrongValue;
        public event VectorExcessEventHandler ExcessValue;
        public event EventHandler<VectorWrongEventArgs> WrongValue;

        // Fields
        private double a;
        private double b;
        private double c;
        private readonly double maxValue = 1000;

        // Properties
        public double A
        {
            get => a;
            set
            {
                if (value <= maxValue)
                    a = value;
                else
                {
                    a = maxValue;
                    ExcessValue?.Invoke(this, new VectorExcessEventArgs(value));
                }
            }
        }
        public double B
        {
            get => b;
            set
            {
                if (value <= maxValue)
                    b = value;
                else
                {
                    b = maxValue;
                    ExcessValue?.Invoke(this, new VectorExcessEventArgs(value));
                }
            }
        }
        public double C
        {
            get => c;
            set
            {
                if (value <= maxValue)
                    c = value;
                else
                {
                    c = maxValue;
                    ExcessValue?.Invoke(this, new VectorExcessEventArgs(value));
                }
            }
        }
        public double MaxValue
        {
            get => maxValue;
        }

        public double Length { get => Math.Sqrt(A * A + B * B + C * C); }

        // Constructors
        public Vector3() { }

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

        // Operator overloads
        public static Vector3 operator +(Vector3 v1, Vector3 v2) => new Vector3(v1.A + v2.A, v1.B + v2.B, v1.C + v2.C);

        public static Vector3 operator -(Vector3 v1, Vector3 v2) => new Vector3(v1.A - v2.A, v1.B - v2.B, v1.C - v2.C);

        public static double operator *(Vector3 v1, Vector3 v2) => v1.A * v2.A + v1.B * v2.B + v1.C * v2.C;

        public static Vector3 operator *(Vector3 v, int d) => new Vector3(v.A * d, v.B * d, v.C * d);

        public static Vector3 operator /(Vector3 v, int d) => new Vector3(v.A / d, v.B / d, v.C / d);


        // Methods
        public double Angle(Vector3 v)
        {
            double sk = this * v;
            double ml = this.Length * v.Length;

            double rad = Math.Acos(sk / ml);

            return rad * (180 / Math.PI);
        }

        public override string ToString() => $"A = {A}, B = {B}, C = {C}";

        // Static methods
        public static void FillInVectorCoordinates(Vector3 v)
        {
            string str = String.Empty;

            Console.Write("Enter A: ");
            try
            {
                str = Console.ReadLine();
                v.A = Convert.ToDouble(str);
            }
            catch
            {
                v.WrongValue?.Invoke(v, new VectorWrongEventArgs(str));
            }

            Console.Write("Enter B: ");
            try
            {
                str = Console.ReadLine();
                v.B = Convert.ToDouble(str);
            }
            catch
            {
                v.WrongValue?.Invoke(v, new VectorWrongEventArgs(str));
            }

            Console.Write("Enter C: ");
            try
            {
                str = Console.ReadLine();
                v.C = Convert.ToDouble(str);
            }
            catch
            {
                v.WrongValue?.Invoke(v, new VectorWrongEventArgs(str));
            }
        }
    }

    internal class Program
    {
        static void Main()
        {
            Vector3 v1 = new Vector3();
            VectorExcessEventHanlders eh = new VectorExcessEventHanlders(v1);
            v1.WrongValue += VectorWrongEventHandlers.OnWrongValue;

            Vector3 v2 = new Vector3();
            v2.ExcessValue += eh.OnExcessValue;
            v2.WrongValue += VectorWrongEventHandlers.OnWrongValue;

            Console.WriteLine("Vector 1");
            Vector3.FillInVectorCoordinates(v1);

            Console.WriteLine();
            Console.WriteLine("Vector 2");
            Vector3.FillInVectorCoordinates(v2);


            Console.WriteLine();
            Console.WriteLine($"v1: {v1}");
            Console.WriteLine($"v2: {v2}");

            Console.WriteLine();
            Console.WriteLine($"v1.Length: {v1.Length:N3}");
            Console.WriteLine($"v2.Length: {v2.Length:N3}");

            Console.WriteLine();
            Console.WriteLine($"Angle: {v1.Angle(v2):N3} degrees");

            Console.WriteLine();
            Console.WriteLine($"v1 + v2: {(v1 + v2)}");
            Console.WriteLine($"v1 - v2: {(v1 - v2)}");
            Console.WriteLine($"v1 * v2: {(v1 * v2)}");

            Console.WriteLine();
            Console.WriteLine($"v1 * 2: {(v1 * 2)}");
            Console.WriteLine($"v2 / 5: {(v2 / 5)}");

            Console.ReadLine();
        }
    }
}
