using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Lab_1
{
    static public class DataExchange
    {
        static public bool DataInput<T>(string message, out T result)
        {
            int x = Console.CursorLeft;
            int y = Console.CursorTop;
            Console.Write(message);

            ConsoleKeyInfo keyInfo;
            StringBuilder sb = new StringBuilder();

            do
            {
                keyInfo = Console.ReadKey();

                switch (keyInfo.Key)
                {
                    case ConsoleKey.OemMinus:
                        if (sb.Length == 0)
                            sb.Append(keyInfo.KeyChar);
                        break;

                    case ConsoleKey.Backspace:
                        if (sb.Length > 0)
                            sb.Remove(sb.Length - 1, 1);
                        break;

                    case ConsoleKey.OemPeriod:
                    case ConsoleKey.Decimal:
                    case ConsoleKey.OemComma:
                        sb.Append(keyInfo.KeyChar);
                        break;

                    case ConsoleKey.Escape:
                        sb.Clear();
                        break;

                    default:
                        if (Char.IsDigit(keyInfo.KeyChar))
                            sb.Append(keyInfo.KeyChar);
                        break;
                }

                Console.CursorLeft = x;
                Console.CursorTop = y;
                Console.Write("{0}{1}", message, sb.ToString());
            }
            while (keyInfo.Key != ConsoleKey.Enter && keyInfo.Key != ConsoleKey.Escape);

            Console.WriteLine();
            result = default(T);
            if (sb.Length == 0)
                return false;
            result = (T)Convert.ChangeType(sb.ToString(), typeof(T), CultureInfo.CurrentCulture);
            return true;
        }
    }
}
