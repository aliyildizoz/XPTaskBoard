using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.Abstract;
using Business.Results;
using Business.Validation;
using DataAccess.Abstract;
using Entities;

namespace Business.Concrete
{
    public class EmployeeManager : IEmployeeService
    {
        private IEmployeeDal _employeeDal;
        private Validation<EmployeeValidator> _validation;
        public EmployeeManager(IEmployeeDal employeeDal)
        {
            _employeeDal = employeeDal;
        }

        public IDataResult<List<Employee>> GetList()
        {
            return new SuccessDataResult<List<Employee>>(_employeeDal.GetList().OrderByDescending(emp => emp.Id).ToList());
        }

        public IDataResult<List<Employee>> Search(string search)
        {
            return new SuccessDataResult<List<Employee>>(_employeeDal.GetList(employee => employee.FirstName.ToLower().Contains(search.ToLower()) || employee.LastName.ToLower().Contains(search.ToLower())).OrderByDescending(emp => emp.Id).ToList());
        }

        public IDataResult<Employee> Add(Employee employee)
        {
            _validation = new Validation<EmployeeValidator>();
            _validation.Validate(employee);
            _employeeDal.Add(employee);
            return new SuccessDataResult<Employee>(employee);
        }

        public IResult Update(Employee employee)
        {
            _employeeDal.Update(employee);
            return new SuccessResult();
        }

        public IResult Delete(int id)
        {
            _employeeDal.Delete(new Employee(){Id = id});
            return  new SuccessResult();
        }
    }
}
