using FirstMEF;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstMEF
{
    class Program
    {
        [Import(typeof(ICalculate))]
        ICalculate calculator;

        static void Main(string[] args)
        {
            Program p = new Program();
            
            var catalog = new AggregateCatalog(
                new AssemblyCatalog(typeof(Program).Assembly));
            //catalog.Catalogs.Add(new DirectoryCatalog());

            CompositionContainer container = new CompositionContainer();            
            container.ComposeParts(p);

            
            while (true)
            {
                Console.WriteLine("Please enter you calculation: ");
                Console.WriteLine( p.calculator.Calculate(Console.ReadLine()));
            }
        }
    }
}
