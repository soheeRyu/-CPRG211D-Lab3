using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Interfaces_and_abstract_classes
{
    public abstract class Animal : IAnimal
    {
        //properties
        public string Name { get; set; }
        public string Colour { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }

        public abstract void Eat();
        public abstract void Cry();
    }
}
