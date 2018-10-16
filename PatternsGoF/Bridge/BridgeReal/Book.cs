using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsGoF.Bridge.BridgeReal
{
    public class Book : Manuscript
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Text { get; set; }

        public Book(IFormatter formatter) : base(formatter)
        {

        }

        public override void Print()
        {
            Console.WriteLine(formatter.Format("Title", Title));
            Console.WriteLine(formatter.Format("Author", Author));
            Console.WriteLine(formatter.Format("Text", Text));
            Console.WriteLine();
        }
    }
}
