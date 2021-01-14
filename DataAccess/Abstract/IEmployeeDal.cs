using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework.Context;
using Entities;

namespace DataAccess.Abstract
{
    public interface IEmployeeDal : IEntityRepository<Employee>
    {
    }
}
