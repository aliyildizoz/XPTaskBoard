using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Business.Results;
using Entities;

namespace XPTaskBoard.Test.Business.Abstract
{

    public interface ITaskServiceUnitTest
    {
       void Add();
       void Delete();
       void AddEmployee();
    }
}
