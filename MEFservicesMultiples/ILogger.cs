using System.IO;
using System;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;

namespace MEFservicesMultiples
{
    internal interface ILogger
    {
        void Write(string message);
    }
}