using System;

namespace builderpatterndemo
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }
            Console.ReadLine();
        }
    }
}
