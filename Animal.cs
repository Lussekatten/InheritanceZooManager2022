using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooPark
{
    internal abstract class Animal
    {
        public Animal(string name, int age, int currentValue, string origin)
        {
            Name = name;
            Age = age;
            CurrentValue = currentValue;
            Origin = origin;
            _index++;
            Id = _index;
        }

        private static int _index = 0;
        public int Id { get;}

        public string Name { get; set; }
        public int Age { get; set; }

        public int CurrentValue { get; set; }

        public string Origin { get; set; }

        public abstract void MakesNoise();
    }

}

