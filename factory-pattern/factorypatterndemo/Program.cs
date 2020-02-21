using System;

namespace factorypatterndemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var person1 = Person.PersonFactory.PersonWithFullnameFactory("John Doe", 25);
            var person2 = Person.PersonFactory.PersonFactoryWithFirstAndLastName("John", "Doe", 28);

            Console.WriteLine("Factory Methods");
            Console.WriteLine(person1);
            Console.WriteLine(person2);


            Console.WriteLine("\nAbstract Factory Methods");
            var absFactory = new AbstractFactoryDemo();
            Console.WriteLine(absFactory.DbLogger());
            Console.WriteLine(absFactory.FileLogger());
            Console.ReadLine();
        }
    }


}
