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

    public Employee(string name, int age, int salary)
    {
        Name = name;
        Age = age;     
    }

    public void Test()
    {
        Console.WriteLine("Test");
        Console.WriteLine("Testar3");
    } 
    
    public void Test2()
    {
        Console.WriteLine("Test"); 
    }
}
