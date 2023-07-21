using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppWeeklyAssignment2
{
    public class LargeDataCollection : IDisposable
    {
        private List<string> employeeList = new List<string>();
        int employeeCount;
        bool disposedValue = false;

        public LargeDataCollection()
        {
            Console.WriteLine("Enter the Number of Employee information you want to Enter: ");
            employeeCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < employeeCount; i++)
            {
                employeeList.Add(Console.ReadLine());
            }
        }

        public void Add(string eName)
        {
            employeeList.Add(eName);
            employeeCount++;
        }

        public void Remove(string eName)
        {
            int index = employeeList.IndexOf(eName);
            if (index != -1) { employeeList.Remove(eName); }
            else
            {
                Console.WriteLine("Employee Name is not in List!");
            }

        }

        public void Search(string eName)
        {
            int index = employeeList.IndexOf(Name);
            if (index == -1)
            {
                Console.WriteLine("Employee is not in List!");
            }
            else
            {
                Console.WriteLine("Employee is in the list at index {0}", index);
            }
        }

        public void DisplayAll()
        {
            Console.WriteLine("All employee's List as follows:");
            foreach (var employee in employeeList)
            {
                Console.WriteLine(employee);
            }
        }

        public virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    employeeCount = 0;
                }
                employeeList = null;
                disposedValue = true;
                Console.WriteLine($"The EmployeeList has been disposed");
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
