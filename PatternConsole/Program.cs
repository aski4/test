using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using PatternsGoF.Adapter;


namespace PatternConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();

            program.AdapterFormal();
        }

        private void AdapterFormal()
        {
            AdapterFormal adapterFormal = new AdapterFormal();
            adapterFormal.Main();
            Console.ReadKey();
        } 
    }
}
