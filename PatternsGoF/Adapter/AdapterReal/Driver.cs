using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsGoF.Adapter.AdapterReal
{
    public sealed class Driver
    {
        public void Travel(ITransport transport)
        {
            transport.Drive();
        }
    }
}
