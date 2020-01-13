using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_virtual_2019_11_28
{
    public abstract class EmployeeBase
    {
        // Component Base
        public abstract int TasksToDo { get; set; }
        public abstract int ProductivityLevel { get; set; }
        public abstract int Work(int time);
    }
}
