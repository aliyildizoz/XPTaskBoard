using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsUI.EventArgs
{
    public class ChangeStateEventArgs: System.EventArgs
    {
        public int TaskId{ get; set; }
        public ChangeStateEventArgs(int taskId)
        {
            TaskId = taskId;
        }
    }
}
