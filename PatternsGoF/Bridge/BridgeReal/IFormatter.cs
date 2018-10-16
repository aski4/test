using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsGoF.Bridge.BridgeReal
{
    public interface IFormatter
    {
        string Format(string key, string value);
    }
}
