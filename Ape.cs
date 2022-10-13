using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooPark
{
    internal class Ape : Animal
    {
        public Ape(string name, int age, int currentValue, string origin) : base(name, age, currentValue, origin)
        {

        }
        public override void MakesNoise()
        {
            Console.WriteLine($"{Name} makes ape like noises");
        }
    }
}
