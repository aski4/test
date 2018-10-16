using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsGoF.Bridge.BridgeReal
{
    public abstract class Manuscript
    {
        protected readonly IFormatter formatter;

        public Manuscript(IFormatter formatter)
        {
            this.formatter = formatter;
        }

        abstract public void Print();
    }
}
