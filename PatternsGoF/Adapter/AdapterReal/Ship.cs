using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsGoF.Adapter.AdapterReal
{
    public class Ship : ITransport
    {
        public void Drive()
        {
            Console.WriteLine("Корабль поплыл");
        }
    }
}
