using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    public class Terminal
    {
        private int _number;
        private string _address;
        private int _capacity;
        private int _load;

        public int number
        {
            get { return _number; }
            set { _number = value; }
        }

        public string address
        {
            get { return _address; }
            set { _address = value; }
        
        }
        public int capacity
        {
            get { return _capacity; }
            set { _capacity = value; }
        }

        public int load
        {
            get { return _load; }
            set { _load = value; }
        }

        public Terminal() { }

        public Terminal(int number, string address, int load)
        {
            this.number = number;
            this.address = address;
            this.load = load;

            this._capacity = 10000;
        }

        public double GetLoadAmount()
        {
            double res;
            res = _load / (double)_capacity * 100;
            return res;
        }
    }
}
