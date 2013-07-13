using System;
using System.Collections.Generic;
using System.Text;

namespace MachBuild
{
    internal class ConsoleHelper
    {
        public static void WriteLineCenter(string Line)
        {
            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + Line.Length / 2) + "}", Line);
        }

        public static void WriteCenter(string Line)
        {
            Console.Write("{0," + ((Console.WindowWidth / 2) + Line.Length / 2) + "}", Line);
        }
    }
}
