using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsGoF.Builder.BuilderReal
{
    public class ClubSandwichBuilder : SandwichBuilder
    {
        public override void AddCondiments()
        {
            sandwich.HasMayo = true;
            sandwich.HasMustard = false;
        }

        public override void ApplyMeatAndCheese()
        {
            sandwich.MeatType = MeatType.Chicken;
        }

        public override void ApplyVegetables()
        {
            sandwich.Vegetables = new List<string> {"Piccles", "NDA" };
        }

        public override void PrepareBread()
        {
            sandwich.BreadType = BreadType.Wheat;
            sandwich.IsToasted = false;
        }
    }
}
