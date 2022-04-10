using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    internal class L41
    {
        // FIELDS
        private int _a;
        private double _b;
        private double _c;
        private double _d;
        private double _result;

        // PROPERTIES
        public int A
        {
            get { return _a; }
            set
            {
                if (value != 1)
                    _a = value;
                else
                    throw new ArgumentException("'A' cannot be equal to '1'");
            }
        }

        public double B
        {
            get { return _b; }
            set { _b = value; }
        }

        public double C
        {
            get { return _c; }
        }

        public double D
        {
            get { return _d; }
            set { _d = value; }
        }

        public double Result
        {
            get { return _result; }
        }

        // CalculateResult overloads
        public void CalculateResult()
        {
            _result = _a + _b * _b / (_a - 1);
        }

        public void CalculateResult(int a)
        {
            A = a;
            CalculateResult();
        }

        public void CalculateResult(double b)
        {
            B = b;
            CalculateResult();
        }

        public void CalculateResult(int a, double b)
        {
            A = a;
            B = b;
            CalculateResult();
        }

        // CalculateC overloads
        public void CalculateC()
        {
            if (_d < _a)
                _c = _a + _b + _d;
            else
                _c = _a - _b - _d;
        }

        public void CalculateC(double d)
        {
            _d = d;
            CalculateC();
        }

        public void CalculateC(int a, double b, double d)
        {
            _a = a;
            _b = b;
            _d = d;
            CalculateC();
        }

        // ToString overloads
        public override string ToString()
        {
            return "Result = " + _result.ToString() + "; C = " + _c.ToString();
        }

        public string ToString(string prefix1, string prefix2)
        {
            return prefix1 + _result.ToString() + prefix2 + _c.ToString();
        }
    }
}
