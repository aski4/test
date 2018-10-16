using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsGoF.Builder.BuilderReal
{
    public abstract class SandwichBuilder
    {
        protected Sandwich sandwich;

        public Sandwich GetSandwich()
        {
            return sandwich;
        }

        public void CreateSandwich()
        {
            sandwich = new Sandwich();
        }

        public abstract void PrepareBread();
        public abstract void ApplyMeatAndCheese();
        public abstract void ApplyVegetables();
        public abstract void AddCondiments();
    }
}
