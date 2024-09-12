using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Sep_concatenationTask
{
    internal class Program
    {
        static void Main()
        {
            string firstName, lastName;
            int age;
            Console.Write("Enter first name: ");
            firstName = Console.ReadLine();
            Console.Write("Enter last name: ");
            lastName = Console.ReadLine();
            Console.Write("Enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello " + firstName + " " + lastName + " you are " + age + " years old");
            Console.ReadLine();
        }
    }
}
