using System;

namespace ReferenceTypesStructureInClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Customer customer = new Customer();
            customer.CreditCardNumber = "0123456789";
            Person person1 = new Person();
            person1 = customer;
            Console.WriteLine(((Customer)person1).CreditCardNumber+"\n");
            Person person2 = new Person();
            ((Person)person2).CreditCardNumber = Console.ReadLine();

        }
    }
    class Person // <----BaseClass 
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Customer : Person
    {
        public string CreditCardNumber { get; set; }
    }
    class Employee : Person
    {
        public int EmployeeNumber { get; set; }
    }

}
