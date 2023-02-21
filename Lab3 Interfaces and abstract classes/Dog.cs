using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Interfaces_and_abstract_classes
{
    internal class Dog : IAnimal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Colour { get; set; }
        public int Height { get; set; }

           
        public Dog() {
            this.Name = Name;
            this.Age = Age;
            this.Colour = Colour;
            this.Height = Height;
        }

        public void Eat()
        {
            Console.WriteLine("Name: " + this.Name);
            Console.WriteLine("Age: " + this.Age);
            Console.WriteLine("Colour: " + this.Colour);
            Console.WriteLine("Height: " + this.Height);
            Console.WriteLine("Dogs eat meat.");
        }
        public void Cry()
        {
            Console.WriteLine("Woof!");
        }
    }
}
