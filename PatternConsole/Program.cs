using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using PatternsGoF.Adapter;
using PatternsGoF.Adapter.AdapterReal;

namespace PatternConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Program program = new Program();

            program.AdapterFormal();
            program.AdapterReal();  
        }

        private void AdapterFormal()
        {
            AdapterFormal adapterFormal = new AdapterFormal();
            adapterFormal.Main();
            Console.ReadKey();
        } 
        private void AdapterReal()
        {
            Driver driver = new Driver();

            Auto auto = new Auto();
            Ship ship = new Ship();

            driver.Travel(auto);
            driver.Travel(ship);

            Camel camel = new Camel();
            ITransport camelTrasport = new CamelToTransportAdapter(camel);

            driver.Travel(camelTrasport);
            Console.ReadKey();
        }
    }
}
