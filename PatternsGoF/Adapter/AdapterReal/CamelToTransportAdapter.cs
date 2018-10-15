using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsGoF.Adapter.AdapterReal
{
    public class CamelToTransportAdapter : ITransport
    {
        private Camel _camel;

        public CamelToTransportAdapter(Camel camel)
        {
            _camel = camel;
        }

        public void Drive()
        {
            _camel.Move();
        }
    }
}
