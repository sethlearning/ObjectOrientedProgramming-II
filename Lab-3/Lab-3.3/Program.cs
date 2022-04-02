using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boolean exit = false;
            TerminalList tl = new TerminalList();

            while (!exit)
            {
                Console.Clear();
                DisplayTerminals(tl);
                Menu();
                ConsoleKeyInfo key = Console.ReadKey();
                switch (key.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        AddTerminal(tl);
                        break;
                    
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        RemoveTerminal(tl);
                        break;

                    case ConsoleKey.D0:
                    case ConsoleKey.NumPad0:
                        exit = true;
                        break;
                }
            }
        }

        static public void DisplayTerminals(TerminalList tl)
        {
            Console.WriteLine("{0,-7} {1,-40} {2,-10} {3,-10}", "Number", "Address", "Capacity", "Load");
            foreach (Terminal t in tl.terminals)
            {
                if (t.GetLoadAmount() > 90)
                {
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.ForegroundColor = ConsoleColor.White;

                }
                Console.WriteLine("{0,-7} {1,-40} {2,-10:n0} {3,-10:n0}", t.number, t.address, t.capacity, t.load);
                Console.ResetColor();
            }
        }

        static public void Menu()
        {
            Console.WriteLine("\n1 - Add terminal\n2 - Remove terminal\n0 - Exit");
        }

        static public void AddTerminal(TerminalList tl)
        {
            int n, l;
            string s;
            try
            {
                Console.Write("\n\nAdding New Terminal:\nNumber: ");
                n = Convert.ToInt32(Console.ReadLine());
                Console.Write("Address: ");
                s = Console.ReadLine();
                Console.Write("Current load: ");
                l = Convert.ToInt32(Console.ReadLine());

                if (!tl.terminals.Exists(x => x.number == n))
                {
                    tl.Add(n, s, l);
                }
                else
                {
                    Console.WriteLine($"\nTerminal with number {n} is already exists.\nPress any key...");
                    Console.ReadKey();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Wrong input\nPress any key...");
                Console.ReadKey();
            }
        }

        static public void RemoveTerminal(TerminalList tl)
        {
            int nr;

            try
            {
                Console.Write("\n\nRemoving Terminal:\nNumber: ");
                nr = Convert.ToInt32(Console.ReadLine());

                if (tl.terminals.Exists(x => x.number == nr))
                    tl.Remove(nr);
                else
                {
                    Console.WriteLine($"\nTerminal with number {nr} doesn't exist.\nPress any key...");
                    Console.ReadKey();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Wrong input\nPress any key...");
                Console.ReadKey();
            }
        }
    }
}
