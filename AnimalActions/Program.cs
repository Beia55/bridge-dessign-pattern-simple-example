using AnimalActions.Abstraction;
using AnimalActions.Implementation;
using System;

namespace AnimalActions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Client client = new Client();

            Animal animal = new Cat(2, 4 ,new Walk());
            client.ClientCode(animal);
            Console.WriteLine();

            animal = new Snake(2, 0, new Crawl());
            client.ClientCode(animal);
            Console.WriteLine();

            animal = new Bird(2, 2, new Fly());
            client.ClientCode(animal);
            Console.WriteLine();

            animal = new Fish(2, 0, new Swim());
            client.ClientCode(animal);
            Console.WriteLine();
        }
    }
}
