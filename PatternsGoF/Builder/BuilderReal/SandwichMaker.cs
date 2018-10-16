using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsGoF.Builder.BuilderReal
{
    public class SandwichMaker
    {
        private readonly SandwichBuilder _builder;

        public SandwichMaker(SandwichBuilder builder)
        {
            _builder = builder;
        }

        public void BuildSandwich()
        {
            _builder.CreateSandwich();
            _builder.PrepareBread();
            _builder.ApplyMeatAndCheese();
            _builder.ApplyVegetables();
            _builder.AddCondiments();
        }

        public Sandwich GetSandwich()
        {
            return _builder.GetSandwich();
        }
    }
}
