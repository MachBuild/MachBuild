using System;
using System.Collections.Generic;
using System.Text;

namespace MachBuild.CSharp
{
    internal class ConvertCSToCpp
    {
        private string CSharpFile = string.Empty;

        public ConvertCSToCpp(string CSFile)
        {
            CSharpFile = CSFile;
        }

        public void Run()
        {
            //Read CS File into a Buffer
            string CSBuffer = string.Empty;
            using (System.IO.StreamReader ReadFile = new System.IO.StreamReader(CSharpFile))
            {
                CSBuffer = ReadFile.ReadToEnd();
            }
            //Strip CSBuffer of Return Char
            CSBuffer = CSBuffer.Replace(((char)13).ToString(), "");
            //Read CSBuffer Line By Line
            foreach (string Line in CSBuffer.Split('\n'))
            {

            }
        }
    }
}
