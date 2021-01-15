using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Results;

namespace Business.Utilities
{
    public interface IBusinessHelper
    {
        DateTime AvgTaskEstimated(int projectId);
        IDataResult<DateTime> DoneDate(int projectId, int taskId);
    }
}
