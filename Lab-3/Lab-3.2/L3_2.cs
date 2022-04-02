using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class L3_2 : L3_1
    {
        public L3_2() : base()
        {

        }

        private float _d;

        public float d
        {
            get { return _d; }
            set { _d = value; }
        }

        public float c2
        {
            get
            {
                if (_d < this.a)
                    return a + b + d;
                else
                    return a - b - d;
            }
        }
    }
}
