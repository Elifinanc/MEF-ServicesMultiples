using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;

namespace MEFservicesMultiples
{
    class Program
    {
        private CompositionContainer _container = null;

        [ImportMany(typeof(ILogger))]

        private IEnumerable <ILogger> _loggers;
        
        static void Main(string[] args)
        {
            var program = new Program();
            program.Run();

            Console.Read();
        }

        public Program()
        {
            var catalog = new DirectoryCatalog(".", "MEFservicesMultiples.*");
            _container = new CompositionContainer(catalog);
            _container.ComposeParts(this);
        }

        public void Run()
        {
            foreach (var logger in _loggers)
            {
                logger.Write("Hello !");
            }
        }
    }
}
