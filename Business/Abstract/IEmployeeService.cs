using System;
using System.Collections.Generic;
using System.Text;
using Business.Results;
using Entities;

namespace Business.Abstract
{
    public interface IEmployeeService
    {
        IDataResult<List<Employee>> GetList();
        IDataResult<List<Employee>> Search(string search);
        IDataResult<Employee> Add(Employee employee);
        IResult Update(Employee employee);
        IResult Delete(int id);
    }
}
