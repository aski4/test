using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsGoF.Adapter.AdapterReal
{
    public class Camel : IAnimal
    {
        public void Move()
        {
            Console.WriteLine("Верблюд движется");
        }
    }
}
