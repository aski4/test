using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsGoF.Bridge.BridgeReal
{
    public class FAQ : Manuscript
    {
        public string Title { get; set; }
        public Dictionary<string, string> Questions { get; set; }

        public FAQ(IFormatter formatter) : base(formatter)
        {
            Questions = new Dictionary<string, string>();
        }

        public override void Print()
        {
            Console.WriteLine(formatter.Format("Title", Title));
            foreach (var item in Questions)
            {
                Console.WriteLine(formatter.Format(" Question", item.Key));
                Console.WriteLine(formatter.Format(" Answer", item.Value));
            }
            Console.WriteLine();
        }
    }
}
