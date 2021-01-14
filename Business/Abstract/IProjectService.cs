using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Results;
using Entities;
using Task = Entities.Task;

namespace Business.Abstract
{
    public interface IProjectService
    {
        IDataResult<Project> Add(Project project);
        IDataResult<List<Project>> GetList();
        IResult Delete(int id);
        IResult Update(Project project);
        IDataResult<List<Project>> Search(string search);
    }
}
