using System;
using System.Collections.Generic;
using System.Text;

namespace MachBuild
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleHelper.WriteLineCenter("--- MachBuild v0.0.001 ---");
            CSharp.ConvertCSToCpp conv = new CSharp.ConvertCSToCpp("beta.cs");
            conv.Run();
            Console.ReadKey();
        }
    }
}
