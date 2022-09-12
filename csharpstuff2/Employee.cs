using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpstuff
{
    internal class Employee
    {
        private string Name;
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            employee1.Name = "Jane Doe";

            Employee employee2 = employee1;
            employee2.Name = "James Doe";

            Employee employee3 = new Employee();
            employee3.Name = "James Doe";

            Console.Write(employee3.Name);
            Console.ReadKey();
        }
    }
}
