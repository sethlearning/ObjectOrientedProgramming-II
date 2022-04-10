using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    internal class L42R : L42Root
    {
        public double Result
        {
            get => _result;
        }

        public override void CalculateResult() => _result = _a + _b * _b / (_a - 1);

        public override string ToString() => "Result = " + _result;
    }

    internal class L42C : L42Root
    {
        public double C
        {
            get => _c;
        }

        public override void CalculateResult()
        {
            if (_d < _a)
                _c = _a + _b + _d;
            else
                _c = _a - _b - _d;
        }

        public override string ToString() => "C = " + _c;

    }
}
