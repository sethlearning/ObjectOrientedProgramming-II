using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    internal abstract class L42Root
    {
        // FIELDS
        protected int _a;
        protected double _b;
        protected double _c;
        protected double _d;
        protected double _result;

        // PROPERTIES
        public int A
        {
            get => _a;
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
            get => _b;
            set => _b = value;
        }

        public double D
        {
            get => _d;
            set => _d = value;
        }

        public virtual void Calculate() => CalculateResult();

        public abstract void CalculateResult();

        public string ToString(string prefix1, string prefix2) => prefix1 + _result.ToString() + prefix2 + _c.ToString();
    }
}
