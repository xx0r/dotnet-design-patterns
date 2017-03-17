namespace Patterns.App
{
    using System;
    using SimpleInjector;


    class Program
    {
        static Program()
        {
            DependencyInjection.RegisterDependencies();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}