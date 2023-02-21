using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Interfaces_and_abstract_classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IAnimal> animals = new List<IAnimal>();

            IAnimal dog = new Dog();
            Console.WriteLine("Dog name: ");
            dog.Name= Console.ReadLine();
            Console.WriteLine("Dog height: ");
            dog.Height = int.Parse(Console.ReadLine());
            Console.WriteLine("Dog colour: ");
            dog.Colour= Console.ReadLine();
            Console.WriteLine("Dog age: ");
            dog.Age= int.Parse(Console.ReadLine());
            dog.Eat();
            dog.Cry();
            animals.Add(dog);

            IAnimal cat = new Cat();
            Console.WriteLine("Cat name: ");
            cat.Name = Console.ReadLine();
            Console.WriteLine("Cat height: ");
            dog.Height = int.Parse(Console.ReadLine());
            Console.WriteLine("Cat colour: ");
            cat.Colour = Console.ReadLine();
            Console.WriteLine("Cat age: ");
            cat.Age = int.Parse(Console.ReadLine());
            cat.Eat();
            cat.Cry();
            animals.Add(cat);

            foreach(IAnimal animal in animals)
            {
                Console.WriteLine(animal.Name);
            }
        }
    }
}
