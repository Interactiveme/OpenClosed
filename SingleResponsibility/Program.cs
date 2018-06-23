using System;

namespace SingleResponsibility
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "Joseph";
            person.LastName = "Smith";

            person.Log();

            Console.ReadLine();
        }
    }
}
