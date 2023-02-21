using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Interfaces_and_abstract_classes
{
    internal class Cat : IAnimal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Colour { get; set; }
        public int Height { get; set; }

        public Cat()
        {
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
            Console.WriteLine("Cats eat mice.");
        }

        public void Cry()
        {
            Console.WriteLine("Meow!");
        }
    }
    
}
