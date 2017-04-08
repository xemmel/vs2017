using System;
namespace VS2017Templates.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Morten", "la Cour");


            //Try tuples!!!
            var fullName = p.GetFullName();
            Console.WriteLine($"Hello {fullName.Item1} {fullName.Item2}");

            var fullNameStrong = p.GetStrongFullName();
            Console.WriteLine($"Hello {fullNameStrong.firstName} {fullNameStrong.lastName}");



        }
    }


    public class Person
    {
        private string _firstName;
        private string _lastName;

        public Person (string firstName, string lastName) {
            _firstName = firstName;
            _lastName = lastName;
        }

        public (string,string) GetFullName()
        {
            return (_firstName, _lastName);
        }

        public (string firstName, string lastName) GetStrongFullName()
        {
            return (_firstName, _lastName);
        }


    }
}
