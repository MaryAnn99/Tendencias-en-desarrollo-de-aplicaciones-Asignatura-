using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_virtual_2019_11_28
{
    abstract public class EmployeeDecoratorBase : EmployeeBase
    {
        EmployeeBase employee;

        public EmployeeDecoratorBase(EmployeeBase employee)
        {
            this.employee = employee;
        }
        public override int TasksToDo 
        {
            get => employee.TasksToDo;
            set => employee.TasksToDo = value;
        }
        public override int ProductivityLevel
        {
            get => employee.ProductivityLevel;
            set => employee.ProductivityLevel = value;
        }
        public override int Work(int time) => employee.Work(time);
    }
}
