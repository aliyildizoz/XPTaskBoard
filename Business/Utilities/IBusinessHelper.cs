using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Results;
using FluentValidation;

namespace Business.Utilities
{
    public interface IBusinessHelper
    {
        DateTime AvgTaskEstimated(int projectId);
        IDataResult<DateTime> DoneDate(int projectId, int taskId);
        void AddValidationExTryCatch(Action tryFunc, Predicate<ValidationException> catchFunc);
    }
}
