using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_virtual_2019_11_28
{
    public class BossDecorator : EmployeeDecoratorBase
    {
        
        public BossDecorator(EmployeeBase employee) : base(employee)
        {
        }
        // Purpose : increment the TasksToDo of an EmployeeBase. Returns the new
        // TasksToDo of that EmployeeBase
        public int AssignTasks(EmployeeBase employee, int tasksAmount)
        {
            if (tasksAmount > 0)
            {
                employee.TasksToDo += tasksAmount;
            }
            return employee.TasksToDo;
        }
    }
}
