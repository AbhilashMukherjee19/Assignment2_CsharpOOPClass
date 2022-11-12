using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_CsharpOOPClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.EmployeeDetails();
            emp.Display();
            Console.ReadLine();
        }
    }
}
