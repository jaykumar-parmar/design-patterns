using System;

namespace builderpatterndemo
{
    public static class Program
    {
        private static void Main()
        {
            System.Console.WriteLine("HTML Element Builder");
            var builderDemo = new HTMLElementBuilderDemo();
            var html = builderDemo.BuildList();
            System.Console.WriteLine(html);

            System.Console.WriteLine("\nPerson Builder");

            var facadeBuilder = new BuilderFacadeDemo();
            var person = facadeBuilder.BuildPerson();
            System.Console.WriteLine(person);
        }
    }
}
