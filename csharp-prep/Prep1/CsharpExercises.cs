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
        }
    }
}