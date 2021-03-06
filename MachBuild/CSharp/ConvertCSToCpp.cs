﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MachBuild.CSharp
{
    internal class ConvertCSToCpp
    {
        private string CSharpFile = string.Empty;
        private CSInfoContainer CInfo;

        public ConvertCSToCpp(string CSFile)
        {
            CSharpFile = CSFile;
            CInfo = new CSInfoContainer();
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
                if (Line.StartsWith("using"))
                {
                    //Get EOL ';' and add to CInfo's UsingContainer
                    string UsingStatment = Line.Substring(0, Line.IndexOf(";"));
                    CInfo.UsingContainer.Add(UsingStatment);
                }
            }
        }
    }
}
