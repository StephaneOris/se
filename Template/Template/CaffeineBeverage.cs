using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    public abstract class CaffeineBeverage
    {

        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            if (CustomerWantsCondiments())
            {
                AddCondiments();
            }

        }

        public abstract void Brew();

        public abstract void AddCondiments();

        void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }

        void PourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }

        bool CustomerWantsCondiments()
        {
            return true;
        }

    }
}