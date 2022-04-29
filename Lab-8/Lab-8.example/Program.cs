using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8.report
{
    
    public class S
    {
        public delegate void EH(object sender, EventArgs e);
        public event EH SomeEvent;

        public void SomeMethod()
        {
            SomeEvent?.Invoke(this, EventArgs.Empty);
        }
    }

    public class R
    {
        public void OnSomeEvent(object sender, EventArgs args)
        {
            Console.WriteLine("Some event registered");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            S s = new S();
            R r = new R();
            s.SomeEvent += r.OnSomeEvent;
            s.SomeMethod();
        }
    }
}
