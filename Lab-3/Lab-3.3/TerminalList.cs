using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class TerminalList
    {
        private List<Terminal> _terminals = new List<Terminal>();
        public List<Terminal> terminals
        {
            get { return _terminals; }
        }

        /*
        public TerminalList()
        {
            _terminals.Add(new Terminal(1, "г. Москва, ул. Пушкина, д. 15", 500));
            _terminals.Add(new Terminal(2, "г. Москва, ул. Толстого, д. 20", 9000));
            _terminals.Add(new Terminal(3, "г. Москва, ул. Достоевского, д. 25", 9001));
        }
        */
        
        public TerminalList()
        {
            Load();
        }
        
        public void Add(int number, string address, int load)
        {
            if (!_terminals.Exists(x => x.number == number))
            {
                _terminals.Add(new Terminal(number, address, load));
                Save();
            }
        }
        
        public void Remove(int number)
        {
            Terminal t = _terminals.Find(x => x.number == number);
            if (t != null)
            {
                _terminals.Remove(t);
                Save();
            }
        }

        private void Save()
        {
            XMLOperations<List<Terminal>> XMLOps = new XMLOperations<List<Terminal>>("TerminalStore");
            XMLOps.Save(this._terminals);
        }

        private void Load()
        {
            XMLOperations<List<Terminal>> XMLOps = new XMLOperations<List<Terminal>>("TerminalStore");
            this._terminals = XMLOps.Load();
        }
    }
}
