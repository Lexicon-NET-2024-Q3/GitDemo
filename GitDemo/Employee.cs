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

    public Employee(string firstname, int age)
    {
        Name = firstname;
        Age = age;
    }

    public void Test()
    {
        Console.WriteLine("Test");
        Console.WriteLine("Testar3");
        Console.WriteLine("Test2"); 
        Console.WriteLine("Test2"); 
        Console.WriteLine("Test2"); 
    } 
    
    public void Banan2()
    {
        Console.WriteLine("Test"); 
    }
}
