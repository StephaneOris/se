using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    public class TestB : CaffeineBeverage
    {
        public override void Brew()
        {
            Console.WriteLine("TestB");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding B");
        }

        public bool CustomerWantsCondiments()
        {
            string answer = getUserInput();

            if (answer.ToLower().StartsWith("y"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private string getUserInput()
        {
            throw new NotImplementedException();
        }
    }
}
