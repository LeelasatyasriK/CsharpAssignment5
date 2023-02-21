using System;
using System.Collections;
namespace Asmt5SecondQuestion
{
    class ArrayListProgram
    {
        static void Main(string[] args)
        {
            ArrayList employee = new ArrayList();
            employee.Add(new Employee { ID = 101, Name = "Leela", Department = "Developing" });
            employee.Add(new Employee { ID = 102, Name = "Satya", Department = "Testing" });
            employee.Add(new Employee { ID = 103, Name = "Sri", Department = "Finance" });
            foreach (Employee emp in employee)
            {
                Console.Write(emp.ID + " ");
                Console.Write(emp.Name+" ");
                Console.WriteLine(emp.Department);
            }
        }
    }
}
