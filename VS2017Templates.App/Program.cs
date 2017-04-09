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


            //Out variables

            //Old 

           // string fName, lName;
            p.GetOutVarName(out string fName, out string lName);
            Console.WriteLine($"Hello {fName} {lName}");


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

        public void GetOutVarName(out string firstName, out string lastName)
        {
            firstName = _firstName;
            lastName = _lastName;
        }


    }
}
