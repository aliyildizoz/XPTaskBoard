using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public enum TaskStateNames
    {
        Update = 1,
        Delete,
        Create,
        ToDo,
        Doing,
        Done,
        AddEmployee,
        RemoveEmployee
    }
    public enum TaskStateBaseNames
    {
        ToDo = 4,
        Doing,
        Done,
        Default
    }
}
