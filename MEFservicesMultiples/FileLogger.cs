using System;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.IO;

namespace MEFservicesMultiples
{
    [Export(typeof(ILogger))]
    internal class FileLogger : ILogger
    {
        public void Write(string message)
        {
            string root = @"C:\Users\konuk\source\repos\MEFservicesMultiples\MEFservicesMultiples\bin\Debug\testFiles";
            TextWriter TextWrite = new StreamWriter(root + "/textwriter.txt");
            TextWrite.Write(DateTime.Now + " : " + message);
            TextWrite.Flush();
            TextWrite.Close();
            TextWrite = null;
        }
    }
}
