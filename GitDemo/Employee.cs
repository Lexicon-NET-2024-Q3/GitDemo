using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitDemo;
internal class Employee
{
    public string Name { get; }
    public int Age { get; }

    public Employee(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void Test()
    {
        Console.WriteLine("Test"); 
    } 
    
    public void Test2()
    {
        Console.WriteLine("Test"); 
    }
}
