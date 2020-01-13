using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_virtual_2019_11_28
{
    class Program
    {
        static void Main(string[] args)
        {
            // Testing
            SoftwareDeveloper softwareDeveloperMartin = new SoftwareDeveloper();
            SoftwareDeveloper softwareDeveloperJorge = new SoftwareDeveloper();
            BossDecorator softwareDeveloperJorgeBoss = new BossDecorator(softwareDeveloperJorge);
            Console.WriteLine($"New TasksToDo Martin: " +
                $"{softwareDeveloperJorgeBoss.AssignTasks(softwareDeveloperMartin, 6)}");
            BestEmployee bestEmployeeMartin = new BestEmployee(softwareDeveloperMartin);
            
            Console.WriteLine($"New TasksToDo Martin: {bestEmployeeMartin.Work(7)}");
            Console.WriteLine($"StudyHours: {bestEmployeeMartin.StudyHours}, " +
                              $"ProductivityLevel: {bestEmployeeMartin.ProductivityLevel}");
            Console.ReadKey();
        }
    }
}
