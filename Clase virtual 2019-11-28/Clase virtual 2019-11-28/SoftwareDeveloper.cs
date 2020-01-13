using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_virtual_2019_11_28
{
    // Concrete Component 
    public class SoftwareDeveloper : EmployeeBase
    {
        public override int TasksToDo { get; set; }
        public override int ProductivityLevel { get; set; }

        public SoftwareDeveloper()
        {
            TasksToDo = 0;
            ProductivityLevel = 1;
        }

        // Purpose: reduce the amount of TasksToDo based on the time for work and 
        // the ProductivityLevel. Returns the new TasksToDo
        public override int Work(int time)
        {
            TasksToDo = Math.Max(0, TasksToDo - (ProductivityLevel * time));
            return TasksToDo;
        }
    }
}
