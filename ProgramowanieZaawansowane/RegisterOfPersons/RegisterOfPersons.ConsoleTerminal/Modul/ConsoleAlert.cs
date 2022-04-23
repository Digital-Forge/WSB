using System;
using System.Collections.Generic;
using System.Text;

namespace RegisterOfPersons.ConsoleTerminal
{
    public static class ConsoleAlert
    {
        public static void Show(string alert, ConsoleColor? color = null, ConsoleColor? backgroundColor = null)
        {
            Show(new ConsoleColorString(alert, color, backgroundColor));
        }

        public static void Show(ConsoleColorString alert)
        {
            Console.Clear();
            alert.ConsoleWriteLine();
            Console.ReadLine();
        }
    }
}
