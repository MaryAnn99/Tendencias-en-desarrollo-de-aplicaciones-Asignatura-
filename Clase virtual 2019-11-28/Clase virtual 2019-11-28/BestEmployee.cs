using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_virtual_2019_11_28
{
    public class BestEmployee : EmployeeDecoratorBase
    {
        public BestEmployee(EmployeeBase employee) : base(employee) { }
        
        public int StudyHours { get; set; }
        public override int Work(int time)
        {
            if(TasksToDo - (ProductivityLevel * time) < 0)
            {
                StudyHours += Math.Abs(TasksToDo - (ProductivityLevel * time));
                ProductivityLevel++;
            }
            TasksToDo = Math.Max(0, TasksToDo - (ProductivityLevel * time));
            return TasksToDo;
        }
    }
}
