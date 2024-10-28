using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitDemo;
internal class Employee
{
    public string Name { get; }
    public Employee(string name)
    {
        Name = name;
    }

    public void Test()
    {
        Console.WriteLine("Test"); 
    }
}
