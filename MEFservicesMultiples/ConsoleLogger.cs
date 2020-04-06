using System;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;

namespace MEFservicesMultiples
{
    [Export(typeof(ILogger))]
    internal class ConsoleLogger : ILogger
    {
        public void Write(string message)
        {
            Console.WriteLine(DateTime.Now + " : " + message);
        }
    }
}