using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3_1
{
    internal class L3_1
    {
        private int _a;
        private float _b;
        public List<(int n, int a, float b, float res)> history = new List<(int, int, float, float)>();

        public int a
        {
            get { return _a; }
            
            set
            {
                if (value != 1)
                    _a = value;
                else
                    throw new ArgumentException("'A' cannot be equal to 1");
            }
        }

        public float b
        {
            get { return _b; }
            set { _b = value; }
        }

        public float GetResult()
        {
            float result = _a + _b * _b / (_a - 1);
            history.Add((history.Count + 1, _a, _b, result));
            return result;
        }


    }
}
