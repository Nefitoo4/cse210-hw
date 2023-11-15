using System;
using Classes.Math;

namespace classes
{ 
    class Program
    {
        static void Main(string[]args)
        {
            var john = new Person();
            john.FirstName = "john";
            john.LastName = "Smith";
            john.Introduce();

            Calculator calculator = new Calculator();
            var result = calculator.Add(1, 2);
            Console.WriteLine(result);
        }
    }
}