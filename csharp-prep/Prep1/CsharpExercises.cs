namespace classes
{ 
    class Program
    {
        static void Main(string[]args)
        {
            Person john = new Person();
            john.FirstName = "john";
            john.LastName = "Smith";
            john.Introduce();
        }
    }
}