using System;
using System.Security.Cryptography.X509Certificates;

namespace Classes
{
    public class Person
    {
        public string FirstName;
        public string LastName;
        public void Introduce()
        {
            Console.WriteLine("My name is " + FirstName + " " + LastName);
        }
    }    
}