using System;

namespace singletonpatterndemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Singleton Demo");
            var singletonDemo = new SingletonDemo();
            System.Console.WriteLine(singletonDemo.GetCityPopulation());
        }
    }
}
